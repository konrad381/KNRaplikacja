using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EARTHLib;
using System.IO;

namespace KNRapp
{
    public partial class GPSfile
    {
        string plikGPS = @"..\GPSdata.kml";
        //string plikGPS = @"D:\GPSdata.kml";
        private EARTHLib.ApplicationGE ge = null;
        

        public GPSfile()
        {
            plikGPS = Path.GetFullPath(plikGPS);

            if (!File.Exists(plikGPS))
            {
                GPSreset(false);
            }  
        }
        
         public void GPSstart()
        {         
            ge = new ApplicationGEClass();
            if (ge != null)
            {
                ge.OpenKmlFile(plikGPS, 0);
            }
        }

       public void GPSreset(Boolean czyWyswietlic)
        {
            File.Delete(plikGPS);
            FileStream fs = File.Create(plikGPS);
            fs.Close();
            File.WriteAllLines(plikGPS, emptyFile);
            if (czyWyswietlic)
            {
                if (ge != null)
                {
                    ge.OpenKmlFile(plikGPS, 0);
                }
            }
        }

        public void GPSset(string X,string Y)
        {
            string[] GPSdata = File.ReadAllLines(plikGPS);
            int n =GPSdata.Length;
            GPSdata[n - 6] = X + "," + Y + ",50";
            GPSdata[n-17]=GPSdata[n-17]+ "\n\t"+ X + "," + Y + ",20";
            File.WriteAllLines(plikGPS,GPSdata);
            if (ge != null)
            {
                ge.OpenKmlFile(plikGPS, 0);
            }
        }



        string[] emptyFile={"<?xml version=\"1.0\" encoding=\"UTF-8\"?>",
"<kml xmlns=\"http://earth.google.com/kml/2.2 \">",
"<Document>",
"<name>Pozycja pojazdu</name>",
"<open>1</open>",
"<Style id=\"yellowLineGreenPoly\">",
"<LineStyle>",
"<color>7f00ffff</color>",
"<width>4</width>",
"</LineStyle>",
"<PolyStyle>",
"<color>7f00ff00</color>",
"</PolyStyle>",
"</Style>",
"<Style id=\"downArrowIcon\">",
"<IconStyle>",
"<Icon>",
"<href>http://maps.google.com/mapfiles/kml/pal4/icon28.png</href>",
"</Icon>",
"</IconStyle>",
"</Style>",
"<Placemark>",
"<name>Przejechana trasa</name>",
"<description></description>",
"<styleUrl>#yellowLineGreenPoly</styleUrl>",
"<LineString>",
"<extrude>1</extrude>",
"<tessellate>1</tessellate>",
"<altitudeMode>relativeToGround</altitudeMode>",
"<coordinates>",
" ",
"</coordinates>",
"</LineString>",
"</Placemark>",
"<Placemark>",
"<name>Nasz Pojazd</name>",
"<visibility>1</visibility>",
"<styleUrl>#downArrowIcon</styleUrl>",
"<Point>",
"<altitudeMode>relativeToGround</altitudeMode>",
"<coordinates>",
" ",
"</coordinates>",
"</Point>",
"</Placemark>",
"</Document>",
"</kml>"};
    }
}
