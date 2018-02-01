using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickLarger
{
    public partial class Form1 : Form
    {
        int[] Array1 = new int[100];
        int[] Array2 = new int[100];
        Random ran = new Random();
        int guessNum = 0;
        int correct;
        int incorrect;
        public Form1()
        {
            InitializeComponent();
            button3.Visible = false;
            label2.Visible = false;

            for (int i = 0; i < 100; i++)
            {
                Array1[i] = ran.Next(0, 1000);
            }
            for (int i = 0; i < 100; i++)
            {
                Array2[i] = ran.Next(0, 1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Array1[guessNum] > Array2[guessNum])
            {
                correct += 1;
                label2.Text=("Correct! Current tally: " + correct + " correct, " + incorrect + " incorrect.");
            }
            else
            {
                incorrect += 1;
                label2.Text = ("Incorrect! Current tally: " + correct + " correct, " + incorrect + " incorrect.");
            }
            guessNum += 1;

            label2.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Array2[guessNum] > Array1[guessNum])
            {
                correct += 1;
                label2.Text = ("Correct! Current tally: " + correct + " correct, " + incorrect + " incorrect.");
            }
            else
            {
                incorrect += 1;
                label2.Text = ("Incorrect! Current tally: " + correct + " correct, " + incorrect + " incorrect.");
            }
            guessNum += 1;

            label2.Visible = true;
            button3.Visible = true;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button3.Visible = false;
            button2.Visible = true;
            button1.Visible = true;
        }
    }
}
