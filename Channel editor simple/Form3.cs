using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Calculator;

namespace PrevueDataSender
{
    public partial class Form3 : Form
    {
        public Form1.DaypartData TSInfo { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void form3Info_Load(object sender, EventArgs e)
        {
            if (TSInfo != null)
            {
                label9.Text = "Daypart Selected: " + TSInfo.DaypartSelected.ToString();
                label10.Text = "Daypart Current Value: " + TSInfo.DaypartValue;
                DisplayCurrentTSSettings(TSInfo.DaypartSelected);
                TSBitmaskDisplay(TSInfo.DaypartValue);
            }
            else 
            {
                label9.Text = "Daypart Selected: " + TSInfo.DaypartSelected.ToString();
                label10.Text = "Daypart Current Value: Not Set";
                DisplayCurrentTSSettings(TSInfo.DaypartSelected);
                TSBitmaskDisplay("0");
            }
        }
        private void DisplayCurrentTSSettings(int daypart)
        {
            int startingts = (daypart - 1) * 8;
            label1.Text = "TS " + (startingts + 1).ToString();
            label2.Text = "TS " + (startingts + 2).ToString();
            label3.Text = "TS " + (startingts + 3).ToString();
            label4.Text = "TS " + (startingts + 4).ToString();
            label5.Text = "TS " + (startingts + 5).ToString();
            label6.Text = "TS " + (startingts + 6).ToString();
            label7.Text = "TS " + (startingts + 7).ToString();
            label8.Text = "TS " + (startingts + 8).ToString();
        }

        private void TSBitmaskDisplay(string valuetodisplay)
            {
                if (valuetodisplay != "")
                {
                    Calc c = new Calc();
                    int testvalue = Convert.ToInt16(valuetodisplay);
                    BitArray bits = new BitArray(System.BitConverter.GetBytes(testvalue));
                    textBox11.Text = c.ConvertTestValue(bits[0], "1", "0");
                    textBox12.Text = c.ConvertTestValue(bits[1], "1", "0");
                    textBox13.Text = c.ConvertTestValue(bits[2], "1", "0");
                    textBox14.Text = c.ConvertTestValue(bits[3], "1", "0");
                    textBox15.Text = c.ConvertTestValue(bits[4], "1", "0");
                    textBox16.Text = c.ConvertTestValue(bits[5], "1", "0");
                    textBox17.Text = c.ConvertTestValue(bits[6], "1", "0");
                    textBox18.Text = c.ConvertTestValue(bits[7], "1", "0");
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc c = new Calc();
            BitArray bits = new BitArray(8);
            bits[0] = c.ConvertValueTest(textBox11.Text, "1", "0");
            bits[1] = c.ConvertValueTest(textBox12.Text, "1", "0");
            bits[2] = c.ConvertValueTest(textBox13.Text, "1", "0");
            bits[3] = c.ConvertValueTest(textBox14.Text, "1", "0");
            bits[4] = c.ConvertValueTest(textBox15.Text, "1", "0");
            bits[5] = c.ConvertValueTest(textBox16.Text, "1", "0");
            bits[6] = c.ConvertValueTest(textBox17.Text, "1", "0");
            bits[7] = c.ConvertValueTest(textBox18.Text, "1", "0");

            int valuetoreturn = c.ConvertToNumeral(bits);

            TSInfo.DaypartValue = valuetoreturn.ToString();
            this.Close();
        }
    }
}
