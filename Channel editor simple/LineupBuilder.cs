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
using FileIO;
using PrevueDataSender;
using SerialIO;
using NetworkIO;
using System.IO.Ports;
using System.Threading.Tasks;

namespace LineupBuilder
{ 
    public class Zap2ItLineup
    {
        public void ParseXMLforLineup(DataTable lineup)
        {
            lineup.Clear();
            XDocument lineupdata = XDocument.Load(PrevueDataSender.Properties.Settings.Default.FolderPath + @"\data.xml");
            foreach (XElement chan in lineupdata.Descendants("channel"))
            {
                string channumber = ""; //initialize channel number in case it does not exist
                string call_letters = ""; //initialize channel call letters in case they do not exist
                int index = 1; //initialize the index value for the array below

                string[] chid = chan.Attribute("id").Value.Split('.');

                string source = chid[1]; // first element is a source id value - up to 6 chars and will always exist
                foreach (XElement chanid in chan.Descendants())
                {  //loops through all of the values found in each source
                    switch (index)
                    {
                        case 2:    // 2nd element is the channel number on the lineup
                            channumber = chanid.Value;
                            break;
                        case 3:    // 3rd element is the call letters for the channel
                            call_letters = chanid.Value;
                            break;
                        default:  // default condition if index does not equal 2 or 3
                            break;
                    }
                    index++;
                }

                DataRow workRow;
                workRow = lineup.NewRow();
                workRow["SourceID"] = source;
                workRow["Number"] = channumber;
                workRow["ID"] = call_letters;
                workRow["RedHiLt"] = "0";
                workRow["SBS"] = "0";
                workRow["PTagDisable"] = "0";
                workRow["PPVSrc"] = "0";
                workRow["DittoEnable"] = "0";
                workRow["LtBlueHiLt"] = "0";
                workRow["StereoSrc"] = "1";
                workRow["Daypt1"] = 255;
                workRow["Daypt2"] = 255;
                workRow["Daypt3"] = 255;
                workRow["Daypt4"] = 255;
                workRow["Daypt5"] = 255;
                workRow["Daypt6"] = 255;
                lineup.Rows.Add(workRow);
            }
            DataRow lastRow;
            lastRow = lineup.NewRow();
            lastRow["SourceID"] = "COPYRT";
            lastRow["Number"] = "";
            lastRow["ID"] = "";
            lastRow["RedHiLt"] = "0";
            lastRow["SBS"] = "0";
            lastRow["PTagDisable"] = "0";
            lastRow["PPVSrc"] = "0";
            lastRow["DittoEnable"] = "1";
            lastRow["LtBlueHiLt"] = "0";
            lastRow["StereoSrc"] = "0";
            lastRow["Daypt1"] = 255;
            lastRow["Daypt2"] = 255;
            lastRow["Daypt3"] = 255;
            lastRow["Daypt4"] = 255;
            lastRow["Daypt5"] = 255;
            lastRow["Daypt6"] = 255;
            lineup.Rows.Add(lastRow);
        }
    }
    public class LineupBuild
    {
        public char[] empty = new char[] { };

        public void UpdateEntries(DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.UpdateRows(table_to_update);
            LineupFile lineupfile = new LineupFile();
            lineupfile.WriteLineupFile(table_to_update);
        }
        public void MoveEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.MoveRow(dgv, table_to_update, direction);
            LineupFile lineupfile = new LineupFile();
            lineupfile.WriteLineupFile(table_to_update);
        }
        public void InsertEntry(DataGridView dgv, DataTable table_to_update, string direction)
        {
            TableChange change = new TableChange();
            change.InsertRow(dgv, table_to_update, direction);
            LineupFile lineupfile = new LineupFile();
            lineupfile.WriteLineupFile(table_to_update);
        }
        public void DeleteSelectedEntries(DataGridView dgv, DataTable table_to_update)
        {
            TableChange change = new TableChange();
            change.DeleteSelectedRows(dgv, table_to_update);
            LineupFile lineupfile = new LineupFile();
            lineupfile.WriteLineupFile(table_to_update);
        }

        public void Import_Z2IData(DataGridView dgv, DataTable from_table, DataTable to_table)
        {
            TableChange change = new TableChange();
            change.ReplaceRowsFromTable(dgv, from_table, to_table);
            UpdateEntries(to_table);
        }

        public void SendLineup(SerialPort port, DataTable lineup, int jdate)
        {
            List<char> list = new List<char>();
            list.AddRange(Convert.ToChar(jdate).ToString());

            for (int counter = 0; counter < lineup.Rows.Count; counter++)
            {
                Calc c = new Calc();
                int attr = c.CalculateBitmaskValue("1",
                                                   lineup.Rows[counter]["RedHiLt"].ToString(),
                                                   lineup.Rows[counter]["SBS"].ToString(),
                                                   lineup.Rows[counter]["PTagDisable"].ToString(),
                                                   lineup.Rows[counter]["PPVSrc"].ToString(),
                                                   lineup.Rows[counter]["DittoEnable"].ToString(),
                                                   lineup.Rows[counter]["LtBlueHiLt"].ToString(),
                                                   lineup.Rows[counter]["StereoSrc"].ToString(), "1", "0");

                list.AddRange(Convert.ToChar(18).ToString());
                list.AddRange(Convert.ToChar(attr).ToString());
                list.AddRange(lineup.Rows[counter]["SourceID"].ToString());
                list.AddRange(Convert.ToChar(17).ToString());
                list.AddRange(lineup.Rows[counter]["Number"].ToString());
                list.AddRange(Convert.ToChar(20).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt1"]).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt2"]).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt3"]).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt4"]).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt5"]).ToString());
                list.AddRange(Convert.ToChar(lineup.Rows[counter]["Daypt6"]).ToString());
                list.AddRange(Convert.ToChar(1).ToString());
                list.AddRange(lineup.Rows[counter]["ID"].ToString());
            }
            char[] body = list.ToArray();

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                net.TransmitNetworkMessage("channel", body);
                net.TransmitNetworkMessage("box off", empty);
                //toolStripStatusLabel1.Text = "Current day channel lineup sent over TCP/IP";
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(port, "channel", body);
                s.TransmitMessage(port, "box off", empty);
                //toolStripStatusLabel1.Text = "Current day channel lineup sent over serial port";
            }
            else
            {
                //toolStripStatusLabel1.Text = "Error with Port Selected Setting - check code";
            }

        }
    
    }
    

}
