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
using Calculator;
using Weather;
using FileIO;
using PrevueDataSender;
using System.IO.Ports;
using System.Collections;

namespace SerialIO
{
    public class Serial
    {   
        public void TransmitMessage(SerialPort port, string selectedmode, char[] messagebody)
        {
            byte[] header = new byte[] { (byte)'\u0055', (byte)'\u00AA' };
            byte[] endcommand = new byte[] { (byte)'\u0000' };

            ConvertArray array = new ConvertArray();
            ModeSelect m = new ModeSelect();

            byte[] mode = array.CharArrayToByteArrayFunction(m.Get_Mode_Select(selectedmode));
            byte[] body = array.CharArrayToByteArrayFunction(messagebody);

            List<byte> list = new List<byte>();
            list.AddRange(header);
            list.AddRange(mode);
            list.AddRange(body);
            list.AddRange(endcommand);
            byte[] messagebuild = list.ToArray();
            byte[] checksum = new byte[] { (byte)array.XORByteArrayFunction(messagebuild) };
            List<byte> messagetosend = new List<byte>();
            messagetosend.AddRange(messagebuild);
            messagetosend.AddRange(checksum);
            byte[] messagetotransmit = messagetosend.ToArray();

            try
            {
                if (selectedmode == "box off")
                {
                    port.Write(messagetotransmit, 0, messagetotransmit.Length);
                    SerialFile ser = new SerialFile();
                    ser.WriteSerialLogFile(messagetotransmit);
                    port.Close();
                }
                else
                {
                    if (port.IsOpen)
                    {
                        port.Write(messagetotransmit, 0, messagetotransmit.Length);
                        SerialFile ser = new SerialFile();
                        ser.WriteSerialLogFile(messagetotransmit);
                    }
                    else
                    {
                        port.Open();
                        port.Write(messagetotransmit, 0, messagetotransmit.Length);
                        SerialFile ser = new SerialFile();
                        ser.WriteSerialLogFile(messagetotransmit);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);

            }
        }
      
        public void TransmitNewLookMessage(SerialPort port, string selectedmode, char[] messagebody)
        {
            char[] header = new char[] { '\u0055', '\u00AA' };
            char[] endcommand = new char[] { '\u0000' };
            
            ConvertArray array = new ConvertArray();
            ModeSelect m = new ModeSelect();
            byte[] hdr = array.CharArrayToByteArrayFunction(header); //constant
            byte[] endc = array.CharArrayToByteArrayFunction(endcommand); //constant
            byte[] mde = array.CharArrayToByteArrayFunction(m.Get_Mode_Select(selectedmode));
            byte[] body = array.CharArrayToByteArrayFunction(messagebody);

            List<byte> list = new List<byte>();
            list.AddRange(hdr);
            list.AddRange(mde);
            list.AddRange(body);
            list.AddRange(endc);
            byte[] messagebuild = list.ToArray();
            byte[] checksum = new byte[] { (byte)array.XORByteArrayFunction(messagebuild) };
            List<byte> messagetosend = new List<byte>();
            messagetosend.AddRange(messagebuild);
            messagetosend.AddRange(checksum);
            byte[] messagetotransmit = messagetosend.ToArray();
            //string test = BitConverter.ToString(messagetotransmit);

            try
            {
                if (selectedmode == "box off")
                {
                    port.Write(messagetotransmit, 0, messagetotransmit.Length);
                    SerialFile ser = new SerialFile();
                    ser.WriteSerialLogFile(messagetotransmit);
                    //ser.WriteSerialLogFile(test);
                    port.Close();
                }
                else
                {
                    if (port.IsOpen)
                    {
                        port.Write(messagetotransmit, 0, messagetotransmit.Length);
                        SerialFile ser = new SerialFile();
                        ser.WriteSerialLogFile(messagetotransmit);
                        //ser.WriteSerialLogFile(test);
                    }
                    else
                    {
                        port.Open();
                        port.Write(messagetotransmit, 0, messagetotransmit.Length);
                        SerialFile ser = new SerialFile();
                        ser.WriteSerialLogFile(messagetotransmit);
                        //ser.WriteSerialLogFile(test);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);

            }
        }



        private void RTS_Start_bit_send(SerialPort port, int delay)
        {            
            //start bit should be 1

            try
            {
                if (port.IsOpen) { port.RtsEnable = true; Thread.Sleep(delay); }
                else { port.Open(); port.RtsEnable = true; Thread.Sleep(delay); }
            }
            catch
            {
                MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);
            }

        }
        private void RTS_data_bit_send(SerialPort port, bool value, int delay)
        {
            if (value == true)
            {
                try
                {
                    if (port.IsOpen) { port.RtsEnable = true; Thread.Sleep(delay); }
                    else { port.Open(); port.RtsEnable = true; Thread.Sleep(delay); }
                }
                catch
                {
                    MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    if (port.IsOpen) { port.RtsEnable = false; Thread.Sleep(delay); }
                    else { port.Open(); port.RtsEnable = false; Thread.Sleep(delay); }
                }
                catch
                {
                    MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);
                }

            }
        }
        private void RTS_Stop_bit_send(SerialPort port, int delay)
        {
            //stop bit should be 0

            try
            {
                if (port.IsOpen) { port.RtsEnable = false; Thread.Sleep(delay); }
                else { port.Open(); port.RtsEnable = false; Thread.Sleep(delay); }
            }
            catch
            { 
                MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);
            }
        }

        public void TransmitTestControlData(SerialPort port)
        {
            int startbitdelay = 135; //135; // ~1000 ms pulse width
            int databitdelay = 90; //90; // ~1000 ms pulse width
            int stopbitdelay = 90; //90; // ~1000 ms pulse width

            // byte 1 /X03
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay); 
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay); 
            //RTS_Start_bit_send(port, startbitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);

            //byte 2 /X0D end
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);

            //checksum
            RTS_Start_bit_send(port, startbitdelay);
            RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);
            //RTS_Start_bit_send(port, startbitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);
            //RTS_data_bit_send(port, true, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);

            RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay);
            //RTS_data_bit_send(port, false, databitdelay); ;

            RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);
            //RTS_Stop_bit_send(port, stopbitdelay);

        }

        public void TransmitControlData(SerialPort port, byte[] data)
        {
            int startbitdelay = 135; // ~1000 ms pulse width
            int databitdelay = 90; // ~1000 ms pulse width
            int stopbitdelay = 90; // ~1000 ms pulse width

            //int testvalue = Convert.ToInt16('\x00');
            //BitArray bits = new BitArray(System.BitConverter.GetBytes(testvalue));
            //BitArray bits = new BitArray(System.BitConverter.GetBytes(b));
            //byte testvalue = Convert.ToByte(b);
          
            foreach (byte b in data)
               {
                  BitArray bits = new BitArray(b);

                  if (bits.Count > 0)
                     {
                        RTS_Start_bit_send(port, startbitdelay);
                        
                        //least significant bit is always sent first 
                        //so then the values need to be reversed
                        if (bits.Length >= 8) { RTS_data_bit_send(port, bits[7], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 7) { RTS_data_bit_send(port, bits[6], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 6) { RTS_data_bit_send(port, bits[5], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 5) { RTS_data_bit_send(port, bits[4], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 4) { RTS_data_bit_send(port, bits[3], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 3) { RTS_data_bit_send(port, bits[2], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 2) { RTS_data_bit_send(port, bits[1], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }

                        if (bits.Length >= 1) { RTS_data_bit_send(port, bits[0], databitdelay); }
                        else { RTS_data_bit_send(port, false, databitdelay); }
                        
                        RTS_Stop_bit_send(port, stopbitdelay);

                        /*

                        if (bits.Length >= 1) { RTS_data_bit_send(bits[0], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 2) { RTS_data_bit_send(bits[1], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 3) { RTS_data_bit_send(bits[2], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 4) { RTS_data_bit_send(bits[3], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 5) { RTS_data_bit_send(bits[4], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 6) { RTS_data_bit_send(bits[5], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 7) { RTS_data_bit_send(bits[6], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        if (bits.Length >= 8) { RTS_data_bit_send(bits[7], delay_110); }
                        else { RTS_data_bit_send(false, delay_110); }

                        */



                        //Calc c = new Calc();
                        //textBox13.Text = c.ConvertTestValue(bits[0], "1", "0");
                        //textBox15.Text = c.ConvertTestValue(bits[1], "1", "0");
                        //textBox19.Text = c.ConvertTestValue(bits[2], "1", "0");
                        //textBox20.Text = c.ConvertTestValue(bits[3], "1", "0");
                        //textBox81.Text = c.ConvertTestValue(bits[4], "1", "0");
                        //textBox87.Text = c.ConvertTestValue(bits[5], "1", "0");
                        //textBox88.Text = c.ConvertTestValue(bits[6], "1", "0");
                        //textBox92.Text = c.ConvertTestValue(bits[7], "1", "0");
                    }
                    else
                    {
                        MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);
                        return;
                    }
                }
        }





    }

}

