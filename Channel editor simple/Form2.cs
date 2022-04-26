using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrevueDataSender
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ProgressBarBuild(int positionvalue, int minvalue, int maxvalue)
        {
            ProgressBar pBar = progressBar1;
            pBar.Minimum = minvalue;
            pBar.Maximum = maxvalue;
            pBar.Value = positionvalue;
        }
    }
}
