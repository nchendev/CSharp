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
///   Author:  Nick Chen                    Date: April 13, 2017
///   Purpose: GUI Program that calculates the cost of buying 
///            cookies from Nina
///-----------------------------------------------------------------
namespace NinasCookieSource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double yc = 0;
        double rc = 0;
        double bc = 0;
        double ec = 0;
        double price = 0;
        double number = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            number = .5;
            label3.Text = (price * number).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            number = 1;
            label3.Text = (price * number).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            number = 2;
            label3.Text = (price * number).ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            number = 3;
            label3.Text = (price * number).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (yc != 0)
                yc = 0;
            else
            {
                yc = 1;
                price += 10;
            }
            if (yc == 0)
                price -= 10;
            label3.Text = (price * number).ToString();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (rc != 0)
                rc = 0;
            else
            {
                rc = 1;
                price += 10;
            }
            if (rc == 0)
                price -= 10;
            label3.Text = (price * number).ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (bc != 0)
                bc = 0;
            else
            {
                bc = 1;
                price += 10;
            }
            if (bc == 0)
                price -= 10;
            label3.Text = (price * number).ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (ec != 0)
                ec = 0;
            else
            {
                ec = 1;
                price += 200;
            }
            if (ec == 0)
                price -= 200;
            label3.Text = (price * number).ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label5.Text = monthCalendar1.SelectionStart.AddDays(3).ToShortDateString();
        }
    }
}
