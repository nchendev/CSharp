using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CustomizeAForm
{
    public partial class Form1 : Form
    {
        int x = 500, y = 350;
        public string tempColor;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            y = (int)numericUpDown1.Value;
            this.Size = new Size(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("Settings.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine(this.BackColor);
            sw.WriteLine(this.Size);
            sw.WriteLine(label1.Text);
            sw.Close();
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x = (int)numericUpDown1.Value;
            this.Size = new Size(x, y);
        }
    }
}
