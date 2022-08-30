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
using SerialIO;
using WindowsFormsApplication1;
using NetworkIO;
using System.IO.Ports;

namespace ListingsBuilder
{
    public class Zap2ItListings
    {
        public List<string> jdates = new List<string>();
        public void ParseXMLforListings(DataTable listings)
        {
            listings.Clear();

            XDocument listingsdata = XDocument.Load(PrevueDataSender.Properties.Settings.Default.FolderPath + @"\data.xml");
            foreach (XElement prog in listingsdata.Descendants("programme"))
            {
                XMLParseData xml = new XMLParseData();
                Calc calc = new Calc();

                string[] chanid = prog.Attribute("channel").Value.Split('.');
                string chid = chanid[1];

                int starthr = Convert.ToInt16(prog.Attribute("start").Value.Substring(8, 2));
                int startmin = Convert.ToInt16(prog.Attribute("start").Value.Substring(10, 2));
                string progstart = xml.FormatStartTime(starthr, startmin);
                string progts = calc.CalcTimeSlot(starthr, startmin,
                                   PrevueDataSender.Properties.Settings.Default.TimeZoneOffset).ToString();


                string proglistdate = prog.Attribute("start").Value.Substring(0, 8);
                int year = Convert.ToInt16(proglistdate.Substring(0, 4));
                int month = Convert.ToInt16(proglistdate.Substring(4, 2));
                int day = Convert.ToInt16(proglistdate.Substring(6, 2));
                string progjdate = calc.CalcOrdinalDate(year, month, day, starthr, startmin,
                                         PrevueDataSender.Properties.Settings.Default.TimeZoneOffset).ToString();

                if (!jdates.Contains(progjdate)) 
                {
                    jdates.Add(progjdate);
                }

                int length = Convert.ToInt16(prog.Element("length").Value);
                string proglength = xml.FormatLength(length);


                string progcategory = xml.ChildNodeValue(prog, "category");
                
                string progattr = xml.GetCategoryValue(xml.ChildNodeValue(prog, "category")).ToString();

                string progsubtitle = xml.ChildNodeValue(prog, "sub-title");

                string progdesc = xml.ChildNodeValue(prog, "desc");

                string prograting = xml.FormatRating(xml.ChildNodeValue(prog, "rating"));
                string progcc = xml.FormatCC(xml.ChildNodeAttrValue(prog, "subtitles", "type"));
                string progdate = xml.ChildNodeValue(prog, "date");

                string progtitle = xml.FormatTitle(progcategory, progstart, prograting, prog.Element("title").Value, progdate,
                          progsubtitle, progdesc, progcc, proglength);
              
 

                DataRow workRow;
                workRow = listings.NewRow();
                workRow["SourceID"] = chid;
                workRow["JulianDay"] = progjdate;
                workRow["TimeSlot"] = progts;
                workRow["Title"] = progtitle;
                workRow["Attr"] =  progattr;
                workRow["Subtitle"] = progsubtitle;
                workRow["Description"] = progdesc;
                listings.Rows.Add(workRow);

            }

            foreach (string jdate in jdates) 
            {
                for (int ts = 1; ts < 49; ts++)
                {
                    if (ts % 2 == 1)
                    {
                        DataRow CopyrightMessageRow1;
                        CopyrightMessageRow1 = listings.NewRow();
                        CopyrightMessageRow1["SourceID"] = "COPYRT";
                        CopyrightMessageRow1["JulianDay"] = jdate;
                        CopyrightMessageRow1["TimeSlot"] = ts;
                        CopyrightMessageRow1["Title"] = PrevueDataSender.Properties.Settings.Default.CustomListing1;
                        CopyrightMessageRow1["Attr"] = "1";
                        CopyrightMessageRow1["Subtitle"] = "";
                        CopyrightMessageRow1["Description"] = "";
                        listings.Rows.Add(CopyrightMessageRow1);
                    }
                    else 
                    {
                        DataRow CopyrightMessageRow2;
                        CopyrightMessageRow2 = listings.NewRow();
                        CopyrightMessageRow2["SourceID"] = "COPYRT";
                        CopyrightMessageRow2["JulianDay"] = jdate;
                        CopyrightMessageRow2["TimeSlot"] = ts;
                        CopyrightMessageRow2["Title"] = PrevueDataSender.Properties.Settings.Default.CustomListing2;
                        CopyrightMessageRow2["Attr"] = "1";
                        CopyrightMessageRow2["Subtitle"] = "";
                        CopyrightMessageRow2["Description"] = "";
                        listings.Rows.Add(CopyrightMessageRow2);
                    }
                }
            }
        }
    }
    
    public class ListingsBuild
    {
        public char[] empty = new char[] { };

        public void UpdateEntries(DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.UpdateRows(table_to_update);
            ListingsFile list = new ListingsFile();
            list.WriteListingsFile(table_to_update);
        }
        public void UpdateScrollMsgEntries(DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.UpdateRows(table_to_update);
            ListingsFile list = new ListingsFile();
            list.WriteScrollMessagesFile(table_to_update);
        }
        public void MoveEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.MoveRow(dgv, table_to_update, direction);
            ListingsFile list = new ListingsFile();
            list.WriteListingsFile(table_to_update);
        }
        public void MoveScrollMsgEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.MoveRow(dgv, table_to_update, direction);
            ListingsFile list = new ListingsFile();
            list.WriteScrollMessagesFile(table_to_update);
        }
        public void InsertEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.InsertRow(dgv, table_to_update, direction);
            ListingsFile list = new ListingsFile();
            list.WriteListingsFile(table_to_update);
        }
        public void InsertScrollMsgEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.InsertRow(dgv, table_to_update, direction);
            ListingsFile list = new ListingsFile();
            list.WriteScrollMessagesFile(table_to_update);
        }
        public void DeleteSelectedEntries(DataGridView dgv, DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.DeleteSelectedRows(dgv, table_to_update);
            ListingsFile list = new ListingsFile();
            list.WriteListingsFile(table_to_update);
        }

        public void DeleteSelectedScrollMsgEntries(DataGridView dgv, DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.DeleteSelectedRows(dgv, table_to_update);
            ListingsFile list = new ListingsFile();
            list.WriteScrollMessagesFile(table_to_update);
        }

        public void Import_Z2IData(DataGridView dgv, DataTable from_table, DataTable to_table)
        {
            TableChange change = new TableChange();
            change.ReplaceListingsRows(dgv, from_table, to_table);
        }

        public string SendListings(SerialPort port, DataGridView dgv, DataTable listings, int jdate)
        {
            string message;

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Convert.ToInt32(listings.Rows[row.Index]["JulianDay"]) == jdate)
                    {
                        List<char> list = new List<char>();
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                        list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                        list.AddRange(Convert.ToChar(18).ToString());
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                        list.AddRange(listings.Rows[row.Index]["Title"].ToString());

                        char[] body = list.ToArray();

                        net.TransmitNetworkMessage("listing", body);
                    }
                }

                net.TransmitNetworkMessage("box off", empty);
                message = "Selected listings have been sent via TCP/IP.";
                return message;
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (Convert.ToInt32(listings.Rows[row.Index]["JulianDay"]) == jdate)
                    {
                        List<char> list = new List<char>();
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                        list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                        list.AddRange(Convert.ToChar(18).ToString());
                        list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                        list.AddRange(listings.Rows[row.Index]["Title"].ToString());

                        char[] body = list.ToArray();
                        s.TransmitMessage(port, "listing", body);
                    }
                }
                s.TransmitMessage(port, "box off", empty);
                message = "Selected listings have been sent via serial.";
                return message;
            }
            else
            {
                message = "Error with Port Selected Setting - check code";
                return message;
            }
        }

        public string SendScrollMessages(SerialPort port, DataGridView dgv, DataTable scrollmsgs, int jdate)
        {
            string message;

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    List<char> list = new List<char>();
                    list.AddRange(Convert.ToChar(1).ToString());
                    list.AddRange(Convert.ToChar(jdate).ToString());
                    list.AddRange(scrollmsgs.Rows[row.Index]["SourceID"].ToString());
                    list.AddRange(Convert.ToChar(18).ToString());
                    list.AddRange(Convert.ToChar(scrollmsgs.Rows[row.Index]["Attr"]).ToString());
                    list.AddRange(scrollmsgs.Rows[row.Index]["Message"].ToString());

                    char[] body = list.ToArray();

                    net.TransmitNetworkMessage("listing", body);
                }

                net.TransmitNetworkMessage("box off", empty);
                message = "Selected messages have been sent via TCP/IP.";
                return message;
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                foreach (DataGridViewRow row in dgv.Rows)
                {
                        List<char> list = new List<char>();
                        list.AddRange(Convert.ToChar(1).ToString());
                        list.AddRange(Convert.ToChar(jdate).ToString());
                        list.AddRange(scrollmsgs.Rows[row.Index]["SourceID"].ToString());
                        list.AddRange(Convert.ToChar(18).ToString());
                        list.AddRange(Convert.ToChar(scrollmsgs.Rows[row.Index]["Attr"]).ToString());
                        list.AddRange(scrollmsgs.Rows[row.Index]["Message"].ToString());

                        char[] body = list.ToArray();
                        s.TransmitMessage(port, "listing", body);
                }
                s.TransmitMessage(port, "box off", empty);
                message = "Selected listings have been sent via serial.";
                return message;
            }
            else
            {
                message = "Error with Port Selected Setting - check code";
                return message;
            }
        }

        public string SendSelectedListings(SerialPort port, DataGridView dgv, DataTable listings)
        {
            string message;

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    List<char> list = new List<char>();
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                    list.AddRange(Convert.ToChar(18).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["Title"].ToString());
                    char[] body = list.ToArray();
                    net.TransmitNetworkMessage("listing", body);
                }
                net.TransmitNetworkMessage("box off", empty);
                message = "Selected listings have been sent via TCP/IP.";
                return message;
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    List<char> list = new List<char>();
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                    list.AddRange(Convert.ToChar(18).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["Title"].ToString());
                    char[] body = list.ToArray();
                    s.TransmitMessage(port, "listing", body);
                }
                s.TransmitMessage(port, "box off", empty);
                message = "Selected listings have been sent via serial.";
                return message;
            }
            else
            {
                message = "Error with Port Selected Setting - check code";
                return message;
            }
        }

        public string SendSelectedScrollMessages(SerialPort port, DataGridView dgv, DataTable listings)
        {
            string message;

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());

                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    List<char> list = new List<char>();
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                    list.AddRange(Convert.ToChar(18).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["Title"].ToString());
                    char[] body = list.ToArray();
                    net.TransmitNetworkMessage("listing", body);
                }
                net.TransmitNetworkMessage("box off", empty);
                message = "Selected listings have been sent via TCP/IP.";
                return message;
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                foreach (DataGridViewRow row in dgv.SelectedRows)
                {
                    List<char> list = new List<char>();
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Timeslot"]).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["JulianDay"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["SourceID"].ToString());
                    list.AddRange(Convert.ToChar(18).ToString());
                    list.AddRange(Convert.ToChar(listings.Rows[row.Index]["Attr"]).ToString());
                    list.AddRange(listings.Rows[row.Index]["Title"].ToString());
                    char[] body = list.ToArray();
                    s.TransmitMessage(port, "listing", body);
                }
                s.TransmitMessage(port, "box off", empty);
                message = "Selected listings have been sent via serial.";
                return message;
            }
            else
            {
                message = "Error with Port Selected Setting - check code";
                return message;
            }
        }

    }
    
}
