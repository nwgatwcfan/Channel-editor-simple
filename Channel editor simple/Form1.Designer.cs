namespace PrevueDataSender 
{ 
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CurDateTime = new System.Windows.Forms.Label();
            this.CurrentDayofYear = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineupRtClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineupDataSet = new System.Data.DataSet();
            this.Lineup = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn102 = new System.Data.DataColumn();
            this.dataColumn105 = new System.Data.DataColumn();
            this.dataColumn106 = new System.Data.DataColumn();
            this.dataColumn107 = new System.Data.DataColumn();
            this.dataColumn108 = new System.Data.DataColumn();
            this.dataColumn116 = new System.Data.DataColumn();
            this.dataColumn117 = new System.Data.DataColumn();
            this.Z2ILineup = new System.Data.DataTable();
            this.dataColumn127 = new System.Data.DataColumn();
            this.dataColumn128 = new System.Data.DataColumn();
            this.dataColumn129 = new System.Data.DataColumn();
            this.dataColumn130 = new System.Data.DataColumn();
            this.dataColumn131 = new System.Data.DataColumn();
            this.dataColumn132 = new System.Data.DataColumn();
            this.dataColumn133 = new System.Data.DataColumn();
            this.dataColumn134 = new System.Data.DataColumn();
            this.dataColumn135 = new System.Data.DataColumn();
            this.dataColumn136 = new System.Data.DataColumn();
            this.dataColumn137 = new System.Data.DataColumn();
            this.dataColumn138 = new System.Data.DataColumn();
            this.dataColumn139 = new System.Data.DataColumn();
            this.dataColumn140 = new System.Data.DataColumn();
            this.dataColumn141 = new System.Data.DataColumn();
            this.dataColumn142 = new System.Data.DataColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ListingDataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.Z2IListings = new System.Data.DataTable();
            this.dataColumn122 = new System.Data.DataColumn();
            this.dataColumn123 = new System.Data.DataColumn();
            this.dataColumn124 = new System.Data.DataColumn();
            this.dataColumn125 = new System.Data.DataColumn();
            this.dataColumn126 = new System.Data.DataColumn();
            this.dataColumn143 = new System.Data.DataColumn();
            this.dataColumn144 = new System.Data.DataColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.WeatherDataSet = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn78 = new System.Data.DataColumn();
            this.dataColumn79 = new System.Data.DataColumn();
            this.dataColumn80 = new System.Data.DataColumn();
            this.dataColumn81 = new System.Data.DataColumn();
            this.dataColumn82 = new System.Data.DataColumn();
            this.dataColumn83 = new System.Data.DataColumn();
            this.dataColumn84 = new System.Data.DataColumn();
            this.dataColumn85 = new System.Data.DataColumn();
            this.dataColumn86 = new System.Data.DataColumn();
            this.dataColumn87 = new System.Data.DataColumn();
            this.dataColumn88 = new System.Data.DataColumn();
            this.dataColumn89 = new System.Data.DataColumn();
            this.dataColumn90 = new System.Data.DataColumn();
            this.QTableDataSet = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn91 = new System.Data.DataColumn();
            this.dataColumn92 = new System.Data.DataColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button26 = new System.Windows.Forms.Button();
            this.label108 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label102 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DayOfYear_Label = new System.Windows.Forms.Label();
            this.CurrentDayOfYear_Label = new System.Windows.Forms.Label();
            this.CurrentDayOfYear_TextBox = new System.Windows.Forms.TextBox();
            this.CurrentPrevueDay_TextBox = new System.Windows.Forms.TextBox();
            this.CustomListing2_TextBox = new System.Windows.Forms.TextBox();
            this.CustomListing1_TextBox = new System.Windows.Forms.TextBox();
            this.TZOffset_TextBox = new System.Windows.Forms.TextBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.Server_TextBox = new System.Windows.Forms.TextBox();
            this.WeatherParseCycleTextBox = new System.Windows.Forms.TextBox();
            this.WeatherCityTextBox = new System.Windows.Forms.TextBox();
            this.WeatherIDTextBox = new System.Windows.Forms.TextBox();
            this.Z2I_Password_TextBox = new System.Windows.Forms.TextBox();
            this.Z2I_Username_TextBox = new System.Windows.Forms.TextBox();
            this.Z2I_NbrOfDays_TextBox = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.EPG_BottomLine_TextBox = new System.Windows.Forms.TextBox();
            this.EPG_TopLine_TextBox = new System.Windows.Forms.TextBox();
            this.Version_TextBox = new System.Windows.Forms.TextBox();
            this.SelectCode_TextBox = new System.Windows.Forms.TextBox();
            this.CurrentPrevueDay_Label = new System.Windows.Forms.Label();
            this.CustomListing2_Label = new System.Windows.Forms.Label();
            this.CustomListing1_Label = new System.Windows.Forms.Label();
            this.TZOffset_Label = new System.Windows.Forms.Label();
            this.Serial_Button = new System.Windows.Forms.RadioButton();
            this.TCP_IP_Button = new System.Windows.Forms.RadioButton();
            this.Port_Label = new System.Windows.Forms.Label();
            this.IP_Address_Label = new System.Windows.Forms.Label();
            this.Port_Select_Label = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.WeatherDisplayLength_Label = new System.Windows.Forms.Label();
            this.WeatherFreqComboBox = new System.Windows.Forms.ComboBox();
            this.WeatherCity_Label = new System.Windows.Forms.Label();
            this.WeatherID_Label = new System.Windows.Forms.Label();
            this.WeatherFrequency_Label = new System.Windows.Forms.Label();
            this.Z2I_Password_Label = new System.Windows.Forms.Label();
            this.Z2I_Username_Label = new System.Windows.Forms.Label();
            this.Z2I_NbrOfDays_Label = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.EPG_BottomLine_Label = new System.Windows.Forms.Label();
            this.EPG_TopLine_Label = new System.Windows.Forms.Label();
            this.Version_Label = new System.Windows.Forms.Label();
            this.SelectCode_Label = new System.Windows.Forms.Label();
            this.UpdateUserSettings_Button = new System.Windows.Forms.Button();
            this.Serial_Port_Label = new System.Windows.Forms.Label();
            this.SerialPort_DropDownBox = new System.Windows.Forms.ComboBox();
            this.button20 = new System.Windows.Forms.Button();
            this.QTable = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.QTable_DGV = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.Commands = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.label114 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.button36 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.BottomLineSendBtn = new System.Windows.Forms.Button();
            this.TopLineSendBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ResetCommand = new System.Windows.Forms.Button();
            this.Config = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label70 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.Config_Update_Button = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Old = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Weathertab = new System.Windows.Forms.TabPage();
            this.label91 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label87 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Downloadtab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.Z2I_Listings_DGV = new System.Windows.Forms.DataGridView();
            this.Z2I_Lineup_DGV = new System.Windows.Forms.DataGridView();
            this.Download = new System.Windows.Forms.Button();
            this.Lineuptab = new System.Windows.Forms.TabPage();
            this.Lineup_SendInitialLineup_Button = new System.Windows.Forms.Button();
            this.Lineup_Z2I_Import_Button = new System.Windows.Forms.Button();
            this.Lineup_InsertBelow_Button = new System.Windows.Forms.Button();
            this.Lineup_MoveDown_Button = new System.Windows.Forms.Button();
            this.Lineup_MoveUp_Button = new System.Windows.Forms.Button();
            this.Lineup_InsertAbove_Button = new System.Windows.Forms.Button();
            this.Lineup_UpdateEntries_Button = new System.Windows.Forms.Button();
            this.Lineup_DGV = new System.Windows.Forms.DataGridView();
            this.Lineup_SendNextDay_Button = new System.Windows.Forms.Button();
            this.Lineup_SendCurrentDay_Button = new System.Windows.Forms.Button();
            this.Lineup_DeleteSelectedEntries_Button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Jdate = new System.Windows.Forms.TextBox();
            this.Listings = new System.Windows.Forms.TabPage();
            this.Listings_SendNextDayEntries_Button = new System.Windows.Forms.Button();
            this.Listings_Z2I_Import_Button = new System.Windows.Forms.Button();
            this.Listings_MoveDown_Button = new System.Windows.Forms.Button();
            this.Listings_MoveUp_Button = new System.Windows.Forms.Button();
            this.Listings_InsertAbove_Button = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.Listings_DGV = new System.Windows.Forms.DataGridView();
            this.Listings_UpdateEntries_Button = new System.Windows.Forms.Button();
            this.Listings_SendCurrentDayEntries_Button = new System.Windows.Forms.Button();
            this.Listings_SendSelectedEntries_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Listing_InsertBelow_Button = new System.Windows.Forms.Button();
            this.Listings_DeleteSelectedEntries_Button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.JdateLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TimeSlotLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Scroll_Messages_DGV = new System.Windows.Forms.DataGridView();
            this.Scroll_Messages_DataSet = new System.Data.DataSet();
            this.ScrollMessages = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.LineupRtClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LineupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lineup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2ILineup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2IListings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.QTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QTable_DGV)).BeginInit();
            this.Commands.SuspendLayout();
            this.Config.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Weathertab.SuspendLayout();
            this.Downloadtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Z2I_Listings_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2I_Lineup_DGV)).BeginInit();
            this.Lineuptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lineup_DGV)).BeginInit();
            this.Listings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listings_DGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Messages_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Messages_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // CurDateTime
            // 
            this.CurDateTime.AutoSize = true;
            this.CurDateTime.Location = new System.Drawing.Point(8, 33);
            this.CurDateTime.Name = "CurDateTime";
            this.CurDateTime.Size = new System.Drawing.Size(69, 13);
            this.CurDateTime.TabIndex = 39;
            this.CurDateTime.Text = "CurDateTime";
            // 
            // CurrentDayofYear
            // 
            this.CurrentDayofYear.AutoSize = true;
            this.CurrentDayofYear.Location = new System.Drawing.Point(373, 33);
            this.CurrentDayofYear.Name = "CurrentDayofYear";
            this.CurrentDayofYear.Size = new System.Drawing.Size(91, 13);
            this.CurrentDayofYear.TabIndex = 40;
            this.CurrentDayofYear.Text = "CurrentDayofYear";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 2400;
            this.serialPort1.RtsEnable = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(943, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(93, 20);
            this.toolStripMenuItem1.Text = "Configuration";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.filesToolStripMenuItem.Text = "File Locations";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // LineupRtClickMenu
            // 
            this.LineupRtClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.moveDownToolStripMenuItem,
            this.moveDownToolStripMenuItem1,
            this.insertToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendToolStripMenuItem});
            this.LineupRtClickMenu.Name = "LineupRtClickMenu";
            this.LineupRtClickMenu.Size = new System.Drawing.Size(139, 142);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem2.Text = "Update";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Lineup_UpdateEntries_Click);
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.moveDownToolStripMenuItem.Text = "Move Up";
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.Lineup_MoveEntryUp_Click);
            // 
            // moveDownToolStripMenuItem1
            // 
            this.moveDownToolStripMenuItem1.Name = "moveDownToolStripMenuItem1";
            this.moveDownToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.moveDownToolStripMenuItem1.Text = "Move Down";
            this.moveDownToolStripMenuItem1.Click += new System.EventHandler(this.Lineup_MoveEntryDown_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.Lineup_InsertEntryBelow_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Lineup_DeleteSelectedEntries_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(135, 6);
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentDayToolStripMenuItem,
            this.nextDayToolStripMenuItem});
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sendToolStripMenuItem.Text = "Send";
            // 
            // currentDayToolStripMenuItem
            // 
            this.currentDayToolStripMenuItem.Name = "currentDayToolStripMenuItem";
            this.currentDayToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.currentDayToolStripMenuItem.Text = "Current Day";
            this.currentDayToolStripMenuItem.Click += new System.EventHandler(this.Lineup_SendCurrentDay_Click);
            // 
            // nextDayToolStripMenuItem
            // 
            this.nextDayToolStripMenuItem.Name = "nextDayToolStripMenuItem";
            this.nextDayToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.nextDayToolStripMenuItem.Text = "Next Day";
            this.nextDayToolStripMenuItem.Click += new System.EventHandler(this.Lineup_SendNextDay_Click);
            // 
            // LineupDataSet
            // 
            this.LineupDataSet.DataSetName = "LineupDataSet";
            this.LineupDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.Lineup,
            this.Z2ILineup});
            // 
            // Lineup
            // 
            this.Lineup.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn102,
            this.dataColumn105,
            this.dataColumn106,
            this.dataColumn107,
            this.dataColumn108,
            this.dataColumn116,
            this.dataColumn117});
            this.Lineup.TableName = "Lineup";
            // 
            // dataColumn6
            // 
            this.dataColumn6.AllowDBNull = false;
            this.dataColumn6.ColumnName = "SourceID";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Number";
            this.dataColumn7.ColumnName = "Number";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "ID";
            this.dataColumn8.ColumnName = "ID";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Red Highlight";
            this.dataColumn10.ColumnName = "RedHiLt";
            this.dataColumn10.MaxLength = 1;
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Summary by Source";
            this.dataColumn11.ColumnName = "SBS";
            this.dataColumn11.MaxLength = 1;
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "Promo Tag Disable";
            this.dataColumn12.ColumnName = "PTagDisable";
            this.dataColumn12.MaxLength = 1;
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "PPV Source";
            this.dataColumn13.ColumnName = "PPVSrc";
            this.dataColumn13.MaxLength = 1;
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "Ditto Enable";
            this.dataColumn14.ColumnName = "DittoEnable";
            this.dataColumn14.MaxLength = 1;
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "Light Blue Highlight";
            this.dataColumn15.ColumnName = "LtBlueHiLt";
            this.dataColumn15.MaxLength = 1;
            // 
            // dataColumn102
            // 
            this.dataColumn102.AllowDBNull = false;
            this.dataColumn102.Caption = "StereoSrc";
            this.dataColumn102.ColumnName = "StereoSrc";
            this.dataColumn102.MaxLength = 1;
            // 
            // dataColumn105
            // 
            this.dataColumn105.AllowDBNull = false;
            this.dataColumn105.Caption = "Daypart 1";
            this.dataColumn105.ColumnName = "Daypt1";
            this.dataColumn105.DataType = typeof(short);
            // 
            // dataColumn106
            // 
            this.dataColumn106.AllowDBNull = false;
            this.dataColumn106.Caption = "Daypart 2";
            this.dataColumn106.ColumnName = "Daypt2";
            this.dataColumn106.DataType = typeof(short);
            // 
            // dataColumn107
            // 
            this.dataColumn107.AllowDBNull = false;
            this.dataColumn107.Caption = "Daypart 3";
            this.dataColumn107.ColumnName = "Daypt3";
            this.dataColumn107.DataType = typeof(short);
            // 
            // dataColumn108
            // 
            this.dataColumn108.AllowDBNull = false;
            this.dataColumn108.Caption = "Daypart 4";
            this.dataColumn108.ColumnName = "Daypt4";
            this.dataColumn108.DataType = typeof(short);
            // 
            // dataColumn116
            // 
            this.dataColumn116.AllowDBNull = false;
            this.dataColumn116.Caption = "Daypart 5";
            this.dataColumn116.ColumnName = "Daypt5";
            this.dataColumn116.DataType = typeof(short);
            // 
            // dataColumn117
            // 
            this.dataColumn117.AllowDBNull = false;
            this.dataColumn117.Caption = "Daypart 6";
            this.dataColumn117.ColumnName = "Daypt6";
            this.dataColumn117.DataType = typeof(short);
            // 
            // Z2ILineup
            // 
            this.Z2ILineup.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn127,
            this.dataColumn128,
            this.dataColumn129,
            this.dataColumn130,
            this.dataColumn131,
            this.dataColumn132,
            this.dataColumn133,
            this.dataColumn134,
            this.dataColumn135,
            this.dataColumn136,
            this.dataColumn137,
            this.dataColumn138,
            this.dataColumn139,
            this.dataColumn140,
            this.dataColumn141,
            this.dataColumn142});
            this.Z2ILineup.TableName = "Z2ILineup";
            // 
            // dataColumn127
            // 
            this.dataColumn127.AllowDBNull = false;
            this.dataColumn127.ColumnName = "SourceID";
            // 
            // dataColumn128
            // 
            this.dataColumn128.ColumnName = "Number";
            // 
            // dataColumn129
            // 
            this.dataColumn129.ColumnName = "ID";
            // 
            // dataColumn130
            // 
            this.dataColumn130.ColumnName = "RedHiLt";
            // 
            // dataColumn131
            // 
            this.dataColumn131.ColumnName = "SBS";
            // 
            // dataColumn132
            // 
            this.dataColumn132.ColumnName = "PTagDisable";
            // 
            // dataColumn133
            // 
            this.dataColumn133.ColumnName = "PPVSrc";
            // 
            // dataColumn134
            // 
            this.dataColumn134.ColumnName = "DittoEnable";
            // 
            // dataColumn135
            // 
            this.dataColumn135.ColumnName = "LtBlueHiLt";
            // 
            // dataColumn136
            // 
            this.dataColumn136.ColumnName = "StereoSrc";
            // 
            // dataColumn137
            // 
            this.dataColumn137.ColumnName = "Daypt1";
            this.dataColumn137.DataType = typeof(short);
            // 
            // dataColumn138
            // 
            this.dataColumn138.ColumnName = "Daypt2";
            this.dataColumn138.DataType = typeof(short);
            // 
            // dataColumn139
            // 
            this.dataColumn139.ColumnName = "Daypt3";
            this.dataColumn139.DataType = typeof(short);
            // 
            // dataColumn140
            // 
            this.dataColumn140.ColumnName = "Daypt4";
            this.dataColumn140.DataType = typeof(short);
            // 
            // dataColumn141
            // 
            this.dataColumn141.ColumnName = "Daypt5";
            this.dataColumn141.DataType = typeof(short);
            // 
            // dataColumn142
            // 
            this.dataColumn142.ColumnName = "Daypt6";
            this.dataColumn142.DataType = typeof(short);
            // 
            // ListingDataSet
            // 
            this.ListingDataSet.DataSetName = "ListingDataSet";
            this.ListingDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.Z2IListings});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.TableName = "Listings";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "JulianDay";
            this.dataColumn1.DataType = typeof(short);
            // 
            // dataColumn2
            // 
            this.dataColumn2.AllowDBNull = false;
            this.dataColumn2.ColumnName = "SourceID";
            // 
            // dataColumn3
            // 
            this.dataColumn3.AllowDBNull = false;
            this.dataColumn3.ColumnName = "TimeSlot";
            this.dataColumn3.DataType = typeof(short);
            // 
            // dataColumn4
            // 
            this.dataColumn4.AllowDBNull = false;
            this.dataColumn4.ColumnName = "Attr";
            this.dataColumn4.DataType = typeof(short);
            // 
            // dataColumn5
            // 
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.ColumnName = "Title";
            // 
            // Z2IListings
            // 
            this.Z2IListings.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn122,
            this.dataColumn123,
            this.dataColumn124,
            this.dataColumn125,
            this.dataColumn126,
            this.dataColumn143,
            this.dataColumn144});
            this.Z2IListings.TableName = "Z2IListings";
            // 
            // dataColumn122
            // 
            this.dataColumn122.AllowDBNull = false;
            this.dataColumn122.ColumnName = "JulianDay";
            this.dataColumn122.DataType = typeof(short);
            // 
            // dataColumn123
            // 
            this.dataColumn123.AllowDBNull = false;
            this.dataColumn123.Caption = "SourceID";
            this.dataColumn123.ColumnName = "SourceID";
            // 
            // dataColumn124
            // 
            this.dataColumn124.AllowDBNull = false;
            this.dataColumn124.ColumnName = "TimeSlot";
            this.dataColumn124.DataType = typeof(short);
            // 
            // dataColumn125
            // 
            this.dataColumn125.AllowDBNull = false;
            this.dataColumn125.ColumnName = "Attr";
            this.dataColumn125.DataType = typeof(short);
            // 
            // dataColumn126
            // 
            this.dataColumn126.AllowDBNull = false;
            this.dataColumn126.ColumnName = "Title";
            // 
            // dataColumn143
            // 
            this.dataColumn143.ColumnName = "Subtitle";
            // 
            // dataColumn144
            // 
            this.dataColumn144.ColumnName = "Description";
            // 
            // WeatherDataSet
            // 
            this.WeatherDataSet.DataSetName = "WeatherDataSet";
            this.WeatherDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn78,
            this.dataColumn79,
            this.dataColumn80,
            this.dataColumn81,
            this.dataColumn82,
            this.dataColumn83,
            this.dataColumn84,
            this.dataColumn85,
            this.dataColumn86,
            this.dataColumn87,
            this.dataColumn88,
            this.dataColumn89,
            this.dataColumn90});
            this.dataTable2.TableName = "Weather";
            // 
            // dataColumn78
            // 
            this.dataColumn78.ColumnName = "display_length";
            this.dataColumn78.DataType = typeof(short);
            // 
            // dataColumn79
            // 
            this.dataColumn79.ColumnName = "ColorID";
            this.dataColumn79.DataType = typeof(short);
            // 
            // dataColumn80
            // 
            this.dataColumn80.ColumnName = "IconID";
            this.dataColumn80.DataType = typeof(short);
            // 
            // dataColumn81
            // 
            this.dataColumn81.ColumnName = "Expansion";
            this.dataColumn81.DataType = typeof(short);
            // 
            // dataColumn82
            // 
            this.dataColumn82.ColumnName = "IDString";
            // 
            // dataColumn83
            // 
            this.dataColumn83.ColumnName = "CurSky";
            // 
            // dataColumn84
            // 
            this.dataColumn84.ColumnName = "CurWeather";
            // 
            // dataColumn85
            // 
            this.dataColumn85.ColumnName = "CurTemp";
            // 
            // dataColumn86
            // 
            this.dataColumn86.ColumnName = "CurWind";
            // 
            // dataColumn87
            // 
            this.dataColumn87.ColumnName = "CurPressure";
            // 
            // dataColumn88
            // 
            this.dataColumn88.ColumnName = "CurHumidity";
            // 
            // dataColumn89
            // 
            this.dataColumn89.ColumnName = "CurDewPoint";
            // 
            // dataColumn90
            // 
            this.dataColumn90.ColumnName = "CurVisibility";
            // 
            // QTableDataSet
            // 
            this.QTableDataSet.DataSetName = "QTableDataSet";
            this.QTableDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable3});
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn91,
            this.dataColumn92});
            this.dataTable3.TableName = "QTable";
            // 
            // dataColumn91
            // 
            this.dataColumn91.ColumnName = "QTSource";
            // 
            // dataColumn92
            // 
            this.dataColumn92.ColumnName = "QTName";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.WeatherUpdateTimer_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.button26);
            this.tabPage2.Controls.Add(this.label108);
            this.tabPage2.Controls.Add(this.label107);
            this.tabPage2.Controls.Add(this.label106);
            this.tabPage2.Controls.Add(this.label105);
            this.tabPage2.Controls.Add(this.label104);
            this.tabPage2.Controls.Add(this.label103);
            this.tabPage2.Controls.Add(this.textBox99);
            this.tabPage2.Controls.Add(this.textBox98);
            this.tabPage2.Controls.Add(this.textBox97);
            this.tabPage2.Controls.Add(this.textBox96);
            this.tabPage2.Controls.Add(this.textBox95);
            this.tabPage2.Controls.Add(this.textBox94);
            this.tabPage2.Controls.Add(this.textBox93);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.label102);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(935, 504);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "Lineup Attr";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(458, 72);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(206, 55);
            this.button26.TabIndex = 112;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.Button26_Click);
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(150, 189);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(48, 13);
            this.label108.TabIndex = 111;
            this.label108.Text = "Brush ID";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(115, 155);
            this.label107.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(86, 13);
            this.label107.TabIndex = 110;
            this.label107.Text = "Grid Foregrnd Clr";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(116, 120);
            this.label106.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(88, 13);
            this.label106.TabIndex = 109;
            this.label106.Text = "Grid backgrnd clr";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(102, 93);
            this.label105.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(99, 13);
            this.label105.TabIndex = 108;
            this.label105.Text = "Sprts Summ Enable";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(125, 60);
            this.label104.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(77, 13);
            this.label104.TabIndex = 107;
            this.label104.Text = "TelVue Enable";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(264, 16);
            this.label103.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(55, 13);
            this.label103.TabIndex = 106;
            this.label103.Text = "Source ID";
            // 
            // textBox99
            // 
            this.textBox99.Location = new System.Drawing.Point(214, 185);
            this.textBox99.Margin = new System.Windows.Forms.Padding(2);
            this.textBox99.Name = "textBox99";
            this.textBox99.Size = new System.Drawing.Size(100, 20);
            this.textBox99.TabIndex = 105;
            // 
            // textBox98
            // 
            this.textBox98.Location = new System.Drawing.Point(214, 154);
            this.textBox98.Margin = new System.Windows.Forms.Padding(2);
            this.textBox98.Name = "textBox98";
            this.textBox98.Size = new System.Drawing.Size(101, 20);
            this.textBox98.TabIndex = 104;
            // 
            // textBox97
            // 
            this.textBox97.Location = new System.Drawing.Point(214, 123);
            this.textBox97.Margin = new System.Windows.Forms.Padding(2);
            this.textBox97.Name = "textBox97";
            this.textBox97.Size = new System.Drawing.Size(101, 20);
            this.textBox97.TabIndex = 103;
            // 
            // textBox96
            // 
            this.textBox96.Location = new System.Drawing.Point(214, 93);
            this.textBox96.Margin = new System.Windows.Forms.Padding(2);
            this.textBox96.Name = "textBox96";
            this.textBox96.Size = new System.Drawing.Size(101, 20);
            this.textBox96.TabIndex = 102;
            // 
            // textBox95
            // 
            this.textBox95.Location = new System.Drawing.Point(214, 58);
            this.textBox95.Margin = new System.Windows.Forms.Padding(2);
            this.textBox95.Name = "textBox95";
            this.textBox95.Size = new System.Drawing.Size(101, 20);
            this.textBox95.TabIndex = 101;
            // 
            // textBox94
            // 
            this.textBox94.Location = new System.Drawing.Point(331, 12);
            this.textBox94.Margin = new System.Windows.Forms.Padding(2);
            this.textBox94.Name = "textBox94";
            this.textBox94.Size = new System.Drawing.Size(110, 20);
            this.textBox94.TabIndex = 100;
            // 
            // textBox93
            // 
            this.textBox93.Location = new System.Drawing.Point(208, 14);
            this.textBox93.MaxLength = 3;
            this.textBox93.Name = "textBox93";
            this.textBox93.Size = new System.Drawing.Size(38, 20);
            this.textBox93.TabIndex = 98;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(93, 14);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker3.TabIndex = 97;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(32, 16);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(56, 13);
            this.label102.TabIndex = 99;
            this.label102.Text = "Julian Day";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.DayOfYear_Label);
            this.tabPage1.Controls.Add(this.CurrentDayOfYear_Label);
            this.tabPage1.Controls.Add(this.CurrentDayOfYear_TextBox);
            this.tabPage1.Controls.Add(this.CurrentPrevueDay_TextBox);
            this.tabPage1.Controls.Add(this.CustomListing2_TextBox);
            this.tabPage1.Controls.Add(this.CustomListing1_TextBox);
            this.tabPage1.Controls.Add(this.TZOffset_TextBox);
            this.tabPage1.Controls.Add(this.Port_TextBox);
            this.tabPage1.Controls.Add(this.Server_TextBox);
            this.tabPage1.Controls.Add(this.WeatherParseCycleTextBox);
            this.tabPage1.Controls.Add(this.WeatherCityTextBox);
            this.tabPage1.Controls.Add(this.WeatherIDTextBox);
            this.tabPage1.Controls.Add(this.Z2I_Password_TextBox);
            this.tabPage1.Controls.Add(this.Z2I_Username_TextBox);
            this.tabPage1.Controls.Add(this.Z2I_NbrOfDays_TextBox);
            this.tabPage1.Controls.Add(this.textBox91);
            this.tabPage1.Controls.Add(this.textBox90);
            this.tabPage1.Controls.Add(this.textBox89);
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.textBox12);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox23);
            this.tabPage1.Controls.Add(this.textBox27);
            this.tabPage1.Controls.Add(this.textBox26);
            this.tabPage1.Controls.Add(this.textBox25);
            this.tabPage1.Controls.Add(this.textBox24);
            this.tabPage1.Controls.Add(this.EPG_BottomLine_TextBox);
            this.tabPage1.Controls.Add(this.EPG_TopLine_TextBox);
            this.tabPage1.Controls.Add(this.Version_TextBox);
            this.tabPage1.Controls.Add(this.SelectCode_TextBox);
            this.tabPage1.Controls.Add(this.CurrentPrevueDay_Label);
            this.tabPage1.Controls.Add(this.CustomListing2_Label);
            this.tabPage1.Controls.Add(this.CustomListing1_Label);
            this.tabPage1.Controls.Add(this.TZOffset_Label);
            this.tabPage1.Controls.Add(this.Serial_Button);
            this.tabPage1.Controls.Add(this.TCP_IP_Button);
            this.tabPage1.Controls.Add(this.Port_Label);
            this.tabPage1.Controls.Add(this.IP_Address_Label);
            this.tabPage1.Controls.Add(this.Port_Select_Label);
            this.tabPage1.Controls.Add(this.label97);
            this.tabPage1.Controls.Add(this.label98);
            this.tabPage1.Controls.Add(this.label99);
            this.tabPage1.Controls.Add(this.WeatherDisplayLength_Label);
            this.tabPage1.Controls.Add(this.WeatherFreqComboBox);
            this.tabPage1.Controls.Add(this.WeatherCity_Label);
            this.tabPage1.Controls.Add(this.WeatherID_Label);
            this.tabPage1.Controls.Add(this.WeatherFrequency_Label);
            this.tabPage1.Controls.Add(this.Z2I_Password_Label);
            this.tabPage1.Controls.Add(this.Z2I_Username_Label);
            this.tabPage1.Controls.Add(this.Z2I_NbrOfDays_Label);
            this.tabPage1.Controls.Add(this.label96);
            this.tabPage1.Controls.Add(this.label95);
            this.tabPage1.Controls.Add(this.label94);
            this.tabPage1.Controls.Add(this.label93);
            this.tabPage1.Controls.Add(this.label92);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.EPG_BottomLine_Label);
            this.tabPage1.Controls.Add(this.EPG_TopLine_Label);
            this.tabPage1.Controls.Add(this.Version_Label);
            this.tabPage1.Controls.Add(this.SelectCode_Label);
            this.tabPage1.Controls.Add(this.UpdateUserSettings_Button);
            this.tabPage1.Controls.Add(this.Serial_Port_Label);
            this.tabPage1.Controls.Add(this.SerialPort_DropDownBox);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(935, 504);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Text = "User Settings";
            // 
            // DayOfYear_Label
            // 
            this.DayOfYear_Label.AutoSize = true;
            this.DayOfYear_Label.Location = new System.Drawing.Point(486, 439);
            this.DayOfYear_Label.Name = "DayOfYear_Label";
            this.DayOfYear_Label.Size = new System.Drawing.Size(63, 13);
            this.DayOfYear_Label.TabIndex = 150;
            this.DayOfYear_Label.Text = "Day of Year";
            // 
            // CurrentDayOfYear_Label
            // 
            this.CurrentDayOfYear_Label.AutoSize = true;
            this.CurrentDayOfYear_Label.Location = new System.Drawing.Point(471, 453);
            this.CurrentDayOfYear_Label.Name = "CurrentDayOfYear_Label";
            this.CurrentDayOfYear_Label.Size = new System.Drawing.Size(41, 13);
            this.CurrentDayOfYear_Label.TabIndex = 149;
            this.CurrentDayOfYear_Label.Text = "Current";
            // 
            // CurrentDayOfYear_TextBox
            // 
            this.CurrentDayOfYear_TextBox.Location = new System.Drawing.Point(468, 470);
            this.CurrentDayOfYear_TextBox.Name = "CurrentDayOfYear_TextBox";
            this.CurrentDayOfYear_TextBox.Size = new System.Drawing.Size(44, 20);
            this.CurrentDayOfYear_TextBox.TabIndex = 148;
            this.CurrentDayOfYear_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentPrevueDay_TextBox
            // 
            this.CurrentPrevueDay_TextBox.Location = new System.Drawing.Point(523, 470);
            this.CurrentPrevueDay_TextBox.Name = "CurrentPrevueDay_TextBox";
            this.CurrentPrevueDay_TextBox.Size = new System.Drawing.Size(45, 20);
            this.CurrentPrevueDay_TextBox.TabIndex = 147;
            this.CurrentPrevueDay_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomListing2_TextBox
            // 
            this.CustomListing2_TextBox.Location = new System.Drawing.Point(169, 201);
            this.CustomListing2_TextBox.Name = "CustomListing2_TextBox";
            this.CustomListing2_TextBox.Size = new System.Drawing.Size(542, 20);
            this.CustomListing2_TextBox.TabIndex = 145;
            // 
            // CustomListing1_TextBox
            // 
            this.CustomListing1_TextBox.Location = new System.Drawing.Point(169, 154);
            this.CustomListing1_TextBox.Name = "CustomListing1_TextBox";
            this.CustomListing1_TextBox.Size = new System.Drawing.Size(542, 20);
            this.CustomListing1_TextBox.TabIndex = 144;
            // 
            // TZOffset_TextBox
            // 
            this.TZOffset_TextBox.Location = new System.Drawing.Point(285, 99);
            this.TZOffset_TextBox.Name = "TZOffset_TextBox";
            this.TZOffset_TextBox.Size = new System.Drawing.Size(49, 20);
            this.TZOffset_TextBox.TabIndex = 143;
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(522, 36);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(99, 20);
            this.Port_TextBox.TabIndex = 139;
            this.Port_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Server_TextBox
            // 
            this.Server_TextBox.Location = new System.Drawing.Point(374, 36);
            this.Server_TextBox.Name = "Server_TextBox";
            this.Server_TextBox.Size = new System.Drawing.Size(142, 20);
            this.Server_TextBox.TabIndex = 138;
            this.Server_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeatherParseCycleTextBox
            // 
            this.WeatherParseCycleTextBox.Location = new System.Drawing.Point(610, 265);
            this.WeatherParseCycleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeatherParseCycleTextBox.Name = "WeatherParseCycleTextBox";
            this.WeatherParseCycleTextBox.Size = new System.Drawing.Size(73, 20);
            this.WeatherParseCycleTextBox.TabIndex = 128;
            this.WeatherParseCycleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeatherCityTextBox
            // 
            this.WeatherCityTextBox.Location = new System.Drawing.Point(329, 265);
            this.WeatherCityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeatherCityTextBox.MaxLength = 26;
            this.WeatherCityTextBox.Name = "WeatherCityTextBox";
            this.WeatherCityTextBox.Size = new System.Drawing.Size(192, 20);
            this.WeatherCityTextBox.TabIndex = 122;
            this.WeatherCityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WeatherIDTextBox
            // 
            this.WeatherIDTextBox.Location = new System.Drawing.Point(208, 265);
            this.WeatherIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeatherIDTextBox.MaxLength = 10;
            this.WeatherIDTextBox.Name = "WeatherIDTextBox";
            this.WeatherIDTextBox.Size = new System.Drawing.Size(105, 20);
            this.WeatherIDTextBox.TabIndex = 121;
            this.WeatherIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Z2I_Password_TextBox
            // 
            this.Z2I_Password_TextBox.Location = new System.Drawing.Point(651, 99);
            this.Z2I_Password_TextBox.Name = "Z2I_Password_TextBox";
            this.Z2I_Password_TextBox.PasswordChar = '*';
            this.Z2I_Password_TextBox.Size = new System.Drawing.Size(174, 20);
            this.Z2I_Password_TextBox.TabIndex = 116;
            this.Z2I_Password_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Z2I_Username_TextBox
            // 
            this.Z2I_Username_TextBox.Location = new System.Drawing.Point(421, 99);
            this.Z2I_Username_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Z2I_Username_TextBox.Name = "Z2I_Username_TextBox";
            this.Z2I_Username_TextBox.Size = new System.Drawing.Size(218, 20);
            this.Z2I_Username_TextBox.TabIndex = 115;
            this.Z2I_Username_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Z2I_NbrOfDays_TextBox
            // 
            this.Z2I_NbrOfDays_TextBox.Location = new System.Drawing.Point(366, 99);
            this.Z2I_NbrOfDays_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Z2I_NbrOfDays_TextBox.MaxLength = 2;
            this.Z2I_NbrOfDays_TextBox.Name = "Z2I_NbrOfDays_TextBox";
            this.Z2I_NbrOfDays_TextBox.Size = new System.Drawing.Size(40, 20);
            this.Z2I_NbrOfDays_TextBox.TabIndex = 114;
            this.Z2I_NbrOfDays_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox91
            // 
            this.textBox91.Location = new System.Drawing.Point(843, 471);
            this.textBox91.Margin = new System.Windows.Forms.Padding(2);
            this.textBox91.Name = "textBox91";
            this.textBox91.Size = new System.Drawing.Size(34, 20);
            this.textBox91.TabIndex = 104;
            this.textBox91.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox90
            // 
            this.textBox90.Location = new System.Drawing.Point(804, 471);
            this.textBox90.Margin = new System.Windows.Forms.Padding(2);
            this.textBox90.Name = "textBox90";
            this.textBox90.Size = new System.Drawing.Size(25, 20);
            this.textBox90.TabIndex = 103;
            this.textBox90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox89
            // 
            this.textBox89.Location = new System.Drawing.Point(753, 471);
            this.textBox89.Margin = new System.Windows.Forms.Padding(2);
            this.textBox89.Name = "textBox89";
            this.textBox89.Size = new System.Drawing.Size(31, 20);
            this.textBox89.TabIndex = 102;
            this.textBox89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(696, 471);
            this.textBox16.Margin = new System.Windows.Forms.Padding(2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(34, 20);
            this.textBox16.TabIndex = 100;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(655, 471);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(25, 20);
            this.textBox12.TabIndex = 99;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(607, 471);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(31, 20);
            this.textBox11.TabIndex = 98;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(154, 470);
            this.textBox23.Margin = new System.Windows.Forms.Padding(2);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(32, 20);
            this.textBox23.TabIndex = 79;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.WordWrap = false;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(342, 470);
            this.textBox27.Margin = new System.Windows.Forms.Padding(2);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(33, 20);
            this.textBox27.TabIndex = 83;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(301, 470);
            this.textBox26.Margin = new System.Windows.Forms.Padding(2);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(36, 20);
            this.textBox26.TabIndex = 82;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(263, 470);
            this.textBox25.Margin = new System.Windows.Forms.Padding(2);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(34, 20);
            this.textBox25.TabIndex = 81;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(190, 470);
            this.textBox24.Margin = new System.Windows.Forms.Padding(2);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(64, 20);
            this.textBox24.TabIndex = 80;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EPG_BottomLine_TextBox
            // 
            this.EPG_BottomLine_TextBox.Location = new System.Drawing.Point(458, 314);
            this.EPG_BottomLine_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EPG_BottomLine_TextBox.Name = "EPG_BottomLine_TextBox";
            this.EPG_BottomLine_TextBox.Size = new System.Drawing.Size(248, 20);
            this.EPG_BottomLine_TextBox.TabIndex = 72;
            this.EPG_BottomLine_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EPG_TopLine_TextBox
            // 
            this.EPG_TopLine_TextBox.Location = new System.Drawing.Point(199, 314);
            this.EPG_TopLine_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EPG_TopLine_TextBox.Name = "EPG_TopLine_TextBox";
            this.EPG_TopLine_TextBox.Size = new System.Drawing.Size(248, 20);
            this.EPG_TopLine_TextBox.TabIndex = 71;
            this.EPG_TopLine_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Version_TextBox
            // 
            this.Version_TextBox.Location = new System.Drawing.Point(169, 99);
            this.Version_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Version_TextBox.Name = "Version_TextBox";
            this.Version_TextBox.Size = new System.Drawing.Size(81, 20);
            this.Version_TextBox.TabIndex = 65;
            this.Version_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelectCode_TextBox
            // 
            this.SelectCode_TextBox.Location = new System.Drawing.Point(77, 99);
            this.SelectCode_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectCode_TextBox.Name = "SelectCode_TextBox";
            this.SelectCode_TextBox.Size = new System.Drawing.Size(85, 20);
            this.SelectCode_TextBox.TabIndex = 62;
            this.SelectCode_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentPrevueDay_Label
            // 
            this.CurrentPrevueDay_Label.AutoSize = true;
            this.CurrentPrevueDay_Label.Location = new System.Drawing.Point(524, 453);
            this.CurrentPrevueDay_Label.Name = "CurrentPrevueDay_Label";
            this.CurrentPrevueDay_Label.Size = new System.Drawing.Size(41, 13);
            this.CurrentPrevueDay_Label.TabIndex = 146;
            this.CurrentPrevueDay_Label.Text = "Prevue";
            // 
            // CustomListing2_Label
            // 
            this.CustomListing2_Label.AutoSize = true;
            this.CustomListing2_Label.Location = new System.Drawing.Point(375, 185);
            this.CustomListing2_Label.Name = "CustomListing2_Label";
            this.CustomListing2_Label.Size = new System.Drawing.Size(101, 13);
            this.CustomListing2_Label.TabIndex = 142;
            this.CustomListing2_Label.Text = "Custom Last Entry 2";
            // 
            // CustomListing1_Label
            // 
            this.CustomListing1_Label.AutoSize = true;
            this.CustomListing1_Label.Location = new System.Drawing.Point(375, 138);
            this.CustomListing1_Label.Name = "CustomListing1_Label";
            this.CustomListing1_Label.Size = new System.Drawing.Size(101, 13);
            this.CustomListing1_Label.TabIndex = 141;
            this.CustomListing1_Label.Text = "Custom Last Entry 1";
            // 
            // TZOffset_Label
            // 
            this.TZOffset_Label.AutoSize = true;
            this.TZOffset_Label.Location = new System.Drawing.Point(282, 80);
            this.TZOffset_Label.Name = "TZOffset_Label";
            this.TZOffset_Label.Size = new System.Drawing.Size(52, 13);
            this.TZOffset_Label.TabIndex = 140;
            this.TZOffset_Label.Text = "TZ Offset";
            // 
            // Serial_Button
            // 
            this.Serial_Button.AutoSize = true;
            this.Serial_Button.Location = new System.Drawing.Point(655, 37);
            this.Serial_Button.Name = "Serial_Button";
            this.Serial_Button.Size = new System.Drawing.Size(51, 17);
            this.Serial_Button.TabIndex = 137;
            this.Serial_Button.TabStop = true;
            this.Serial_Button.Text = "Serial";
            this.Serial_Button.UseVisualStyleBackColor = true;
            this.Serial_Button.CheckedChanged += new System.EventHandler(this.Serial_Button_CheckedChanged);
            // 
            // TCP_IP_Button
            // 
            this.TCP_IP_Button.AutoSize = true;
            this.TCP_IP_Button.Location = new System.Drawing.Point(314, 37);
            this.TCP_IP_Button.Name = "TCP_IP_Button";
            this.TCP_IP_Button.Size = new System.Drawing.Size(59, 17);
            this.TCP_IP_Button.TabIndex = 136;
            this.TCP_IP_Button.TabStop = true;
            this.TCP_IP_Button.Text = "TCP-IP";
            this.TCP_IP_Button.UseVisualStyleBackColor = true;
            this.TCP_IP_Button.CheckedChanged += new System.EventHandler(this.TCP_IP_Button_CheckedChanged);
            // 
            // Port_Label
            // 
            this.Port_Label.AutoSize = true;
            this.Port_Label.Location = new System.Drawing.Point(550, 20);
            this.Port_Label.Name = "Port_Label";
            this.Port_Label.Size = new System.Drawing.Size(36, 13);
            this.Port_Label.TabIndex = 135;
            this.Port_Label.Text = "Port #";
            // 
            // IP_Address_Label
            // 
            this.IP_Address_Label.AutoSize = true;
            this.IP_Address_Label.Location = new System.Drawing.Point(422, 20);
            this.IP_Address_Label.Name = "IP_Address_Label";
            this.IP_Address_Label.Size = new System.Drawing.Size(58, 13);
            this.IP_Address_Label.TabIndex = 134;
            this.IP_Address_Label.Text = "IP Address";
            // 
            // Port_Select_Label
            // 
            this.Port_Select_Label.AutoSize = true;
            this.Port_Select_Label.Location = new System.Drawing.Point(249, 39);
            this.Port_Select_Label.Name = "Port_Select_Label";
            this.Port_Select_Label.Size = new System.Drawing.Size(59, 13);
            this.Port_Select_Label.TabIndex = 133;
            this.Port_Select_Label.Text = "Port Select";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(847, 452);
            this.label97.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(30, 13);
            this.label97.TabIndex = 132;
            this.label97.Text = "Time";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(790, 452);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(56, 13);
            this.label98.TabIndex = 131;
            this.label98.Text = "Julian Day";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(755, 452);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(29, 13);
            this.label99.TabIndex = 130;
            this.label99.Text = "Year";
            // 
            // WeatherDisplayLength_Label
            // 
            this.WeatherDisplayLength_Label.AutoSize = true;
            this.WeatherDisplayLength_Label.Location = new System.Drawing.Point(619, 244);
            this.WeatherDisplayLength_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeatherDisplayLength_Label.Name = "WeatherDisplayLength_Label";
            this.WeatherDisplayLength_Label.Size = new System.Drawing.Size(64, 13);
            this.WeatherDisplayLength_Label.TabIndex = 129;
            this.WeatherDisplayLength_Label.Text = "Disp Length";
            // 
            // WeatherFreqComboBox
            // 
            this.WeatherFreqComboBox.FormattingEnabled = true;
            this.WeatherFreqComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.WeatherFreqComboBox.Location = new System.Drawing.Point(537, 264);
            this.WeatherFreqComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeatherFreqComboBox.MaxLength = 1;
            this.WeatherFreqComboBox.Name = "WeatherFreqComboBox";
            this.WeatherFreqComboBox.Size = new System.Drawing.Size(55, 21);
            this.WeatherFreqComboBox.TabIndex = 127;
            // 
            // WeatherCity_Label
            // 
            this.WeatherCity_Label.AutoSize = true;
            this.WeatherCity_Label.Location = new System.Drawing.Point(385, 244);
            this.WeatherCity_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeatherCity_Label.Name = "WeatherCity_Label";
            this.WeatherCity_Label.Size = new System.Drawing.Size(68, 13);
            this.WeatherCity_Label.TabIndex = 126;
            this.WeatherCity_Label.Text = "Weather City";
            // 
            // WeatherID_Label
            // 
            this.WeatherID_Label.AutoSize = true;
            this.WeatherID_Label.Location = new System.Drawing.Point(229, 244);
            this.WeatherID_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeatherID_Label.Name = "WeatherID_Label";
            this.WeatherID_Label.Size = new System.Drawing.Size(62, 13);
            this.WeatherID_Label.TabIndex = 125;
            this.WeatherID_Label.Text = "Weather ID";
            // 
            // WeatherFrequency_Label
            // 
            this.WeatherFrequency_Label.AutoSize = true;
            this.WeatherFrequency_Label.Location = new System.Drawing.Point(535, 244);
            this.WeatherFrequency_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeatherFrequency_Label.Name = "WeatherFrequency_Label";
            this.WeatherFrequency_Label.Size = new System.Drawing.Size(57, 13);
            this.WeatherFrequency_Label.TabIndex = 124;
            this.WeatherFrequency_Label.Text = "Frequency";
            // 
            // Z2I_Password_Label
            // 
            this.Z2I_Password_Label.AutoSize = true;
            this.Z2I_Password_Label.Location = new System.Drawing.Point(712, 83);
            this.Z2I_Password_Label.Name = "Z2I_Password_Label";
            this.Z2I_Password_Label.Size = new System.Drawing.Size(53, 13);
            this.Z2I_Password_Label.TabIndex = 119;
            this.Z2I_Password_Label.Text = "Password";
            // 
            // Z2I_Username_Label
            // 
            this.Z2I_Username_Label.AutoSize = true;
            this.Z2I_Username_Label.Location = new System.Drawing.Point(501, 80);
            this.Z2I_Username_Label.Name = "Z2I_Username_Label";
            this.Z2I_Username_Label.Size = new System.Drawing.Size(55, 13);
            this.Z2I_Username_Label.TabIndex = 118;
            this.Z2I_Username_Label.Text = "Username";
            // 
            // Z2I_NbrOfDays_Label
            // 
            this.Z2I_NbrOfDays_Label.AutoSize = true;
            this.Z2I_NbrOfDays_Label.Location = new System.Drawing.Point(363, 80);
            this.Z2I_NbrOfDays_Label.Name = "Z2I_NbrOfDays_Label";
            this.Z2I_NbrOfDays_Label.Size = new System.Drawing.Size(53, 13);
            this.Z2I_NbrOfDays_Label.TabIndex = 117;
            this.Z2I_NbrOfDays_Label.Text = "# of Days";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(702, 452);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(30, 13);
            this.label96.TabIndex = 108;
            this.label96.Text = "Time";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(642, 452);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(56, 13);
            this.label95.TabIndex = 107;
            this.label95.Text = "Julian Day";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(609, 452);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(29, 13);
            this.label94.TabIndex = 106;
            this.label94.Text = "Year";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(789, 439);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(49, 13);
            this.label93.TabIndex = 97;
            this.label93.Text = "Exit DST";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(641, 439);
            this.label92.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(57, 13);
            this.label92.TabIndex = 96;
            this.label92.Text = "Enter DST";
            // 
            // comboBox6
            // 
            this.comboBox6.AllowDrop = true;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.comboBox6.Location = new System.Drawing.Point(395, 469);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(40, 21);
            this.comboBox6.TabIndex = 94;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.comboBox5.Location = new System.Drawing.Point(89, 470);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(61, 21);
            this.comboBox5.TabIndex = 93;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Sun",
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat"});
            this.comboBox4.Location = new System.Drawing.Point(26, 470);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(50, 21);
            this.comboBox4.TabIndex = 92;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(403, 452);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 13);
            this.label30.TabIndex = 91;
            this.label30.Text = "DST";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(339, 452);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 13);
            this.label29.TabIndex = 90;
            this.label29.Text = "Second";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(298, 452);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 89;
            this.label28.Text = "Minute";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(264, 452);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 88;
            this.label27.Text = "Hour";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(206, 452);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 87;
            this.label26.Text = "Year";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(156, 452);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 86;
            this.label25.Text = "Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(98, 452);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 85;
            this.label24.Text = "Month";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(36, 452);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 84;
            this.label23.Text = "Day";
            // 
            // EPG_BottomLine_Label
            // 
            this.EPG_BottomLine_Label.AutoSize = true;
            this.EPG_BottomLine_Label.Location = new System.Drawing.Point(526, 299);
            this.EPG_BottomLine_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EPG_BottomLine_Label.Name = "EPG_BottomLine_Label";
            this.EPG_BottomLine_Label.Size = new System.Drawing.Size(93, 13);
            this.EPG_BottomLine_Label.TabIndex = 69;
            this.EPG_BottomLine_Label.Text = "Botlom Line (EPG)";
            // 
            // EPG_TopLine_Label
            // 
            this.EPG_TopLine_Label.AutoSize = true;
            this.EPG_TopLine_Label.Location = new System.Drawing.Point(282, 299);
            this.EPG_TopLine_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EPG_TopLine_Label.Name = "EPG_TopLine_Label";
            this.EPG_TopLine_Label.Size = new System.Drawing.Size(80, 13);
            this.EPG_TopLine_Label.TabIndex = 68;
            this.EPG_TopLine_Label.Text = "Top Line (EPG)";
            // 
            // Version_Label
            // 
            this.Version_Label.AutoSize = true;
            this.Version_Label.Location = new System.Drawing.Point(188, 80);
            this.Version_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Version_Label.Name = "Version_Label";
            this.Version_Label.Size = new System.Drawing.Size(42, 13);
            this.Version_Label.TabIndex = 66;
            this.Version_Label.Text = "Version";
            // 
            // SelectCode_Label
            // 
            this.SelectCode_Label.AutoSize = true;
            this.SelectCode_Label.Location = new System.Drawing.Point(85, 80);
            this.SelectCode_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectCode_Label.Name = "SelectCode_Label";
            this.SelectCode_Label.Size = new System.Drawing.Size(65, 13);
            this.SelectCode_Label.TabIndex = 64;
            this.SelectCode_Label.Text = "Select Code";
            // 
            // UpdateUserSettings_Button
            // 
            this.UpdateUserSettings_Button.Location = new System.Drawing.Point(386, 385);
            this.UpdateUserSettings_Button.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateUserSettings_Button.Name = "UpdateUserSettings_Button";
            this.UpdateUserSettings_Button.Size = new System.Drawing.Size(126, 39);
            this.UpdateUserSettings_Button.TabIndex = 63;
            this.UpdateUserSettings_Button.Text = "Update";
            this.UpdateUserSettings_Button.UseVisualStyleBackColor = true;
            this.UpdateUserSettings_Button.Click += new System.EventHandler(this.UpdateUserSettings_Click);
            // 
            // Serial_Port_Label
            // 
            this.Serial_Port_Label.AutoSize = true;
            this.Serial_Port_Label.Location = new System.Drawing.Point(724, 20);
            this.Serial_Port_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Serial_Port_Label.Name = "Serial_Port_Label";
            this.Serial_Port_Label.Size = new System.Drawing.Size(55, 13);
            this.Serial_Port_Label.TabIndex = 61;
            this.Serial_Port_Label.Text = "Serial Port";
            // 
            // SerialPort_DropDownBox
            // 
            this.SerialPort_DropDownBox.FormattingEnabled = true;
            this.SerialPort_DropDownBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.SerialPort_DropDownBox.Location = new System.Drawing.Point(711, 36);
            this.SerialPort_DropDownBox.Margin = new System.Windows.Forms.Padding(2);
            this.SerialPort_DropDownBox.Name = "SerialPort_DropDownBox";
            this.SerialPort_DropDownBox.Size = new System.Drawing.Size(78, 21);
            this.SerialPort_DropDownBox.TabIndex = 60;
            this.SerialPort_DropDownBox.SelectionChangeCommitted += new System.EventHandler(this.SerialPort_DropDownBox_SelectionChangeCommitted);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(100, 26);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(130, 39);
            this.button20.TabIndex = 59;
            this.button20.Text = "Change Save Folder";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.ChangeSaveFolder_Click);
            // 
            // QTable
            // 
            this.QTable.BackColor = System.Drawing.Color.AliceBlue;
            this.QTable.Controls.Add(this.button22);
            this.QTable.Controls.Add(this.button21);
            this.QTable.Controls.Add(this.QTable_DGV);
            this.QTable.Controls.Add(this.button5);
            this.QTable.Location = new System.Drawing.Point(4, 22);
            this.QTable.Name = "QTable";
            this.QTable.Padding = new System.Windows.Forms.Padding(3);
            this.QTable.Size = new System.Drawing.Size(935, 504);
            this.QTable.TabIndex = 3;
            this.QTable.Text = "QTable";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(545, 440);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(106, 32);
            this.button22.TabIndex = 7;
            this.button22.Text = "Send";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.Send_QTable_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(372, 439);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(105, 33);
            this.button21.TabIndex = 6;
            this.button21.Text = "Delete";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.Delete_QTable_Entry_Click);
            // 
            // QTable_DGV
            // 
            this.QTable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QTable_DGV.Location = new System.Drawing.Point(205, 15);
            this.QTable_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.QTable_DGV.Name = "QTable_DGV";
            this.QTable_DGV.RowHeadersWidth = 51;
            this.QTable_DGV.RowTemplate.Height = 24;
            this.QTable_DGV.Size = new System.Drawing.Size(446, 401);
            this.QTable_DGV.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(205, 439);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 33);
            this.button5.TabIndex = 4;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Update_QTable_Entry_Click);
            // 
            // Commands
            // 
            this.Commands.BackColor = System.Drawing.Color.AliceBlue;
            this.Commands.Controls.Add(this.button12);
            this.Commands.Controls.Add(this.label114);
            this.Commands.Controls.Add(this.label113);
            this.Commands.Controls.Add(this.label112);
            this.Commands.Controls.Add(this.textBox116);
            this.Commands.Controls.Add(this.textBox115);
            this.Commands.Controls.Add(this.textBox114);
            this.Commands.Controls.Add(this.textBox21);
            this.Commands.Controls.Add(this.button36);
            this.Commands.Controls.Add(this.button32);
            this.Commands.Controls.Add(this.button31);
            this.Commands.Controls.Add(this.button25);
            this.Commands.Controls.Add(this.button24);
            this.Commands.Controls.Add(this.button23);
            this.Commands.Controls.Add(this.BottomLineSendBtn);
            this.Commands.Controls.Add(this.TopLineSendBtn);
            this.Commands.Controls.Add(this.button3);
            this.Commands.Controls.Add(this.button4);
            this.Commands.Controls.Add(this.ResetCommand);
            this.Commands.Cursor = System.Windows.Forms.Cursors.Default;
            this.Commands.Location = new System.Drawing.Point(4, 22);
            this.Commands.Name = "Commands";
            this.Commands.Padding = new System.Windows.Forms.Padding(3);
            this.Commands.Size = new System.Drawing.Size(935, 504);
            this.Commands.TabIndex = 2;
            this.Commands.Text = "Commands";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(372, 76);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 21);
            this.button12.TabIndex = 89;
            this.button12.Text = "Send Wthr ID";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.WeatherID_Send_Click);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(258, 204);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(66, 13);
            this.label114.TabIndex = 88;
            this.label114.Text = "Sub member";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(185, 204);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(45, 13);
            this.label113.TabIndex = 87;
            this.label113.Text = "Member";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(78, 204);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(86, 13);
            this.label112.TabIndex = 86;
            this.label112.Text = "Command Family";
            // 
            // textBox116
            // 
            this.textBox116.Location = new System.Drawing.Point(251, 220);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(85, 20);
            this.textBox116.TabIndex = 85;
            // 
            // textBox115
            // 
            this.textBox115.Location = new System.Drawing.Point(170, 220);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(75, 20);
            this.textBox115.TabIndex = 84;
            // 
            // textBox114
            // 
            this.textBox114.Location = new System.Drawing.Point(77, 220);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(87, 20);
            this.textBox114.TabIndex = 83;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox21.Location = new System.Drawing.Point(7, 431);
            this.textBox21.Margin = new System.Windows.Forms.Padding(2);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(921, 46);
            this.textBox21.TabIndex = 40;
            // 
            // button36
            // 
            this.button36.Location = new System.Drawing.Point(352, 209);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(107, 31);
            this.button36.TabIndex = 82;
            this.button36.Text = "Util Request";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.UtilityCommand_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(590, 34);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(85, 28);
            this.button32.TabIndex = 81;
            this.button32.Text = "Box On";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.SendManualBoxOn_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(466, 35);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(109, 27);
            this.button31.TabIndex = 80;
            this.button31.Text = "Box Off";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.SendManualBoxOff_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(208, 36);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(104, 26);
            this.button25.TabIndex = 79;
            this.button25.Text = "Save Data";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.SaveDataButton_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(333, 112);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(130, 32);
            this.button24.TabIndex = 60;
            this.button24.Text = "Send G3 DST Exit";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.Send_DST_G3_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(194, 112);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(130, 32);
            this.button23.TabIndex = 59;
            this.button23.Text = "Send G2 DST Enter";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.Send_DST_G2_Click);
            // 
            // BottomLineSendBtn
            // 
            this.BottomLineSendBtn.Location = new System.Drawing.Point(220, 76);
            this.BottomLineSendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BottomLineSendBtn.Name = "BottomLineSendBtn";
            this.BottomLineSendBtn.Size = new System.Drawing.Size(122, 23);
            this.BottomLineSendBtn.TabIndex = 50;
            this.BottomLineSendBtn.Text = "Bottom Line Send";
            this.BottomLineSendBtn.UseVisualStyleBackColor = true;
            this.BottomLineSendBtn.Click += new System.EventHandler(this.BottomLineSendBtn_Click);
            // 
            // TopLineSendBtn
            // 
            this.TopLineSendBtn.Location = new System.Drawing.Point(77, 77);
            this.TopLineSendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.TopLineSendBtn.Name = "TopLineSendBtn";
            this.TopLineSendBtn.Size = new System.Drawing.Size(123, 22);
            this.TopLineSendBtn.TabIndex = 48;
            this.TopLineSendBtn.Text = "Top Line Send";
            this.TopLineSendBtn.UseVisualStyleBackColor = true;
            this.TopLineSendBtn.Click += new System.EventHandler(this.TopLineSendBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 117);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Send Clock Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SendClockData_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(333, 36);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "Version Check";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Version_Check_Click);
            // 
            // ResetCommand
            // 
            this.ResetCommand.Location = new System.Drawing.Point(78, 36);
            this.ResetCommand.Name = "ResetCommand";
            this.ResetCommand.Size = new System.Drawing.Size(104, 26);
            this.ResetCommand.TabIndex = 0;
            this.ResetCommand.Text = "Reset Command";
            this.ResetCommand.UseVisualStyleBackColor = true;
            this.ResetCommand.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.AliceBlue;
            this.Config.Controls.Add(this.panel2);
            this.Config.Controls.Add(this.Config_Update_Button);
            this.Config.Controls.Add(this.button15);
            this.Config.Controls.Add(this.Old);
            this.Config.Controls.Add(this.panel1);
            this.Config.Location = new System.Drawing.Point(4, 22);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(935, 504);
            this.Config.TabIndex = 4;
            this.Config.Text = "Config";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label70);
            this.panel2.Controls.Add(this.label69);
            this.panel2.Controls.Add(this.textBox77);
            this.panel2.Controls.Add(this.textBox76);
            this.panel2.Controls.Add(this.textBox48);
            this.panel2.Controls.Add(this.textBox58);
            this.panel2.Controls.Add(this.textBox49);
            this.panel2.Controls.Add(this.textBox68);
            this.panel2.Controls.Add(this.textBox50);
            this.panel2.Controls.Add(this.textBox59);
            this.panel2.Controls.Add(this.textBox51);
            this.panel2.Controls.Add(this.textBox80);
            this.panel2.Controls.Add(this.textBox52);
            this.panel2.Controls.Add(this.textBox60);
            this.panel2.Controls.Add(this.textBox53);
            this.panel2.Controls.Add(this.textBox69);
            this.panel2.Controls.Add(this.textBox54);
            this.panel2.Controls.Add(this.textBox61);
            this.panel2.Controls.Add(this.textBox55);
            this.panel2.Controls.Add(this.label79);
            this.panel2.Controls.Add(this.textBox56);
            this.panel2.Controls.Add(this.textBox62);
            this.panel2.Controls.Add(this.textBox57);
            this.panel2.Controls.Add(this.textBox70);
            this.panel2.Controls.Add(this.label49);
            this.panel2.Controls.Add(this.textBox63);
            this.panel2.Controls.Add(this.label50);
            this.panel2.Controls.Add(this.label81);
            this.panel2.Controls.Add(this.label51);
            this.panel2.Controls.Add(this.textBox64);
            this.panel2.Controls.Add(this.label52);
            this.panel2.Controls.Add(this.textBox71);
            this.panel2.Controls.Add(this.label53);
            this.panel2.Controls.Add(this.textBox65);
            this.panel2.Controls.Add(this.label54);
            this.panel2.Controls.Add(this.textBox78);
            this.panel2.Controls.Add(this.label55);
            this.panel2.Controls.Add(this.textBox66);
            this.panel2.Controls.Add(this.label56);
            this.panel2.Controls.Add(this.textBox72);
            this.panel2.Controls.Add(this.label57);
            this.panel2.Controls.Add(this.label58);
            this.panel2.Controls.Add(this.label60);
            this.panel2.Controls.Add(this.textBox47);
            this.panel2.Controls.Add(this.textBox79);
            this.panel2.Controls.Add(this.textBox46);
            this.panel2.Controls.Add(this.label61);
            this.panel2.Controls.Add(this.textBox45);
            this.panel2.Controls.Add(this.textBox73);
            this.panel2.Controls.Add(this.textBox44);
            this.panel2.Controls.Add(this.label62);
            this.panel2.Controls.Add(this.textBox43);
            this.panel2.Controls.Add(this.label80);
            this.panel2.Controls.Add(this.textBox42);
            this.panel2.Controls.Add(this.label63);
            this.panel2.Controls.Add(this.textBox41);
            this.panel2.Controls.Add(this.textBox74);
            this.panel2.Controls.Add(this.textBox40);
            this.panel2.Controls.Add(this.label64);
            this.panel2.Controls.Add(this.textBox39);
            this.panel2.Controls.Add(this.label59);
            this.panel2.Controls.Add(this.label48);
            this.panel2.Controls.Add(this.label65);
            this.panel2.Controls.Add(this.label47);
            this.panel2.Controls.Add(this.textBox75);
            this.panel2.Controls.Add(this.label46);
            this.panel2.Controls.Add(this.label66);
            this.panel2.Controls.Add(this.label45);
            this.panel2.Controls.Add(this.textBox67);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.label67);
            this.panel2.Controls.Add(this.label43);
            this.panel2.Controls.Add(this.label71);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.label68);
            this.panel2.Controls.Add(this.label41);
            this.panel2.Controls.Add(this.label78);
            this.panel2.Controls.Add(this.label40);
            this.panel2.Controls.Add(this.label72);
            this.panel2.Controls.Add(this.label77);
            this.panel2.Controls.Add(this.label73);
            this.panel2.Controls.Add(this.label76);
            this.panel2.Controls.Add(this.label74);
            this.panel2.Controls.Add(this.label75);
            this.panel2.Location = new System.Drawing.Point(10, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 285);
            this.panel2.TabIndex = 128;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(754, 12);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(85, 13);
            this.label70.TabIndex = 106;
            this.label70.Text = "PC Disk Support";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(733, 44);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(116, 13);
            this.label69.TabIndex = 107;
            this.label69.Text = "Ret. Trade Zone Audio";
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(853, 37);
            this.textBox77.Margin = new System.Windows.Forms.Padding(2);
            this.textBox77.Name = "textBox77";
            this.textBox77.Size = new System.Drawing.Size(41, 20);
            this.textBox77.TabIndex = 108;
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(853, 9);
            this.textBox76.Margin = new System.Windows.Forms.Padding(2);
            this.textBox76.Name = "textBox76";
            this.textBox76.Size = new System.Drawing.Size(41, 20);
            this.textBox76.TabIndex = 109;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(134, 252);
            this.textBox48.Margin = new System.Windows.Forms.Padding(2);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(41, 20);
            this.textBox48.TabIndex = 77;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(498, 5);
            this.textBox58.Margin = new System.Windows.Forms.Padding(2);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(41, 20);
            this.textBox58.TabIndex = 97;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(295, 6);
            this.textBox49.Margin = new System.Windows.Forms.Padding(2);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(41, 20);
            this.textBox49.TabIndex = 76;
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(686, 37);
            this.textBox68.Margin = new System.Windows.Forms.Padding(2);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(41, 20);
            this.textBox68.TabIndex = 117;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(295, 30);
            this.textBox50.Margin = new System.Windows.Forms.Padding(2);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(41, 20);
            this.textBox50.TabIndex = 75;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(498, 37);
            this.textBox59.Margin = new System.Windows.Forms.Padding(2);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(41, 20);
            this.textBox59.TabIndex = 96;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(295, 55);
            this.textBox51.Margin = new System.Windows.Forms.Padding(2);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(41, 20);
            this.textBox51.TabIndex = 74;
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(853, 118);
            this.textBox80.Margin = new System.Windows.Forms.Padding(2);
            this.textBox80.Name = "textBox80";
            this.textBox80.Size = new System.Drawing.Size(41, 20);
            this.textBox80.TabIndex = 123;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(296, 82);
            this.textBox52.Margin = new System.Windows.Forms.Padding(2);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(41, 20);
            this.textBox52.TabIndex = 73;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(498, 61);
            this.textBox60.Margin = new System.Windows.Forms.Padding(2);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(41, 20);
            this.textBox60.TabIndex = 95;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(296, 114);
            this.textBox53.Margin = new System.Windows.Forms.Padding(2);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(41, 20);
            this.textBox53.TabIndex = 72;
            // 
            // textBox69
            // 
            this.textBox69.Location = new System.Drawing.Point(686, 61);
            this.textBox69.Margin = new System.Windows.Forms.Padding(2);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(41, 20);
            this.textBox69.TabIndex = 116;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(296, 145);
            this.textBox54.Margin = new System.Windows.Forms.Padding(2);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(41, 20);
            this.textBox54.TabIndex = 71;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(498, 86);
            this.textBox61.Margin = new System.Windows.Forms.Padding(2);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(41, 20);
            this.textBox61.TabIndex = 94;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(293, 169);
            this.textBox55.Margin = new System.Windows.Forms.Padding(2);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(41, 20);
            this.textBox55.TabIndex = 70;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(764, 68);
            this.label79.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(64, 13);
            this.label79.TabIndex = 118;
            this.label79.Text = "Flexible Grid";
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(296, 200);
            this.textBox56.Margin = new System.Windows.Forms.Padding(2);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(41, 20);
            this.textBox56.TabIndex = 69;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(498, 113);
            this.textBox62.Margin = new System.Windows.Forms.Padding(2);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(41, 20);
            this.textBox62.TabIndex = 93;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(295, 224);
            this.textBox57.Margin = new System.Windows.Forms.Padding(2);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(41, 20);
            this.textBox57.TabIndex = 68;
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(686, 87);
            this.textBox70.Margin = new System.Windows.Forms.Padding(2);
            this.textBox70.Name = "textBox70";
            this.textBox70.Size = new System.Drawing.Size(41, 20);
            this.textBox70.TabIndex = 115;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(189, 230);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(103, 13);
            this.label49.TabIndex = 67;
            this.label49.Text = "Laser Insertion Type";
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(498, 144);
            this.textBox63.Margin = new System.Windows.Forms.Padding(2);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(41, 20);
            this.textBox63.TabIndex = 92;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(196, 203);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(96, 13);
            this.label50.TabIndex = 66;
            this.label50.Text = "VideoVue Insertion";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(784, 124);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(55, 13);
            this.label81.TabIndex = 122;
            this.label81.Text = "ClockCmd";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(196, 175);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(93, 13);
            this.label51.TabIndex = 65;
            this.label51.Text = "Grid Roll and Hold";
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(498, 169);
            this.textBox64.Margin = new System.Windows.Forms.Padding(2);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(41, 20);
            this.textBox64.TabIndex = 91;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(184, 148);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(153, 13);
            this.label52.TabIndex = 64;
            this.label52.Text = "Grid Sport Summ Roll and Hold";
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(686, 117);
            this.textBox71.Margin = new System.Windows.Forms.Padding(2);
            this.textBox71.Name = "textBox71";
            this.textBox71.Size = new System.Drawing.Size(41, 20);
            this.textBox71.TabIndex = 114;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(181, 117);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(145, 13);
            this.label53.TabIndex = 63;
            this.label53.Text = "Grid PrimeTime Roll and Hold";
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(498, 196);
            this.textBox65.Margin = new System.Windows.Forms.Padding(2);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(41, 20);
            this.textBox65.TabIndex = 90;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(177, 83);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(160, 13);
            this.label54.TabIndex = 62;
            this.label54.Text = "Grid Movie Recap Roll and Hold";
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(853, 68);
            this.textBox78.Margin = new System.Windows.Forms.Padding(2);
            this.textBox78.Name = "textBox78";
            this.textBox78.Size = new System.Drawing.Size(41, 20);
            this.textBox78.TabIndex = 119;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(184, 61);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(117, 13);
            this.label55.TabIndex = 61;
            this.label55.Text = "Grid SBS Roll and Hold";
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(498, 226);
            this.textBox66.Margin = new System.Windows.Forms.Padding(2);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(41, 20);
            this.textBox66.TabIndex = 89;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(177, 31);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(136, 13);
            this.label56.TabIndex = 60;
            this.label56.Text = "Sports Summary Frequency";
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(686, 145);
            this.textBox72.Margin = new System.Windows.Forms.Padding(2);
            this.textBox72.Name = "textBox72";
            this.textBox72.Size = new System.Drawing.Size(41, 20);
            this.textBox72.TabIndex = 113;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(171, 9);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(155, 13);
            this.label57.TabIndex = 59;
            this.label57.Text = "PrimeTime Summary Frequency";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(75, 255);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(55, 13);
            this.label58.TabIndex = 58;
            this.label58.Text = "Language";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(359, 230);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(195, 13);
            this.label60.TabIndex = 86;
            this.label60.Text = "PPV Disp After Prg StartAftrOrdr 3 chars";
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(131, 230);
            this.textBox47.Margin = new System.Windows.Forms.Padding(2);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(36, 20);
            this.textBox47.TabIndex = 57;
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(853, 94);
            this.textBox79.Margin = new System.Windows.Forms.Padding(2);
            this.textBox79.Name = "textBox79";
            this.textBox79.Size = new System.Drawing.Size(41, 20);
            this.textBox79.TabIndex = 121;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(142, 203);
            this.textBox46.Margin = new System.Windows.Forms.Padding(2);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(36, 20);
            this.textBox46.TabIndex = 56;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(367, 203);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(127, 13);
            this.label61.TabIndex = 85;
            this.label61.Text = "Sports Summ LookAhead";
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(144, 175);
            this.textBox45.Margin = new System.Windows.Forms.Padding(2);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(36, 20);
            this.textBox45.TabIndex = 55;
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(686, 170);
            this.textBox73.Margin = new System.Windows.Forms.Padding(2);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(41, 20);
            this.textBox73.TabIndex = 112;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(144, 145);
            this.textBox44.Margin = new System.Windows.Forms.Padding(2);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(36, 20);
            this.textBox44.TabIndex = 54;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(370, 172);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(128, 13);
            this.label62.TabIndex = 84;
            this.label62.Text = "PrimeTime Promo End TS";
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(144, 114);
            this.textBox43.Margin = new System.Windows.Forms.Padding(2);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(36, 20);
            this.textBox43.TabIndex = 53;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(729, 97);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(120, 13);
            this.label80.TabIndex = 120;
            this.label80.Text = "Ret Trade Zone System";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(144, 83);
            this.textBox42.Margin = new System.Windows.Forms.Padding(2);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(36, 20);
            this.textBox42.TabIndex = 52;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(370, 148);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(131, 13);
            this.label63.TabIndex = 83;
            this.label63.Text = "PrimeTime Promo Start TS";
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(144, 55);
            this.textBox41.Margin = new System.Windows.Forms.Padding(2);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(36, 20);
            this.textBox41.TabIndex = 51;
            // 
            // textBox74
            // 
            this.textBox74.Location = new System.Drawing.Point(686, 196);
            this.textBox74.Margin = new System.Windows.Forms.Padding(2);
            this.textBox74.Name = "textBox74";
            this.textBox74.Size = new System.Drawing.Size(41, 20);
            this.textBox74.TabIndex = 111;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(144, 28);
            this.textBox40.Margin = new System.Windows.Forms.Padding(2);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(36, 20);
            this.textBox40.TabIndex = 50;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(359, 120);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(191, 13);
            this.label64.TabIndex = 82;
            this.label64.Text = "Grid Synopsis Roll/Hold - F setting lock";
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(144, 2);
            this.textBox39.Margin = new System.Windows.Forms.Padding(2);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(36, 20);
            this.textBox39.TabIndex = 49;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(576, 12);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(106, 13);
            this.label59.TabIndex = 87;
            this.label59.Text = "Cycle Summary Freq.";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(69, 230);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(57, 13);
            this.label48.TabIndex = 48;
            this.label48.Text = "Pie Format";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(399, 86);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(71, 13);
            this.label65.TabIndex = 81;
            this.label65.Text = "Grid Synopsis";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(-2, 206);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(140, 13);
            this.label47.TabIndex = 47;
            this.label47.Text = "AdVue/Graphic Ad Insertion";
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(686, 227);
            this.textBox75.Margin = new System.Windows.Forms.Padding(2);
            this.textBox75.Name = "textBox75";
            this.textBox75.Size = new System.Drawing.Size(41, 20);
            this.textBox75.TabIndex = 110;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(33, 178);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(106, 13);
            this.label46.TabIndex = 46;
            this.label46.Text = "Display Format Mode";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(382, 61);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(100, 13);
            this.label66.TabIndex = 80;
            this.label66.Text = "Cycle Summary Info";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(-2, 148);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(153, 13);
            this.label45.TabIndex = 45;
            this.label45.Text = "Scroll SBS TimeSlt LookAhead";
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(686, 9);
            this.textBox67.Margin = new System.Windows.Forms.Padding(2);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(41, 20);
            this.textBox67.TabIndex = 88;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(-2, 117);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(152, 13);
            this.label44.TabIndex = 44;
            this.label44.Text = "Grid SBS TimeSlot LookAhead";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(349, 40);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(160, 13);
            this.label67.TabIndex = 79;
            this.label67.Text = "PrimeTime LookAheadTimeSlots";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(49, 83);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(77, 13);
            this.label43.TabIndex = 43;
            this.label43.Text = "Grid SBS Freq.";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(598, 233);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(67, 13);
            this.label71.TabIndex = 105;
            this.label71.Text = "Text Ad Flag";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(37, 58);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(98, 13);
            this.label42.TabIndex = 42;
            this.label42.Text = "Movie Recap Freq.";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(355, 12);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(139, 13);
            this.label68.TabIndex = 78;
            this.label68.Text = "PrimeTime Starting TimeSlot";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 30);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(136, 13);
            this.label41.TabIndex = 41;
            this.label41.Text = "Grid Source/Channel Order";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(560, 44);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(122, 13);
            this.label78.TabIndex = 98;
            this.label78.Text = "System Default Brush ID";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(53, 9);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(77, 13);
            this.label40.TabIndex = 40;
            this.label40.Text = "Grid Hold Time";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(609, 203);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(58, 13);
            this.label72.TabIndex = 104;
            this.label72.Text = "# of Colors";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(567, 68);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(115, 13);
            this.label77.TabIndex = 99;
            this.label77.Text = "Weather Roll and Hold";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(577, 173);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(105, 13);
            this.label73.TabIndex = 103;
            this.label73.Text = "Custom Disp Length ";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(609, 93);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(65, 13);
            this.label76.TabIndex = 100;
            this.label76.Text = "Military Time";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(582, 148);
            this.label74.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(100, 13);
            this.label74.TabIndex = 102;
            this.label74.Text = "Disp Length Setting";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(576, 120);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(118, 13);
            this.label75.TabIndex = 101;
            this.label75.Text = "Cleanup Unused Logos";
            // 
            // Config_Update_Button
            // 
            this.Config_Update_Button.Location = new System.Drawing.Point(303, 463);
            this.Config_Update_Button.Name = "Config_Update_Button";
            this.Config_Update_Button.Size = new System.Drawing.Size(102, 25);
            this.Config_Update_Button.TabIndex = 126;
            this.Config_Update_Button.Text = "Update";
            this.Config_Update_Button.UseVisualStyleBackColor = true;
            this.Config_Update_Button.Click += new System.EventHandler(this.Config_UpdateEntries_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(560, 463);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 24);
            this.button15.TabIndex = 125;
            this.button15.Text = "new";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SendNewConfig_Click);
            // 
            // Old
            // 
            this.Old.Location = new System.Drawing.Point(437, 463);
            this.Old.Margin = new System.Windows.Forms.Padding(2);
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(112, 25);
            this.Old.TabIndex = 124;
            this.Old.Text = "old";
            this.Old.UseVisualStyleBackColor = true;
            this.Old.Click += new System.EventHandler(this.SendOldConfig_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox38);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.textBox34);
            this.panel1.Controls.Add(this.textBox35);
            this.panel1.Controls.Add(this.textBox36);
            this.panel1.Controls.Add(this.textBox37);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.textBox29);
            this.panel1.Controls.Add(this.textBox30);
            this.panel1.Controls.Add(this.textBox31);
            this.panel1.Controls.Add(this.textBox32);
            this.panel1.Controls.Add(this.textBox33);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox22);
            this.panel1.Controls.Add(this.textBox28);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 133);
            this.panel1.TabIndex = 127;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(812, 71);
            this.textBox38.Margin = new System.Windows.Forms.Padding(2);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(41, 20);
            this.textBox38.TabIndex = 39;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(538, 66);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(103, 13);
            this.label35.TabIndex = 15;
            this.label35.Text = "Movie Summary Pay";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(559, 94);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 13);
            this.label36.TabIndex = 16;
            this.label36.Text = "Movie Summary";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(743, 13);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(49, 13);
            this.label37.TabIndex = 17;
            this.label37.Text = "Graphics";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(731, 42);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(77, 13);
            this.label38.TabIndex = 18;
            this.label38.Text = "Video Insertion";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(722, 74);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(86, 13);
            this.label39.TabIndex = 19;
            this.label39.Text = "Time Offset (min)";
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(645, 63);
            this.textBox34.Margin = new System.Windows.Forms.Padding(2);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(41, 20);
            this.textBox34.TabIndex = 35;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(645, 91);
            this.textBox35.Margin = new System.Windows.Forms.Padding(2);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(41, 20);
            this.textBox35.TabIndex = 36;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(812, 10);
            this.textBox36.Margin = new System.Windows.Forms.Padding(2);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(41, 20);
            this.textBox36.TabIndex = 37;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(812, 38);
            this.textBox37.Margin = new System.Windows.Forms.Padding(2);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(41, 20);
            this.textBox37.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Observe DST";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(384, 66);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 13);
            this.label31.TabIndex = 11;
            this.label31.Text = "Continuation";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(398, 94);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Keyboard";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(547, 9);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 13);
            this.label33.TabIndex = 13;
            this.label33.Text = "Minus 10 windows";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(553, 38);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(88, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Minus 3 windows";
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(458, 35);
            this.textBox29.Margin = new System.Windows.Forms.Padding(2);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(41, 20);
            this.textBox29.TabIndex = 30;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(457, 63);
            this.textBox30.Margin = new System.Windows.Forms.Padding(2);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(41, 20);
            this.textBox30.TabIndex = 31;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(458, 91);
            this.textBox31.Margin = new System.Windows.Forms.Padding(2);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(41, 20);
            this.textBox31.TabIndex = 32;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(645, 6);
            this.textBox32.Margin = new System.Windows.Forms.Padding(2);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(41, 20);
            this.textBox32.TabIndex = 33;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(645, 35);
            this.textBox33.Margin = new System.Windows.Forms.Padding(2);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(41, 20);
            this.textBox33.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "# Lines in Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "EPG Crawl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Minus Minutes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Plus Minutes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Time Zone";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(312, 6);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(38, 20);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(312, 35);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(38, 20);
            this.textBox8.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(312, 63);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(38, 20);
            this.textBox9.TabIndex = 27;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(310, 90);
            this.textBox22.Margin = new System.Windows.Forms.Padding(2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(40, 20);
            this.textBox22.TabIndex = 28;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(458, 6);
            this.textBox28.Margin = new System.Windows.Forms.Padding(2);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(40, 20);
            this.textBox28.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backward Display Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Forward Display Window";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Scroll Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "# Local Ads";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 20);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 35);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(38, 20);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 63);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 20);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 90);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(38, 20);
            this.textBox5.TabIndex = 23;
            // 
            // Weathertab
            // 
            this.Weathertab.BackColor = System.Drawing.Color.AliceBlue;
            this.Weathertab.Controls.Add(this.label91);
            this.Weathertab.Controls.Add(this.label90);
            this.Weathertab.Controls.Add(this.textBox86);
            this.Weathertab.Controls.Add(this.textBox85);
            this.Weathertab.Controls.Add(this.textBox84);
            this.Weathertab.Controls.Add(this.textBox83);
            this.Weathertab.Controls.Add(this.textBox82);
            this.Weathertab.Controls.Add(this.textBox6);
            this.Weathertab.Controls.Add(this.textBox18);
            this.Weathertab.Controls.Add(this.textBox17);
            this.Weathertab.Controls.Add(this.textBox14);
            this.Weathertab.Controls.Add(this.button17);
            this.Weathertab.Controls.Add(this.button16);
            this.Weathertab.Controls.Add(this.label87);
            this.Weathertab.Controls.Add(this.label86);
            this.Weathertab.Controls.Add(this.label85);
            this.Weathertab.Controls.Add(this.label84);
            this.Weathertab.Controls.Add(this.label83);
            this.Weathertab.Controls.Add(this.label82);
            this.Weathertab.Controls.Add(this.label6);
            this.Weathertab.Controls.Add(this.button9);
            this.Weathertab.Controls.Add(this.label18);
            this.Weathertab.Location = new System.Drawing.Point(4, 22);
            this.Weathertab.Name = "Weathertab";
            this.Weathertab.Padding = new System.Windows.Forms.Padding(3);
            this.Weathertab.Size = new System.Drawing.Size(935, 504);
            this.Weathertab.TabIndex = 5;
            this.Weathertab.Text = "Weather";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(190, 22);
            this.label91.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(28, 13);
            this.label91.TabIndex = 40;
            this.label91.Text = "0:00";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(66, 22);
            this.label90.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(114, 13);
            this.label90.TabIndex = 39;
            this.label90.Text = "Time until next update:";
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(193, 80);
            this.textBox86.Margin = new System.Windows.Forms.Padding(2);
            this.textBox86.Name = "textBox86";
            this.textBox86.Size = new System.Drawing.Size(346, 20);
            this.textBox86.TabIndex = 38;
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(193, 278);
            this.textBox85.Margin = new System.Windows.Forms.Padding(2);
            this.textBox85.Name = "textBox85";
            this.textBox85.Size = new System.Drawing.Size(347, 20);
            this.textBox85.TabIndex = 35;
            // 
            // textBox84
            // 
            this.textBox84.Location = new System.Drawing.Point(192, 145);
            this.textBox84.Margin = new System.Windows.Forms.Padding(2);
            this.textBox84.Name = "textBox84";
            this.textBox84.Size = new System.Drawing.Size(347, 20);
            this.textBox84.TabIndex = 32;
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(192, 211);
            this.textBox83.Margin = new System.Windows.Forms.Padding(2);
            this.textBox83.Name = "textBox83";
            this.textBox83.Size = new System.Drawing.Size(347, 20);
            this.textBox83.TabIndex = 27;
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(192, 178);
            this.textBox82.Margin = new System.Windows.Forms.Padding(2);
            this.textBox82.Name = "textBox82";
            this.textBox82.Size = new System.Drawing.Size(347, 20);
            this.textBox82.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(193, 245);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(347, 20);
            this.textBox6.TabIndex = 25;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(192, 112);
            this.textBox18.Margin = new System.Windows.Forms.Padding(2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(347, 20);
            this.textBox18.TabIndex = 15;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(193, 56);
            this.textBox17.Margin = new System.Windows.Forms.Padding(2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(347, 20);
            this.textBox17.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(616, 80);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(39, 20);
            this.textBox14.TabIndex = 11;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(359, 17);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(74, 23);
            this.button17.TabIndex = 37;
            this.button17.Text = "Stop";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.StopWeatherDataTimer);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(272, 16);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(72, 24);
            this.button16.TabIndex = 36;
            this.button16.Text = "Start";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.StartWeatherDataTimer);
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(146, 281);
            this.label87.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(43, 13);
            this.label87.TabIndex = 34;
            this.label87.Text = "Visibility";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(155, 148);
            this.label86.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(32, 13);
            this.label86.TabIndex = 33;
            this.label86.Text = "Wind";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(140, 214);
            this.label85.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(48, 13);
            this.label85.TabIndex = 31;
            this.label85.Text = "Pressure";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(141, 181);
            this.label84.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(47, 13);
            this.label84.TabIndex = 30;
            this.label84.Text = "Humidity";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(133, 248);
            this.label83.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(56, 13);
            this.label83.TabIndex = 29;
            this.label83.Text = "Dew Point";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(121, 114);
            this.label82.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(67, 13);
            this.label82.TabIndex = 28;
            this.label82.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Current Weather";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(446, 16);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 24);
            this.button9.TabIndex = 22;
            this.button9.Text = "Send Wthr Data";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SendWeatherData_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(570, 83);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Icon ID";
            // 
            // Downloadtab
            // 
            this.Downloadtab.BackColor = System.Drawing.Color.AliceBlue;
            this.Downloadtab.Controls.Add(this.button1);
            this.Downloadtab.Controls.Add(this.button29);
            this.Downloadtab.Controls.Add(this.button28);
            this.Downloadtab.Controls.Add(this.Z2I_Listings_DGV);
            this.Downloadtab.Controls.Add(this.Z2I_Lineup_DGV);
            this.Downloadtab.Controls.Add(this.Download);
            this.Downloadtab.Location = new System.Drawing.Point(4, 22);
            this.Downloadtab.Margin = new System.Windows.Forms.Padding(2);
            this.Downloadtab.Name = "Downloadtab";
            this.Downloadtab.Padding = new System.Windows.Forms.Padding(2);
            this.Downloadtab.Size = new System.Drawing.Size(935, 504);
            this.Downloadtab.TabIndex = 9;
            this.Downloadtab.Text = "Download";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Z2I_LoadDataGridViews_Click);
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(839, 105);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(78, 30);
            this.button29.TabIndex = 8;
            this.button29.Text = "List Merge";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(755, 105);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(78, 31);
            this.button28.TabIndex = 7;
            this.button28.Text = "Merge";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.Lineup_Z2I_Import_Click);
            // 
            // Z2I_Listings_DGV
            // 
            this.Z2I_Listings_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Z2I_Listings_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Z2I_Listings_DGV.Location = new System.Drawing.Point(8, 158);
            this.Z2I_Listings_DGV.Name = "Z2I_Listings_DGV";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Z2I_Listings_DGV.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Z2I_Listings_DGV.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Z2I_Listings_DGV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Z2I_Listings_DGV.Size = new System.Drawing.Size(919, 341);
            this.Z2I_Listings_DGV.TabIndex = 6;
            // 
            // Z2I_Lineup_DGV
            // 
            this.Z2I_Lineup_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Z2I_Lineup_DGV.Location = new System.Drawing.Point(8, 5);
            this.Z2I_Lineup_DGV.Name = "Z2I_Lineup_DGV";
            this.Z2I_Lineup_DGV.Size = new System.Drawing.Size(741, 147);
            this.Z2I_Lineup_DGV.TabIndex = 4;
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(756, 24);
            this.Download.Margin = new System.Windows.Forms.Padding(2);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(78, 28);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Z2I_Download_Click);
            // 
            // Lineuptab
            // 
            this.Lineuptab.BackColor = System.Drawing.Color.AliceBlue;
            this.Lineuptab.Controls.Add(this.Lineup_SendInitialLineup_Button);
            this.Lineuptab.Controls.Add(this.Lineup_Z2I_Import_Button);
            this.Lineuptab.Controls.Add(this.Lineup_InsertBelow_Button);
            this.Lineuptab.Controls.Add(this.Lineup_MoveDown_Button);
            this.Lineuptab.Controls.Add(this.Lineup_MoveUp_Button);
            this.Lineuptab.Controls.Add(this.Lineup_InsertAbove_Button);
            this.Lineuptab.Controls.Add(this.Lineup_UpdateEntries_Button);
            this.Lineuptab.Controls.Add(this.Lineup_DGV);
            this.Lineuptab.Controls.Add(this.Lineup_SendNextDay_Button);
            this.Lineuptab.Controls.Add(this.Lineup_SendCurrentDay_Button);
            this.Lineuptab.Controls.Add(this.Lineup_DeleteSelectedEntries_Button);
            this.Lineuptab.Controls.Add(this.dateTimePicker2);
            this.Lineuptab.Controls.Add(this.label3);
            this.Lineuptab.Controls.Add(this.Jdate);
            this.Lineuptab.Location = new System.Drawing.Point(4, 22);
            this.Lineuptab.Name = "Lineuptab";
            this.Lineuptab.Padding = new System.Windows.Forms.Padding(3);
            this.Lineuptab.Size = new System.Drawing.Size(935, 504);
            this.Lineuptab.TabIndex = 1;
            this.Lineuptab.Text = "Channel Lineup";
            // 
            // Lineup_SendInitialLineup_Button
            // 
            this.Lineup_SendInitialLineup_Button.Location = new System.Drawing.Point(8, 471);
            this.Lineup_SendInitialLineup_Button.Name = "Lineup_SendInitialLineup_Button";
            this.Lineup_SendInitialLineup_Button.Size = new System.Drawing.Size(95, 27);
            this.Lineup_SendInitialLineup_Button.TabIndex = 171;
            this.Lineup_SendInitialLineup_Button.Text = "Initialize CurDay";
            this.Lineup_SendInitialLineup_Button.UseVisualStyleBackColor = true;
            this.Lineup_SendInitialLineup_Button.Click += new System.EventHandler(this.Lineup_SendInitialLineup_Click);
            // 
            // Lineup_Z2I_Import_Button
            // 
            this.Lineup_Z2I_Import_Button.Location = new System.Drawing.Point(687, 470);
            this.Lineup_Z2I_Import_Button.Name = "Lineup_Z2I_Import_Button";
            this.Lineup_Z2I_Import_Button.Size = new System.Drawing.Size(69, 27);
            this.Lineup_Z2I_Import_Button.TabIndex = 170;
            this.Lineup_Z2I_Import_Button.Text = "Import";
            this.Lineup_Z2I_Import_Button.UseVisualStyleBackColor = true;
            this.Lineup_Z2I_Import_Button.Click += new System.EventHandler(this.Lineup_Z2I_Import_Click);
            // 
            // Lineup_InsertBelow_Button
            // 
            this.Lineup_InsertBelow_Button.Location = new System.Drawing.Point(576, 471);
            this.Lineup_InsertBelow_Button.Name = "Lineup_InsertBelow_Button";
            this.Lineup_InsertBelow_Button.Size = new System.Drawing.Size(80, 27);
            this.Lineup_InsertBelow_Button.TabIndex = 169;
            this.Lineup_InsertBelow_Button.Text = "Insert Below";
            this.Lineup_InsertBelow_Button.UseVisualStyleBackColor = true;
            this.Lineup_InsertBelow_Button.Click += new System.EventHandler(this.Lineup_InsertEntryBelow_Click);
            // 
            // Lineup_MoveDown_Button
            // 
            this.Lineup_MoveDown_Button.Location = new System.Drawing.Point(399, 471);
            this.Lineup_MoveDown_Button.Name = "Lineup_MoveDown_Button";
            this.Lineup_MoveDown_Button.Size = new System.Drawing.Size(76, 27);
            this.Lineup_MoveDown_Button.TabIndex = 168;
            this.Lineup_MoveDown_Button.Text = "Move Down";
            this.Lineup_MoveDown_Button.UseVisualStyleBackColor = true;
            this.Lineup_MoveDown_Button.Click += new System.EventHandler(this.Lineup_MoveEntryDown_Click);
            // 
            // Lineup_MoveUp_Button
            // 
            this.Lineup_MoveUp_Button.Location = new System.Drawing.Point(317, 471);
            this.Lineup_MoveUp_Button.Name = "Lineup_MoveUp_Button";
            this.Lineup_MoveUp_Button.Size = new System.Drawing.Size(76, 27);
            this.Lineup_MoveUp_Button.TabIndex = 167;
            this.Lineup_MoveUp_Button.Text = "Move Up";
            this.Lineup_MoveUp_Button.UseVisualStyleBackColor = true;
            this.Lineup_MoveUp_Button.Click += new System.EventHandler(this.Lineup_MoveEntryUp_Click);
            // 
            // Lineup_InsertAbove_Button
            // 
            this.Lineup_InsertAbove_Button.Location = new System.Drawing.Point(491, 471);
            this.Lineup_InsertAbove_Button.Name = "Lineup_InsertAbove_Button";
            this.Lineup_InsertAbove_Button.Size = new System.Drawing.Size(79, 27);
            this.Lineup_InsertAbove_Button.TabIndex = 166;
            this.Lineup_InsertAbove_Button.Text = "Insert Above";
            this.Lineup_InsertAbove_Button.UseVisualStyleBackColor = true;
            this.Lineup_InsertAbove_Button.Click += new System.EventHandler(this.Lineup_InsertEntryAbove_Click);
            // 
            // Lineup_UpdateEntries_Button
            // 
            this.Lineup_UpdateEntries_Button.Location = new System.Drawing.Point(770, 470);
            this.Lineup_UpdateEntries_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Lineup_UpdateEntries_Button.Name = "Lineup_UpdateEntries_Button";
            this.Lineup_UpdateEntries_Button.Size = new System.Drawing.Size(69, 27);
            this.Lineup_UpdateEntries_Button.TabIndex = 165;
            this.Lineup_UpdateEntries_Button.Text = "Update";
            this.Lineup_UpdateEntries_Button.UseVisualStyleBackColor = true;
            this.Lineup_UpdateEntries_Button.Click += new System.EventHandler(this.Lineup_UpdateEntries_Click);
            // 
            // Lineup_DGV
            // 
            this.Lineup_DGV.AllowUserToResizeRows = false;
            this.Lineup_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Lineup_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lineup_DGV.ContextMenuStrip = this.LineupRtClickMenu;
            this.Lineup_DGV.Location = new System.Drawing.Point(7, 37);
            this.Lineup_DGV.Name = "Lineup_DGV";
            this.Lineup_DGV.RowHeadersWidth = 51;
            this.Lineup_DGV.Size = new System.Drawing.Size(921, 428);
            this.Lineup_DGV.TabIndex = 163;
            this.Lineup_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lineup_DGV_CellClick);
            // 
            // Lineup_SendNextDay_Button
            // 
            this.Lineup_SendNextDay_Button.Location = new System.Drawing.Point(205, 470);
            this.Lineup_SendNextDay_Button.Name = "Lineup_SendNextDay_Button";
            this.Lineup_SendNextDay_Button.Size = new System.Drawing.Size(91, 27);
            this.Lineup_SendNextDay_Button.TabIndex = 17;
            this.Lineup_SendNextDay_Button.Text = "Send NextDay";
            this.Lineup_SendNextDay_Button.UseVisualStyleBackColor = true;
            this.Lineup_SendNextDay_Button.Click += new System.EventHandler(this.Lineup_SendNextDay_Click);
            // 
            // Lineup_SendCurrentDay_Button
            // 
            this.Lineup_SendCurrentDay_Button.Location = new System.Drawing.Point(108, 470);
            this.Lineup_SendCurrentDay_Button.Name = "Lineup_SendCurrentDay_Button";
            this.Lineup_SendCurrentDay_Button.Size = new System.Drawing.Size(91, 27);
            this.Lineup_SendCurrentDay_Button.TabIndex = 16;
            this.Lineup_SendCurrentDay_Button.Text = "Send CurDay";
            this.Lineup_SendCurrentDay_Button.UseVisualStyleBackColor = true;
            this.Lineup_SendCurrentDay_Button.Click += new System.EventHandler(this.Lineup_SendCurrentDay_Click);
            // 
            // Lineup_DeleteSelectedEntries_Button
            // 
            this.Lineup_DeleteSelectedEntries_Button.Location = new System.Drawing.Point(844, 471);
            this.Lineup_DeleteSelectedEntries_Button.Name = "Lineup_DeleteSelectedEntries_Button";
            this.Lineup_DeleteSelectedEntries_Button.Size = new System.Drawing.Size(70, 27);
            this.Lineup_DeleteSelectedEntries_Button.TabIndex = 14;
            this.Lineup_DeleteSelectedEntries_Button.Text = "Delete";
            this.Lineup_DeleteSelectedEntries_Button.UseVisualStyleBackColor = true;
            this.Lineup_DeleteSelectedEntries_Button.Click += new System.EventHandler(this.Lineup_DeleteSelectedEntries_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.CalculateChannelJDate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Julian Day";
            // 
            // Jdate
            // 
            this.Jdate.Location = new System.Drawing.Point(205, 9);
            this.Jdate.MaxLength = 3;
            this.Jdate.Name = "Jdate";
            this.Jdate.Size = new System.Drawing.Size(38, 20);
            this.Jdate.TabIndex = 84;
            // 
            // Listings
            // 
            this.Listings.BackColor = System.Drawing.Color.AliceBlue;
            this.Listings.Controls.Add(this.Listings_SendNextDayEntries_Button);
            this.Listings.Controls.Add(this.Listings_Z2I_Import_Button);
            this.Listings.Controls.Add(this.Listings_MoveDown_Button);
            this.Listings.Controls.Add(this.Listings_MoveUp_Button);
            this.Listings.Controls.Add(this.Listings_InsertAbove_Button);
            this.Listings.Controls.Add(this.button30);
            this.Listings.Controls.Add(this.Listings_DGV);
            this.Listings.Controls.Add(this.Listings_UpdateEntries_Button);
            this.Listings.Controls.Add(this.Listings_SendCurrentDayEntries_Button);
            this.Listings.Controls.Add(this.Listings_SendSelectedEntries_Button);
            this.Listings.Controls.Add(this.textBox1);
            this.Listings.Controls.Add(this.Listing_InsertBelow_Button);
            this.Listings.Controls.Add(this.Listings_DeleteSelectedEntries_Button);
            this.Listings.Controls.Add(this.dateTimePicker1);
            this.Listings.Controls.Add(this.JdateLabel);
            this.Listings.Controls.Add(this.comboBox1);
            this.Listings.Controls.Add(this.TimeSlotLabel);
            this.Listings.Location = new System.Drawing.Point(4, 22);
            this.Listings.Name = "Listings";
            this.Listings.Padding = new System.Windows.Forms.Padding(3);
            this.Listings.Size = new System.Drawing.Size(935, 504);
            this.Listings.TabIndex = 0;
            this.Listings.Text = "Listings";
            // 
            // Listings_SendNextDayEntries_Button
            // 
            this.Listings_SendNextDayEntries_Button.Location = new System.Drawing.Point(189, 470);
            this.Listings_SendNextDayEntries_Button.Name = "Listings_SendNextDayEntries_Button";
            this.Listings_SendNextDayEntries_Button.Size = new System.Drawing.Size(81, 27);
            this.Listings_SendNextDayEntries_Button.TabIndex = 54;
            this.Listings_SendNextDayEntries_Button.Text = "Next Day";
            this.Listings_SendNextDayEntries_Button.UseVisualStyleBackColor = true;
            this.Listings_SendNextDayEntries_Button.Click += new System.EventHandler(this.Listings_SendNextDayEntries_Click);
            // 
            // Listings_Z2I_Import_Button
            // 
            this.Listings_Z2I_Import_Button.Location = new System.Drawing.Point(676, 471);
            this.Listings_Z2I_Import_Button.Name = "Listings_Z2I_Import_Button";
            this.Listings_Z2I_Import_Button.Size = new System.Drawing.Size(78, 27);
            this.Listings_Z2I_Import_Button.TabIndex = 53;
            this.Listings_Z2I_Import_Button.Text = "Import";
            this.Listings_Z2I_Import_Button.UseVisualStyleBackColor = true;
            this.Listings_Z2I_Import_Button.Click += new System.EventHandler(this.Listings_Z2I_Import_Click);
            // 
            // Listings_MoveDown_Button
            // 
            this.Listings_MoveDown_Button.AutoSize = true;
            this.Listings_MoveDown_Button.Location = new System.Drawing.Point(426, 471);
            this.Listings_MoveDown_Button.Name = "Listings_MoveDown_Button";
            this.Listings_MoveDown_Button.Size = new System.Drawing.Size(75, 27);
            this.Listings_MoveDown_Button.TabIndex = 52;
            this.Listings_MoveDown_Button.Text = "Move Down";
            this.Listings_MoveDown_Button.UseVisualStyleBackColor = true;
            this.Listings_MoveDown_Button.Click += new System.EventHandler(this.Listings_MoveEntryDown_Click);
            // 
            // Listings_MoveUp_Button
            // 
            this.Listings_MoveUp_Button.AutoSize = true;
            this.Listings_MoveUp_Button.Location = new System.Drawing.Point(348, 471);
            this.Listings_MoveUp_Button.Name = "Listings_MoveUp_Button";
            this.Listings_MoveUp_Button.Size = new System.Drawing.Size(72, 27);
            this.Listings_MoveUp_Button.TabIndex = 51;
            this.Listings_MoveUp_Button.Text = "Move Up";
            this.Listings_MoveUp_Button.UseVisualStyleBackColor = true;
            this.Listings_MoveUp_Button.Click += new System.EventHandler(this.Listings_MoveEntryUp_Click);
            // 
            // Listings_InsertAbove_Button
            // 
            this.Listings_InsertAbove_Button.AutoSize = true;
            this.Listings_InsertAbove_Button.Location = new System.Drawing.Point(508, 471);
            this.Listings_InsertAbove_Button.Name = "Listings_InsertAbove_Button";
            this.Listings_InsertAbove_Button.Size = new System.Drawing.Size(77, 27);
            this.Listings_InsertAbove_Button.TabIndex = 50;
            this.Listings_InsertAbove_Button.Text = "Insert Above";
            this.Listings_InsertAbove_Button.UseVisualStyleBackColor = true;
            this.Listings_InsertAbove_Button.Click += new System.EventHandler(this.Listings_InsertEntryAbove_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(276, 471);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(66, 27);
            this.button30.TabIndex = 48;
            this.button30.Text = "Stop Send";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // Listings_DGV
            // 
            this.Listings_DGV.AllowUserToAddRows = false;
            this.Listings_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listings_DGV.Location = new System.Drawing.Point(5, 40);
            this.Listings_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.Listings_DGV.Name = "Listings_DGV";
            this.Listings_DGV.RowHeadersWidth = 51;
            this.Listings_DGV.RowTemplate.Height = 24;
            this.Listings_DGV.Size = new System.Drawing.Size(925, 425);
            this.Listings_DGV.TabIndex = 46;
            this.Listings_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Listings_DGV_CellClick);
            // 
            // Listings_UpdateEntries_Button
            // 
            this.Listings_UpdateEntries_Button.Location = new System.Drawing.Point(769, 470);
            this.Listings_UpdateEntries_Button.Name = "Listings_UpdateEntries_Button";
            this.Listings_UpdateEntries_Button.Size = new System.Drawing.Size(79, 27);
            this.Listings_UpdateEntries_Button.TabIndex = 44;
            this.Listings_UpdateEntries_Button.Text = "Update";
            this.Listings_UpdateEntries_Button.UseVisualStyleBackColor = true;
            this.Listings_UpdateEntries_Button.Click += new System.EventHandler(this.Listings_UpdateEntries_Click);
            // 
            // Listings_SendCurrentDayEntries_Button
            // 
            this.Listings_SendCurrentDayEntries_Button.Location = new System.Drawing.Point(101, 471);
            this.Listings_SendCurrentDayEntries_Button.Name = "Listings_SendCurrentDayEntries_Button";
            this.Listings_SendCurrentDayEntries_Button.Size = new System.Drawing.Size(82, 25);
            this.Listings_SendCurrentDayEntries_Button.TabIndex = 42;
            this.Listings_SendCurrentDayEntries_Button.Text = "Current Day";
            this.Listings_SendCurrentDayEntries_Button.UseVisualStyleBackColor = true;
            this.Listings_SendCurrentDayEntries_Button.Click += new System.EventHandler(this.Listings_SendCurrentDayEntries_Click);
            // 
            // Listings_SendSelectedEntries_Button
            // 
            this.Listings_SendSelectedEntries_Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Listings_SendSelectedEntries_Button.Location = new System.Drawing.Point(8, 471);
            this.Listings_SendSelectedEntries_Button.Name = "Listings_SendSelectedEntries_Button";
            this.Listings_SendSelectedEntries_Button.Size = new System.Drawing.Size(87, 25);
            this.Listings_SendSelectedEntries_Button.TabIndex = 43;
            this.Listings_SendSelectedEntries_Button.Text = "Send Selected";
            this.Listings_SendSelectedEntries_Button.UseVisualStyleBackColor = false;
            this.Listings_SendSelectedEntries_Button.Click += new System.EventHandler(this.Listings_SendSelectedEntries_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 15);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 26;
            // 
            // Listing_InsertBelow_Button
            // 
            this.Listing_InsertBelow_Button.AutoSize = true;
            this.Listing_InsertBelow_Button.Location = new System.Drawing.Point(591, 471);
            this.Listing_InsertBelow_Button.Name = "Listing_InsertBelow_Button";
            this.Listing_InsertBelow_Button.Size = new System.Drawing.Size(79, 27);
            this.Listing_InsertBelow_Button.TabIndex = 12;
            this.Listing_InsertBelow_Button.Text = "Insert Below";
            this.Listing_InsertBelow_Button.UseVisualStyleBackColor = true;
            this.Listing_InsertBelow_Button.Click += new System.EventHandler(this.Listings_InsertEntryBelow_Click);
            // 
            // Listings_DeleteSelectedEntries_Button
            // 
            this.Listings_DeleteSelectedEntries_Button.Location = new System.Drawing.Point(854, 470);
            this.Listings_DeleteSelectedEntries_Button.Name = "Listings_DeleteSelectedEntries_Button";
            this.Listings_DeleteSelectedEntries_Button.Size = new System.Drawing.Size(73, 27);
            this.Listings_DeleteSelectedEntries_Button.TabIndex = 13;
            this.Listings_DeleteSelectedEntries_Button.Text = "Delete";
            this.Listings_DeleteSelectedEntries_Button.UseVisualStyleBackColor = true;
            this.Listings_DeleteSelectedEntries_Button.Click += new System.EventHandler(this.Listings_DeleteSelectedEntries_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 38;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.Calculate_JDate);
            // 
            // JdateLabel
            // 
            this.JdateLabel.AutoSize = true;
            this.JdateLabel.Location = new System.Drawing.Point(22, 18);
            this.JdateLabel.Name = "JdateLabel";
            this.JdateLabel.Size = new System.Drawing.Size(60, 13);
            this.JdateLabel.TabIndex = 13;
            this.JdateLabel.Text = "Julian Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5:00 AM",
            "5:30 AM",
            "6:00 AM",
            "6:30 AM",
            "7:00 AM",
            "7:30 AM",
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM",
            "5:30 PM",
            "6:00 PM",
            "6:30 PM",
            "7:00 PM",
            "7:30 PM",
            "8:00 PM",
            "8:30 PM",
            "9:00 PM",
            "9:30 PM",
            "10:00 PM",
            "10:30 PM",
            "11:00 PM",
            "11:30 PM",
            "12:00 AM",
            "12:30 AM",
            "1:00 AM",
            "1:30 AM",
            "2:00 AM",
            "2:30 AM",
            "3:00 AM",
            "3:30 AM",
            "4:00 AM",
            "4:30 AM"});
            this.comboBox1.Location = new System.Drawing.Point(327, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // TimeSlotLabel
            // 
            this.TimeSlotLabel.AutoSize = true;
            this.TimeSlotLabel.Location = new System.Drawing.Point(273, 18);
            this.TimeSlotLabel.Name = "TimeSlotLabel";
            this.TimeSlotLabel.Size = new System.Drawing.Size(48, 13);
            this.TimeSlotLabel.TabIndex = 14;
            this.TimeSlotLabel.Text = "TimeSlot";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Listings);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.Lineuptab);
            this.tabControl1.Controls.Add(this.Downloadtab);
            this.tabControl1.Controls.Add(this.Weathertab);
            this.tabControl1.Controls.Add(this.Config);
            this.tabControl1.Controls.Add(this.Commands);
            this.tabControl1.Controls.Add(this.QTable);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 530);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button13);
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.Scroll_Messages_DGV);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(935, 504);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "Listing Setup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButton13);
            this.groupBox5.Controls.Add(this.radioButton14);
            this.groupBox5.Location = new System.Drawing.Point(693, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 82);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Other";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(6, 19);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(51, 17);
            this.radioButton13.TabIndex = 20;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "None";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.Other_Listing_Color_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(6, 55);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(66, 17);
            this.radioButton14.TabIndex = 19;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "Highlight";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.Other_Listing_Color_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton10);
            this.groupBox4.Controls.Add(this.radioButton11);
            this.groupBox4.Location = new System.Drawing.Point(561, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 82);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "News";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton10.Size = new System.Drawing.Size(51, 17);
            this.radioButton10.TabIndex = 17;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "None";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.News_Listing_Color_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(6, 55);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(66, 17);
            this.radioButton11.TabIndex = 16;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Highlight";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.News_Listing_Color_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Location = new System.Drawing.Point(425, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 82);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Family";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(8, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(51, 17);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "None";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.Family_Listing_Color_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(8, 55);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(66, 17);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Highlight";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.Family_Listing_Color_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(283, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 82);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sports";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "None";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Sports_Listing_Color_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 55);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(66, 17);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Highlight";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.Sports_Listing_Color_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(139, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 82);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Movie_Listing_Color_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 55);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Highlight";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Movie_Listing_Color_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(398, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Listing Color Attributes";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(935, 504);
            this.tabPage4.TabIndex = 11;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Scroll_Messages_DGV
            // 
            this.Scroll_Messages_DGV.AllowUserToAddRows = false;
            this.Scroll_Messages_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Scroll_Messages_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Scroll_Messages_DGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.Scroll_Messages_DGV.Location = new System.Drawing.Point(66, 139);
            this.Scroll_Messages_DGV.Margin = new System.Windows.Forms.Padding(2);
            this.Scroll_Messages_DGV.Name = "Scroll_Messages_DGV";
            this.Scroll_Messages_DGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Scroll_Messages_DGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Scroll_Messages_DGV.RowTemplate.Height = 24;
            this.Scroll_Messages_DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Scroll_Messages_DGV.Size = new System.Drawing.Size(782, 299);
            this.Scroll_Messages_DGV.TabIndex = 47;
            this.Scroll_Messages_DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Scroll_Messages_DGV_CellClick);
            // 
            // Scroll_Messages_DataSet
            // 
            this.Scroll_Messages_DataSet.DataSetName = "Scroll_Messages_DataSet";
            this.Scroll_Messages_DataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.ScrollMessages});
            // 
            // ScrollMessages
            // 
            this.ScrollMessages.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn16,
            this.dataColumn17});
            this.ScrollMessages.TableName = "ScrollMessages";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "SourceID";
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "Attr";
            this.dataColumn16.ColumnName = "Attr";
            this.dataColumn16.DataType = typeof(short);
            this.dataColumn16.DefaultValue = ((short)(1));
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "Message";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(55, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 25);
            this.button2.TabIndex = 48;
            this.button2.Text = "Send Selected";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Scroll_Messages_SendSelectedEntries_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(148, 461);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 25);
            this.button6.TabIndex = 49;
            this.button6.Text = "Current Day";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Scroll_Messages_SendCurrentDayEntries_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(233, 461);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 25);
            this.button7.TabIndex = 55;
            this.button7.Text = "Next Day";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Scroll_Messages_SendNextDayEntries_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(332, 460);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 27);
            this.button8.TabIndex = 56;
            this.button8.Text = "Move Up";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Scroll_Messages_MoveEntryUp_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(409, 460);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 57;
            this.button10.Text = "Move Down";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Scroll_Messages_MoveEntryDown_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(502, 460);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(77, 27);
            this.button11.TabIndex = 58;
            this.button11.Text = "Insert Above";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Scroll_Messages_InsertEntryAbove_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(585, 459);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(79, 27);
            this.button13.TabIndex = 59;
            this.button13.Text = "Insert Below";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Scroll_Messages_InsertEntryBelow_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(686, 458);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(79, 27);
            this.button14.TabIndex = 60;
            this.button14.Text = "Update";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Scroll_Messages_UpdateEntries_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(775, 458);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 27);
            this.button18.TabIndex = 61;
            this.button18.Text = "Delete";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.Scroll_Messages_DeleteSelectedEntries_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(406, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Scroll Messages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(943, 604);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CurrentDayofYear);
            this.Controls.Add(this.CurDateTime);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Prevue Channel Listings Editor/Sender";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LineupRtClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LineupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lineup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2ILineup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2IListings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.QTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QTable_DGV)).EndInit();
            this.Commands.ResumeLayout(false);
            this.Commands.PerformLayout();
            this.Config.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Weathertab.ResumeLayout(false);
            this.Weathertab.PerformLayout();
            this.Downloadtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Z2I_Listings_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z2I_Lineup_DGV)).EndInit();
            this.Lineuptab.ResumeLayout(false);
            this.Lineuptab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lineup_DGV)).EndInit();
            this.Listings.ResumeLayout(false);
            this.Listings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Listings_DGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Messages_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scroll_Messages_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrollMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CurDateTime;
        private System.Windows.Forms.Label CurrentDayofYear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataSet LineupDataSet;
        private System.Data.DataTable Lineup;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn78;
        private System.Data.DataColumn dataColumn79;
        private System.Data.DataColumn dataColumn80;
        private System.Data.DataColumn dataColumn81;
        private System.Data.DataColumn dataColumn82;
        private System.Data.DataColumn dataColumn83;
        private System.Data.DataColumn dataColumn84;
        private System.Data.DataColumn dataColumn85;
        private System.Data.DataColumn dataColumn86;
        private System.Data.DataColumn dataColumn87;
        private System.Data.DataColumn dataColumn88;
        private System.Data.DataColumn dataColumn89;
        private System.Data.DataColumn dataColumn90;
        private System.Data.DataSet QTableDataSet;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn91;
        private System.Data.DataColumn dataColumn92;
        private System.Data.DataSet WeatherDataSet;
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Data.DataSet ListingDataSet;
        private System.Data.DataColumn dataColumn102;
        private System.Data.DataColumn dataColumn105;
        private System.Data.DataColumn dataColumn106;
        private System.Data.DataColumn dataColumn107;
        private System.Data.DataColumn dataColumn108;
        private System.Data.DataColumn dataColumn116;
        private System.Data.DataColumn dataColumn117;
        private System.Windows.Forms.ContextMenuStrip LineupRtClickMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextDayToolStripMenuItem;
        private System.Data.DataTable Z2ILineup;
        private System.Data.DataTable Z2IListings;
        private System.Data.DataColumn dataColumn122;
        private System.Data.DataColumn dataColumn123;
        private System.Data.DataColumn dataColumn124;
        private System.Data.DataColumn dataColumn125;
        private System.Data.DataColumn dataColumn126;
        private System.Data.DataColumn dataColumn127;
        private System.Data.DataColumn dataColumn128;
        private System.Data.DataColumn dataColumn129;
        private System.Data.DataColumn dataColumn130;
        private System.Data.DataColumn dataColumn131;
        private System.Data.DataColumn dataColumn132;
        private System.Data.DataColumn dataColumn133;
        private System.Data.DataColumn dataColumn134;
        private System.Data.DataColumn dataColumn135;
        private System.Data.DataColumn dataColumn136;
        private System.Data.DataColumn dataColumn137;
        private System.Data.DataColumn dataColumn138;
        private System.Data.DataColumn dataColumn139;
        private System.Data.DataColumn dataColumn140;
        private System.Data.DataColumn dataColumn141;
        private System.Data.DataColumn dataColumn142;
        private System.Data.DataColumn dataColumn143;
        private System.Data.DataColumn dataColumn144;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label DayOfYear_Label;
        private System.Windows.Forms.Label CurrentDayOfYear_Label;
        private System.Windows.Forms.TextBox CurrentDayOfYear_TextBox;
        private System.Windows.Forms.TextBox CurrentPrevueDay_TextBox;
        private System.Windows.Forms.TextBox CustomListing2_TextBox;
        private System.Windows.Forms.TextBox CustomListing1_TextBox;
        private System.Windows.Forms.TextBox TZOffset_TextBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.TextBox Server_TextBox;
        private System.Windows.Forms.TextBox WeatherParseCycleTextBox;
        private System.Windows.Forms.TextBox WeatherCityTextBox;
        private System.Windows.Forms.TextBox WeatherIDTextBox;
        private System.Windows.Forms.TextBox Z2I_Password_TextBox;
        private System.Windows.Forms.TextBox Z2I_Username_TextBox;
        private System.Windows.Forms.TextBox Z2I_NbrOfDays_TextBox;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox EPG_BottomLine_TextBox;
        private System.Windows.Forms.TextBox EPG_TopLine_TextBox;
        private System.Windows.Forms.TextBox Version_TextBox;
        private System.Windows.Forms.TextBox SelectCode_TextBox;
        private System.Windows.Forms.Label CurrentPrevueDay_Label;
        private System.Windows.Forms.Label CustomListing2_Label;
        private System.Windows.Forms.Label CustomListing1_Label;
        private System.Windows.Forms.Label TZOffset_Label;
        private System.Windows.Forms.RadioButton Serial_Button;
        private System.Windows.Forms.RadioButton TCP_IP_Button;
        private System.Windows.Forms.Label Port_Label;
        private System.Windows.Forms.Label IP_Address_Label;
        private System.Windows.Forms.Label Port_Select_Label;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label WeatherDisplayLength_Label;
        private System.Windows.Forms.ComboBox WeatherFreqComboBox;
        private System.Windows.Forms.Label WeatherCity_Label;
        private System.Windows.Forms.Label WeatherID_Label;
        private System.Windows.Forms.Label WeatherFrequency_Label;
        private System.Windows.Forms.Label Z2I_Password_Label;
        private System.Windows.Forms.Label Z2I_Username_Label;
        private System.Windows.Forms.Label Z2I_NbrOfDays_Label;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label EPG_BottomLine_Label;
        private System.Windows.Forms.Label EPG_TopLine_Label;
        private System.Windows.Forms.Label Version_Label;
        private System.Windows.Forms.Label SelectCode_Label;
        private System.Windows.Forms.Button UpdateUserSettings_Button;
        private System.Windows.Forms.Label Serial_Port_Label;
        private System.Windows.Forms.ComboBox SerialPort_DropDownBox;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TabPage QTable;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.DataGridView QTable_DGV;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage Commands;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox textBox116;
        private System.Windows.Forms.TextBox textBox115;
        private System.Windows.Forms.TextBox textBox114;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button BottomLineSendBtn;
        private System.Windows.Forms.Button TopLineSendBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ResetCommand;
        private System.Windows.Forms.TabPage Config;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Button Config_Update_Button;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Old;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage Weathertab;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage Downloadtab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.DataGridView Z2I_Listings_DGV;
        private System.Windows.Forms.DataGridView Z2I_Lineup_DGV;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.TabPage Lineuptab;
        private System.Windows.Forms.Button Lineup_Z2I_Import_Button;
        private System.Windows.Forms.Button Lineup_InsertBelow_Button;
        private System.Windows.Forms.Button Lineup_MoveDown_Button;
        private System.Windows.Forms.Button Lineup_MoveUp_Button;
        private System.Windows.Forms.Button Lineup_InsertAbove_Button;
        private System.Windows.Forms.Button Lineup_UpdateEntries_Button;
        private System.Windows.Forms.DataGridView Lineup_DGV;
        private System.Windows.Forms.Button Lineup_SendNextDay_Button;
        private System.Windows.Forms.Button Lineup_SendCurrentDay_Button;
        private System.Windows.Forms.Button Lineup_DeleteSelectedEntries_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Jdate;
        private System.Windows.Forms.TabPage Listings;
        private System.Windows.Forms.Button Listings_SendNextDayEntries_Button;
        private System.Windows.Forms.Button Listings_Z2I_Import_Button;
        private System.Windows.Forms.Button Listings_MoveDown_Button;
        private System.Windows.Forms.Button Listings_MoveUp_Button;
        private System.Windows.Forms.Button Listings_InsertAbove_Button;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.DataGridView Listings_DGV;
        private System.Windows.Forms.Button Listings_UpdateEntries_Button;
        private System.Windows.Forms.Button Listings_SendCurrentDayEntries_Button;
        private System.Windows.Forms.Button Listings_SendSelectedEntries_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Listing_InsertBelow_Button;
        private System.Windows.Forms.Button Listings_DeleteSelectedEntries_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label JdateLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TimeSlotLabel;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Button button17;
        public System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button Lineup_SendInitialLineup_Button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Scroll_Messages_DGV;
        private System.Data.DataSet Scroll_Messages_DataSet;
        private System.Data.DataTable ScrollMessages;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label13;
    }
}

