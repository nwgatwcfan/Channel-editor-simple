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
    public partial class Form4 : Form
    {
        public Form1.ListingAttrData AttrInfo { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void form4Info_Load(object sender, EventArgs e)
        {
            if (AttrInfo != null)
            {
                label9.Text = "Daypart Selected: " + AttrInfo.ListingEntrySelected.ToString();
                label10.Text = "Daypart Current Value: " + AttrInfo.AttributeValue;
                DisplaySettingsLabels();
                AttrBitmaskDisplay(AttrInfo.AttributeValue);
            }
            else
            {
                label9.Text = "Daypart Selected: " + AttrInfo.ListingEntrySelected.ToString();
                label10.Text = "Daypart Current Value: Not Set";
                DisplaySettingsLabels();
                AttrBitmaskDisplay("1");
            }
        }
        private void DisplaySettingsLabels()
        {
            //label1.Text = "None " ;
            label2.Text = "Movie " ;
            label3.Text = "AltHighltProg " ;
            label4.Text = "TagProg " ;
            label5.Text = "SportsProg " ;
            //label6.Text = "DView Used " ;
            label7.Text = "Repeat Prog" ;
            //label8.Text = "Prev Day Data" ;
        }

        private void AttrBitmaskDisplay(string valuetodisplay)
        {
            if (valuetodisplay != "")
            {
                Calc c = new Calc();
                int testvalue = Convert.ToInt16(valuetodisplay);
                BitArray bits = new BitArray(System.BitConverter.GetBytes(testvalue));
                //textBox11.Text = c.ConvertTestValue(bits[0], "1", "0");
                textBox12.Text = c.ConvertTestValue(bits[1], "1", "0");
                textBox13.Text = c.ConvertTestValue(bits[2], "1", "0");
                textBox14.Text = c.ConvertTestValue(bits[3], "1", "0");
                textBox15.Text = c.ConvertTestValue(bits[4], "1", "0");
                //textBox16.Text = c.ConvertTestValue(bits[5], "1", "0");
                textBox17.Text = c.ConvertTestValue(bits[6], "1", "0");
                //textBox18.Text = c.ConvertTestValue(bits[7], "1", "0");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calc c = new Calc();
            BitArray bits = new BitArray(8);
            bits[0] = true;
            bits[1] = c.ConvertValueTest(textBox12.Text, "1", "0");
            bits[2] = c.ConvertValueTest(textBox13.Text, "1", "0");
            bits[3] = c.ConvertValueTest(textBox14.Text, "1", "0");
            bits[4] = c.ConvertValueTest(textBox15.Text, "1", "0");
            bits[5] = false;
            bits[6] = c.ConvertValueTest(textBox17.Text, "1", "0");
            bits[7] = false;

            int valuetoreturn = c.ConvertToNumeral(bits);

            AttrInfo.AttributeValue = valuetoreturn.ToString();
            this.Close();
        }

    }
}
