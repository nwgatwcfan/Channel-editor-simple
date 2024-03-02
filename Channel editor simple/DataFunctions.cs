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
using System.Collections;
using ColorSettings = PrevueDataSender.ListingColor;
using TextSettings = PrevueDataSender.ListingText;

namespace DataFunctions
{
    public class TableChange
    {
        private DataRow GetDefaultRow(DataTable table) 
        {
            if (table.TableName == "Lineup")   
            {
                DataRow defaultrow = table.NewRow();
                defaultrow["SourceID"] = "new";
                defaultrow["Number"] = "";
                defaultrow["ID"] = "";
                defaultrow["RedHiLt"] = "";
                defaultrow["SBS"] = "";
                defaultrow["PTagDisable"] = "";
                defaultrow["PPVSrc"] = "";
                defaultrow["DittoEnable"] = "";
                defaultrow["LtBlueHiLt"] = "";
                defaultrow["StereoSrc"] = "";
                defaultrow["Daypt1"] = 255;
                defaultrow["Daypt2"] = 255;
                defaultrow["Daypt3"] = 255;
                defaultrow["Daypt4"] = 255;
                defaultrow["Daypt5"] = 255;
                defaultrow["Daypt6"] = 255;
                return defaultrow;
            }
            else if (table.TableName == "Listings")
            {
                DataRow defaultrow = table.NewRow();
                defaultrow["JulianDay"] = 0;
                defaultrow["SourceID"] = "new";
                defaultrow["TimeSlot"] = 1;
                defaultrow["Attr"] = 1;
                defaultrow["Title"] = "title";
                return defaultrow;
            }
            else
            {
                DataRow defaultrow = table.NewRow();
                return defaultrow;
            }
        }
        public void InsertRow(DataGridView dgv, DataTable table, string direction)
        {
            try
            {
                int index = dgv.CurrentCell.RowIndex;
                DataRow RowToInsert = GetDefaultRow(table);
                if (direction == "below")
                {
                    int InsertAtIndex = index + 1;
                    table.Rows.InsertAt(RowToInsert, InsertAtIndex);
                    UpdateRows(table);
                    dgv.Rows[InsertAtIndex].Selected = true;
                    dgv.CurrentCell = dgv.Rows[InsertAtIndex].Cells[0];
                }

                if (direction == "above")
                {
                    int InsertAtIndex = index;
                    table.Rows.InsertAt(RowToInsert, InsertAtIndex);
                    UpdateRows(table);
                    dgv.Rows[InsertAtIndex].Selected = true;
                    dgv.CurrentCell = dgv.Rows[InsertAtIndex].Cells[0];
                }
            }
            catch { }
        }
        public void UpdateRows(DataTable table)
        {
            try { table.AcceptChanges(); }
            catch { }
        }
        public void MoveRow(DataGridView dgv, DataTable table, string direction)
        {
            try
            {
                int rowIndex = dgv.SelectedCells[0].OwningRow.Index;

                DataRow oldRow = table.Rows[rowIndex];
                DataRow newRow = table.NewRow();

                newRow.ItemArray = oldRow.ItemArray;

                int oldRowIndex = table.Rows.IndexOf(oldRow);

                if (direction == "down")
                {
                    int newRowIndex = oldRowIndex + 1;
                    if (oldRowIndex < (table.Rows.Count))
                    {
                        table.Rows.Remove(oldRow);
                        table.Rows.InsertAt(newRow, newRowIndex);
                        UpdateRows(table);
                        dgv.Rows[newRowIndex].Selected = true;
                        dgv.CurrentCell = dgv.Rows[newRowIndex].Cells[0];
                    }
                }

                if (direction == "up")
                {
                    int newRowIndex = oldRowIndex - 1;
                    if (oldRowIndex > 0)
                    {
                        table.Rows.Remove(oldRow);
                        table.Rows.InsertAt(newRow, newRowIndex);
                        UpdateRows(table);
                        dgv.Rows[newRowIndex].Selected = true;
                        dgv.CurrentCell = dgv.Rows[newRowIndex].Cells[0];
                    }
                }
            }
            catch { }
        }
        public void DeleteSelectedRows(DataGridView dgv, DataTable table)
        {
            if (MessageBox.Show("Would you like to delete the selected entries?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow item in dgv.SelectedRows)
                    {
                        dgv.Rows.RemoveAt(item.Index);
                    }
                    UpdateRows(table);
                }
                catch { }
            }
        }
        public void ReplaceRowsFromTable(DataGridView dgv, DataTable FromTable, DataTable ToTable)
        {
            if (MessageBox.Show("Would you like replace data in table?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ToTable.Clear();
                    PrevueDataSender.Form2 display = new PrevueDataSender.Form2();
                    display.Show();
                    foreach (DataRow readRow in FromTable.Rows)
                    {
                        display.ProgressBarBuild(ToTable.Rows.Count, 0, FromTable.Rows.Count);
                        DataRow writeRow = ToTable.NewRow();
                        writeRow.ItemArray = readRow.ItemArray;                     
                        ToTable.Rows.Add(writeRow);
                        dgv.Update();
                    }
                    display.Close();
                    dgv.Refresh();
                }
                catch { }
            }
        }

        public void ReplaceListingsRows(DataGridView dgv, DataTable FromTable, DataTable ToTable)
        {
            if (MessageBox.Show("Would you like replace data in table?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ToTable.Clear();
                    PrevueDataSender.Form2 display = new PrevueDataSender.Form2();
                    display.Show();
                    foreach (DataRow readRow in FromTable.Rows)
                    {
                        display.ProgressBarBuild(ToTable.Rows.Count, 0, FromTable.Rows.Count);
                        DataRow writeRow = ToTable.NewRow();
                        writeRow["JulianDay"] = readRow["JulianDay"];
                        writeRow["SourceID"] = readRow["SourceID"];
                        writeRow["TimeSlot"] = readRow["TimeSlot"];
                        writeRow["Attr"] = readRow["Attr"];
                        writeRow["Title"] = readRow["Title"];
                        //writeRow.ItemArray = readRow.ItemArray;
                        ToTable.Rows.Add(writeRow);
                        
                    }
                    display.Close();
                    dgv.Update();
                    dgv.Refresh();
                }
                catch { }
            }
        }

    }
    public class ModeSelect
    {
        public char[] Get_Mode_Select(string selection)
        {
            char[] modeselected;
            switch (selection)
            {
                case "box off":
                    modeselected = new char[] { '\u00bb', '\u00bb' };
                    return modeselected;
                case "box on":
                    modeselected = new char[] { 'A' };
                    return modeselected;
                case "listing":
                    modeselected = new char[] { 'P' };
                    return modeselected;
                case "new listing":
                    modeselected = new char[] { 'p' };
                    return modeselected;
                case "clock":
                    modeselected = new char[] { 'K' };
                    return modeselected;
                case "DST":
                    modeselected = new char[] { 'g' };
                    return modeselected;
                case "channel":
                    modeselected = new char[] { 'C' };
                    return modeselected;
                case "chan attr":
                    modeselected = new char[] { 'c' };
                    return modeselected;
                case "reset":
                    modeselected = new char[] { 'R' };
                    return modeselected;
                case "weather id":
                    modeselected = new char[] { 'I' };
                    return modeselected;
                case "weather data":
                    modeselected = new char[] { 'W' };
                    return modeselected;
                case "version":
                    modeselected = new char[] { 'V' };
                    return modeselected;
                case "qtable":
                    modeselected = new char[] { 'Q' };
                    return modeselected;
                case "top line":
                    modeselected = new char[] { 'T' };
                    return modeselected;
                case "bottom line":
                    modeselected = new char[] { 'B' };
                    return modeselected;
                case "local ad":
                    modeselected = new char[] { 'L' };
                    return modeselected;
                case "config":
                    modeselected = new char[] { 'F' };
                    return modeselected;
                case "new config":
                    modeselected = new char[] { 'f' };
                    return modeselected;
                case "save data":
                    modeselected = new char[] { '%' };
                    return modeselected;
                case "utility":
                    modeselected = new char[] { 'x' };
                    return modeselected;
                default:
                    modeselected = new char[] { '*' };
                    return modeselected;
            }
        }
    }

    public class ConvertArray
    {
        public int XORByteArrayFunction(byte[] bytearray)
        {
            int sPos = 0;
            int XORvalue = 0;

            // recursively loop through each char in the character array
            while (sPos < bytearray.Length)
            {
                XORvalue ^= bytearray[sPos];
                ++sPos;
            }
            return (XORvalue);
        }

        public byte[] CharArrayToByteArrayFunction(char[] messagetosend)
        {
            // create a byte arry to hold chars...
            byte[] data = new byte[messagetosend.Length];

            // loop thru chars and convert to byte...
            for (int i = 0; i < messagetosend.Length; i++)
            {
                // convert char to byte and place in byte array...
                data[i] = Convert.ToByte(messagetosend[i]);
            }
            return (data);

        }

    }
    /*
        public char[] ReverseBytes(char[] valuetoreverse)
        {
            byte[] intAsBytes = BitConverter.GetBytes(valuetoreverse);
            Array.Reverse(intAsBytes);
            return BitConverter.ToCharArray(intAsBytes, 0);
        }
        */
    public class XMLParseData
    {
        public string FormatStartTime(int hr, int min)
        {
            string starttime = "";
            int adjhr;

            if (min != 0 && min != 30)
            {
                if (hr == 0) { adjhr = 12; }
                else if (hr > 12) { adjhr = hr - 12; }
                else { adjhr = hr; }
                starttime = "(" + adjhr.ToString().PadLeft(2, ' ') + ":" + min.ToString().PadLeft(2, '0') + ")";
                return starttime;
            }
            else { return starttime; }
        }

        public string FormatLength(int lengthinminutes)
        {
            string length;

            int hr = lengthinminutes / 60;
            int min = lengthinminutes % 60;

            length = "(" + hr.ToString() + ":" + min.ToString().PadLeft(2, '0') + ")";
            return length;
        }

        public string FormatRating(string rating)
        {
            string formattedrating = "";
            if (rating != "")
            {
                formattedrating = "(" + rating + ")";
                return formattedrating;
            }
            else { return formattedrating; }
        }

        public string FormatCC(string subtitle)
        {
            string progcc = "";
            if (subtitle == "teletext")
            {
                progcc = "(CC)";
                return progcc;
            }
            else { return progcc; }
        }

        public string CaseSelect(string category, string title)
        {
            string formattedtitle;

            if (category == "Movie" && TextSettings.Default.MovieTextCaseSelected == 1)
            {
                formattedtitle = title.ToUpper();
                return formattedtitle;
            }
            else if (category == "Movie" && TextSettings.Default.MovieTextCaseSelected == 0)
            {
                formattedtitle = title;
                return formattedtitle;
            }
            else if (TextSettings.Default.AllTextCaseSelected == 1)
            {
                formattedtitle = title.ToUpper();
                return formattedtitle;
            }
            else
            {
                formattedtitle = title;
                return formattedtitle;
            }
        }

        public int ConvertDisplayLengthtoIntegerLength(string length)
        {
            string[] splitlength = length.Split('(', ':', ')');

            int hours = Convert.ToInt16(splitlength[1]);
            int minutes = Convert.ToInt16(splitlength[2]);

            int totalminutes = (hours * 60) + minutes;

            return totalminutes;
        }

        public string SportsSubtitleSelect(string title, string subtitle, string length)
        {
            int proglength = ConvertDisplayLengthtoIntegerLength(length);
            string formattedtitle;

            if (proglength > 30 && TextSettings.Default.AllTextCaseSelected == 1)
            {
                formattedtitle = title.ToUpper() + ": " + subtitle.ToUpper();
                return formattedtitle;
            }
            else if (proglength > 30 && TextSettings.Default.AllTextCaseSelected == 0)
            {
                formattedtitle = title + ": " + subtitle;
                return formattedtitle;
            }
            else if (TextSettings.Default.AllTextCaseSelected == 1)
            {
                formattedtitle = title.ToUpper();
                return formattedtitle;
            }
            else
            {
                formattedtitle = title;
                return formattedtitle;
            }
        }
        public string FormatTitle(string category, string starttime, string rating, string title, string year,
                                  string subtitle, string desc, string cc, string length)
        {
            //SportsListBuilder sports = new SportsListBuilder();
            //sports.BuildSportsTitleList();
            string adjustedlisting;

            if (category == "Movie")
            {
                if (starttime != "")
                {
                    adjustedlisting = starttime + " \"" + CaseSelect(category, title) + "\" " + rating + " (" + year + ") " + desc + " " + cc + " " + length;
                    return adjustedlisting;
                }
                else
                {
                    adjustedlisting = "\"" + CaseSelect(category, title) + "\" " + rating + " (" + year + ") " + desc + " " + cc + " " + length;
                    return adjustedlisting;
                }
            }
            //else if (sports.sportstitles.Contains(title))
            else if (category == "Sports")
            {
                if (starttime != "")
                {
                    string content = subtitle ?? "";
                    if (content != "")
                    {
                        adjustedlisting = starttime + " " + SportsSubtitleSelect(title, subtitle, length) + " " + cc;
                        return adjustedlisting;

                    }
                    else
                    {
                        adjustedlisting = starttime + " " + CaseSelect(category, title) + " " + cc;
                        return adjustedlisting;
                    }
                }
                else
                {
                    string content = subtitle ?? "";

                    if (content != "")
                    {
                        adjustedlisting = SportsSubtitleSelect(title, subtitle, length) + " " + cc;
                        return adjustedlisting;
                    }
                    else
                    {
                        adjustedlisting = CaseSelect(category, title) + " " + cc;
                        return adjustedlisting;
                    }
                }
            }
            else
            {
                if (starttime != "")
                {
                    if (TextSettings.Default.DisplayTVRatings == 1) 
                    {
                        adjustedlisting = starttime + " " + CaseSelect(category, title) + " " + rating + " " + cc;
                        return adjustedlisting; 
                    }
                    else
                    {
                        adjustedlisting = starttime + " " + CaseSelect(category, title) + " " + cc;
                        return adjustedlisting;
                    }
                }
                else
                {
                    if (TextSettings.Default.DisplayTVRatings == 1)
                    {
                        adjustedlisting = CaseSelect(category, title) + " " + rating + " " + cc;
                        return adjustedlisting;
                    }
                    else
                    {
                        adjustedlisting = CaseSelect(category, title) + " " + cc;
                        return adjustedlisting;
                    }
                }
            } 
        }

        public int GetCategoryValue(string category)
        {
            BitArray bits = new BitArray(8); 
            
            bits[0] = true;     //"None - will always be true" ;

            if (category == "Movie" ) { bits[1] = true; /* Movie */ }
            else { bits[1] = false; }

            if (category == "Movie" && ColorSettings.Default.MovieRBSelected == 1) { bits[2] = true; /* AltHighltProg */ }
            else if (category == "Sports" && ColorSettings.Default.SportsRBSelected == 1) { bits[2] = true; /* AltHighltProg */ }
            else if (category == "Family" && ColorSettings.Default.FamilyRBSelected == 1) { bits[2] = true; /* AltHighltProg */ }
            else if (category == "News" && ColorSettings.Default.NewsRBSelected == 1) { bits[2] = true; /* AltHighltProg */ }
            else if (category != "Movie" && category != "Sports" && category != "Family" && category != "News" &&
                    ColorSettings.Default.OtherRBSelected == 1) { bits[2] = true; /* AltHighltProg */ }
            else { bits[2] = false; /* AltHighltProg */ }


            if (category == "Movie") { bits[3] = true; /* TagProg */ }
            else if (category == "Sports") { bits[3] = true; /* TagProg */ }
            else if (category == "Family") { bits[3] = true; /* TagProg */ }
            else if (category == "News") { bits[3] = true; /* TagProg */ }
            else { bits[3] = false; }

            if (category == "Sports") { bits[4] = true; /* SportsProg */ }
            else { bits[4] = false; }

            bits[5] = false;    //"DView Used - will always be false" ;

            bits[6] = false;    //"Repeat Prog - will always be false" ;

            bits[7] = false;    //"Prev Day Data - will always be false" ;

            Calc c = new Calc();
            int valuetoreturn = c.ConvertToNumeral(bits);
            return valuetoreturn;
            
        }
        public string ChildNodeValue(XElement parentNode, string ChildNode)
        {
            string value = "";
            XElement node = parentNode.Element(ChildNode);
            if (node != null)
            {
                value = parentNode.Element(ChildNode).Value;
                return value;
            }
            else
            {
                return value;
            }
        }
        public string ChildNodeAttrValue(XElement parentNode, string ChildNode, string attr)
        {
            string value = "";
            XElement node = parentNode.Element(ChildNode);
            if (node != null)
            {
                value = parentNode.Element(ChildNode).Attribute(attr).Value;
                return value;
            }
            else
            {
                return value;
            }
        }

    }


}

