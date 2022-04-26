using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Net;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;
using DataFunctions;
using Calculator;
using Weather;
using FileIO;
using SerialIO;
using WindowsFormsApplication1;
using System.IO.Ports;

namespace NetworkIO
{
    class Network
    {
        public void TransmitNetworkMessage(string selectedmode, char[] messagebody)
        {
            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.

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
                TcpClient client = new TcpClient(PrevueDataSender.Properties.Settings.Default.IP_Address, Convert.ToInt32(PrevueDataSender.Properties.Settings.Default.Port_Number));
                NetworkStream stream = client.GetStream(); 
                stream.Write(messagetotransmit, 0, messagetotransmit.Length);
                
                SerialFile ser = new SerialFile();
                ser.WriteSerialLogFile(messagetotransmit);

                stream.Close();
                client.Close();
                }
                catch (ArgumentNullException e)
                    {
                        MessageBox.Show("Error sending data. Arg Null 2222 " + e, "Error", MessageBoxButtons.OK);
                        //Console.WriteLine("ArgumentNullException: {0}", e);
                    }
                catch (SocketException e)
                    {
                        MessageBox.Show("Error sending data. Socket 2222 " + e, "Error", MessageBoxButtons.OK);
                        //Console.WriteLine("SocketException: {0}", e);
                    }
                catch (IOException e)
                    { 

                    MessageBox.Show("Error sending data. Check net setting. " + e, "Error", MessageBoxButtons.OK);

                    }


            /*
                try
                {
           

        // Receive the TcpServer.response.

        // Buffer to store the response bytes.
        //data = new Byte[256];

        // String to store the response ASCII representation.
        //String responseData = String.Empty;

        // Read the first batch of the TcpServer response bytes.
        //Int32 bytes = stream.Read(data, 0, data.Length);
        //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        //Console.WriteLine("Received: {0}", responseData);

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Error sending data. Arg Null 3333" + e , "Error", MessageBoxButtons.OK);
                //Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                MessageBox.Show("Error sending data. Socket 3333" + e, "Error", MessageBoxButtons.OK);
                //Console.WriteLine("SocketException: {0}", e);
            }
            */
        }

    }
}
