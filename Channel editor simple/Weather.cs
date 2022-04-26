using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using DataFunctions;
using SerialIO;
using NetworkIO;
using Calculator;
using System.IO.Ports;
using User_Settings = PrevueDataSender.Properties.Settings;

namespace Weather
{
    public class NWS_Weather_Data
    {
        private List<string> _raw_data = new List<string>();

        public List<string> Raw_Data
        { get { return _raw_data; } }

        public void AddToLineData(string line)
        { Raw_Data.Add(line); }

        public List<string> GetList()
        {
            return _raw_data;
        }
    }

    public class Current
    {
        private readonly char[] charsToTrim = { '%' };

        private string _sky;
        private string _displaysky;

        private string _weather;
        private string _displayweather;

        private double temp;
        private string _temp;
        private string _windchill;
        private string _heatindex;
        private string _displaytemp;

        private double wind;
        private string _wind;
        private string _winddirection;
        private string _windgust;
        private string _displaywind;

        private double pressure;
        private double _previous_pressure;
        private string _pressure;
        private string _pressurechg;
        private string _displaypressure;

        private double humidity;
        private string _humidity;
        private string _displayhumidity;

        private double dewpoint;
        private string _dewpoint;
        private string _displaydewpoint;

        private string _visibility;
        private string _displayvisibility;

        private string _displayicon;

        public string Sky
        {
            get { return _sky; }
            set
            { CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                _sky = value;
            }
        }
        public string Weather
        {
            get { return _weather; }
            set
            {
                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                _weather = value;
            }
        }
        public string Wind
        { 
            get { return _wind; }
            set { wind = Convert.ToDouble(value);  _wind = value; } 
        }

        public string WindDirection 
        {
            get { return _winddirection; }
            set { _winddirection = value; }
        }
        public string WindGust 
        {
            get { return _windgust; }
            set { _windgust = value; }
        }
        public string Humidity 
        {
            get { return _humidity; }
            set { humidity = Convert.ToDouble(value.Trim(charsToTrim));  
                 _humidity = value;}
        }
        public string Temp
        {
            get { return _temp; }
            set 
            { 
                temp = Convert.ToDouble(value);
                value = Math.Floor(temp).ToString();
                _temp = value;
            }
        }
        public string WindChill
        {
            get { return _windchill; }
            set
            {
                if ((temp <= 50) && (wind > 3))
                {
                    Calc c = new Calc();
                    value = c.CalcWindChill(temp, wind).ToString();
                    _windchill = value;
                }
                else
                { value = "";  _windchill = value; }
            }
        }
        public string HeatIndex
        {
            get { return _heatindex; }
            set
            {
                if (temp >= 70)
                {
                    Calc c = new Calc();
                    value = c.CalcHeatIndex(temp, humidity).ToString();
                    _heatindex = value;
                }
                else 
                {
                    value = "";
                    _heatindex = value;
                }
            }
        }
        public string Pressure
        {
            get { return _pressure; }
            set 
            {
                pressure = Convert.ToDouble(value);
                _pressure = String.Format("{0:0.00}", value);
            }
        }
        public double Previous_Pressure
        {
            get { return _previous_pressure; }
            set { _previous_pressure = value; }
        }

        public string PressureChg
        { get { return _pressurechg; } 
          set {

                if (_previous_pressure < pressure)
                { _pressurechg = "R"; }
                else
                {
                    if (_previous_pressure > pressure)
                    { _pressurechg = "F"; }
                    else
                    { _pressurechg = "S"; }
                }
              }
        }
        
        public string DewPoint
        { 
            get { return _dewpoint; }
            set { dewpoint = Math.Floor(Convert.ToDouble(value));
                 _dewpoint = value; }
        }
        public string Visibility
        { 
            get { return _visibility; }
            set { _visibility = value; }
        }

        public string IconSelection
        {
            get { return _displayicon; }
            set
            {
                if (_sky == " Partly Cloudy" && _weather == "")
                { value = "2"; _displayicon = value; }

                else if (_sky == " Overcast" && _weather == "")
                { value = "4"; _displayicon = value; }

                else if (_sky == " Clear" && _weather == "")
                { value = "1"; _displayicon = value; }

                else if (_sky == " Mostly Cloudy" && _weather == "")
                { value = "4"; _displayicon = value; }

                else if (_sky == "" && _weather == " Fog")
                { value = "3"; _displayicon = value; }

                else { value = "1"; _displayicon = value; }
            }
        }
        public string Display_Sky
        {
            get { _displaysky = "\x18" + _sky;   return _displaysky; }
        }
        public string Display_Weather
        {
            get { _displayweather = "\x18" + _weather;   return _displayweather; }
        }
        public string Display_Wind
        {
            get
            {
                if (_wind == "0")
                {
                    _displaywind = "\x18" + "Wind Calm";
                    return _displaywind;
                }
                else if (_windgust != "0")
                {
                    _displaywind = "\x18" + "Wind " + _winddirection + " at " + _wind + " MPH  Gusts to " + _windgust + " MPH";
                    return _displaywind;
                }
                else
                {
                    _displaywind = "\x18" + "Wind " + _winddirection + " at " + _wind + " MPH";
                    return _displaywind;
                }
            }
        }
        public string Display_Temp
        {
            get
            {
                if (_heatindex != "")
                {
                    _displaytemp = "\x18" + "Temp " + _temp + "^F  Heat Index " + _heatindex + "^F";
                    return _displaytemp;
                }
                else if (_windchill != "")
                {
                    _displaytemp = "\x18" + "Temp " + _temp + "^F  Wind Chill " + _windchill + "^F";
                    return _displaytemp;
                }
                else
                {
                    _displaytemp = "\x18" + "Temp " + _temp + "^F";
                    return _displaytemp;
                }
             }
        }
          public string Display_Humidity
            {
                get { _displayhumidity =  "\x18" + "Humidity " + _humidity + "%";
                    return _displayhumidity; }
            }      

            public string Display_Dewpoint 
            { 
                get { _displaydewpoint = "\x18" + "DewPoint " + _dewpoint + "^F";
                     return _displaydewpoint;  }
            }

            public string Display_Visibility
            {
                get 
                {  _displayvisibility = "\x18" + "Visibility "  + _visibility + " mi."; 
                   return _displayvisibility;                 
                }
            }

            public string Display_Pressure
            {            
                get { _displaypressure = "\x18" + "Pressure " + _pressure + " in. " + PressureChg;
                return _displaypressure; }
            }
            }

    public class WeatherFile
    {
        public void Weather_NWS_Raw_Data_Download()
        {
            // Get URL from settings
            User_Settings settings = User_Settings.Default;
            string url = settings.WeatherDataPath + settings.WeatherID + ".TXT";

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential("anonymous", "janeDoe@contoso.com");
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            NWS_Weather_Data nws = new NWS_Weather_Data();
            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Stream responseStream = response.GetResponseStream();

                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        while (!reader.EndOfStream)
                        {
                            
                            nws.AddToLineData(reader.ReadLine());
                        }  
                        reader.Close();
                    }
                response.Close();
                }
                Weather_NWS_Raw_Data_SaveToFile(nws);
            }
            catch (Exception)
            {
                MessageBox.Show("Weather Data not available at this time.", "Prevue Weather", MessageBoxButtons.OK);
            }
        }
        public void Weather_NWS_Raw_Data_SaveToFile(NWS_Weather_Data nws)
        {
            // Set data folder to store raw data
            User_Settings settings = User_Settings.Default;
            string weatherdatafile = settings.FolderPath + @"\" + settings.WeatherID + ".TXT";
            File.WriteAllLines(weatherdatafile, nws.Raw_Data);
        }
    }

    public class GetWeatherData
    {
        public void Weather_NWS_Raw_Data_Parse(NWS_Weather_Data nws)
        {
            char[] delimiterChars = { ':' };
            char[] spacedelimiter = { ' ' };

            string line;

            Current cur = new Current();
            cur.Weather = "";

            foreach (string linedata in nws.Raw_Data)
            {
                string[] parseinfo = linedata.Split(delimiterChars);
                switch (parseinfo[0])
                {
                    case "Wind":
                        line = parseinfo[1];
                        string[] parsewindline = line.Split(spacedelimiter);
                        if (parsewindline[1] == "Calm")
                        {
                            cur.Wind = "0";
                            cur.WindDirection = "";
                            cur.WindGust = "0";
                        }
                        else
                        {
                            if (Array.Exists(parsewindline, element => element == "gusting"))
                            {
                                cur.Wind = parsewindline[7];
                                cur.WindDirection = parsewindline[3];
                                cur.WindGust = parsewindline[13];
                            }
                            else
                            {
                                if (Array.Exists(parsewindline, element => element == "(direction variable)"))
                                {
                                    cur.Wind = parsewindline[7];
                                    cur.WindDirection = "Variable";
                                    cur.WindGust = "0";
                                }
                                else
                                {
                                    cur.Wind = parsewindline[7];
                                    cur.WindDirection = parsewindline[3];
                                    cur.WindGust = "0";
                                }
                            }
                        }
                        break;
                    case "Visibility":
                        line = parseinfo[1];
                        string[] parsevisibilityline = line.Split(spacedelimiter);
                        if (parsevisibilityline[1] == "less")
                        {
                            cur.Visibility = parsevisibilityline[1] + " " + parsevisibilityline[2] + " " + parsevisibilityline[3];
                        }
                        else
                        {
                            cur.Visibility = parsevisibilityline[1];
                        }
                        break;
                    case "Sky conditions":
                        cur.Sky = parseinfo[1];
                        break;
                    case "Weather":
                        cur.Weather = parseinfo[1];
                        break;
                    case "Temperature":
                        line = parseinfo[1];
                        string[] parsetempline = line.Split(spacedelimiter);
                        cur.Temp = parsetempline[1];
                        break;
                    case "Dew Point":
                        line = parseinfo[1];
                        string[] parseDewptline = line.Split(spacedelimiter);
                        cur.DewPoint = parseDewptline[1];
                        break;
                    case "Relative Humidity":
                        cur.Humidity = parseinfo[1];
                        break;
                    case "Pressure (altimeter)":
                        cur.Previous_Pressure = Convert.ToDouble(cur.Pressure);
                        line = parseinfo[1];
                        string[] parsePressureline = line.Split(spacedelimiter);
                        cur.Pressure = parsePressureline[1];
                        break;
                    default:
                        break;
                }

            }
        }
    }
    public class WeatherData
    {
        public void Weather_GetData(NWS_Weather_Data nws)
        {
            WeatherFile wfile = new WeatherFile();
            wfile.Weather_NWS_Raw_Data_Download();

            GetWeatherData wthr = new GetWeatherData();
            wthr.Weather_NWS_Raw_Data_Parse(nws);
        }

        public char[] empty = new char[] { };
        public string Weather_SendData(SerialPort serialport)
        {
            string message;
            Current cur = new Current();     
            try
            {     
                List<char> list = new List<char>();
                list.AddRange(Convert.ToInt32(User_Settings.Default.WeatherParseCycle).ToString());
                list.AddRange(Convert.ToChar("1").ToString()); //ClrID
                list.AddRange(cur.IconSelection);
                list.AddRange(Convert.ToChar("1").ToString()); //Exp
                list.AddRange(User_Settings.Default.WeatherID);
                list.AddRange(Convert.ToChar(18).ToString());  //flag1
                list.AddRange(cur.Display_Sky);
                if (cur.Display_Weather != "")
                {
                    list.AddRange(cur.Display_Weather);
                }
                list.AddRange(cur.Display_Temp);
                list.AddRange(cur.Display_Wind);
                list.AddRange(cur.Display_Pressure);
                list.AddRange(cur.Display_Humidity);
                list.AddRange(cur.Display_Dewpoint);
                list.AddRange(cur.Display_Visibility);
                char[] body = list.ToArray();


                if (User_Settings.Default.Port_Selected == 'T')
                {
                    Network net = new Network();
                    net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                    net.TransmitNetworkMessage("bottom line", User_Settings.Default.BottomLine.ToCharArray());
                    net.TransmitNetworkMessage("box off", empty);
                    message = "EPG Bottom line information sent via TCP/IP";
                    return message;
                }
                else if (User_Settings.Default.Port_Selected == 'S')
                {
                    Serial s = new Serial();
                    s.TransmitMessage(serialport, "box on", User_Settings.Default.Select_Code.ToCharArray());
                    s.TransmitMessage(serialport, "weather data", body);
                    s.TransmitMessage(serialport, "box off", empty);
                    message = "Weather data sent over Serial Port";
                    return message;
                }
                else
                {
                    message = "Error with Port Selected Setting - check code";
                    return message;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot send data", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //PrevueDataSender.Form1.timer2.Enabled = false;
                //PrevueDataSender.Form1.button16.Enabled = true;
                //PrevueDataSender.Form1.button17.Enabled = false;
                message = "Error with Weather - check code";
                return message;
            }
        }
    }
    /*
       public void ReadWeatherFile(DataTable weather)
       {
           string weatherfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\weatherdata.txt";
           string data;

           if (File.Exists(weatherfilename))
           {
               StreamReader weatherfile = new StreamReader(weatherfilename);

               while ((data = weatherfile.ReadLine()) != null)
               {
                   char[] delimiterChars = { '\x00' };
                   string text = data;
                   string[] parseinfo = text.Split(delimiterChars);

                   DataRow workRow;
                   workRow = weather.NewRow();

                   workRow["display_length"] = Int32.Parse(parseinfo[0]);
                   workRow["ColorID"] = Int32.Parse(parseinfo[1]);
                   workRow["IconID"] = Int32.Parse(parseinfo[2]);
                   workRow["Expansion"] = Int32.Parse(parseinfo[3]);
                   workRow["IDString"] = parseinfo[4];
                   workRow["CurSky"] = parseinfo[5];
                   workRow["CurWeather"] = parseinfo[6];
                   workRow["CurTemp"] = parseinfo[7];
                   workRow["CurWind"] = parseinfo[8];
                   workRow["CurPressure"] = parseinfo[9];
                   workRow["CurHumidity"] = parseinfo[10];
                   workRow["CurDewPoint"] = parseinfo[11];
                   workRow["CurVisibility"] = parseinfo[12];

                   weather.Rows.Add(workRow);

                   //f.toolStripStatusLabel1.Text = "File Uploading" + weather.Rows.Count + " records found";

               }

               weatherfile.Close();
               //f.toolStripStatusLabel1.Text = "File Reading Completed: " + weather.Rows.Count + " records found";
           }
           else
           {
               // Create the file.
               File.Create(weatherfilename);
           }
       }

       public void WriteWeatherFile(DataTable weather)
       {
           string weatherfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\weatherdata.txt";
           try
           {
               if (File.Exists(weatherfilename))
               {
                   StreamWriter weatherfile = new StreamWriter(weatherfilename);

                   //DataTable weather = f.WeatherDataSet.Tables["Weather"];

                   for (int i = 0; i < weather.Rows.Count; i++)
                   {
                       weatherfile.WriteLine(weather.Rows[i]["display_length"] + "\x00" +
                                             weather.Rows[i]["ColorID"] + "\x00" +
                                             weather.Rows[i]["IconID"] + "\x00" +
                                             weather.Rows[i]["Expansion"] + "\x00" +
                                             weather.Rows[i]["IDString"] + "\x00" +
                                             weather.Rows[i]["CurSky"] + "\x00" +
                                             weather.Rows[i]["CurWeather"] + "\x00" +
                                             weather.Rows[i]["CurTemp"] + "\x00" +
                                             weather.Rows[i]["CurWind"] + "\x00" +
                                             weather.Rows[i]["CurPressure"] + "\x00" +
                                             weather.Rows[i]["CurHumidity"] + "\x00" +
                                             weather.Rows[i]["CurDewPoint"] + "\x00" +
                                             weather.Rows[i]["CurVisibility"]);

                       //f.toolStripStatusLabel1.Text = "File Saving:" + weather.Rows.Count + " records saved";
                   }

                   weatherfile.Close();
                   //f.toolStripStatusLabel1.Text = "File Save Completed: " + weather.Rows.Count + " records saved";
               }
               else
               {
                   // Create the file.
                   File.Create(weatherfilename);
               }
           }
           catch (Exception)
           {
               MessageBox.Show("Cannot save weather data", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           }
       }*/

}