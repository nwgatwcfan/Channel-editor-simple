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
using System.Linq;
using System.Xml.Linq;
using DataFunctions;
using Calculator;
using Weather;
using FileIO;
using PrevueDataSender;
using System.IO.Ports;
using NetworkIO;
using SerialIO;


namespace LocalAds
{
    public class LocalAd
    {
        public char[] empty = new char[] { };

        public void LocalAdLineActive_SetCheckBox(int selection, CheckBox chkbx, RadioButton rb1, RadioButton rb2, RadioButton rb3, System.Windows.Forms.TextBox txtbx)
        {
            if (selection == 1)
            {
                chkbx.Checked = true;
                rb1.Enabled = true;
                rb2.Enabled = true;
                rb3.Enabled = true;
                txtbx.Enabled = true;
            }
            else
            {
                chkbx.Checked = false;
                rb1.Enabled = false;
                rb2.Enabled = false;
                rb3.Enabled = false;
                txtbx.Enabled = false;
            }
        }

        public int LocalAdLineActive_GetCheckBox(CheckBox chkbx)
        {
            int selection;
            if (chkbx.Checked == true)
            { selection = 1; return selection; }
            else
            { selection = 0; return selection; }
        }

        public void LocalAdJustify_SetRadioButtons(int selection, RadioButton rb1)
        {
            if (selection == 1) { rb1.Checked = true; }
            else { rb1.Checked = false; }
        }

        public int LocalAdJustify_GetRadioButtons(RadioButton rb1)
        {
            int selection;
            if (rb1.Checked == true) { selection = 1; return selection; }
            else { selection = 0; return selection; }
        }

        public void LocalAdAdd(DataTable adinfo, int adnbr, int ln_nbr, CheckBox ln_actv, RadioButton lnLft, RadioButton lnCtr, RadioButton lnRgt, string msg)
        {
            DataRow line = adinfo.NewRow();
            line["AdNumber"] = adnbr;
            line["LineNumber"] = ln_nbr;
            line["LineActive"] = LocalAdLineActive_GetCheckBox(ln_actv);
            line["LineLeft"] = LocalAdJustify_GetRadioButtons(lnLft); ;
            line["LineCenter"] = LocalAdJustify_GetRadioButtons(lnCtr); ;
            line["LineRight"] = LocalAdJustify_GetRadioButtons(lnRgt); ;
            line["LineMessage"] = msg;
            adinfo.Rows.Add(line);
            adinfo.AcceptChanges();
        }

        public void LocalAdDelete(DataTable adinfo, int adnumberselected)
        {
            for (int i = adinfo.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = adinfo.Rows[i];
                if (Convert.ToInt32(dr["AdNumber"]) == Convert.ToInt32(adnumberselected))
                {
                    dr.Delete();
                }
            }
            adinfo.AcceptChanges();
        }

        public string SendLocalAds(SerialPort port, DataTable localads, int adnumber)
        {
            List<char> list = new List<char>();
            list.AddRange(Convert.ToChar(adnumber).ToString());

            for (int i = 0; i <= localads.Rows.Count - 1; i++)
            {
                int justify;

                DataRow ad = localads.Rows[i];
                if (Convert.ToInt32(ad["AdNumber"]) == Convert.ToInt32(adnumber))
                {
                    if (Convert.ToInt32(ad["LineNumber"]) == 1)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 2)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 3)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 4)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 5)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 6)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 7)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                    if (Convert.ToInt32(ad["LineNumber"]) == 8)
                    {
                        if (Convert.ToInt32(ad["LineActive"]) == 1)
                        {
                            if (Convert.ToInt32(ad["LineLeft"]) == 1)
                            { justify = 25; }
                            else if (Convert.ToInt32(ad["LineCenter"]) == 1)
                            { justify = 24; }
                            else if (Convert.ToInt32(ad["LineRight"]) == 1)
                            { justify = 26; }
                            else { justify = 24; }

                            list.AddRange(Convert.ToChar(justify).ToString());
                            list.AddRange(ad["LineMessage"].ToString());
                        }
                    }
                }
            }

            char[] messagetosend = list.ToArray();

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                net.TransmitNetworkMessage("local ad", messagetosend);
                net.TransmitNetworkMessage("box off", empty);
                return "EPG Local ad information sent via TCP/IP";
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(port, "local ad", messagetosend);
                s.TransmitMessage(port, "box off", empty);
                return "EPG Local ad information sent via serial.";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        public string SendResetLocalAds(SerialPort port)
        {
            string reset_ads_command = "\x92";
            char[] messagetosend = reset_ads_command.ToArray();

            if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                net.TransmitNetworkMessage("local ad", messagetosend);
                net.TransmitNetworkMessage("box off", empty);
                return "EPG Local ad information sent via TCP/IP";
            }
            else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(port, "local ad", messagetosend);
                s.TransmitMessage(port, "box off", empty);
                return "EPG Local ad information sent via serial.";
            }
            else
            {
                return "Error with Port Selected Setting - check code";
            }
        }

        /*
       public string SendLocalCrawlAd(SerialPort port, string crawlad, int adnumber)
       {
           List<char> list = new List<char>();
           list.AddRange(Convert.ToChar(adnumber).ToString());
           int justify = 11;
           list.AddRange(Convert.ToChar(justify).ToString());
           list.AddRange(crawlad);
           char[] messagetosend = list.ToArray();

           if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'T')
           {
               Network net = new Network();
               net.TransmitNetworkMessage("box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
               net.TransmitNetworkMessage("local ad", messagetosend);
               net.TransmitNetworkMessage("box off", empty);
               return "EPG Local Crawl ad sent via TCP/IP";
           }
           else if (PrevueDataSender.Properties.Settings.Default.Port_Selected == 'S')
           {
               Serial s = new Serial();
               s.TransmitMessage(port, "box on", PrevueDataSender.Properties.Settings.Default.Select_Code.ToCharArray());
               s.TransmitMessage(port, "local ad", messagetosend);
               s.TransmitMessage(port, "box off", empty);
               return "EPG Local Crawl ad sent via serial.";
           }
           else
           {
               return "Error with Port Selected Setting - check code";
           }
       }*/
    }
}
