using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
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
using Calculator;
using Weather;
using FileIO;
using SerialIO;
using NetworkIO;
using LineupBuilder;
using ListingsBuilder;
using Commands;
using User_Settings = PrevueDataSender.Properties.Settings;

namespace PrevueDataSender
{
    public partial class Form1 : Form
    {
        public class DaypartData
        {
            public int DaypartSelected { get; set; }
            public string DaypartValue { get; set; }
        }
        public class ListingAttrData
        {
            public int ListingEntrySelected { get; set; }
            public string AttributeValue { get; set; }
        }

        public ClockData clock = new ClockData();

        // Global Variables throughout program:

        int wu_minutes;
        int wu_seconds;

        //User Set Variables
        public int timeslotselection;
        public int adjustedJulianDateselection;
        public int channeladjustedJulianDateselection;
        public int listingattrselection;
        public char[] empty = new char[] { };

        // Functions Section: Functions needed for program

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Clock Timer
            DateTime currentDate_Time = DateTime.Now;
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DaylightTime daylight = localZone.GetDaylightChanges(currentDate_Time.Year);

            clock.CurrentDayOfWeek = (int)currentDate_Time.DayOfWeek;
            clock.CurrentMonth = currentDate_Time.Month;
            clock.CurrentDay = currentDate_Time.Day;
            clock.CurrentYear = currentDate_Time.Year;
            clock.CurrentHour = currentDate_Time.Hour;
            clock.CurrentMinute = currentDate_Time.Minute;
            clock.CurrentSecond = currentDate_Time.Second;
            clock.CurrentDayOfYear = currentDate_Time.DayOfYear;
            Calc c = new Calc();
            clock.CurrentPrevueDayOfYear = c.CalcOrdinalDate(clock.CurrentYear,
                                                             clock.CurrentMonth,
                                                             clock.CurrentDay,
                                                             clock.CurrentHour,
                                                             clock.CurrentMinute,
                                                             User_Settings.Default.TimeZoneOffset);
            clock.CurrentDSTSetting = currentDate_Time.IsDaylightSavingTime();
            clock.DST_Enter_Year = currentDate_Time.Year.ToString();
            clock.DST_Enter_DayOfYear = daylight.Start.DayOfYear.ToString().PadLeft(3, '0');
            clock.DST_Enter_Time = daylight.Start.Hour.ToString().PadLeft(2, '0') + ':' + daylight.Start.Minute.ToString().PadLeft(2, '0');
            clock.DST_Exit_Year = currentDate_Time.Year.ToString();
            clock.DST_Exit_DayOfYear = daylight.End.DayOfYear.ToString().PadLeft(3, '0');
            clock.DST_Exit_Time = daylight.End.Hour.ToString().PadLeft(2, '0') + ':' + daylight.End.Minute.ToString().PadLeft(2, '0');
            comboBox4.SelectedIndex = Convert.ToInt16(clock.CurrentDayOfWeek);
            comboBox5.SelectedIndex = Convert.ToInt16(clock.CurrentMonth - 1);
            textBox23.Text = Convert.ToInt16(clock.CurrentDay).ToString();
            textBox24.Text = Convert.ToInt16(clock.CurrentYear).ToString();
            textBox25.Text = Convert.ToInt16(clock.CurrentHour).ToString();
            textBox26.Text = Convert.ToInt16(clock.CurrentMinute).ToString().PadLeft(2, '0');
            textBox27.Text = Convert.ToInt16(clock.CurrentSecond).ToString().PadLeft(2, '0');
            comboBox6.SelectedIndex = Convert.ToInt16(clock.CurrentDSTSetting);
            CurrentDayOfYear_TextBox.Text = clock.CurrentDayOfYear.ToString();
            CurrentPrevueDay_TextBox.Text = clock.CurrentPrevueDayOfYear.ToString();
            textBox11.Text = clock.DST_Enter_Year;
            textBox12.Text = clock.DST_Enter_DayOfYear;
            textBox16.Text = clock.DST_Enter_Time;
            textBox89.Text = clock.DST_Exit_Year;
            textBox90.Text = clock.DST_Exit_DayOfYear;
            textBox91.Text = clock.DST_Exit_Time;



            CurDateTime.Text = "Current Date and Time: " + currentDate_Time.ToString();
            CurrentDayofYear.Text = "Current Day of the Year: " + currentDate_Time.DayOfYear.ToString();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Time Slot selection box
            timeslotselection = comboBox1.SelectedIndex + 1;
        }

        public void Calculate_JDate(object sender, EventArgs e)
        {
            //Time String - Input the Julian Date Julian Date is in Decimal Form
            //Calculate Julian Date that Prevue will understand - anything over 256 starts over at zero
            // Julian Date selection box

            DateTime dateselection = dateTimePicker1.Value;
            Calc c = new Calc();
            adjustedJulianDateselection = c.CalcAdjustedJulianDate(dateselection);
            textBox1.Text = adjustedJulianDateselection.ToString();
        }

        public void CalculateChannelJDate(object sender, EventArgs e)
        {
            //Time String - Input the Julian Date Julian Date is in Decimal Form
            //Calculate Julian Date that Prevue will understand - anything over 256 starts over at zero
            // Julian Date selection box

            DateTime dateselection = dateTimePicker2.Value;
            Calc c = new Calc();
            channeladjustedJulianDateselection = c.CalcAdjustedJulianDate(dateselection);
            Jdate.Text = channeladjustedJulianDateselection.ToString();
        }

        /*
        private void None_CheckedChanged(object sender, EventArgs e)
        {
            Calc c = new Calc();
            listingattrselection = c.ValueDeterminationFunction(None.Checked, listingattrselection, 1);
        }
        */

        public Form1()
        {
            InitializeComponent();
            RunAtStartup();
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            try
            {
                Thread currentThread = Thread.CurrentThread;
                if (currentThread.IsAlive)
                    currentThread.Abort();
            }
            catch (ThreadAbortException ex)
            {
                Thread.ResetAbort();
                MessageBox.Show(ex.ToString());
            }
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        
        private void RunAtStartup()
        {
            UserDataFolder data = new UserDataFolder();
            if (Properties.Settings.Default.FirstRun == true)
            {
                data.Select_UserDataFolder(User_Settings.Default.FirstRun, folderBrowserDialog1);
                UserSettings_InitializeTextFields();
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.MovieRBSelected,
                                                            radioButton1, radioButton2);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.SportsRBSelected,
                                                            radioButton4, radioButton5);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.FamilyRBSelected,
                                                            radioButton7, radioButton8);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.NewsRBSelected,
                                                            radioButton10, radioButton11);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.OtherRBSelected,
                                                            radioButton13, radioButton14);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.MovieTextCaseSelected,
                                                            radioButton3, radioButton6);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.AllTextCaseSelected,
                                                            radioButton9, radioButton12);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.DisplayTVRatings,
                                                            radioButton15, radioButton16);

                ReadConfigurationFile();
                LineupFile lineupfile = new LineupFile();
                lineupfile.ReadLineupFile(LineupDataSet.Tables["Lineup"]);
                ListingsFile list = new ListingsFile();
                list.ReadListingsFile(ListingDataSet.Tables["Listings"]);
                list.ReadScrollMessagesFile(Scroll_Messages_DataSet.Tables["ScrollMessages"]);
                QTableFile qtable = new QTableFile();
                qtable.ReadQTableFile(QTableDataSet.Tables["QTable"]);
                Bind_DataSources();
                Listings_FormatDataGridView();
                Lineup_FormatDataGridView();
                Z2ILineup_FormatDataGridView();
                Z2IListings_FormatDataGridView();
                Scroll_Messages_FormatDataGridView();
                QTable_FormatDataGridView();
            }
            else
            {
                SerialFile serial = new SerialFile();
                serial.ClearSerialLogFile();
                UserSettings_InitializeTextFields();
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.MovieRBSelected,
                                                            radioButton1, radioButton2);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.SportsRBSelected,
                                                            radioButton4, radioButton5);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.FamilyRBSelected,
                                                            radioButton7, radioButton8);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.NewsRBSelected,
                                                            radioButton10, radioButton11);
                ListingColorSettings_InitializeRadioButtons(ListingColor.Default.OtherRBSelected,
                                                            radioButton13, radioButton14);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.MovieTextCaseSelected,
                                                            radioButton3, radioButton6);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.AllTextCaseSelected,
                                                            radioButton9, radioButton12);
                ListingTextSetting_InitializeRadioButtons(ListingText.Default.DisplayTVRatings,
                                                            radioButton15, radioButton16);

                ReadConfigurationFile();
                LineupFile lineupfile = new LineupFile();
                lineupfile.ReadLineupFile(LineupDataSet.Tables["Lineup"]);
                ListingsFile list = new ListingsFile();
                list.ReadListingsFile(ListingDataSet.Tables["Listings"]);
                list.ReadScrollMessagesFile(Scroll_Messages_DataSet.Tables["ScrollMessages"]);
                QTableFile qtable = new QTableFile();
                qtable.ReadQTableFile(QTableDataSet.Tables["QTable"]);
                Bind_DataSources();
                Listings_FormatDataGridView();
                Lineup_FormatDataGridView();
                Z2ILineup_FormatDataGridView();
                Z2IListings_FormatDataGridView();
                Scroll_Messages_FormatDataGridView();
                QTable_FormatDataGridView();
            }
        }

        private void Bind_DataSources()
        {
            // Create a BindingSource for each DataTable set up. 
            BindingSource Listing_BindSource = new BindingSource
            { DataSource = ListingDataSet.Tables["Listings"] };
            BindingSource Lineup_BindSource = new BindingSource
            { DataSource = LineupDataSet.Tables["Lineup"] };
            BindingSource Z2IListing_BindSource = new BindingSource
            { DataSource = ListingDataSet.Tables["Z2IListings"] };
            BindingSource Z2ILineup_BindSource = new BindingSource
            { DataSource = LineupDataSet.Tables["Z2ILineup"] };
            BindingSource Scroll_Messages_BindSource = new BindingSource
            { DataSource = Scroll_Messages_DataSet.Tables["ScrollMessages"] };
            BindingSource QTable_BindSource = new BindingSource
            { DataSource = QTableDataSet.Tables["QTable"] };

            // Binding the table sources to each DataGridView's data source   
            Lineup_DGV.DataSource = Lineup_BindSource;
            Listings_DGV.DataSource = Listing_BindSource;
            Z2I_Lineup_DGV.DataSource = Z2ILineup_BindSource;
            Z2I_Listings_DGV.DataSource = Z2IListing_BindSource;
            Scroll_Messages_DGV.DataSource = Scroll_Messages_BindSource;
            QTable_DGV.DataSource = QTable_BindSource;
           
        }

        /// <summary>
        /// Listings Tab:
        /// 
        /// This section contains the code for sending setup commands.
        /// The screen controls are located in the Commands Tab.
        /// </summary>

        private void Listings_FormatDataGridView()
        {
            Listings_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn dc in Listings_DGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Listings_DGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            Properties.View settings = Properties.View.Default;

            Listings_DGV.Columns[0].Width = settings.ListingsDGV_AdjDayofYear_ColWidth;
            Listings_DGV.Columns[1].Width = settings.ListingsDGV_SourceID_ColWidth;
            Listings_DGV.Columns[2].Width = settings.ListingsDGV_TimeSlot_ColWidth;
            Listings_DGV.Columns[3].Width = settings.ListingsDGV_Attribute_ColWidth;
            Listings_DGV.Columns[4].Width = settings.ListingsDGV_Title_ColWidth;
        }
        private void Update_Attr_Entries(int attribute, DataGridViewCell item)
        {
            ListingAttrData entry = new ListingAttrData
            {
                ListingEntrySelected = attribute,
                AttributeValue = item.Value.ToString()
            };

            using (Form4 frm = new Form4() { AttrInfo = entry })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    item.Value = entry.AttributeValue;
                }

            }

            toolStripStatusLabel1.Text = "Entries have been updated to lineup.";
        }
        private void Listings_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell item = Listings_DGV.CurrentCell;

            switch (item.ColumnIndex)
            {
                case 3: { Update_Attr_Entries(1, item); break; }
                default: { break; }
            }
        }
        private void Listings_UpdateEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.UpdateEntries(ListingDataSet.Tables["Listings"]);
        }
        private void Listings_MoveEntryUp_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.MoveEntry(Listings_DGV, ListingDataSet.Tables["Listings"], "up");
        }
        private void Listings_MoveEntryDown_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.MoveEntry(Listings_DGV, ListingDataSet.Tables["Listings"], "down");
        }
        private void Listings_InsertEntryAbove_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.InsertEntry(Listings_DGV, ListingDataSet.Tables["Listings"], "above");
        }
        private void Listings_InsertEntryBelow_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.InsertEntry(Listings_DGV, ListingDataSet.Tables["Listings"], "below");
        }
        private void Listings_DeleteSelectedEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.DeleteSelectedEntries(Listings_DGV, ListingDataSet.Tables["Listings"]);
        }
        private void Listings_Z2I_Import_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.Import_Z2IData(Listings_DGV, ListingDataSet.Tables["Z2IListings"], ListingDataSet.Tables["Listings"]);
        }
        private void Listings_SendCurrentDayEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendListings(serialPort1, Listings_DGV, ListingDataSet.Tables["Listings"],
                                         clock.CurrentPrevueDayOfYear);
        }
        private void Listings_SendNextDayEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendListings(serialPort1, Listings_DGV, ListingDataSet.Tables["Listings"],
                                         clock.CurrentPrevueDayOfYear + 1);
        }
        private void Listings_SendSelectedEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendSelectedListings(serialPort1, Listings_DGV, ListingDataSet.Tables["Listings"]);
        }


        /// <summary>
        /// Listing Color Atrributes:
        /// 
        /// This section contains the code for selecting genre defined colors inside the scroll/grid.
        /// Genre Information is based off of Zap2It's information.
        /// Controls are found in Listing Setup tab
        /// </summary>

        private void ListingColorSettings_InitializeRadioButtons(int selection, RadioButton rb1, RadioButton rb2)
        {
            if (selection == 1)
            {
                rb1.Checked = false;
                rb2.Checked = true;
            }
            else
            {
                rb1.Checked = true;
                rb2.Checked = false;
            }
        }

        private void Movie_Listing_Color_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingColor.Default.MovieRBSelected = selectedIndex;
            ListingColor.Default.Save();
        }

        private void Sports_Listing_Color_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox2.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingColor.Default.SportsRBSelected = selectedIndex;
            ListingColor.Default.Save();
        }

        private void Family_Listing_Color_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox3.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingColor.Default.FamilyRBSelected = selectedIndex;
            ListingColor.Default.Save();
        }

        private void News_Listing_Color_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox4.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingColor.Default.NewsRBSelected = selectedIndex;
            ListingColor.Default.Save();
        }

        private void Other_Listing_Color_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox5.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingColor.Default.OtherRBSelected = selectedIndex;
            ListingColor.Default.Save();
        }

        /// <summary>
        /// Listing Text Atrributes:
        /// 
        /// This section contains the code for selecting the case of the listings.
        /// Default Setting is Mixed case, but can be changed to uppercase letters in early Prevue 
        /// listings.
        /// Genre Information is based off of Zap2It's information.
        /// Controls are found in Listing Setup tab
        /// </summary>

        private void ListingTextSetting_InitializeRadioButtons(int selection, RadioButton rb1, RadioButton rb2)
        {
            if (selection == 1)
            {
                rb1.Checked = false;
                rb2.Checked = true;
            }
            else
            {
                rb1.Checked = true;
                rb2.Checked = false;
            }
        }

        private void MovieTitleTextSetting_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox6.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingText.Default.MovieTextCaseSelected = selectedIndex;
            ListingText.Default.Save();
        }

        private void AllListings_TextSetting_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox7.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingText.Default.AllTextCaseSelected = selectedIndex;
            ListingText.Default.Save();
        }

        private void TVRatings_Setting_CheckedChanged(object sender, EventArgs e)
        {
            var radioButtons = groupBox8.Controls.OfType<RadioButton>().ToArray();
            var selectedIndex = Array.IndexOf(radioButtons, radioButtons.Single(rb => rb.Checked));

            ListingText.Default.DisplayTVRatings = selectedIndex;
            ListingText.Default.Save();
        }

        /// <summary>
        /// Scroll Messages in Listings:
        /// 
        /// This section contains the code for building and sending messages for display in the scroll/grid.
        /// Must hit update button to save the settings in the DataGridView
        /// Controls are found in Listing Setup tab
        /// </summary>

        private void Scroll_Messages_FormatDataGridView()
        {
            Scroll_Messages_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn dc in Scroll_Messages_DGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Scroll_Messages_DGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            Properties.View settings = Properties.View.Default;

            Scroll_Messages_DGV.Columns[0].Width = settings.ListingsDGV_SourceID_ColWidth;
            Scroll_Messages_DGV.Columns[1].Width = settings.ListingsDGV_Attribute_ColWidth;
            Scroll_Messages_DGV.Columns[2].Width = settings.ListingsDGV_Title_ColWidth;
        }

        private void Scroll_Messages_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell item = Scroll_Messages_DGV.CurrentCell;

            switch (item.ColumnIndex)
            {
                case 1: { Update_Attr_Entries(1, item); break; }
                default: { break; }
            }
        }
        private void Scroll_Messages_UpdateEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.UpdateScrollMsgEntries(Scroll_Messages_DataSet.Tables["ScrollMessages"]);
        }
        private void Scroll_Messages_MoveEntryUp_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.MoveScrollMsgEntry(Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"], "up");
        }
        private void Scroll_Messages_MoveEntryDown_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.MoveScrollMsgEntry(Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"], "down");
        }
        private void Scroll_Messages_InsertEntryAbove_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.InsertScrollMsgEntry(Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"], "above");
        }
        private void Scroll_Messages_InsertEntryBelow_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.InsertScrollMsgEntry(Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"], "below");
        }
        private void Scroll_Messages_DeleteSelectedEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            listings.DeleteSelectedScrollMsgEntries(Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"]);
        }

        private void Scroll_Messages_SendCurrentDayEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendScrollMessages(serialPort1, Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"],
                                         clock.CurrentPrevueDayOfYear);
        }
        private void Scroll_Messages_SendNextDayEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendScrollMessages(serialPort1, Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"],
                                         clock.CurrentPrevueDayOfYear + 1);
        }
        private void Scroll_Messages_SendSelectedEntries_Click(object sender, EventArgs e)
        {
            ListingsBuild listings = new ListingsBuild();
            toolStripStatusLabel1.Text = listings.SendSelectedScrollMessages(serialPort1, Scroll_Messages_DGV, Scroll_Messages_DataSet.Tables["ScrollMessages"]);
        }


        /// <summary>
        /// Channel Lineup Tab:
        /// 
        /// This section contains the code for sending setup commands.
        /// The screen controls are located in the Commands Tab.
        /// </summary>

        private void Lineup_FormatDataGridView()
        {
            Lineup_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn dc in Lineup_DGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Properties.View settings = Properties.View.Default;

            Lineup_DGV.Columns[0].Width = settings.LineupDGV_SourceID_ColWidth;
            Lineup_DGV.Columns[1].Width = settings.LineupDGV_Number_ColWidth;
            Lineup_DGV.Columns[2].Width = settings.LineupDGV_ID_ColWidth;
            Lineup_DGV.Columns[3].Width = settings.LineupDGV_Attribute_ColWidth;
            Lineup_DGV.Columns[4].Width = settings.LineupDGV_Daypart1_ColWidth;
            Lineup_DGV.Columns[5].Width = settings.LineupDGV_Daypart2_ColWidth;
            Lineup_DGV.Columns[6].Width = settings.LineupDGV_Daypart3_ColWidth;
            Lineup_DGV.Columns[7].Width = settings.LineupDGV_Daypart4_ColWidth;
            Lineup_DGV.Columns[8].Width = settings.LineupDGV_Daypart5_ColWidth;
            Lineup_DGV.Columns[9].Width = settings.LineupDGV_Daypart6_ColWidth;
        }
        private void Update_TS_Entries(int daypart, DataGridViewCell item)
        {
            DaypartData entry = new DaypartData
            {
                DaypartSelected = daypart,
                DaypartValue = item.Value.ToString()
            };

            using (Form3 frm = new Form3() { TSInfo = entry })
               {
                   if (frm.ShowDialog() == DialogResult.OK)
                   {
                       item.Value = entry.DaypartValue;
                   }
               }
           toolStripStatusLabel1.Text = "Entries have been updated to lineup.";
        }
        private void Lineup_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell item = Lineup_DGV.CurrentCell;

            switch (item.ColumnIndex)
            {
                case 10: { Update_TS_Entries(1, item); break; }
                case 11: { Update_TS_Entries(2, item); break; }
                case 12: { Update_TS_Entries(3, item); break; }
                case 13: { Update_TS_Entries(4, item); break; }
                case 14: { Update_TS_Entries(5, item); break; }
                case 15: { Update_TS_Entries(6, item); break; }
                default: { break; }
            }
        }       
        private void Lineup_MoveEntryUp_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.MoveEntry(Lineup_DGV, LineupDataSet.Tables["Lineup"], "up");
        }
        private void Lineup_MoveEntryDown_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.MoveEntry(Lineup_DGV, LineupDataSet.Tables["Lineup"], "down");
        }
        private void Lineup_InsertEntryAbove_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.InsertEntry(Lineup_DGV, LineupDataSet.Tables["Lineup"], "above");
        }
        private void Lineup_InsertEntryBelow_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.InsertEntry(Lineup_DGV, LineupDataSet.Tables["Lineup"], "below");
        }
        private void Lineup_UpdateEntries_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.UpdateEntries(LineupDataSet.Tables["Lineup"]);
        }
        private void Lineup_DeleteSelectedEntries_Click(object sender, EventArgs e)
        {
            LineupBuild lineup = new LineupBuild();
            lineup.DeleteSelectedEntries(Lineup_DGV, LineupDataSet.Tables["Lineup"]);
        }

        private void Lineup_SendInitialLineup_Click(object sender, EventArgs e)
        {
            //Version 7 requires the clock command to be sent first before a channel lineup can be sent.

            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Clock(serialPort1, clock);
            LineupBuild lineup = new LineupBuild();
            toolStripStatusLabel1.Text = lineup.SendLineup(serialPort1, LineupDataSet.Tables["Lineup"], clock.CurrentPrevueDayOfYear);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }
        private void Lineup_SendCurrentDay_Click(object sender, EventArgs e)
        {
            //Use for changes to current lineup already sent
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            LineupBuild lineup = new LineupBuild();
            toolStripStatusLabel1.Text = lineup.SendLineup(serialPort1, LineupDataSet.Tables["Lineup"], clock.CurrentPrevueDayOfYear);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }        
        private void Lineup_SendNextDay_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            LineupBuild lineup = new LineupBuild();
            toolStripStatusLabel1.Text = lineup.SendLineup(serialPort1, LineupDataSet.Tables["Lineup"], clock.CurrentPrevueDayOfYear + 1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }
        private void Lineup_Z2I_Import_Click(object sender, EventArgs e) 
        {
            LineupBuild lineup = new LineupBuild();
            lineup.Import_Z2IData(Lineup_DGV, LineupDataSet.Tables["Z2ILineup"], LineupDataSet.Tables["Lineup"]);
        }

        /// <summary>
        /// Zap2It Download Tab:
        /// 
        /// This section contains the controls for downloading and exporting
        /// the Zap2It listings data into the User modifiable listings and
        /// channel lineup tabs.
        /// </summary>

        private void Z2ILineup_FormatDataGridView()
        {           
            foreach (DataGridViewColumn dc in Z2I_Lineup_DGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Z2I_Lineup_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Properties.View settings = Properties.View.Default;
            Z2I_Lineup_DGV.Columns[0].Width = settings.Z2ILineupDGV_SourceID_ColWidth; //60
            Z2I_Lineup_DGV.Columns[1].Width = settings.Z2ILineupDGV_Number_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[2].Width = settings.Z2ILineupDGV_ID_ColWidth;//80;
            Z2I_Lineup_DGV.Columns[3].Width = settings.Z2ILineupDGV_RedHiLt_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[4].Width = settings.Z2ILineupDGV_SBS_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[5].Width = settings.Z2ILineupDGV_PTagDisabled_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[6].Width = settings.Z2ILineupDGV_PPVSrc_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[7].Width = settings.Z2ILineupDGV_DittoEnable_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[8].Width = settings.Z2ILineupDGV_LtBlueHiLt_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[9].Width = settings.Z2ILineupDGV_StereoSrc_ColWidth;//60;
            Z2I_Lineup_DGV.Columns[10].Width = settings.Z2ILineupDGV_Daypart1_ColWidth;//40;
            Z2I_Lineup_DGV.Columns[11].Width = settings.Z2ILineupDGV_Daypart2_ColWidth;//40;
            Z2I_Lineup_DGV.Columns[12].Width = settings.Z2ILineupDGV_Daypart3_ColWidth;//40;
            Z2I_Lineup_DGV.Columns[13].Width = settings.Z2ILineupDGV_Daypart4_ColWidth;//40;
            Z2I_Lineup_DGV.Columns[14].Width = settings.Z2ILineupDGV_Daypart5_ColWidth;//40;
            Z2I_Lineup_DGV.Columns[15].Width = settings.Z2ILineupDGV_Daypart6_ColWidth;//40;
        }
        private void Z2IListings_FormatDataGridView()
        {
            Z2I_Listings_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn dc in Z2I_Listings_DGV.Columns)
            {
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            Properties.View settings = Properties.View.Default;
            Z2I_Listings_DGV.Columns[0].Width = settings.Z2IListingsDGV_AdjDayofYear_ColWidth;
            Z2I_Listings_DGV.Columns[1].Width = settings.Z2IListingsDGV_SourceID_ColWidth;
            Z2I_Listings_DGV.Columns[2].Width = settings.Z2IListingsDGV_TimeSlot_ColWidth;
            Z2I_Listings_DGV.Columns[3].Width = settings.Z2IListingsDGV_Attribute_ColWidth;
            Z2I_Listings_DGV.Columns[4].Width = settings.Z2IListingsDGV_Title_ColWidth;
            Z2I_Listings_DGV.Columns[5].Width = settings.Z2IListingsDGV_Subtitle_ColWidth;
            Z2I_Listings_DGV.Columns[6].Width = settings.Z2IListingsDGV_Description_ColWidth;            
        }
        private void Z2I_Download_Click(object sender, EventArgs e)
        {
            Zap2ItXMLFile listingxml = new Zap2ItXMLFile();
            Thread Z2IDownload_Thread = new Thread(listingxml.DownloadZap2ItXMLInfo);
            Download.Enabled = false;
            Z2IDownload_Thread.Start();
            toolStripStatusLabel1.Text = "Zap2Xml Information has downloaded.";
            Download.Enabled = true;
        }
        private void Z2I_LoadDataGridViews_Click(object sender, EventArgs e)
        {
            Zap2ItLineup zaplineup = new Zap2ItLineup();
            zaplineup.ParseXMLforLineup(LineupDataSet.Tables["Z2ILineup"]);

            Zap2ItListings zaplistings = new Zap2ItListings();
            zaplistings.ParseXMLforListings(ListingDataSet.Tables["Z2IListings"]);

            toolStripStatusLabel1.Text = "Zap2Xml Information has downloaded.";
        }

        /// <summary>
        /// This section contains the code for sending setup commands.
        /// The screen controls are located in the Commands Tab.
        /// </summary>

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Save_Prevue_Data(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Reset_Prevue_Software(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void SendManualBoxOn_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
        }

        private void SendManualBoxOff_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void Version_Check_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Version_Check(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void SendClockData_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Clock(serialPort1, clock);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void Send_DST_G2_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.DST_Data(serialPort1, "2", clock);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void Send_DST_G3_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.DST_Data(serialPort1, "3", clock);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void WeatherID_Send_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Weather_ID(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }
        private void TopLineSendBtn_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Top_Line(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void BottomLineSendBtn_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            toolStripStatusLabel1.Text = cmd.Bottom_Line(serialPort1);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }
        private void UtilityCommand_Click(object sender, EventArgs e)
        {
            char[] commandfamily = new char[] { Convert.ToChar(textBox114.Text) };
            string member = textBox115.Text;
            string submember = textBox116.Text;

            List<char> list = new List<char>();
            list.AddRange(commandfamily);
            list.AddRange(member.ToCharArray());
            list.AddRange(submember.ToCharArray());

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                net.TransmitNetworkMessage("utility", body);
                net.TransmitNetworkMessage("box off", empty);
                toolStripStatusLabel1.Text = "Utility command sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(serialPort1, "utility", body);
                s.TransmitMessage(serialPort1, "box off", empty);
                toolStripStatusLabel1.Text = "Utility command sent via serial.";
            }
            else
            {
                toolStripStatusLabel1.Text = "Error with Port Selected Setting - check code";
            }
        }



        /// <summary>
        /// This section contains the code for setting the user defined settings.
        /// The screen controls are located in the User Settings Tab.
        /// </summary>
        /// 
        private void UserSettings_InitializeTextFields()
        {
            if(User_Settings.Default.Port_Selected == 'T') 
            {
                TCP_IP_Button.Checked = true;
                Serial_Button.Checked = false;
                Server_TextBox.Enabled = true;
                Port_TextBox.Enabled = true;
                SerialPort_DropDownBox.Enabled = false;
            }
            else if(User_Settings.Default.Port_Selected == 'S') 
            {
                Serial_Button.Checked = true;
                TCP_IP_Button.Checked = false;
                Server_TextBox.Enabled = false;
                Port_TextBox.Enabled = false;
                SerialPort_DropDownBox.Enabled = true;
            }
            Server_TextBox.Text = User_Settings.Default.IP_Address;
            Port_TextBox.Text = User_Settings.Default.Port_Number;
            SerialPort_DropDownBox.SelectedIndex = SerialPort_DropDownBox.Items.IndexOf(User_Settings.Default.COMPort);

            SelectCode_TextBox.Text = User_Settings.Default.Select_Code;
            Version_TextBox.Text = User_Settings.Default.Current_Version;
            TZOffset_TextBox.Text = User_Settings.Default.TimeZoneOffset.ToString();
            Z2I_NbrOfDays_TextBox.Text = User_Settings.Default.DlNumberOfDays;
            Z2I_Username_TextBox.Text = User_Settings.Default.DlUsername;
            Z2I_Password_TextBox.Text = User_Settings.Default.DlPassword;

            CustomListing1_TextBox.Text = User_Settings.Default.CustomListing1;
            CustomListing2_TextBox.Text = User_Settings.Default.CustomListing2;

            WeatherIDTextBox.Text = User_Settings.Default.WeatherID;
            WeatherCityTextBox.Text = User_Settings.Default.WeatherCity;
            WeatherFreqComboBox.Text = User_Settings.Default.WeatherFrequency;
            WeatherParseCycleTextBox.Text = User_Settings.Default.WeatherParseCycle;

            EPG_TopLine_TextBox.Text = User_Settings.Default.TopLine;
            EPG_BottomLine_TextBox.Text = User_Settings.Default.BottomLine;      
        }

       private void ChangeSaveFolder_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            UserDataFolder data = new UserDataFolder();
            data.Select_UserDataFolder(User_Settings.Default.FirstRun, folderBrowserDialog1);
            RunAtStartup();
        }

        private void TCP_IP_Button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                User_Settings.Default.Port_Selected = 'T';
                User_Settings.Default.Save();
                Server_TextBox.Enabled = true;
                Port_TextBox.Enabled = true;
                SerialPort_DropDownBox.Enabled = false;
                serialPort1.Close();
            }
            catch
            {
                MessageBox.Show("Error setting TCPIP : ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void Serial_Button_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                User_Settings.Default.Port_Selected = 'S';
                User_Settings.Default.Save();
                Server_TextBox.Enabled = false;
                Port_TextBox.Enabled = false;
                SerialPort_DropDownBox.Enabled = true;
                serialPort1.Close();
                serialPort1.PortName = User_Settings.Default.COMPort;
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Error setting serial port: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }

        }
 
        private void SerialPort_DropDownBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Separated from other user settings to allow for on the fly changes to the serial port.
            try
            {
                serialPort1.Close();
                User_Settings.Default.COMPort = SerialPort_DropDownBox.SelectedItem.ToString();
                User_Settings.Default.Save();
                serialPort1.PortName = User_Settings.Default.COMPort;
                serialPort1.Open();
            }
            catch
            {
                MessageBox.Show("Error setting serial port: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);
            }
        }        
        
        private void UpdateUserSettings_Click(object sender, EventArgs e)
        {
            if (User_Settings.Default.Port_Selected == 'T')
            {
                try
                {
                    User_Settings.Default.IP_Address = Server_TextBox.Text;
                    User_Settings.Default.Port_Number = Port_TextBox.Text;
                    User_Settings.Default.Save();
                }
                catch
                {
                    MessageBox.Show("Error setting network: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
            }

            User_Settings.Default.Select_Code = SelectCode_TextBox.Text;
            User_Settings.Default.Current_Version = Version_TextBox.Text;
            User_Settings.Default.TimeZoneOffset = Convert.ToInt16(TZOffset_TextBox.Text);
            User_Settings.Default.DlNumberOfDays = Z2I_NbrOfDays_TextBox.Text;
            User_Settings.Default.DlUsername = Z2I_Username_TextBox.Text;
            User_Settings.Default.DlPassword = Z2I_Password_TextBox.Text;
            User_Settings.Default.CustomListing1 = CustomListing1_TextBox.Text;
            User_Settings.Default.CustomListing2 = CustomListing2_TextBox.Text;
            User_Settings.Default.WeatherFrequency = WeatherFreqComboBox.Text;
            User_Settings.Default.WeatherID = WeatherIDTextBox.Text;
            User_Settings.Default.WeatherCity = WeatherCityTextBox.Text;
            User_Settings.Default.WeatherParseCycle = WeatherParseCycleTextBox.Text;
            User_Settings.Default.TopLine = EPG_TopLine_TextBox.Text;
            User_Settings.Default.BottomLine = EPG_BottomLine_TextBox.Text;

            User_Settings.Default.Save();
            toolStripStatusLabel1.Text = "User Settings have been updated.";
        }


        /// <summary>
        /// This section contains the code for receiving weather data.
        /// The screen controls are located in the Weather Tab.
        /// 
        /// </summary>

        private void Weather_TextBoxDisplay()
        {
            Weather_Display disp = new Weather_Display();
            textBox14.Text = disp.Icon.ToString();
            textBox17.Text = disp.Sky;
            textBox86.Text = disp.Weather;
            textBox18.Text = disp.Temp;
            textBox84.Text = disp.Wind;
            textBox83.Text = disp.Pressure;
            textBox82.Text = disp.Humidity;
            textBox6.Text =  disp.DewPoint;
            textBox85.Text = disp.Visibility;
        }

        private void SendWeatherData_Click(object sender, EventArgs e)
        {
            WeatherData w = new WeatherData();
            w.Weather_GetData();
            Weather_TextBoxDisplay();
            toolStripStatusLabel1.Text = w.Weather_SendData(serialPort1);
        }

        private void WeatherUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Verify if the time didn't pass.
            if ((wu_minutes == 0) && (wu_seconds == 0))
            {
                WeatherData w = new WeatherData();
                // If the time is over, clear all settings and fields.
                button16.Enabled = false;
                button17.Enabled = true;
                label91.Text = "Downloading Update";
                w.Weather_GetData();
                Weather_TextBoxDisplay();
                toolStripStatusLabel1.Text = w.Weather_SendData(serialPort1);
                wu_minutes = Convert.ToInt32(User_Settings.Default.WeatherParseCycle);
            }
            else
            {
                // Else continue counting.
                if (wu_seconds < 1)
                {
                    wu_seconds = 59;
                    wu_minutes -= 1;
                }
                else
                    wu_seconds -= 1;

                if (wu_seconds < 10) { label91.Text = wu_minutes.ToString() + ":0" + wu_seconds.ToString(); }
                else label91.Text = wu_minutes.ToString() + ":" + wu_seconds.ToString();
            }
        }

        private void StartWeatherDataTimer(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            button16.Enabled = false;
            button17.Enabled = true;
        }

        private void StopWeatherDataTimer(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            button16.Enabled = true;
            button17.Enabled = false;
        }

        /// <summary>
        /// This section contains the code for the Configuration set up and sending.
        /// The screen controls are located in the Config and Config 2 Tabs.
        /// 
        /// </summary>
       
        private void ReadConfigurationFile()
        {
            Calc c = new Calc();

            // Old Config Settings

            //Timeslot Backward Display  
            textBox2.Text = PrevueOldConfig.Default.TimeSlot_Backward_Display;
            //Timeslot Forward Display
            textBox3.Text = PrevueOldConfig.Default.Timeslot_Forward_Display;
            //Scroll Speed
            textBox4.Text = PrevueOldConfig.Default.Scroll_Speed.ToString();
            //Num. Text Ads
            textBox5.Text = PrevueOldConfig.Default.Number_of_Text_Ads.ToString();
            //Num. Text Ad Lines
            textBox7.Text = PrevueOldConfig.Default.Number_of_Text_Ad_Lines.ToString();
            //Ignore National Ads Flag / Crawl
            textBox8.Text = c.ConvertTestValue(PrevueOldConfig.Default.Ignore_National_Ads_Flag, "Y", "N");
            //Before Timeslot Minutes
            textBox9.Text = PrevueOldConfig.Default.Before_TimeSlot_Minutes.ToString();
            //After Timeslot Minutes
            textBox22.Text = PrevueOldConfig.Default.After_TimeSlot_Minutes.ToString();
            //Time Zone
            textBox28.Text = PrevueOldConfig.Default.Time_Zone.ToString();
            //Observe DST Flag
            textBox29.Text =  c.ConvertTestValue(PrevueOldConfig.Default.Observe_DST_Flag, "Y", "N");
            //Continued Flag
            textBox30.Text = c.ConvertTestValue(PrevueOldConfig.Default.Continued_Flag, "Y", "N");         
            //Keyboard Flag
            textBox31.Text = c.ConvertTestValue(PrevueOldConfig.Default.Keyboard_Flag, "Y", "N");
            //10 Minute Window
            textBox32.Text = c.ConvertTestValue(PrevueOldConfig.Default.Ten_Minute_Window, "Y", "N");
            //3 Minute Window
            textBox33.Text = c.ConvertTestValue(PrevueOldConfig.Default.Three_Minute_Window, "Y", "N");
            //Ignore VCR Plus Flag / Movie summary Pay
            textBox34.Text = c.ConvertTestValue(PrevueOldConfig.Default.Ignore_VCR_Plus_Flag, "Y", "N");
            //Laser Format / Movie Summary
            textBox35.Text = PrevueOldConfig.Default.Laser_Format.ToString();
            //Graphic Ads Enabled Flag
            textBox36.Text = PrevueOldConfig.Default.Graphic_Ads_Enabled_Flag.ToString();
            //Video Insertion Enabled Flag
            textBox37.Text = PrevueOldConfig.Default.Video_Insertion_Enabled_Flag.ToString();
            //Time Zone Minutes Adjustment
            textBox38.Text = PrevueOldConfig.Default.Time_Zone_Minutes_Adjustment.ToString();
                    
            // New Config Settings

            //f.Grid_Hold_Time
            textBox39.Text = PrevueConfig.Default.Grid_Hold_Time.ToString();
            //f.Grid_Source_Channel_Order
            textBox40.Text = PrevueConfig.Default.Grid_Source_Channel_Order.ToString();
            //f.Grid_Movie_Recap_Frequency
            textBox41.Text = PrevueConfig.Default.Grid_Movie_Recap_Frequency.ToString();
            //f.Grid_SBS_Frequency
            textBox42.Text = PrevueConfig.Default.Grid_SBS_Frequency.ToString();
            //f.Grid_SBS_TimeSlot_LookAhead
            textBox43.Text = PrevueConfig.Default.Grid_SBS_TimeSlot_LookAhead.ToString();
            //f.Scroll_SBS_TimeSlot_LookAhead
            textBox44.Text = PrevueConfig.Default.Scroll_SBS_TimeSlot_LookAhead.ToString();
            //f.Display_Format
            textBox45.Text = PrevueConfig.Default.Display_Format.ToString();
            //f.Advue_Insertion
            textBox46.Text = c.ConvertTestValue(PrevueConfig.Default.Advue_Insertion, "Y", "N");
            //f.Pie_Format
            textBox47.Text = PrevueConfig.Default.Pie_Format.ToString();
            //f.Language
            textBox48.Text = PrevueConfig.Default.Language.ToString();
            //f.Prime_Time_Summary_Frequency
            textBox49.Text = PrevueConfig.Default.Prime_Time_Summary_Frequency.ToString();
            //f.Sports_Summary_Frequency
            textBox50.Text = PrevueConfig.Default.Sports_Summary_Frequency.ToString();
            //f.Grid_SBS_Roll_and_Hold
            textBox51.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_SBS_Roll_and_Hold, "Y", "N");
            //f.Grid_Movie_Recap_Roll_and_Hold
            textBox52.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Movie_Recap_Roll_and_Hold, "Y", "N");
            //f.Grid_Prime_Time_Roll_and_Hold
            textBox53.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Prime_Time_Roll_and_Hold, "Y", "N");
            //f.Grid_Sports_Summary_Roll_and_Hold
            textBox54.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Sports_Summary_Roll_and_Hold, "Y", "N");
            //f.Grid_Roll_and_Hold
            textBox55.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Roll_and_Hold, "Y", "N");
            //f.VideoVue_Insertion
            textBox56.Text = c.ConvertTestValue(PrevueConfig.Default.VideoVue_Insertion, "Y", "N");
            //f.Laser_Insertion_Type
            textBox57.Text = PrevueConfig.Default.Laser_Insertion_Type.ToString();
            //f.Prime_Time_Starting_TimeSlot
            textBox58.Text = PrevueConfig.Default.Prime_Time_Starting_TimeSlot.ToString();
            //f.Prime_Time_LookAhead_TimeSlots
            textBox59.Text = PrevueConfig.Default.Prime_Time_LookAhead_TimeSlots.ToString();
            //f.Cycle_Summary_Info
            textBox60.Text = c.ConvertTestValue(PrevueConfig.Default.Cycle_Summary_Info, "Y", "N");
            //f.Grid_Synopsis
            textBox61.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Synopsis, "Y", "N");
            //f.Grid_Synopsis_Roll_and_Hold
            textBox62.Text = c.ConvertTestValue(PrevueConfig.Default.Grid_Synopsis_Roll_and_Hold, "Y", "N");
            //f.Prime_Time_Promotion_Start_TimeSlot
            textBox63.Text = PrevueConfig.Default.Prime_Time_Promotion_Start_TimeSlot.ToString();
            //f.Prime_Time_Promotion_End_TimeSlot
            textBox64.Text = PrevueConfig.Default.Prime_Time_Promotion_End_TimeSlot.ToString();
            //f.Sports_Summary_LookAhead
            textBox65.Text = PrevueConfig.Default.Sports_Summary_LookAhead.ToString();
            //f.PPV_Display_After_PGM_Start
            textBox66.Text = PrevueConfig.Default.PPV_Display_After_PGM_Start.ToString();
            //f.Cycle_Summary_Frequency
            textBox67.Text = PrevueConfig.Default.Cycle_Summary_Frequency.ToString();
            //f.System_Default_Brush_ID
            textBox68.Text = PrevueConfig.Default.System_Default_Brush_ID.ToString();
            //f.Weather_Roll_and_Hold
            textBox69.Text = c.ConvertTestValue(PrevueConfig.Default.Weather_Roll_and_Hold, "Y", "N");
            //f.Military_Time_Flag
            textBox70.Text = c.ConvertTestValue(PrevueConfig.Default.Military_Time_Flag, "Y", "N");
            //f.Cleanup_Unused_Logos
            textBox71.Text = c.ConvertTestValue(PrevueConfig.Default.Cleanup_Unused_Logos, "Y", "N");
            //f.Display_Length_Setting
            textBox72.Text = PrevueConfig.Default.Display_Length_Setting.ToString();
            //f.Custom_Display_Length
            textBox73.Text = PrevueConfig.Default.Custom_Display_Length.ToString();
            //f.Number_of_Colors
            textBox74.Text = PrevueConfig.Default.Number_of_Colors.ToString();
            //f.Text_Ad_Flag
            textBox75.Text = PrevueConfig.Default.Text_Ad_Flag.ToString();
            //f.PC_Disk_Support
            textBox76.Text = c.ConvertTestValue(PrevueConfig.Default.PC_Disk_Support, "Y", "N");
            //f.Retail_Trade_Zone_Audio
            textBox77.Text = PrevueConfig.Default.Retail_Trade_Zone_Audio.ToString();
            //f.Flexible_Grid
            textBox78.Text = c.ConvertTestValue(PrevueConfig.Default.Flexible_Grid, "Y", "N");
            //f.Retail_Trade_Zone_System
            textBox79.Text = PrevueConfig.Default.Retail_Trade_Zone_System.ToString();
            //f.Clock_Command
            textBox80.Text = PrevueConfig.Default.Clock_Command.ToString();
        }

        private void Config_UpdateEntries_Click(object sender, EventArgs e)
        {
            Calc c = new Calc();
            PrevueOldConfig.Default.TimeSlot_Backward_Display = textBox2.Text;
            PrevueOldConfig.Default.Timeslot_Forward_Display = textBox3.Text;
            PrevueOldConfig.Default.Scroll_Speed = Convert.ToInt16(textBox4.Text);
            PrevueOldConfig.Default.Number_of_Text_Ads = Convert.ToInt16(textBox5.Text);
            PrevueOldConfig.Default.Number_of_Text_Ad_Lines = Convert.ToInt16(textBox7.Text);
            // Crawl
            PrevueOldConfig.Default.Ignore_National_Ads_Flag = c.ConvertValueTest(textBox8.Text, "Y", "N");
            PrevueOldConfig.Default.Before_TimeSlot_Minutes = Convert.ToInt16(textBox9.Text);
            PrevueOldConfig.Default.After_TimeSlot_Minutes = Convert.ToInt16(textBox22.Text);
            PrevueOldConfig.Default.Time_Zone = Convert.ToInt16(textBox28.Text);
            PrevueOldConfig.Default.Observe_DST_Flag = c.ConvertValueTest(textBox29.Text, "Y", "N");
            PrevueOldConfig.Default.Continued_Flag = c.ConvertValueTest(textBox30.Text, "Y", "N");
            PrevueOldConfig.Default.Keyboard_Flag = c.ConvertValueTest(textBox31.Text, "Y", "N");
            PrevueOldConfig.Default.Ten_Minute_Window = c.ConvertValueTest(textBox32.Text, "Y", "N");
            PrevueOldConfig.Default.Three_Minute_Window = c.ConvertValueTest(textBox33.Text, "Y", "N");
            //Movie summary Pay
            PrevueOldConfig.Default.Ignore_VCR_Plus_Flag = c.ConvertValueTest(textBox34.Text, "Y", "N");
            //Movie Summary
            PrevueOldConfig.Default.Laser_Format = textBox35.Text;
            PrevueOldConfig.Default.Graphic_Ads_Enabled_Flag = textBox36.Text;
            PrevueOldConfig.Default.Video_Insertion_Enabled_Flag = textBox37.Text;
            PrevueOldConfig.Default.Time_Zone_Minutes_Adjustment = Convert.ToInt16(textBox38.Text);
            PrevueOldConfig.Default.Save();

            // New Config Settings

            PrevueConfig.Default.Grid_Hold_Time = Convert.ToInt16(textBox39.Text); 
            PrevueConfig.Default.Grid_Source_Channel_Order = textBox40.Text;
            PrevueConfig.Default.Grid_Movie_Recap_Frequency = Convert.ToInt16(textBox41.Text);
            PrevueConfig.Default.Grid_SBS_Frequency = Convert.ToInt16(textBox42.Text);
            PrevueConfig.Default.Grid_SBS_TimeSlot_LookAhead = Convert.ToInt16(textBox43.Text);
            PrevueConfig.Default.Scroll_SBS_TimeSlot_LookAhead = Convert.ToInt16(textBox44.Text);
            PrevueConfig.Default.Display_Format = textBox45.Text;
            PrevueConfig.Default.Advue_Insertion = c.ConvertValueTest(textBox46.Text, "Y", "N");
            PrevueConfig.Default.Pie_Format = textBox47.Text;
            PrevueConfig.Default.Language = textBox48.Text;
            PrevueConfig.Default.Prime_Time_Summary_Frequency = Convert.ToInt16(textBox49.Text);
            PrevueConfig.Default.Sports_Summary_Frequency = Convert.ToInt16(textBox50.Text);
            PrevueConfig.Default.Grid_SBS_Roll_and_Hold = c.ConvertValueTest(textBox51.Text, "Y", "N");
            PrevueConfig.Default.Grid_Movie_Recap_Roll_and_Hold = c.ConvertValueTest(textBox52.Text, "Y", "N");
            PrevueConfig.Default.Grid_Prime_Time_Roll_and_Hold = c.ConvertValueTest(textBox53.Text, "Y", "N");
            PrevueConfig.Default.Grid_Sports_Summary_Roll_and_Hold = c.ConvertValueTest(textBox54.Text, "Y", "N");
            PrevueConfig.Default.Grid_Roll_and_Hold = c.ConvertValueTest(textBox55.Text, "Y", "N");
            PrevueConfig.Default.VideoVue_Insertion = c.ConvertValueTest(textBox56.Text, "Y", "N");
            PrevueConfig.Default.Laser_Insertion_Type = textBox57.Text;
            PrevueConfig.Default.Prime_Time_Starting_TimeSlot = Convert.ToInt16(textBox58.Text);
            PrevueConfig.Default.Prime_Time_LookAhead_TimeSlots = Convert.ToInt16(textBox59.Text);
            PrevueConfig.Default.Cycle_Summary_Info = c.ConvertValueTest(textBox60.Text, "Y", "N");
            PrevueConfig.Default.Grid_Synopsis = c.ConvertValueTest(textBox61.Text, "Y", "N");
            PrevueConfig.Default.Grid_Synopsis_Roll_and_Hold = c.ConvertValueTest(textBox62.Text, "Y", "N");
            PrevueConfig.Default.Prime_Time_Promotion_Start_TimeSlot = Convert.ToInt16(textBox63.Text);
            PrevueConfig.Default.Prime_Time_Promotion_End_TimeSlot = Convert.ToInt16(textBox64.Text);
            PrevueConfig.Default.Sports_Summary_LookAhead = Convert.ToInt16(textBox65.Text);
            PrevueConfig.Default.PPV_Display_After_PGM_Start = Convert.ToInt16(textBox66.Text);
            PrevueConfig.Default.Cycle_Summary_Frequency = Convert.ToInt16(textBox67.Text);
            PrevueConfig.Default.System_Default_Brush_ID = textBox68.Text;
            PrevueConfig.Default.Weather_Roll_and_Hold = c.ConvertValueTest(textBox69.Text, "Y", "N");
            PrevueConfig.Default.Military_Time_Flag = c.ConvertValueTest(textBox70.Text, "Y", "N");
            PrevueConfig.Default.Cleanup_Unused_Logos = c.ConvertValueTest(textBox71.Text, "Y", "N");
            PrevueConfig.Default.Display_Length_Setting = textBox72.Text;
            PrevueConfig.Default.Custom_Display_Length = Convert.ToInt16(textBox73.Text);
            PrevueConfig.Default.Number_of_Colors = Convert.ToInt16(textBox74.Text);
            PrevueConfig.Default.Text_Ad_Flag = textBox75.Text;
            PrevueConfig.Default.PC_Disk_Support = c.ConvertValueTest(textBox76.Text, "Y", "N");
            PrevueConfig.Default.Retail_Trade_Zone_Audio = textBox77.Text;
            PrevueConfig.Default.Flexible_Grid = c.ConvertValueTest(textBox78.Text, "Y", "N");
            PrevueConfig.Default.Retail_Trade_Zone_System = textBox79.Text;
            PrevueConfig.Default.Clock_Command = Convert.ToInt16(textBox80.Text);
            
            PrevueConfig.Default.Save();
        }

        private void SendOldConfig_Click(object sender, EventArgs e)
        {        
            //DataTable config = ConfigDataSet.Tables["Config"];            
            List<char> list = new List<char>();
            Calc c = new Calc();
            //Timeslot Backward Display
            //PrevueOldConfig.Default.TimeSlot_Backward_Display
            list.AddRange(PrevueOldConfig.Default.TimeSlot_Backward_Display);

            //Timeslot Forward Display
            //PrevueOldConfig.Default.Timeslot_Forward_Display
            list.AddRange(PrevueOldConfig.Default.Timeslot_Forward_Display);
            
            //Scroll Speed
            //PrevueOldConfig.Default.Scroll_Speed
            list.AddRange(PrevueOldConfig.Default.Scroll_Speed.ToString());
            
            //Num. Text Ads
            //PrevueOldConfig.Default.Number_of_Text_Ads
            list.AddRange(PrevueOldConfig.Default.Number_of_Text_Ads.ToString().PadLeft(2, '0'));
            
            //Num. Text Ad Lines
            //PrevueOldConfig.Default.Number_of_Text_Ad_Lines
            list.AddRange(PrevueOldConfig.Default.Number_of_Text_Ad_Lines.ToString());
            
            //Ignore National Ads Flag / Crawl
            //PrevueOldConfig.Default.Ignore_National_Ads_Flag
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Ignore_National_Ads_Flag, "Y", "N"));
            
            //Before Timeslot Minutes
            //PrevueOldConfig.Default.Before_TimeSlot_Minutes
            list.AddRange(Convert.ToChar(PrevueOldConfig.Default.Before_TimeSlot_Minutes).ToString());
            
            //After Timeslot Minutes
            //PrevueOldConfig.Default.After_TimeSlot_Minutes
            list.AddRange(Convert.ToChar(PrevueOldConfig.Default.After_TimeSlot_Minutes).ToString());
            
            //Time Zone
            //PrevueOldConfig.Default.Time_Zone
            list.AddRange(PrevueOldConfig.Default.Time_Zone.ToString());
            
            //Observe DST Flag
            // PrevueOldConfig.Default.Observe_DST_Flag
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Observe_DST_Flag, "Y", "N"));
            
            //Continued Flag
            //PrevueOldConfig.Default.Continued_Flag
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Continued_Flag, "Y", "N"));
            
            //Keyboard Flag
            //PrevueOldConfig.Default.Keyboard_Flag
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Keyboard_Flag, "Y", "N"));
            
            //10 Minute Window
            //PrevueOldConfig.Default.Ten_Minute_Window
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Ten_Minute_Window, "Y", "N"));
            
            //3 Minute Window
            //PrevueOldConfig.Default.Three_Minute_Window
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Three_Minute_Window, "Y", "N"));
            
            //Ignore VCR Plus Flag / Movie summary Pay
            //PrevueOldConfig.Default.Ignore_VCR_Plus_Flag
            list.AddRange(c.ConvertTestValue(PrevueOldConfig.Default.Ignore_VCR_Plus_Flag, "Y", "N"));
            
            //Laser Format / Movie Summary
            //PrevueOldConfig.Default.Laser_Format
            list.AddRange(PrevueOldConfig.Default.Laser_Format);
            
            //Graphic Ads Enabled Flag
            //PrevueOldConfig.Default.Graphic_Ads_Enabled_Flag
            list.AddRange(PrevueOldConfig.Default.Graphic_Ads_Enabled_Flag);
            
            //Video Insertion Enabled Flag
            //PrevueOldConfig.Default.Video_Insertion_Enabled_Flag
            list.AddRange(PrevueOldConfig.Default.Video_Insertion_Enabled_Flag);
            
            //Time Zone Minutes Adjustment
            //PrevueOldConfig.Default.Time_Zone_Minutes_Adjustment
            list.AddRange(Convert.ToChar(PrevueOldConfig.Default.Time_Zone_Minutes_Adjustment).ToString());

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                net.TransmitNetworkMessage("config", body);
                net.TransmitNetworkMessage("box off", empty);
                toolStripStatusLabel1.Text = "Old config Information sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(serialPort1, "config", body);
                s.TransmitMessage(serialPort1, "box off", empty);

                toolStripStatusLabel1.Text = "Old config Information sent via serial";
            }
            else
            {
                toolStripStatusLabel1.Text = "Error with Port Selected Setting - check code";
            }
        }

        private void SendNewConfig_Click(object sender, EventArgs e)
        {
            Calc c = new Calc();

            List<char> list = new List<char>();
            //list.AddRange("\u0000"); //command family = 1 for ASCII
            //list.AddRange("\u0000\u0036"); //length of command including checksum

            //PrevueConfig.Default.Grid_Hold_Time
            list.AddRange(PrevueConfig.Default.Grid_Hold_Time.ToString());

            //PrevueConfig.Default.Grid_Source_Channel_Order
            list.AddRange(PrevueConfig.Default.Grid_Source_Channel_Order);
            
            //PrevueConfig.Default.Grid_Movie_Recap_Frequency
            list.AddRange(PrevueConfig.Default.Grid_Movie_Recap_Frequency.ToString());

            //PrevueConfig.Default.Grid_SBS_Frequency
            list.AddRange(PrevueConfig.Default.Grid_SBS_Frequency.ToString());

            //PrevueConfig.Default.Grid_SBS_TimeSlot_LookAhead
            list.AddRange(PrevueConfig.Default.Grid_SBS_TimeSlot_LookAhead.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Scroll_SBS_TimeSlot_LookAhead
            list.AddRange(PrevueConfig.Default.Scroll_SBS_TimeSlot_LookAhead.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Display_Format
            list.AddRange(PrevueConfig.Default.Display_Format);

            //PrevueConfig.Default.Advue_Insertion
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Advue_Insertion, "Y", "N"));

            //PrevueConfig.Default.Pie_Format
            list.AddRange(PrevueConfig.Default.Pie_Format);

            //PrevueConfig.Default.Language
            list.AddRange(PrevueConfig.Default.Language);

            //PrevueConfig.Default.Prime_Time_Summary_Frequency
            list.AddRange(PrevueConfig.Default.Prime_Time_Summary_Frequency.ToString());

            //PrevueConfig.Default.Sports_Summary_Frequency
            list.AddRange(PrevueConfig.Default.Sports_Summary_Frequency.ToString());

            //PrevueConfig.Default.Grid_SBS_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_SBS_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.Grid_Movie_Recap_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Movie_Recap_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.Grid_Prime_Time_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Prime_Time_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.Grid_Sports_Summary_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Sports_Summary_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.Grid_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.VideoVue_Insertion
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.VideoVue_Insertion, "Y", "N"));

            //PrevueConfig.Default.Laser_Insertion_Type
            list.AddRange(PrevueConfig.Default.Laser_Insertion_Type);

            //PrevueConfig.Default.Prime_Time_Starting_TimeSlot
            list.AddRange(PrevueConfig.Default.Prime_Time_Starting_TimeSlot.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Prime_Time_LookAhead_TimeSlots
            list.AddRange(PrevueConfig.Default.Prime_Time_LookAhead_TimeSlots.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Cycle_Summary_Info
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Cycle_Summary_Info, "Y", "N"));

            //PrevueConfig.Default.Grid_Synopsis
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Synopsis, "Y", "N"));

            //PrevueConfig.Default.Grid_Synopsis_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Grid_Synopsis_Roll_and_Hold, "Y", "N"));

            //PrevueConfig.Default.Prime_Time_Promotion_Start_TimeSlot
            list.AddRange(PrevueConfig.Default.Prime_Time_Promotion_Start_TimeSlot.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Prime_Time_Promotion_End_TimeSlot
            list.AddRange(PrevueConfig.Default.Prime_Time_Promotion_End_TimeSlot.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.Sports_Summary_LookAhead
            list.AddRange(PrevueConfig.Default.Sports_Summary_LookAhead.ToString().PadLeft(2, '0'));

            //PrevueConfig.Default.PPV_Display_After_PGM_Start
            list.AddRange(PrevueConfig.Default.PPV_Display_After_PGM_Start.ToString().PadLeft(3, '0'));

            //PrevueConfig.Default.Cycle_Summary_Frequency
            list.AddRange(PrevueConfig.Default.Cycle_Summary_Frequency.ToString());

            //PrevueConfig.Default.System_Default_Brush_ID
            list.AddRange(PrevueConfig.Default.System_Default_Brush_ID);

            //PrevueConfig.Default.Weather_Roll_and_Hold
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Weather_Roll_and_Hold, "Y", "N"));
            
            //PrevueConfig.Default.Military_Time_Flag
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Military_Time_Flag, "Y", "N"));

            //PrevueConfig.Default.Cleanup_Unused_Logos
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Cleanup_Unused_Logos, "Y", "N"));

            //PrevueConfig.Default.Display_Length_Setting
            list.AddRange(PrevueConfig.Default.Display_Length_Setting);

            //PrevueConfig.Default.Custom_Display_Length
            list.AddRange(Convert.ToChar(PrevueConfig.Default.Custom_Display_Length).ToString());

            //PrevueConfig.Default.Number_of_Colors
            //list.AddRange(Convert.ToChar(PrevueConfig.Default.Number_of_Colors).ToString());
            list.AddRange(PrevueConfig.Default.Number_of_Colors.ToString());

            //PrevueConfig.Default.Text_Ad_Flag
            list.AddRange(PrevueConfig.Default.Text_Ad_Flag);

            //PrevueConfig.Default.PC_Disk_Support
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.PC_Disk_Support, "Y", "N"));

            //PrevueConfig.Default.Retail_Trade_Zone_Audio
            list.AddRange(PrevueConfig.Default.Retail_Trade_Zone_Audio);

            //PrevueConfig.Default.Flexible_Grid
            list.AddRange(c.ConvertTestValue(PrevueConfig.Default.Flexible_Grid, "Y", "N"));

            //PrevueConfig.Default.Retail_Trade_Zone_System
            list.AddRange(PrevueConfig.Default.Retail_Trade_Zone_System);

            //PrevueConfig.Default.Clock_Command
            list.AddRange(PrevueConfig.Default.Clock_Command.ToString());

            char[] body = list.ToArray();

            if (User_Settings.Default.Port_Selected == 'T')
            {
                Network net = new Network();
                net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                net.TransmitNewLookNetworkMessage("new config", body);
                net.TransmitNetworkMessage("box off", empty);
                toolStripStatusLabel1.Text = "New Config Information sent via TCP/IP";
            }
            else if (User_Settings.Default.Port_Selected == 'S')
            {
                Serial s = new Serial();
                s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
                s.TransmitMessage(serialPort1, "new config", body);
                s.TransmitMessage(serialPort1, "box off", empty);

                toolStripStatusLabel1.Text = "New Config Information sent via serial";
            }
            else
            {
                toolStripStatusLabel1.Text = "Error with Port Selected Setting - check code";
            }



        }



        private void QTable_FormatDataGridView()
        {
            QTable_DGV.Columns[0].Width = 80;
            QTable_DGV.Columns[1].Width = 295;
            QTable_DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn dc in QTable_DGV.Columns)
            {
                //dc.Width = 50;
                dc.SortMode = DataGridViewColumnSortMode.NotSortable;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void Update_QTable_Entry_Click(object sender, EventArgs e)
        {
            DataTable QTable = QTableDataSet.Tables["QTable"];
            QTable.AcceptChanges();
            QTableFile qtable = new QTableFile();
            qtable.WriteQTableFile(QTable);

            toolStripStatusLabel1.Text = "Entries have been updated to Q Table.";
        }

        private void Delete_QTable_Entry_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Would you like to to delete the selected entries?", "My Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable QTable = QTableDataSet.Tables["QTable"];

                foreach (DataGridViewRow item in this.QTable_DGV.SelectedRows)
                {
                    QTable_DGV.Rows.RemoveAt(item.Index);
                }
                QTable.AcceptChanges();
                QTableFile qtable = new QTableFile();
                qtable.WriteQTableFile(QTable);
                toolStripStatusLabel1.Text = "Selected Q Table entries have been deleted.";
            }
            else
            {
                toolStripStatusLabel1.Text = "No Q Table entries have been deleted.";
            }

        }

        private void Send_QTable_Click(object sender, EventArgs e)
        {
            string QTablefilename = User_Settings.Default.FolderPath + @"\qtable.txt";

            if (File.Exists(QTablefilename))
            {
                DataTable QTable = QTableDataSet.Tables["QTable"];
                List<char> list = new List<char>();

                for (int counter = 0; counter < QTable.Rows.Count; counter++)
                {
                    string srrc = QTable.Rows[counter]["QTSource"].ToString();
                    string name = QTable.Rows[counter]["QTName"].ToString();
                    char[] Source = srrc.ToCharArray();
                    char[] ChName = name.ToCharArray();

                    list.AddRange(Source);
                    list.AddRange("\x09");
                    list.AddRange("\x18");
                    list.AddRange(ChName);
                    list.AddRange("\x0d");
                    list.AddRange("\x0a");

                }
                list.AddRange("\x1a");
                char[] body = list.ToArray();

                if (User_Settings.Default.Port_Selected == 'T')
                {
                    Network net = new Network();
                    net.TransmitNetworkMessage("box on", User_Settings.Default.Select_Code.ToCharArray());
                    net.TransmitNetworkMessage("qtable", body);
                    net.TransmitNetworkMessage("box off", empty);
                    toolStripStatusLabel1.Text = "New Config Information sent via TCP/IP";
                }
                else if (User_Settings.Default.Port_Selected == 'S')
                {
                    Serial s = new Serial();
                    s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
                    s.TransmitMessage(serialPort1, "qtable", body);
                    s.TransmitMessage(serialPort1, "box off", empty);
                    toolStripStatusLabel1.Text = "Q Table sent over serial port";

                }
                else
                {
                    toolStripStatusLabel1.Text = "Error with Port Selected Setting - check code";
                }



            }

        }

        //Experimental Work


        private void Button26_Click(object sender, EventArgs e)
        {
            Command cmd = new Command();
            toolStripStatusLabel1.Text = cmd.Box_On(serialPort1);
            LineupBuild lineup = new LineupBuild();
            toolStripStatusLabel1.Text = lineup.SendLineupAttr(serialPort1, LineupDataSet.Tables["Lineup"], clock.CurrentPrevueDayOfYear);
            toolStripStatusLabel1.Text = cmd.Box_Off(serialPort1);
        }

        private void BuildQTable_Click(object sender, EventArgs e)
        {
            Serial s = new Serial();

            string string1 = "XYZ	I'm am the greatestsinceCassiou Clay ";
            string string2 = " XY1	I'm am the greatestsinceCassiou Clay1 ";

            List<char> list = new List<char>();
            list.AddRange(string1.ToCharArray());
            list.AddRange(string2.ToCharArray());
            char[] body = list.ToArray();

            s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
            s.TransmitMessage(serialPort1, "qtable", body);
            s.TransmitMessage(serialPort1, "box off", empty);

            toolStripStatusLabel1.Text = "QTable build command sent via serial";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Serial s = new Serial();

            //char[] info = new char[] { '\x04','\u0095','N','0','1','0','0','2','\x12','\x01','\x18','W','A','T','C','H','\x19','T','H','E',' ','P','R','E','V','U','E',' ','G','U','I','D','E','\x18','1','-','9','9','9','-','9','9','9','-','9','9','9','9' };

            char[] jdate = new char[] { Convert.ToChar(1) };
            string title = "YOU ARE WATCHING PREVUE GUIDE";
            char[] titlearray = title.ToCharArray();
            char[] flag1 = new char[] { Convert.ToChar(18) };
            string source = "PRE001";
            char[] sourceid = source.ToCharArray();
            char[] flag2 = new char[] { Convert.ToChar(1) };
            char[] value1 = new char[] { Convert.ToChar(168) };
            char[] flag3 = new char[] { Convert.ToChar(1) };
            char[] value2 = new char[] { Convert.ToChar(169) };
            char[] flag4 = new char[] { Convert.ToChar(1) };
            char[] value3 = new char[] { Convert.ToChar(170) };

            List<char> list = new List<char>();
            list.AddRange(jdate);
            list.AddRange(titlearray);
            list.AddRange(flag1);
            list.AddRange(sourceid);
            list.AddRange(flag2);
            list.AddRange(value1);
            list.AddRange(flag3);
            list.AddRange(value2);
            list.AddRange(flag4);
            list.AddRange(value3);

            char[] body = list.ToArray();

            s.TransmitMessage(serialPort1, "box on", User_Settings.Default.Select_Code.ToCharArray());
            s.TransmitMessage(serialPort1, "new listing", body);
            s.TransmitMessage(serialPort1, "box off", empty);

            toolStripStatusLabel1.Text = "test sent via serial";
        }
    }
}

