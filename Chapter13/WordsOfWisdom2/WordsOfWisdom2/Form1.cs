using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.MouseEnter += label1_MouseEnter;
            label2.MouseEnter += label2_MouseEnter;
            label3.MouseEnter += label3_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            label2.MouseLeave += label2_MouseLeave;
            label3.MouseLeave += label3_MouseLeave;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }
    }
}
