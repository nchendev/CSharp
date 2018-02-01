using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double hw, pr, grossP, fedT, stateT,netP;
            String name, ssn;
            name = textBox1.Text;
            ssn = textBox2.Text;
            pr = double.Parse(textBox3.Text);
            hw = double.Parse(textBox4.Text);
            grossP = pr * hw;
            fedT = (grossP * .15);
            stateT = (grossP * .05);
            netP = (grossP - fedT-stateT);
            label2.Visible = true;
            label2.Text = "Hi, "+name+", Social Security Number "+ssn+", Your Gross Pay is "+grossP+", your Federal Withholding Tax is "+fedT+
                "your State Withholding Tax is " + stateT + ", and your Net Pay is " + netP + ".";

        }
    }
}
