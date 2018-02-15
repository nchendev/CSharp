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
///   Purpose: GUI Program that tests changing of UI colors
///-----------------------------------------------------------------
namespace FiveColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black ;
        }
    }
}
