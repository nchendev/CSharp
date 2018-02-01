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
///   Purpose: Program that averages 5 test scores
///-----------------------------------------------------------------
namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score1, score2, score3, score4, score5, avg;
            score1 = double.Parse(t1.Text);
            score2 = double.Parse(t2.Text);
            score3 = double.Parse(t3.Text);
            score4 = double.Parse(t4.Text);
            score5 = double.Parse(t5.Text);
            avg = (score1 + score2 + score3 + score4 + score5) / 5.00;
            answer.Text = "The average of your 5 test scores is " + Math.Round(avg, 2);
            answer.Visible = true;
        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void t1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
