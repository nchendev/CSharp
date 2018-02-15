using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///-----------------------------------------------------------------
///   Author:  Nick Chen                    Date: April 11, 2017
///   Purpose: GUI Program that calculates the cost of employing Dave
///-----------------------------------------------------------------
namespace Dave_s_Driveway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "Total:";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ppf = double.Parse(label4.Text);
            label5.Text = "Total: " + ppf * double.Parse(numericUpDown1.Value.ToString());
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "10";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "12";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "14";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "17";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
