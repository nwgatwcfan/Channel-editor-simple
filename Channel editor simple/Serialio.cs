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

namespace SerialIO

{
    public class Serial
    {
       
        public void InitializeSerialPort(SerialPort port, string portselection) 
        {
            try
            {
                port.PortName = portselection;
                //port.DiscardInBuffer();
                port.Close();
                port.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void DiscardInBuffer()
        {
            Form1 f = new Form1();
            try
            {
                f.serialPort1.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw new InvalidOperationException(CommPhrases.ClearDataStreamError + ": " + ex.Message, ex);
            }
        }
        
        
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

        /*
        public void TransmitMessage(SerialPort port, string selectedmode, char[] messagebody)
        {        
            char[] header = new char[] { '\x55', '\xAA' };
            char[] endcommand = new char[] { '\x00' };

            ConvertArray array = new ConvertArray();

            ModeSelect m = new ModeSelect();
            List<char> list = new List<char>();
            list.AddRange(header);
            list.AddRange(m.Get_Mode_Select(selectedmode));
            list.AddRange(messagebody);
            list.AddRange(endcommand);

            char[] messagebuilder = list.ToArray();
            //UTF8Encoding ascii = new UTF8Encoding();
            UnicodeEncoding ascii = new UnicodeEncoding();
            byte[] messagebuild = messagebuilder.GetBytes();
            byte[] checksum = new byte[] { (byte)array.XORByteArrayFunction(messagebuild) };
            
            List<byte> messagetosend = new List<byte>();
            messagetosend.AddRange(messagebuild);
            messagetosend.AddRange(checksum);
            
            byte[] messagetotransmit = messagetosend.ToArray();
            string test = BitConverter.ToString(messagetotransmit);
            try
            {
                if (selectedmode == "box off")
                {
                    port.Write(messagetotransmit, 0, messagetotransmit.Length);
                    SerialFile ser = new SerialFile();
                    ser.WriteSerialLogFile(messagetotransmit);
                    ser.WriteSerialLogFile(test);
                    port.Close();
                }
                else
                {
                    if (port.IsOpen)
                    {
                        port.Write(messagetotransmit, 0, messagetotransmit.Length);
                        SerialFile ser = new SerialFile();
                        ser.WriteSerialLogFile(messagetotransmit);
                        ser.WriteSerialLogFile(test);
                    }
                    else 
                    {
                    port.Open();
                    port.Write(messagetotransmit, 0, messagetotransmit.Length);
                    SerialFile ser = new SerialFile();
                    ser.WriteSerialLogFile(messagetotransmit);
                    ser.WriteSerialLogFile(test);
                    }
                }
            }
            catch
            {

                MessageBox.Show("Error sending data. Check serial port setting.", "Error", MessageBoxButtons.OK);

            }
        } */
        
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









    }

}

