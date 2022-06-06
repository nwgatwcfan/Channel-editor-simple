using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
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
using PrevueDataSender;

namespace FileIO
{
    public class UserDataFolder
    {
        public void Select_UserDataFolder(bool firstrun, FolderBrowserDialog folderselect)
        {
            if(firstrun == true)
            { 
                DialogResult result = folderselect.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // The user selects a folder and pressed the OK button.

                    PrevueDataSender.Properties.Settings.Default.FolderPath = folderselect.SelectedPath;
                    PrevueDataSender.Properties.Settings.Default.FirstRun = false;
                    PrevueDataSender.Properties.Settings.Default.Save();
                    MessageBox.Show("Selected folder:" + PrevueDataSender.Properties.Settings.Default.FolderPath, "Message");
                }
                else
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else 
            {
                DialogResult result = folderselect.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // The user selects a folder and pressed the OK button.

                    PrevueDataSender.Properties.Settings.Default.FolderPath = folderselect.SelectedPath;
                    PrevueDataSender.Properties.Settings.Default.FirstRun = false;
                    PrevueDataSender.Properties.Settings.Default.Save();
                    MessageBox.Show("Selected folder:" + PrevueDataSender.Properties.Settings.Default.FolderPath, "Message");
                }
                else{ }
            }
        }
    }
    class SerialFile 
    {
        public void WriteSerialLogFile(byte[] array)
        {
            string serial_log_filename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\serial_log.txt";
            byte[] read_data = new byte[] { };
            byte[] line_end = new byte[] { (byte)'\x0D', (byte)'\x0A' };
            try
            {
                StreamReader serlogfile = new StreamReader(serial_log_filename);
                {
                    read_data = File.ReadAllBytes(serial_log_filename);
                    serlogfile.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                FileStream writeStream = new FileStream(serial_log_filename, FileMode.Create);

                BinaryWriter writeData = new BinaryWriter(writeStream);
                writeData.Write(read_data);
                writeData.Write(line_end);
                writeData.Write(array);
                writeData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void ClearSerialLogFile()
        {
            string serial_log_filename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\serial_log.txt";
            try
            {
                FileStream writeStream = new FileStream(serial_log_filename, FileMode.Create);

                BinaryWriter writeData = new BinaryWriter(writeStream);
                writeData.Write(String.Empty);
                writeData.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
}
public class Zap2ItXMLFile
    {
        public void DownloadZap2ItXMLInfo()
        {
            /// This function opens the Zap2XML Program that is stored in the program's folder and
            /// and allows the program to run in a hidden window in the background
            /// This uses a Process to open the program up and the data for the username,
            /// password, and number of days to pull are User defined settings and stored in the
            /// Properties.Settings.Default
            
            string folderpath = PrevueDataSender.Properties.Settings.Default.FolderPath;
            string numofdays = PrevueDataSender.Properties.Settings.Default.DlNumberOfDays;
            string username = @PrevueDataSender.Properties.Settings.Default.DlUsername;
            string password = @PrevueDataSender.Properties.Settings.Default.DlPassword;
                
            Process OpenZap2XMLProgram = new Process();
            //PrevueDataSender.Form1.toolStripStatusLabel1.Text = "Zap2Xml Information downloading. Please wait...";
            OpenZap2XMLProgram.StartInfo.FileName = folderpath + @"\zap2xml.exe";
            OpenZap2XMLProgram.StartInfo.Arguments = @"-d " + numofdays +
                " -u " + @username +
                " -p " + @password +
                " -o " + folderpath + @"\data.xml"; //argument
            OpenZap2XMLProgram.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            OpenZap2XMLProgram.Start();
            OpenZap2XMLProgram.WaitForExit();

        }

    }

    class LineupFile 
    {
        public void ReadLineupFile(DataTable lineup)
        {
            string data;
            string lineupfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\Channel Lineup.txt";

            if (File.Exists(lineupfilename))
            {
                StreamReader lineupfile = new StreamReader(lineupfilename);

                while ((data = lineupfile.ReadLine()) != null)
                {
                    char[] delimiterChars = { '\x00' };
                    string text = data;
                    string[] parseinfo = text.Split(delimiterChars);

                    DataRow workRow;
                    workRow = lineup.NewRow();
                    workRow["SourceID"] = parseinfo[0];
                    workRow["Number"] = parseinfo[1];
                    workRow["ID"] = parseinfo[2];
                    workRow["RedHiLt"] = parseinfo[3];
                    workRow["SBS"] = parseinfo[4];
                    workRow["PTagDisable"] = parseinfo[5];
                    workRow["PPVSrc"] = parseinfo[6];
                    workRow["DittoEnable"] = parseinfo[7];
                    workRow["LtBlueHiLt"] = parseinfo[8];
                    workRow["StereoSrc"] = parseinfo[9];
                    workRow["Daypt1"] = Int32.Parse(parseinfo[10]);
                    workRow["Daypt2"] = Int32.Parse(parseinfo[11]);
                    workRow["Daypt3"] = Int32.Parse(parseinfo[12]);
                    workRow["Daypt4"] = Int32.Parse(parseinfo[13]);
                    workRow["Daypt5"] = Int32.Parse(parseinfo[14]);
                    workRow["Daypt6"] = Int32.Parse(parseinfo[15]);

                    lineup.Rows.Add(workRow);

                    //toolStripStatusLabel1.Text = "File Uploading";
                }
                lineupfile.Close();
                //toolStripStatusLabel1.Text = "File Reading Completed: " + lineup.Rows.Count + " channels found";
            }

            else
            {
                // Create the file.
                File.Create(lineupfilename);
            }
        }

        public void WriteLineupFile(DataTable lineup)
        {
            string lineupfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\Channel Lineup.txt";
            try
            {
                if (File.Exists(lineupfilename))
                {
                    StreamWriter lineupfile = new StreamWriter(lineupfilename);

                    for (int i = 0; i < lineup.Rows.Count; i++)
                    {
                        lineupfile.WriteLine(lineup.Rows[i]["SourceID"] + "\x00" +
                                             lineup.Rows[i]["Number"] + "\x00" +
                                             lineup.Rows[i]["ID"] + "\x00" +
                                             lineup.Rows[i]["RedHiLt"] + "\x00" +
                                             lineup.Rows[i]["SBS"] + "\x00" +
                                             lineup.Rows[i]["PTagDisable"] + "\x00" +
                                             lineup.Rows[i]["PPVSrc"] + "\x00" +
                                             lineup.Rows[i]["DittoEnable"] + "\x00" +
                                             lineup.Rows[i]["LtBlueHiLt"] + "\x00" +
                                             lineup.Rows[i]["StereoSrc"] + "\x00" +
                                             lineup.Rows[i]["Daypt1"] + "\x00" +
                                             lineup.Rows[i]["Daypt2"] + "\x00" +
                                             lineup.Rows[i]["Daypt3"] + "\x00" +
                                             lineup.Rows[i]["Daypt4"] + "\x00" +
                                             lineup.Rows[i]["Daypt5"] + "\x00" +
                                             lineup.Rows[i]["Daypt6"]);

                        //toolStripStatusLabel1.Text = "File Saving:" + lineup.Rows.Count + " channels saved";
                    }

                    lineupfile.Close();
                    //toolStripStatusLabel1.Text = "File Save Completed: " + lineup.Rows.Count + " channels saved";
                }
                else
                {
                    // Create the file.
                    File.Create(lineupfilename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save channel lineup", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

    }
    class ListingsFile
    {
        public void WriteListingsFile(DataTable listing)
        {
            string listingsfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\Listings.txt";
            try
            {
                if (File.Exists(listingsfilename))
                {
                    StreamWriter listingsfile = new StreamWriter(listingsfilename);

                    for (int i = 0; i < listing.Rows.Count; i++)
                    {
                        listingsfile.WriteLine(listing.Rows[i]["JulianDay"] + "\x00" +
                                               listing.Rows[i]["SourceID"] + "\x00" +
                                               listing.Rows[i]["TimeSlot"] + "\x00" +
                                               listing.Rows[i]["Title"] + "\x00" +
                                               listing.Rows[i]["Attr"]);

                        //f.toolStripStatusLabel1.Text = "File Saving:" + listing.Rows.Count + " listings saved";
                    }

                    listingsfile.Close();
                    //f.toolStripStatusLabel1.Text = "File Save Completed: " + listing.Rows.Count + " listings saved";
                }
                else
                {
                    // Create the file.
                    File.Create(listingsfilename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save listings data", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        public void ReadListingsFile(DataTable listing)
        {
            string listingsfilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\Listings.txt";
            string data;
            try
            {
                if (File.Exists(listingsfilename))
                {
                    StreamReader listingsfile = new StreamReader(listingsfilename);

                    while ((data = listingsfile.ReadLine()) != null)
                    {
                        char[] delimiterChars = { '\x00' };
                        string text = data;
                        string[] parseinfo = text.Split(delimiterChars);

                        DataRow workRow;
                        workRow = listing.NewRow();
                        workRow["JulianDay"] = Int32.Parse(parseinfo[0]);
                        workRow["SourceID"] = parseinfo[1];
                        workRow["TimeSlot"] = Int32.Parse(parseinfo[2]);
                        workRow["Attr"] = Int32.Parse(parseinfo[4]);
                        workRow["Title"] = parseinfo[3];
                        listing.Rows.Add(workRow);

                        //f.toolStripStatusLabel1.Text = "File Uploading" + listing.Rows.Count + " listings found";

                    }

                    listingsfile.Close();
                    //f.toolStripStatusLabel1.Text = "File Reading Completed: " + listing.Rows.Count + " listings found";
                }
                else
                {
                    // Create the file.
                    File.Create(listingsfilename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save listings data", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }

    

    class QTableFile
    {
        public void ReadQTableFile(DataTable QTable)
        {
            string data;
            string QTablefilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\qtable.txt";

            if (File.Exists(QTablefilename))
            {
                StreamReader QTablefile = new StreamReader(QTablefilename);
                //DataTable QTable = QTableDataSet.Tables["QTable"];

                while ((data = QTablefile.ReadLine()) != null)
                {
                    char[] delimiterChars = { '\x09' };
                    string text = data;
                    string[] parseinfo = text.Split(delimiterChars);

                    DataRow workRow;
                    workRow = QTable.NewRow();
                    workRow["QTSource"] = parseinfo[0];
                    workRow["QTName"] = parseinfo[1];

                    QTable.Rows.Add(workRow);

                    //toolStripStatusLabel1.Text = "File Uploading";
                }
                QTablefile.Close();
                //toolStripStatusLabel1.Text = "File Reading Completed: " + QTable.Rows.Count + " channels found";
            }

            else
            {
                // Create the file.
                File.Create(QTablefilename);
            }
        }

        public void WriteQTableFile(DataTable QTable)
        {
            string QTablefilename = PrevueDataSender.Properties.Settings.Default.FolderPath + @"\qtable.txt";
            try
            {
                if (File.Exists(QTablefilename))
                {
                    StreamWriter QTablefile = new StreamWriter(QTablefilename);
                    for (int i = 0; i < QTable.Rows.Count; i++)
                    {
                        QTablefile.WriteLine(QTable.Rows[i]["QTSource"] + "\x09" +
                                             QTable.Rows[i]["QTName"]);
                        //toolStripStatusLabel1.Text = "File Saving:" + QTable.Rows.Count + " channels saved";
                    }

                    QTablefile.Close();
                    //toolStripStatusLabel1.Text = "File Save Completed: " + QTable.Rows.Count + " channels saved";
                }
                else
                {
                    // Create the file.
                    File.Create(QTablefilename);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save Q Table", "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

    }

}