using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
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
using Calculator;
using Weather;
using FileIO;
using SerialIO;
using NetworkIO;
using LineupBuilder;
using ListingsBuilder;
using User_Settings = PrevueDataSender.Properties.Settings;

namespace Commands
{
    public class Command
    {
        public string Save_Prevue_Data(SerialPort port)
        {
            char[] body = new char[] { };

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("save data", body);
                return "Save Command sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "save data", body);
                return"Save Command sent via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string Reset_Prevue_Software(SerialPort port)
        {
            char[] body = new char[] { };

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("reset", body);
                return "Reset Command sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "reset", body);
                return "Reset Command sent via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }

        }

        public string Box_On(SerialPort port)
        {
            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                return "Sent manual box on command via TCP-IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", User_Settings.Default.Select_Code.ToCharArray());
                return "Sent manual box on command via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string Box_Off(SerialPort port)
        {
            char[] body = new char[] { };

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box off", body);
                return "Sent manual box off command via TCP-IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box off", body);
                return "Sent manual box off command via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string Version_Check(SerialPort port)
        {
            string messagebody = '\x01' + User_Settings.Default.Current_Version;
            char[] body = messagebody.ToCharArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("version", body);
                return "Version check sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "version", body);
                return "Version check sent via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string Clock(SerialPort port, ClockData clock)
        {
            char[] daylight;

            if (clock.CurrentDSTSetting == true)
            {
                daylight = new char[] { Convert.ToChar(1) };
            }
            else
            {
                daylight = new char[] { Convert.ToChar(0) };
            }

            List<char> list = new List<char>();
            list.AddRange(Convert.ToChar(clock.CurrentDayOfWeek).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentMonth - 1).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentDay - 1).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentYear - 1900).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentHour).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentMinute).ToString());
            list.AddRange(Convert.ToChar(clock.CurrentSecond).ToString());
            list.AddRange(daylight);

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("clock", body);
                return "Clock Data sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "clock", body);
                return "Clock Data sent via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string DST_Data(SerialPort port, string option, ClockData clock)
        {
            char[] commandlength = new char[] { '2', '7' };

            List<char> list = new List<char>();
            list.AddRange(option);
            list.AddRange(commandlength);
            list.AddRange("\x04");
            list.AddRange(clock.DST_Enter_Year);
            list.AddRange(clock.DST_Enter_DayOfYear);
            list.AddRange(clock.DST_Enter_Time);
            list.AddRange("\x13");
            list.AddRange(clock.DST_Exit_Year);
            list.AddRange(clock.DST_Exit_DayOfYear);
            list.AddRange(clock.DST_Exit_Time);

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("DST", body);
                return "Daylight Savings Time Data sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "DST", body);
                return "Daylight Savings Time Data sent via TCP/IP";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }

        }

        public string Weather_ID(SerialPort port)
        {
            Serial s = new Serial();
            string messagebody = User_Settings.Default.WeatherFrequency +
                                 User_Settings.Default.WeatherID + '\x12' +
                                 User_Settings.Default.WeatherCity;

            char[] body = messagebody.ToCharArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("weather id", body);
                return "Weather ID sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                s.TransmitMessage(port, "weather id", body);
                return "Weather ID sent via serial";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }
        public string Top_Line(SerialPort port)
        {
            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("top line", User_Settings.Default.TopLine.ToCharArray());
                return "EPG Top line information sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "top line", User_Settings.Default.TopLine.ToCharArray());
                return "EPG Top line information sent via serial.";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string Bottom_Line(SerialPort port)
        {
            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("bottom line", User_Settings.Default.BottomLine.ToCharArray());
                return "EPG Bottom line information sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "bottom line", User_Settings.Default.BottomLine.ToCharArray());
                return "EPG Bottom line information sent via serial.";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }
        /*
        public string Utility(SerialPort port)
        {
            char[] commandfamily = new char[] { Convert.ToChar(textBox114.Text) };
            //string member = textBox115.Text;
            //string submember = textBox116.Text;

            List<char> list = new List<char>();
            list.AddRange(commandfamily);
            list.AddRange(member.ToCharArray());
            list.AddRange(submember.ToCharArray());

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("utility", body);
                return "Utility command sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "utility", body);
                return "Utility command sent via serial.";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }*/
    }
}
