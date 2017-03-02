using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using SlimDX.DirectInput;


namespace KNRapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
            GetSticks(); //Start the process
            Sticks = GetSticks();
            timer1.Enabled = true; //enable the timer

        }

        GPSfile gps = new KNRapp.GPSfile();
        DirectInput Input = new DirectInput();
        SlimDX.DirectInput.Joystick stick;
        Joystick[] Sticks;
        JoystickState state = new JoystickState();

        static Encoding enc8 = Encoding.UTF8;
        int yValue = 0;
        int xValue = 0;
        int zValue = 0;

        decimal pValue = 0;
        decimal iValue = 0;
        decimal kValue = 0;

        byte[] inputBuffor = new byte[100];
        int znakiPolecenia;
        Boolean nowePolecenie = false;
        byte[] polecenie = new byte[20];
        int licznik = 0;

        Int16 data1;
        Int16 data2;
        Int16 data3;

        int polecenieDoWyslania = 0;



        //=======================================================================================================
        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames(); //sczytaj dostepne porty szeregowe
            comboBox_portNames.Items.AddRange(ports); //zapisz je w liscie comboBox'a
        }


        //============================================================================================================
        private void closePort()
        {
            serialPort1.Close();
            progressBar_status.Value = 0;
            textBox_diagnostics.Enabled = false;
            button_closePort.Enabled = false; //disable close_button
            button_openPort.Enabled = true; //re-enable the open_button
        }

        //=============================================================================================================
        public Joystick[] GetSticks()
        {
            List<SlimDX.DirectInput.Joystick> sticks = new List<SlimDX.DirectInput.Joystick>();
            foreach (DeviceInstance device in Input.GetDevices(DeviceClass.GameController, DeviceEnumerationFlags.AttachedOnly))
            {
                try
                {
                    stick = new SlimDX.DirectInput.Joystick(Input, device.InstanceGuid);
                    stick.Acquire();

                    foreach (DeviceObjectInstance deviceObject in stick.GetObjects())
                    {
                        if ((deviceObject.ObjectType & ObjectDeviceType.Axis) != 0)
                        {
                            stick.GetObjectPropertiesById((int)deviceObject.ObjectType).SetRange(-100, 100);
                        }
                    }
                    sticks.Add(stick);
                }
                catch (DirectInputException)
                {
                    textBox_diagnostics.Text = "Nie wykryto Joysticka";
                }
            }
            return sticks.ToArray();
        }

        //=========================================================================================================
        //StickHandle function gets the state of the controller and sets button values into variables
        void stickHandle(Joystick stick, int id)
        {

            state = stick.GetCurrentState();

            yValue = state.Y;
            if (Math.Abs(yValue) < 4) yValue = 0;
            xValue = state.X;
            if (Math.Abs(xValue) < 4) xValue = 0;
            zValue = state.Z;

            //wyswietlaj pozycje joysticka
            textBox_X.Text = xValue.ToString();
            textBox_Y.Text = yValue.ToString();
            textBox_Z.Text = zValue.ToString();

            //Wysylaj info po szeregu
            try
            {
                if (serialPort1.IsOpen)
                {
                    if (polecenieDoWyslania != 0)
                    {
                        switch (polecenieDoWyslania)
                        {
                            case 1:
                                serialPort1.Write("#S1");
                                break;
                            case 2:
                                serialPort1.Write("#S0");
                                break;
                            case 3:
                                this.pidValueSet();
                                break;
                            case 4:
                           //   serialPort1.Write("#v");
                          //      byte[] valByte = { 0, 0xFF-49 }; //xValue jest w (-100, 100)
                          //      serialPort1.Write(valByte, 0, valByte.Length);
                                break;

                        }
                        polecenieDoWyslania = 0;
                    }
                    else
                    {
                        serialPort1.Write("#v");
                        byte[] valByte = { (byte)(xValue), (byte)(yValue) }; //xValue jest w (-100, 100)
                        serialPort1.Write(valByte, 0, valByte.Length);
                    }
                }

                bool[] buttons = state.GetButtons();
                if (id == 0)
                {
                    if (buttons[0])
                    {
                        checkBox1.Checked = true;
                      //  polecenieDoWyslania = 4;
                    }
                    else
                    {
                        checkBox1.Checked = false;
                    }
                    if (buttons[1])
                    {
                        checkBox2.Checked = true;
                    }
                    else
                    {
                        checkBox2.Checked = false;
                    }
                    if (buttons[2])
                    {
                        checkBox3.Checked = true;
                    }
                    else
                    {
                        checkBox3.Checked = false;
                    }
                    if (buttons[3])
                    {
                        checkBox4.Checked = true;
                    }
                    else
                    {
                        checkBox4.Checked = false;
                    }
                    if (buttons[4])
                    {
                        checkBox5.Checked = true;
                    }
                    else
                    {
                        checkBox5.Checked = false;
                    }
                }
            }
            catch (System.IO.IOException)
            {
                textBox_diagnostics.Text = "Przerwano połączenie";
                this.closePort();
            }
        }

        //============================================================================================================
        private void pidValueSet()
        {
            pValue = numericUpDown1.Value;
            iValue = numericUpDown2.Value;
            kValue = numericUpDown3.Value;

            if (serialPort1.IsOpen)
            {
                serialPort1.Write("#p");
                byte[] valByte = { (byte)(pValue), (byte)(((Int16)iValue)&0xFF), (byte)(((Int16)iValue)&0xFF00 >> 8), (byte)(kValue) };//pValue, iValue, kValue - całkowite z zakresu 0-255
                serialPort1.Write(valByte, 0, valByte.Length);
            }



        }
        //=======================================================================================================
        private void serialRead()
        {
            if (serialPort1.BytesToRead != 0)
            {
                int n = serialPort1.BytesToRead;
                Array.Clear(inputBuffor, 0, 100);
                serialPort1.Read(inputBuffor, 0, n);
                for (int i = 0; i < n; i++)
                {
                    if (nowePolecenie)
                    {
                        switch (inputBuffor[i])
                        {
                            case (byte)'B':
                                znakiPolecenia = 2;
                                polecenie[0] = inputBuffor[i];
                                break;
                            case (byte)'s':
                                znakiPolecenia = 1;
                                polecenie[0] = inputBuffor[i];
                                break;
                            case (byte)'v':
                                znakiPolecenia = 6;
                                polecenie[0] = inputBuffor[i];
                                break;
                            case (byte)'V':
                                znakiPolecenia = 6;
                                polecenie[0] = inputBuffor[i];
                                break;
                            case (byte)'i':
                                znakiPolecenia = 6;
                                polecenie[0] = inputBuffor[i];
                                break;
                            case (byte)'I':
                                znakiPolecenia = 6;
                                polecenie[0] = inputBuffor[i];
                                break;
                            default:
                                break;
                        }
                        nowePolecenie = false;
                    }
                    else if (inputBuffor[i] == '#' && znakiPolecenia == 0)
                    {
                        nowePolecenie = true;
                        licznik = 1;
                    }
                    else if (znakiPolecenia > 0)
                    {
                        polecenie[licznik] = inputBuffor[i];
                        licznik++;
                        znakiPolecenia--;
                    }
                    if (znakiPolecenia == 0 && licznik > 1)
                    {
                        this.wykonajPolecenie();
                        Array.Clear(polecenie, 0, 20);
                        licznik = 0;
                    }
                }
            }
        }

        private void wykonajPolecenie()
        {
            switch (polecenie[0])
            {
                case (byte)'B':
                    this.ustawBateria();
                    break;
                case (byte)'s':
                    this.stopStatus();
                    break;
                case (byte)'V':
                    this.prawyPredkosc();
                    break;
                case (byte)'v':
                    this.lewyPredkosc();
                    break;
                case (byte)'I':
                    this.prawyPrad();
                    break;
                case (byte)'i':
                    this.lewyPrad();
                    break;
                case (byte)'G':
                    this.GPSset();
                    break;
                case (byte)'b':
                    textBox1.Text = System.Text.Encoding.UTF8.GetString(polecenie);
                    break;
            }

        }

        private void lewyPrad()
        {
            this.lowHighToInt16();
            // tutaj trzeba zamieścić odpowiednie obliczenia 
            double prad1 = data1;
            double prad2 = data2;
            double prad3 = data3;
            pradL1.Text = prad1.ToString();
            pradL2.Text = prad2.ToString();
            pradL3.Text = prad3.ToString();
        }

        private void prawyPrad()
        {
            this.lowHighToInt16();
            // tutaj trzeba zamieścić odpowiednie obliczenia 
            double prad1 = data1;
            double prad2 = data2;
            double prad3 = data3;
            pradP1.Text = prad1.ToString();
            pradP2.Text = prad2.ToString();
            pradP3.Text = prad3.ToString();
        }

        private void lewyPredkosc()
        {
            this.lowHighToInt16();
            speedL1.Text = (data1 / 20).ToString();
            speedL2.Text = (data2 / 20).ToString();
            speedL3.Text = (data3 / 20).ToString();
            //this.dataToFile(data1);
        }

        private void prawyPredkosc()
        {
            this.lowHighToInt16();
            speedP1.Text = (data1 / 20).ToString();
            speedP2.Text = (data2 / 20).ToString();
            speedP3.Text = (data3 / 20).ToString();
          

        }

        private void lowHighToInt16()
        {
            data1 = (Int16)(polecenie[1] | polecenie[2] << 8);
            data2 = (Int16)(polecenie[3] | polecenie[4] << 8);
            data3 = (Int16)(polecenie[5] | polecenie[6] << 8);
        }

        private void stopStatus()
        {
            if (polecenie[1] == 0)
            {
                textBox_diagnostics.Text = "Napędy zatrzymane";
            }
            else if (polecenie[1] == 1)
            {
                textBox_diagnostics.Text = "Napędy aktywne";
            }
        }

        private void ustawBateria()
        {
            double batteryPomiar = (polecenie[1] | polecenie[2] << 8) / 206.86;
            batteryVoltage.Text = batteryPomiar.ToString("F");
            if (batteryPomiar < 11)
            {
                this.batteryVoltage.BackColor = System.Drawing.Color.Red;
            } else
            {
                this.batteryVoltage.BackColor = System.Drawing.Color.White;
            }
        }

        byte[] X = null;
        byte[] Y = null;

        private void GPSset()
        {
            Array.Copy(polecenie, 1, X, 0, 7);
            Array.Copy(polecenie, 1, Y, 0, 7);
            gps.GPSset(enc8.GetString(X), enc8.GetString(Y));
        }
        //=======================================================================================================
        //#######################################################################################################
        //=======================================================================================================
        private void button_openPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_portNames.Text == "" || comboBox_baudRate.Text == "") //jesli nie ma zadnych polaczen w zasiegu (np. BT jest off)
                {
                    textBox_diagnostics.Text = "Please select port settings";
                }
                else
                {
                    serialPort1.PortName = comboBox_portNames.Text; //assign port name selected to serial port
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text); //set the Baud Rate
                    serialPort1.Open();
                    progressBar_status.Value = 100;
                    textBox_diagnostics.Enabled = true;
                    button_openPort.Enabled = false; //you cannot open the port again
                    button_closePort.Enabled = true;
                    textBox_diagnostics.ResetText();
                    serialPort1.DiscardInBuffer();

                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox_diagnostics.Text = "Nieautoryzowany dostęp";
            }
            catch (System.IO.IOException)
            {
                textBox_diagnostics.Text = "Wybrano zły port COM";
            }
        }
        //========================================================================================================
        private void button_closePort_Click(object sender, EventArgs e)
        {
            this.closePort();
        }
        //========================================================================================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Sticks.Length; i++)
            {
                stickHandle(Sticks[i], i);

                if (serialPort1.IsOpen)
                {
                    this.serialRead();
                    //stickHandle(Sticks[i], i);
                }
            }
        }
        //========================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            Joystick[] joystick = GetSticks();
        }

        //========================================================================================================
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            polecenieDoWyslania = 3;
        }
        //========================================================================================================
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            polecenieDoWyslania = 3;
        }
        //========================================================================================================
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            polecenieDoWyslania = 3;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            polecenieDoWyslania = 2;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            polecenieDoWyslania = 1;
        }


        private void mapaStart_Click(object sender, EventArgs e)
        {
            button_mapaStart.Enabled = false;
            gps.GPSstart();
        }

        private void ResetMap_Click(object sender, EventArgs e)
        {
            gps.GPSreset(true);
        }




        private void dataToFile(int data)
        {
            if (polecenieDoWyslania == 4) { 
            string plikPredkosc = @"..\predkoscdata.txt";
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(plikPredkosc, true))
            {
                file.WriteLine(data.ToString());
            }
        }
    }

    }
}
