namespace KNRapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_portNames = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.progressBar_status = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_openPort = new System.Windows.Forms.Button();
            this.button_closePort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_diagnostics = new System.Windows.Forms.GroupBox();
            this.textBox_diagnostics = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.textBox_Z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.batteryVoltage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pradP3 = new System.Windows.Forms.TextBox();
            this.speedP3 = new System.Windows.Forms.TextBox();
            this.pradP2 = new System.Windows.Forms.TextBox();
            this.speedP2 = new System.Windows.Forms.TextBox();
            this.pradP1 = new System.Windows.Forms.TextBox();
            this.speedP1 = new System.Windows.Forms.TextBox();
            this.speedL3 = new System.Windows.Forms.TextBox();
            this.speedL2 = new System.Windows.Forms.TextBox();
            this.speedL1 = new System.Windows.Forms.TextBox();
            this.pradL3 = new System.Windows.Forms.TextBox();
            this.pradL2 = new System.Windows.Forms.TextBox();
            this.pradL1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ResetMap = new System.Windows.Forms.Button();
            this.button_mapaStart = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_diagnostics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_portNames
            // 
            this.comboBox_portNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portNames.FormattingEnabled = true;
            this.comboBox_portNames.Location = new System.Drawing.Point(12, 27);
            this.comboBox_portNames.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_portNames.Name = "comboBox_portNames";
            this.comboBox_portNames.Size = new System.Drawing.Size(82, 21);
            this.comboBox_portNames.TabIndex = 0;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(98, 27);
            this.comboBox_baudRate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(82, 21);
            this.comboBox_baudRate.TabIndex = 1;
            // 
            // progressBar_status
            // 
            this.progressBar_status.Location = new System.Drawing.Point(184, 30);
            this.progressBar_status.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_status.Name = "progressBar_status";
            this.progressBar_status.Size = new System.Drawing.Size(63, 18);
            this.progressBar_status.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // button_openPort
            // 
            this.button_openPort.Location = new System.Drawing.Point(184, 52);
            this.button_openPort.Margin = new System.Windows.Forms.Padding(2);
            this.button_openPort.Name = "button_openPort";
            this.button_openPort.Size = new System.Drawing.Size(63, 31);
            this.button_openPort.TabIndex = 5;
            this.button_openPort.Text = "Open Port";
            this.button_openPort.UseVisualStyleBackColor = true;
            this.button_openPort.Click += new System.EventHandler(this.button_openPort_Click);
            // 
            // button_closePort
            // 
            this.button_closePort.Enabled = false;
            this.button_closePort.Location = new System.Drawing.Point(184, 86);
            this.button_closePort.Margin = new System.Windows.Forms.Padding(2);
            this.button_closePort.Name = "button_closePort";
            this.button_closePort.Size = new System.Drawing.Size(63, 31);
            this.button_closePort.TabIndex = 6;
            this.button_closePort.Text = "Close Port";
            this.button_closePort.UseVisualStyleBackColor = true;
            this.button_closePort.Click += new System.EventHandler(this.button_closePort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // groupBox_diagnostics
            // 
            this.groupBox_diagnostics.Controls.Add(this.textBox_diagnostics);
            this.groupBox_diagnostics.Enabled = false;
            this.groupBox_diagnostics.Location = new System.Drawing.Point(5, 51);
            this.groupBox_diagnostics.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_diagnostics.Name = "groupBox_diagnostics";
            this.groupBox_diagnostics.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_diagnostics.Size = new System.Drawing.Size(175, 70);
            this.groupBox_diagnostics.TabIndex = 8;
            this.groupBox_diagnostics.TabStop = false;
            this.groupBox_diagnostics.Text = "Diagnostics";
            // 
            // textBox_diagnostics
            // 
            this.textBox_diagnostics.Location = new System.Drawing.Point(5, 14);
            this.textBox_diagnostics.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_diagnostics.Multiline = true;
            this.textBox_diagnostics.Name = "textBox_diagnostics";
            this.textBox_diagnostics.Size = new System.Drawing.Size(166, 52);
            this.textBox_diagnostics.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.ParityReplace = ((byte)(3));
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Position X";
            // 
            // textBox_X
            // 
            this.textBox_X.Enabled = false;
            this.textBox_X.Location = new System.Drawing.Point(8, 35);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.Size = new System.Drawing.Size(68, 20);
            this.textBox_X.TabIndex = 10;
            // 
            // textBox_Z
            // 
            this.textBox_Z.Enabled = false;
            this.textBox_Z.Location = new System.Drawing.Point(8, 126);
            this.textBox_Z.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Z.Name = "textBox_Z";
            this.textBox_Z.Size = new System.Drawing.Size(68, 20);
            this.textBox_Z.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position Z";
            // 
            // textBox_Y
            // 
            this.textBox_Y.Enabled = false;
            this.textBox_Y.Location = new System.Drawing.Point(7, 82);
            this.textBox_Y.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Y.Name = "textBox_Y";
            this.textBox_Y.Size = new System.Drawing.Size(68, 20);
            this.textBox_Y.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Position Y";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(93, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 132);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przyciski Joystick";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Button 5";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Button 4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Button 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Button 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Button 1";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(6, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 25;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 24;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_X);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Z);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Y);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 161);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametry Joystick";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 34);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.Value = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 60);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 1024;
            this.numericUpDown2.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(8, 86);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown3.TabIndex = 27;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 112);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nastawy regulatorów";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "K";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "P";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(87, 20);
            this.textBox1.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_portNames);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBox_baudRate);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.groupBox_diagnostics);
            this.groupBox4.Controls.Add(this.progressBar_status);
            this.groupBox4.Controls.Add(this.button_closePort);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.button_openPort);
            this.groupBox4.Location = new System.Drawing.Point(239, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 121);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.startButton);
            this.groupBox5.Controls.Add(this.stopButton);
            this.groupBox5.Location = new System.Drawing.Point(239, 130);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(159, 43);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.ForeColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(82, 9);
            this.startButton.Name = "startButton";
            this.startButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startButton.Size = new System.Drawing.Size(71, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(6, 9);
            this.stopButton.Name = "stopButton";
            this.stopButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stopButton.Size = new System.Drawing.Size(71, 30);
            this.stopButton.TabIndex = 0;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // batteryVoltage
            // 
            this.batteryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.batteryVoltage.Location = new System.Drawing.Point(414, 153);
            this.batteryVoltage.Name = "batteryVoltage";
            this.batteryVoltage.ReadOnly = true;
            this.batteryVoltage.Size = new System.Drawing.Size(72, 20);
            this.batteryVoltage.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(404, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Battery Voltage [V]";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.pradP3);
            this.groupBox6.Controls.Add(this.speedP3);
            this.groupBox6.Controls.Add(this.pradP2);
            this.groupBox6.Controls.Add(this.speedP2);
            this.groupBox6.Controls.Add(this.pradP1);
            this.groupBox6.Controls.Add(this.speedP1);
            this.groupBox6.Controls.Add(this.speedL3);
            this.groupBox6.Controls.Add(this.speedL2);
            this.groupBox6.Controls.Add(this.speedL1);
            this.groupBox6.Controls.Add(this.pradL3);
            this.groupBox6.Controls.Add(this.pradL2);
            this.groupBox6.Controls.Add(this.pradL1);
            this.groupBox6.Location = new System.Drawing.Point(105, 179);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(262, 140);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Parametry napędu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 105);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(172, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 26);
            this.label19.TabIndex = 50;
            this.label19.Text = "Prędkość\r\n  [RPM]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 26);
            this.label18.TabIndex = 49;
            this.label18.Text = "Prędkość\r\n  [RPM]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 26);
            this.label17.TabIndex = 48;
            this.label17.Text = "Prąd\r\n [A]";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 26);
            this.label16.TabIndex = 47;
            this.label16.Text = "Prąd\r\n [A]";
            // 
            // pradP3
            // 
            this.pradP3.Enabled = false;
            this.pradP3.Location = new System.Drawing.Point(217, 101);
            this.pradP3.Name = "pradP3";
            this.pradP3.Size = new System.Drawing.Size(36, 20);
            this.pradP3.TabIndex = 46;
            // 
            // speedP3
            // 
            this.speedP3.Enabled = false;
            this.speedP3.Location = new System.Drawing.Point(175, 101);
            this.speedP3.Name = "speedP3";
            this.speedP3.Size = new System.Drawing.Size(36, 20);
            this.speedP3.TabIndex = 45;
            // 
            // pradP2
            // 
            this.pradP2.Enabled = false;
            this.pradP2.Location = new System.Drawing.Point(217, 75);
            this.pradP2.Name = "pradP2";
            this.pradP2.Size = new System.Drawing.Size(36, 20);
            this.pradP2.TabIndex = 44;
            // 
            // speedP2
            // 
            this.speedP2.Enabled = false;
            this.speedP2.Location = new System.Drawing.Point(175, 75);
            this.speedP2.Name = "speedP2";
            this.speedP2.Size = new System.Drawing.Size(36, 20);
            this.speedP2.TabIndex = 43;
            // 
            // pradP1
            // 
            this.pradP1.Enabled = false;
            this.pradP1.Location = new System.Drawing.Point(217, 49);
            this.pradP1.Name = "pradP1";
            this.pradP1.Size = new System.Drawing.Size(36, 20);
            this.pradP1.TabIndex = 42;
            // 
            // speedP1
            // 
            this.speedP1.Enabled = false;
            this.speedP1.Location = new System.Drawing.Point(175, 49);
            this.speedP1.Name = "speedP1";
            this.speedP1.Size = new System.Drawing.Size(36, 20);
            this.speedP1.TabIndex = 41;
            // 
            // speedL3
            // 
            this.speedL3.Enabled = false;
            this.speedL3.Location = new System.Drawing.Point(55, 101);
            this.speedL3.Name = "speedL3";
            this.speedL3.Size = new System.Drawing.Size(36, 20);
            this.speedL3.TabIndex = 40;
            // 
            // speedL2
            // 
            this.speedL2.Enabled = false;
            this.speedL2.Location = new System.Drawing.Point(55, 75);
            this.speedL2.Name = "speedL2";
            this.speedL2.Size = new System.Drawing.Size(36, 20);
            this.speedL2.TabIndex = 39;
            // 
            // speedL1
            // 
            this.speedL1.Enabled = false;
            this.speedL1.Location = new System.Drawing.Point(55, 49);
            this.speedL1.Name = "speedL1";
            this.speedL1.Size = new System.Drawing.Size(36, 20);
            this.speedL1.TabIndex = 38;
            // 
            // pradL3
            // 
            this.pradL3.Enabled = false;
            this.pradL3.Location = new System.Drawing.Point(13, 101);
            this.pradL3.Name = "pradL3";
            this.pradL3.Size = new System.Drawing.Size(36, 20);
            this.pradL3.TabIndex = 37;
            // 
            // pradL2
            // 
            this.pradL2.Enabled = false;
            this.pradL2.Location = new System.Drawing.Point(13, 75);
            this.pradL2.Name = "pradL2";
            this.pradL2.Size = new System.Drawing.Size(36, 20);
            this.pradL2.TabIndex = 36;
            // 
            // pradL1
            // 
            this.pradL1.Enabled = false;
            this.pradL1.Location = new System.Drawing.Point(13, 49);
            this.pradL1.Name = "pradL1";
            this.pradL1.Size = new System.Drawing.Size(36, 20);
            this.pradL1.TabIndex = 35;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ResetMap);
            this.groupBox7.Controls.Add(this.button_mapaStart);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Location = new System.Drawing.Point(373, 179);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(118, 139);
            this.groupBox7.TabIndex = 35;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "GPS";
            // 
            // ResetMap
            // 
            this.ResetMap.Location = new System.Drawing.Point(6, 116);
            this.ResetMap.Name = "ResetMap";
            this.ResetMap.Size = new System.Drawing.Size(78, 24);
            this.ResetMap.TabIndex = 7;
            this.ResetMap.Text = "Mapa Reset";
            this.ResetMap.UseVisualStyleBackColor = true;
            this.ResetMap.Click += new System.EventHandler(this.ResetMap_Click);
            // 
            // button_mapaStart
            // 
            this.button_mapaStart.Location = new System.Drawing.Point(6, 88);
            this.button_mapaStart.Name = "button_mapaStart";
            this.button_mapaStart.Size = new System.Drawing.Size(78, 24);
            this.button_mapaStart.TabIndex = 6;
            this.button_mapaStart.Text = "Mapa Start";
            this.button_mapaStart.UseVisualStyleBackColor = true;
            this.button_mapaStart.Click += new System.EventHandler(this.mapaStart_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(48, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Długość";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Szerokość ";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(6, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(78, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(6, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(499, 320);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.batteryVoltage);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "KNR Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_diagnostics.ResumeLayout(false);
            this.groupBox_diagnostics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_portNames;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ProgressBar progressBar_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_openPort;
        private System.Windows.Forms.Button button_closePort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_diagnostics;
        private System.Windows.Forms.TextBox textBox_diagnostics;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.TextBox textBox_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox batteryVoltage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox pradL1;
        private System.Windows.Forms.TextBox pradP1;
        private System.Windows.Forms.TextBox speedP1;
        private System.Windows.Forms.TextBox speedL3;
        private System.Windows.Forms.TextBox speedL2;
        private System.Windows.Forms.TextBox speedL1;
        private System.Windows.Forms.TextBox pradL3;
        private System.Windows.Forms.TextBox pradL2;
        private System.Windows.Forms.TextBox pradP3;
        private System.Windows.Forms.TextBox speedP3;
        private System.Windows.Forms.TextBox pradP2;
        private System.Windows.Forms.TextBox speedP2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button_mapaStart;
        private System.Windows.Forms.Button ResetMap;
    }
}

