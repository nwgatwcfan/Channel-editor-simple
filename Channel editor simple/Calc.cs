using System;
using System.Threading;
using System.Diagnostics;
using System.Collections;
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

namespace Calculator
{
    public class ClockData
    {
        private int _CurrentDayOfWeek;
        private int _CurrentMonth;
        private int _CurrentDay;
        private int _CurrentYear;
        private int _CurrentDayOfYear;
        private int _CurrentPrevueDayOfYear;
        private int _CurrentHour;
        private int _CurrentMinute;
        private int _CurrentSecond;
        private bool _CurrentDSTSetting;
        private string _DST_Enter_Year;
        private string _DST_Enter_DayOfYear;
        private string _DST_Enter_Time;
        private string _DST_Exit_Year;
        private string _DST_Exit_DayOfYear;
        private string _DST_Exit_Time;

        public int CurrentDayOfWeek
        {
            get { return _CurrentDayOfWeek; }
            set { _CurrentDayOfWeek = value; }
        }
        public int CurrentMonth
        {
            get { return _CurrentMonth; }
            set { _CurrentMonth = value; }
        }
        public int CurrentDay
        {
            get { return _CurrentDay; }
            set { _CurrentDay = value; }
        }
        public int CurrentYear
        {
            get { return _CurrentYear; }
            set { _CurrentYear = value; }
        }
        public int CurrentDayOfYear
        {
            get { return _CurrentDayOfYear; }
            set { _CurrentDayOfYear = value; }
        }
        public int CurrentHour
        {
            get { return _CurrentHour; }
            set { _CurrentHour = value; }
        }
        public int CurrentMinute
        {
            get { return _CurrentMinute; }
            set { _CurrentMinute = value; }
        }
        public int CurrentSecond
        {
            get { return _CurrentSecond; }
            set { _CurrentSecond = value; }
        }
        public int CurrentPrevueDayOfYear
        {
            get { return _CurrentPrevueDayOfYear; }
            set { _CurrentPrevueDayOfYear = value; }
        }
        public bool CurrentDSTSetting
        {
            get { return _CurrentDSTSetting; }
            set { _CurrentDSTSetting = value; }
        }
        public string DST_Enter_Year
        {
            get { return _DST_Enter_Year; }
            set { _DST_Enter_Year = value; }
        }
        public string DST_Enter_DayOfYear
        {
            get { return _DST_Enter_DayOfYear; }
            set { _DST_Enter_DayOfYear = value; }
        }
        public string DST_Enter_Time
        {
            get { return _DST_Enter_Time; }
            set { _DST_Enter_Time = value; }
        }
        public string DST_Exit_Year
        {
            get { return _DST_Exit_Year; }
            set { _DST_Exit_Year = value; }
        }
        public string DST_Exit_DayOfYear
        {
            get { return _DST_Exit_DayOfYear; }
            set { _DST_Exit_DayOfYear = value; }
        }
        public string DST_Exit_Time
        {
            get { return _DST_Exit_Time; }
            set { _DST_Exit_Time = value; }
        }
    }

    public class Calc
    {
        public int CalcOrdinalDate(int year, int month, int day, int starthour, int startminute, int timezoneoffset)
        {
            int ordinaldate = 0;
            for (int i = 1; i < month; i++)
            {
              ordinaldate += DateTime.DaysInMonth(year, i);
            }
            ordinaldate += day;

            if (ordinaldate > 255)
            {
                ordinaldate -= 256;
            }
            int timeslot = (starthour * 2) + (startminute / 30) + (timezoneoffset * 2) + 1;
            if (timeslot <= 0)
            { 
                ordinaldate -= 1;
                return ordinaldate;
            }
            else 
            { 
                return ordinaldate; 
            }
        }

        public int CalcTimeSlot(int starthour, int startminute, int timezoneoffset)
        {

            //int timezoneoffset = -5;
            int timeslot = (starthour * 2) + (startminute / 30) + (timezoneoffset * 2) + 1;

            if (timeslot <= 0)
            {
                timeslot += 48;
                return timeslot;
            } 
            
            else
            { 
                return timeslot; 
            }
        }

        public int CalcAdjustedJulianDate(DateTime selection)
        {
            //Calculate Julian Date that Prevue will understand - anything over 256 starts over at zero
            int adjselection;

            if (selection.DayOfYear >= 256 && selection.DayOfYear < 367)
            {
                adjselection = selection.DayOfYear - 256;
                return adjselection;
            }
            else
            {
                adjselection = selection.DayOfYear;
                return adjselection;
            }
        }

        public int ValueDeterminationFunction(bool test, int Value, int factor)
        {
            if (test == true)
            {
                Value += factor;
                return Value;
            }
            else
            {
                Value -= factor;
                return Value;
            }
        }

        public string ConvertTestValue(bool test, string valueiftrue, string valueiffalse)
        {
            string valuetoreturn;
            if (test == true)
            {
                valuetoreturn = valueiftrue;
                return valuetoreturn;
            }
            else
            {
                valuetoreturn = valueiffalse;
                return valuetoreturn;
            }
        }
        public char ConvertTestValue(bool test, char valueiftrue, char valueiffalse)
        {
            char valuetoreturn;
            if (test == true)
            {
                valuetoreturn = valueiftrue;
                return valuetoreturn;
            }
            else
            {
                valuetoreturn = valueiffalse;
                return valuetoreturn;
            }
        }
        public bool ConvertValueTest(string value, string truevalue, string falsevalue)
        {
            bool valuetoreturn;
            if (value == truevalue)
            {
                valuetoreturn = true;
                return valuetoreturn;
            }
            else if (value == falsevalue)
            {
                valuetoreturn = false;
                return valuetoreturn;
            }
            else
                MessageBox.Show("Cannot save configuration", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return false;
        }
        public bool ConvertValueTest(char value, char truevalue, char falsevalue)
        {
            bool valuetoreturn;
            if (value == truevalue)
            {
                valuetoreturn = true;
                return valuetoreturn;
            }
            else if (value == falsevalue)
            {
                valuetoreturn = false;
                return valuetoreturn;
            }
            else
                MessageBox.Show("Cannot save configuration", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return false;
        }

        public int ConvertToNumeral(BitArray binary)
        {
            if (binary == null)
                throw new ArgumentNullException("binary");
            if (binary.Length > 32)
                throw new ArgumentException("must be at most 32 bits long");

            var result = new int[1];
            binary.CopyTo(result, 0);
            return result[0];
        }

        public int CalculateBitmaskValue(string val1, string val2, string val3, string val4,
                                         string val5, string val6, string val7, string val8,
                                         string trueval, string falseval)
        {
            Calc c = new Calc();
            BitArray bits = new BitArray(8);
            bits[7] = c.ConvertValueTest(val8, trueval, falseval);
            bits[6] = c.ConvertValueTest(val7, trueval, falseval);
            bits[5] = c.ConvertValueTest(val6, trueval, falseval);
            bits[4] = c.ConvertValueTest(val5, trueval, falseval);
            bits[3] = c.ConvertValueTest(val4, trueval, falseval);
            bits[2] = c.ConvertValueTest(val3, trueval, falseval);
            bits[1] = c.ConvertValueTest(val2, trueval, falseval);
            bits[0] = c.ConvertValueTest(val1, trueval, falseval);

            int convertedvalue = c.ConvertToNumeral(bits);
            return convertedvalue;

        }

        public double CalcWindChill(double temp, double wind)
        {
            double WindChill;

            double piece1 = 0.6215 * temp;
            double windfactor = 0.16;
            double windcomponent = Math.Pow(wind, windfactor);

            WindChill = 35.74 + piece1
                      - (35.75 * windcomponent)
                      + (0.4275 * temp * windcomponent);

            return (int)Math.Round(WindChill, 0);
        }
        public double CalcHeatIndex(double temp, double humidity)
        {
            double HeatIndex;
            double AdjustedHeatIndex;

            HeatIndex = -42.379 + (2.04901523 * temp) + (10.14333127 * humidity) - (0.22475541 * temp * humidity)
                        - (0.00683783 * (long)Math.Pow(temp, 2))
                        - (0.05481717 * (long)Math.Pow(humidity, 2))
                        + (0.00122874 * (long)Math.Pow(temp, 2) * (humidity))
                        + (0.00085282 * temp * (long)Math.Pow((humidity), 2))
                        - (0.00000199 * (long)Math.Pow(temp, 2) * (long)Math.Pow((humidity), 2));

            if (temp >= 80 && temp <= 112 && humidity <= 13)
            {
                AdjustedHeatIndex = HeatIndex - ((13 - humidity) / 4) * Math.Sqrt((17 - Math.Abs(temp - 95)) / 17);
                return (double)Math.Round(AdjustedHeatIndex, 0);
            }
            else
            {
                if (temp >= 80 && temp <= 87 && humidity > 85)
                {
                    AdjustedHeatIndex = HeatIndex + ((humidity - 85) / 10) * ((87 - temp) / 5);
                    return (double)Math.Round(AdjustedHeatIndex, 0);
                }
                else
                {
                    if (temp < 80)
                    {
                        AdjustedHeatIndex = 0.5 * (temp + 61.0 + ((temp - 68.0) * 1.2) + (humidity * 0.094));
                        return (double)Math.Round(AdjustedHeatIndex, 0);
                    }
                    else
                    {
                        AdjustedHeatIndex = HeatIndex;
                        return (double)Math.Round(AdjustedHeatIndex, 0);
                    }
                }
            }
        }
    }
    
}
