using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        int num = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            num = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            num = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            num = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                subaru sub1 = new subaru();
                sub1.ShowDialog();
                
            } 
            else if (num == 2)
            {
                honda hon1 = new honda();
                hon1.ShowDialog();
            }
            else if (num == 3)
            {
                nissan niss1 = new nissan();
                niss1.ShowDialog();
            }
        }
    }
}
