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
        public static List<string> _raw_data = new List<string>();

        public static string sky;
        public static string weather;
        public static double temp;
        public static double wind;
        public static string winddirection;
        public static double windgust;
        public static double pressure;
        public static double previous_pressure;
        public static double humidity;
        public static double dewpoint;
        public static string visibility;

        public List<string> Raw_Data
        { get { return _raw_data; } }

        public void AddToLineData(string line)
        { Raw_Data.Add(line); }

        public string Sky
        {
            get { return sky; }
            set { sky = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value.Remove(0, 1)); }
        }
        public string Weather
        {
            get { return weather; }
            set { weather = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
        }
        public double Wind
        {
            get { return wind; }
            set { wind = Convert.ToDouble(value); }
        }
        public string WindDirection
        {
            get { return winddirection; }
            set { winddirection = value; }
        }
        public double WindGust
        {
            get { return windgust; }
            set { windgust = value; }
        }
        public double Humidity
        {
            get { return humidity; }
            set { humidity = Convert.ToDouble(value); }
        }
        public double Temp
        {
            get { return temp; }
            set { temp = Math.Floor(Convert.ToDouble(value)); }
        }
        public double WindChill
        {
            get { Calc c = new Calc();
                return c.CalcWindChill(Temp, Wind); }
        }
        public double HeatIndex
        {
            get { Calc c = new Calc();
                return c.CalcHeatIndex(Temp, Humidity); }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = Convert.ToDouble(value); }
        }
        public double Previous_Pressure
        {
            get { return previous_pressure; }
            set { previous_pressure = Convert.ToDouble(value); }
        }
        public string PressureChg
        {
            get { Calc c = new Calc();
                return c.PressureTendency(Pressure, Previous_Pressure); }
        }
        public double DewPoint
        {
            get { return dewpoint; }
            set { dewpoint = Math.Floor(Convert.ToDouble(value)); }
        }
        public string Visibility
        {
            get { return visibility; }
            set { visibility = value; }
        }
    }
    public class Weather_Display
    {
        NWS_Weather_Data nws = new NWS_Weather_Data();

        public static string sky;
        public static string weather;
        public static string temp;
        public static string wind;
        public static string pressure;
        public static string humidity;
        public static string dewpoint;
        public static string visibility;
        public static int icon;

        public string Sky 
        { get { sky = "\x18" + nws.Sky;
                return sky; }
          set { sky = value; } }

        public string Weather
        { get { if (nws.Weather != "")
                { if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                     { weather = "\x18Light Drizzle and Fog with Thunder"; }
                  else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                     { weather = "\x18Drizzle and Fog with Thunder"; }
                  else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                     { weather = "\x18Heavy Drizzle and Fog with Thunder"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Light Drizzle and Fog with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Drizzle and Fog with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Heavy Drizzle and Fog with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Light Drizzle and Mist with Thunder"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Drizzle and Mist with Thunder"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Drizzle and Mist with Thunder"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Light Drizzle and Mist with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Drizzle and Mist with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Drizzle and Mist with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Light Drizzle with Thunder"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Drizzle with Thunder"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Heavy Drizzle with Thunder"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Light Drizzle with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Drizzle with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Heavy Drizzle with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Light Drizzle and Fog"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Drizzle and Fog"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Heavy Drizzle and Fog"; }

                    else if (nws.Weather.Contains("Light Drizzle") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Light Drizzle and Mist"; }
                    else if (nws.Weather.Contains("Drizzle") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Drizzle and Mist"; }
                    else if (nws.Weather.Contains("Heavy Drizzle") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Drizzle and Mist"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Light Rain and Fog with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Rain and Fog with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Heavy Rain and Fog with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Thundershower and Fog"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Thunderstorm and Fog"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Heavy Thunderstorm and Fog"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Thundershower and Fog"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Thunderstorm and Fog"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Fog"))
                    { weather = "\x18Heavy Thunderstorm and Fog"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Light Rain and Mist with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Rain and Mist with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder In The Vicinity") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Rain and Mist with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Thundershower and Mist"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Thunderstorm and Mist"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Thunderstorm and Mist"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Thundershower and Mist"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Thunderstorm and Mist"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Lightning Observed") && nws.Weather.Contains("Mist"))
                    { weather = "\x18Heavy Thunderstorm and Mist"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder In The Vicinity"))
                    { weather = "\x18Light Rain with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder In The Vicinity"))
                    { weather = "\x18Rain with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder In The Vicinity"))
                    { weather = "\x18Heavy Rain with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Thundershower"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Thunderstorm"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Thunder"))
                    { weather = "\x18Heavy Thunderstorm"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Thundershower"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Thunderstorm"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Lightning Observed"))
                    { weather = "\x18Heavy Thunderstorm"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Freezing Fog"))
                    { weather = "\x18Light Rain and Freezing Fog"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Freezing Fog"))
                    { weather = "\x18Rain and Freezing Fog"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Freezing Fog"))
                    { weather = "\x18Heavy Rain and Freezing Fog"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Light Rain and Fog"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Rain and Fog"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Heavy Rain and Fog"; }

                    else if (nws.Weather.Contains("Light Rain") && nws.Weather.Contains("Mist"))
                       { weather = "\x18Light Rain and Mist"; }
                    else if (nws.Weather.Contains("Rain") && nws.Weather.Contains("Mist"))
                       { weather = "\x18Rain and Mist"; }
                    else if (nws.Weather.Contains("Heavy Rain") && nws.Weather.Contains("Mist"))
                       { weather = "\x18Heavy Rain and Mist"; }


                    else if (nws.Weather.Contains("Light Snow") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Light Snow and Fog"; }
                    else if (nws.Weather.Contains("Snow") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Snow and Fog"; }
                    else if (nws.Weather.Contains("Heavy Snow") && nws.Weather.Contains("Fog"))
                       { weather = "\x18Heavy Snow and Fog"; }

                    else if (nws.Weather.Contains("Light Snow") && nws.Weather.Contains("Thunder"))
                       { weather = "\x18Light Snow with Thunder"; }
                    else if (nws.Weather.Contains("Snow") && nws.Weather.Contains("Thunder"))
                       { weather = "\x18Thundersnow"; }
                    else if (nws.Weather.Contains("Heavy Snow") && nws.Weather.Contains("Thunder"))
                       { weather = "\x18Heavy Thundersnow"; }

                    else if (nws.Weather.Contains("Light Snow") && nws.Weather.Contains("Lightning Observed"))
                       { weather = "\x18Light Snow with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Snow") && nws.Weather.Contains("Lightning Observed"))
                       { weather = "\x18Snow with Thunder Nearby"; }
                    else if (nws.Weather.Contains("Heavy Snow") && nws.Weather.Contains("Lightning Observed"))
                       { weather = "\x18Heavy Snow with Thunder Nearby"; }

                    else if (nws.Weather.Contains("Lightning Observed"))
                       { weather = "\x18Thunder Nearby"; }

                    else if (nws.Weather.Contains("Thunder"))
                       { weather = "\x18Thunder"; }

                    else 
                       { weather = "\x18" + nws.Weather.Remove(0, 1); } }
                else { weather = ""; }
                return weather; }
          set { weather = value; } }
        public string Wind
        { get { if (nws.Wind == 0)
                   { wind = "\x18" + "Wind Calm"; }
                else if (nws.WindGust != 0)
                   { wind = "\x18" + "Wind " + nws.WindDirection + " at " + nws.Wind.ToString() + " MPH  Gusts to " + nws.WindGust.ToString() + " MPH"; }
                else
                   { wind = "\x18" + "Wind " + nws.WindDirection + " at " + nws.Wind.ToString() + " MPH"; }
                return wind; }
          set { wind = value; } }
        
        public string Temp
        { get { if (nws.HeatIndex != nws.Temp)
                   { temp = "\x18" + "Temp " + nws.Temp.ToString() + "^F  Heat Index " + nws.HeatIndex.ToString() + "^F"; }
                else if (nws.WindChill != nws.Temp)
                   { temp = "\x18" + "Temp " + nws.Temp.ToString() + "^F  Wind Chill " + nws.WindChill.ToString() + "^F"; }
                else 
                   { temp = "\x18" + "Temp " + nws.Temp.ToString() + "^F"; }
                return temp; } 
          set { temp = value; } }

        public string Humidity 
        { get { humidity = "\x18" + "Humidity " + nws.Humidity.ToString() + "%";
                return humidity; }
          set { humidity = value; } }

        public string Pressure 
        { get { pressure = "\x18" + "Pressure " + String.Format("{0:0.00}", nws.Pressure) + " in. " + nws.PressureChg;
                return pressure; }
          set { pressure = value; } }

        public string DewPoint 
        { get { dewpoint = "\x18" + "DewPoint " + nws.DewPoint.ToString() + "^F";
                return dewpoint; }
          set { dewpoint = value; } }

        public string Visibility 
        { get { visibility = "\x18" + "Visibility " + nws.Visibility + " mi.";
                return visibility; }
          set { visibility = value; } }

        public int Icon

        /// * 0 = illegal
        /// 1 = no icon
        /// 2 = "wsun"                      Icon 1 is Sunny
        /// 3 = "wcloud" (partly cloudy)    Icon 2 is Cloudy
        /// 4 = "wrain"                     Icon 3 is Rain
        /// 5 = "wovercast"                 Icon 4 is Partly Cloudy
        /// 6 = "wsnow"                     Icon 5 is Snow
        /// 7 = "wfog"                      
        /// 8 = "wcold                      

        { get { if (nws.Weather != null && nws.Weather.Contains("Drizzle")) { icon = 4; }
                else if (nws.Weather != null && nws.Weather.Contains("Rain")) { icon = 4; }
                else if (nws.Weather != null && nws.Weather.Contains("Snow")) { icon = 6; }
                else if (nws.Weather != null && nws.Weather.Contains("Fog")) { icon = 5; }
                else if (nws.Weather != null && nws.Weather.Contains("Haze")) { icon = 3; }
                else if (nws.Sky == "Clear") { icon = 2; }
                else if (nws.Sky == "Partly Cloudy") { icon = 3; }
                else if (nws.Sky == "Mostly Cloudy") { icon = 3; }
                else if (nws.Sky == "Overcast") { icon = 5; }
                else { icon = 1; }
                return icon;
            }
            set { icon = value; }
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
            Weather_Display disp = new Weather_Display();
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
                Weather_Reset_Display_Values(disp);
                Weather_NWS_Raw_Data_Parse(nws);
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

        public void Weather_Reset_Display_Values(Weather_Display disp)
        {
            disp.Sky = "";
            disp.Weather = "";
            disp.Temp = "";
            disp.Wind = "";
            disp.Humidity = "";
            disp.DewPoint = "";
            disp.Visibility = "";
            disp.Icon = 0;
        }

        public void Weather_NWS_Raw_Data_Parse(NWS_Weather_Data nws)
        {
            char[] delimiterChars = { ':' };
            char[] spacedelimiter = { ' ' };
            char[] charsToTrim = { '%' };

            string line;

            foreach (string linedata in nws.Raw_Data)
            {
                string[] firstpass = linedata.Split(delimiterChars);

                if (firstpass[0] != "Weather")
                {
                    nws.Weather = "";
                }
                else
                {   
                    nws.Weather = firstpass[1];
                    break;
                };
            }

            foreach (string linedata2 in nws.Raw_Data)
            {
                string[] parseinfo = linedata2.Split(delimiterChars);
                switch (parseinfo[0])
                {
                    case "Wind":
                        line = parseinfo[1];
                        string[] parsewindline = line.Split(spacedelimiter);
                        if (parsewindline[1] == "Calm")
                        {
                            nws.Wind = 0;
                            nws.WindDirection = "";
                            nws.WindGust = 0;
                        }
                        else
                        {
                            if (Array.Exists(parsewindline, element => element == "gusting"))
                            {
                                nws.Wind = Convert.ToDouble(parsewindline[7]);
                                nws.WindDirection = parsewindline[3];
                                nws.WindGust = Convert.ToDouble(parsewindline[13]);
                            }
                            else
                            {
                                if (Array.Exists(parsewindline, element => element == "(direction variable)"))
                                {
                                    nws.Wind = Convert.ToDouble(parsewindline[7]);
                                    nws.WindDirection = "Variable";
                                    nws.WindGust = 0;
                                }
                                else
                                {
                                    nws.Wind = Convert.ToDouble(parsewindline[7]);
                                    nws.WindDirection = parsewindline[3];
                                    nws.WindGust = 0;
                                }
                            }
                        }
                        break;
                    case "Visibility":
                        line = parseinfo[1];
                        string[] parsevisibilityline = line.Split(spacedelimiter);
                        if (parsevisibilityline[1] == "less")
                        {
                            nws.Visibility = parsevisibilityline[1] + " " + parsevisibilityline[2] + " " + parsevisibilityline[3];
                        }
                        else
                        {
                            nws.Visibility = parsevisibilityline[1];
                        }
                        break;
                    case "Sky conditions":
                        nws.Sky = parseinfo[1];
                        break;
                    //case "Weather":
                        //nws.Weather = parseinfo[1];
                        //break;
                    case "Temperature":
                        line = parseinfo[1];
                        string[] parsetempline = line.Split(spacedelimiter);
                        nws.Temp = Convert.ToDouble(parsetempline[1]);
                        break;
                    case "Dew Point":
                        line = parseinfo[1];
                        string[] parseDewptline = line.Split(spacedelimiter);
                        nws.DewPoint = Convert.ToDouble(parseDewptline[1]);
                        break;
                    case "Relative Humidity":
                        nws.Humidity = Convert.ToDouble(parseinfo[1].Trim(charsToTrim));
                        break;
                    case "Pressure (altimeter)":
                        nws.Previous_Pressure = nws.Pressure;
                        line = parseinfo[1];
                        string[] parsePressureline = line.Split(spacedelimiter);
                        nws.Pressure = Convert.ToDouble(parsePressureline[1]);
                        break;
                    default:
                        break;
                }

            }
        }
    }
    public class WeatherData
    {
        public void Weather_GetData()
        {
            WeatherFile wthr = new WeatherFile();
            wthr.Weather_NWS_Raw_Data_Download();
        }

        public char[] empty = new char[] { };
        public string Weather_SendData(SerialPort serialport)
        {   
            string message;
            try
            {   
                Weather_Display disp = new Weather_Display();
                List<char> list = new List<char>();
                list.AddRange(Convert.ToChar(Convert.ToInt16(User_Settings.Default.WeatherParseCycle)).ToString());
                list.AddRange(Convert.ToChar(1).ToString()); //ClrID
                list.AddRange(Convert.ToChar(disp.Icon).ToString());
                list.AddRange(Convert.ToChar(1).ToString()); //Exp
                list.AddRange(User_Settings.Default.WeatherID);
                list.AddRange(Convert.ToChar(18).ToString());  //flag1
                list.AddRange(disp.Sky);
                if (disp.Weather != "")
                {
                    list.AddRange(disp.Weather);
                }
                list.AddRange(disp.Temp);
                list.AddRange(disp.Wind);
                list.AddRange(disp.Pressure);
                list.AddRange(disp.Humidity);
                list.AddRange(disp.DewPoint);
                list.AddRange(disp.Visibility);
                char[] body = list.ToArray();

                if (User_Settings.Default.Port_Selected == 'T')
                {
                    Network net = new Network();
                    net.TransmitNetworkMessage("weather data", body);
                    message = "Weather data sent over TCP/IP";
                    return message;
                }
                else if (User_Settings.Default.Port_Selected == 'S')
                {
                    Serial s = new Serial();
                    s.TransmitMessage(serialport, "weather data", body);
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
                message = "Error with Weather - check code";
                return message;
            }
        }
    }

}