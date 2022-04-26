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
    public class SportsListBuilder
    {
        public List<string> sportstitles = new List<string>();

        public void BuildSportsTitleList()
        {
            sportstitles.Add("MLB Baseball");
            sportstitles.Add("NFL Football");
            sportstitles.Add("NBA Basketball");
            sportstitles.Add("NHL Hockey");
            sportstitles.Add("MLS Soccer");
            sportstitles.Add("NWSL Soccer");
            sportstitles.Add("WNBA Basketball");
            sportstitles.Add("Tennis");
            sportstitles.Add("Baseball");
            sportstitles.Add("College Baseball");
            sportstitles.Add("College Football");
            sportstitles.Add("College Basketball");
            sportstitles.Add("College Hockey");
            sportstitles.Add("Women's College Soccer");
            sportstitles.Add("Women's College Volleyball");
            sportstitles.Add("Women's College Basketball");
            sportstitles.Add("European PGA Tour Golf");
            sportstitles.Add("Women's Golf");
            sportstitles.Add("LPGA Tour Golf");
            sportstitles.Add("PGA Tour Golf");
            sportstitles.Add("PGA Tour Champions Golf");
            sportstitles.Add("Horse Racing");
            sportstitles.Add(@"ATP/WTA Tennis");
            sportstitles.Add("FIFA World Cup 2022 Qualifying");
            sportstitles.Add("Boxing");
            sportstitles.Add("Formula 1 Racing");
            sportstitles.Add("Figure Skating");
            sportstitles.Add("IMSA Weathertech Sportscar Championship");
            sportstitles.Add("High School Basketball");
            sportstitles.Add("High School Football");
            sportstitles.Add("Center Court");
            sportstitles.Add("Fight Sports: Boxing");
            sportstitles.Add("Boat Racing");
            sportstitles.Add("Major League Fishing");
            sportstitles.Add("Lucas Oil Motorsports");
            sportstitles.Add("FIFA Eliminatorias Copa Mundial 2022");
            sportstitles.Add("Béisbol Liga Mexicana");
            sportstitles.Add("Fútbol Americano Colegial de México");
            sportstitles.Add("FIS Alpine Skiing");
            sportstitles.Add("Premier League Soccer");
            sportstitles.Add("2022 Winter Olympics");
            sportstitles.Add("2022 NCAA Women's Basketball Tournament");
            sportstitles.Add("2022 NIT Basketball Tournament");
            sportstitles.Add("Women's College Hockey");
            sportstitles.Add("Snowmobile Racing");
            sportstitles.Add("PBR Bull Riding");
            sportstitles.Add("College Gymnastics");
            sportstitles.Add("Women's College Gymnastics");
            sportstitles.Add("PBA Bowling");
            sportstitles.Add("NASCAR Camping World Truck Series");
            sportstitles.Add("NASCAR Xfinity Racing Series");
            sportstitles.Add("NASCAR Cup Series");
            sportstitles.Add("Motorcycle Racing");
            sportstitles.Add("Major League Rugby");
            sportstitles.Add("Athletes Unlimited Volleyball");
            sportstitles.Add("Athletes Unlimited Basketball");
            sportstitles.Add("Tennis Classics");
            sportstitles.Add("Ladies Euro Tour Golf");
            sportstitles.Add("ATP Tennis");
            sportstitles.Add("WTA Tennis");
            sportstitles.Add("College Softball");
            sportstitles.Add("Women's College Lacrosse");
            sportstitles.Add("College Swimming");
            sportstitles.Add("2022 World Women's Curling Championship");
            sportstitles.Add("Track and Field");
            sportstitles.Add("Mexico Primera Division Soccer");
            sportstitles.Add("2022 NCAA Men's Basketball Tournament");
            sportstitles.Add("World Poker Tour");
            sportstitles.Add("NFL's Greatest Games");
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

        public string FormatTitle(string category, string starttime, string rating, string title, string year,
                                  string subtitle, string desc, string cc, string length)
        {
            SportsListBuilder sports = new SportsListBuilder();
            sports.BuildSportsTitleList();

            string formattedtitle;

            if (category == "Movie")
            {
                if (starttime != "")
                {
                    formattedtitle = starttime + " \"" + title + "\" " + rating + " (" + year + ") " + desc + " " + cc + " " + length;
                    return formattedtitle;
                }
                else
                {
                    formattedtitle = "\"" + title + "\" " + rating + " (" + year + ") " + desc + " " + cc + " " + length;
                    return formattedtitle;
                }
            }
            else if (sports.sportstitles.Contains(title))
            {
                if (starttime != "")
                {
                    string content = subtitle ?? "";
                    if (content != "")
                    {
                        formattedtitle = starttime + " " + title + ": " + subtitle + " " + cc;
                        return formattedtitle;

                    }
                    else
                    {
                        formattedtitle = starttime + " " + title + " " + cc;
                        return formattedtitle;
                    }
                }
                else
                {
                    string content = subtitle ?? "";

                    if (content != "")
                    {
                        formattedtitle = title + ": " + subtitle + " " + cc;
                        return formattedtitle;
                    }
                    else
                    {
                        formattedtitle = title + " " + cc;
                        return formattedtitle;
                    }
                }
            }
            else
            {
                if (starttime != "")
                {
                    formattedtitle = starttime + " " + title + " " + rating + " " + cc;
                    return formattedtitle;
                }
                else
                {
                    formattedtitle = title + " " + rating + " " + cc;
                    return formattedtitle;
                }
            }
        }
        public int GetCategoryValue(string category)
        {
            if (category == "Movie") 
            {
                Calc c = new Calc();
                BitArray bits = new BitArray(8);
                bits[0] = true;
                bits[1] = true;
                bits[2] = true;
                bits[3] = true;
                bits[4] = false;
                bits[5] = false;
                bits[6] = false;
                bits[7] = false;

                int valuetoreturn = c.ConvertToNumeral(bits);
                return valuetoreturn;
        
            }
            else if (category == "Sports") 
            {
                Calc c = new Calc();
                BitArray bits = new BitArray(8);
                bits[0] = true;
                bits[1] = false;
                bits[2] = true;
                bits[3] = true;
                bits[4] = true;
                bits[5] = false;
                bits[6] = false;
                bits[7] = false;

                int valuetoreturn = c.ConvertToNumeral(bits);
                return valuetoreturn;
            }
            else if (category == "Family") 
            { 
                Calc c = new Calc();
                BitArray bits = new BitArray(8);
                bits[0] = true;
                bits[1] = false;
                bits[2] = false;
                bits[3] = true;
                bits[4] = false;
                bits[5] = false;
                bits[6] = false;
                bits[7] = false;

                int valuetoreturn = c.ConvertToNumeral(bits);
                return valuetoreturn;
            }
            else if (category == "News") 
            { 
                Calc c = new Calc();
                BitArray bits = new BitArray(8);
                bits[0] = true;
                bits[1] = false;
                bits[2] = false;
                bits[3] = true;
                bits[4] = false;
                bits[5] = false;
                bits[6] = false;
                bits[7] = false;

                int valuetoreturn = c.ConvertToNumeral(bits);
                return valuetoreturn;
            }
            else 
            {
                Calc c = new Calc();
                BitArray bits = new BitArray(8);
                bits[0] = true;
                bits[1] = false;
                bits[2] = false;
                bits[3] = false;
                bits[4] = false;
                bits[5] = false;
                bits[6] = false;
                bits[7] = false;

                int valuetoreturn = c.ConvertToNumeral(bits);
                return valuetoreturn;
            }
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

