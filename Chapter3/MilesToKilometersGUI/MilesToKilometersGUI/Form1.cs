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
///   Author:  Nick Chen                    Date: September 27, 2016
///   Purpose: Program that converts miles to kilometers 
///-----------------------------------------------------------------
namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//This actually operates real time; changing the values too much/too often will freeze the GUI.
            double miles, kilometers;
            miles = double.Parse(answer.Text);
            kilometers = miles * 1.6;
            topText.Text = miles+" miles is "+kilometers+" kilometers";
        }
    }
}
