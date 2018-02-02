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
///   Purpose: Program that converts 5 sums of user-inputed egg count
///            to dozens
///-----------------------------------------------------------------
namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double c1Ans, c2Ans, c3Ans, c4Ans, c5Ans, sum, dozens, remainder;
            c1Ans = double.Parse(c1Answer.Text);
            c2Ans = double.Parse(c2Answer.Text);
            c3Ans = double.Parse(c3Answer.Text);
            c4Ans = double.Parse(c4Answer.Text);
            c5Ans = double.Parse(c5Answer.Text);
            sum = c1Ans + c2Ans + c3Ans + c4Ans + c5Ans;
            dozens = sum / 12;
            remainder = sum % 12;
            label2.Text = sum + " eggs is " + dozens + "dozen with " + remainder + " left over.";
        }

        private void c1Answer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
