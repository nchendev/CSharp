using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
namespace GuessANumber
{
    public partial class Form1 : Form
    {
        public static Random ran = new Random();
        int answer = ran.Next(1, 6);
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (answer == 1)
                label2.Text = ("You got it right!");
            else
                label2.Text = ("WRONGGGGG");
            label2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (answer == 2)
                label2.Text = ("You got it right!");
            else
                label2.Text = ("WRONGGGGG");
            label2.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (answer == 3)
                label2.Text = ("You got it right!");
            else
                label2.Text = ("WRONGGGGG");
            label2.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (answer == 4)
                label2.Text = ("You got it right!");
            else
                label2.Text = ("WRONGGGGG");
            label2.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (answer == 5)
                label2.Text = ("You got it right!");
            else
                label2.Text = ("WRONGGGGG");
            label2.Visible = true;
        }
    }
}
