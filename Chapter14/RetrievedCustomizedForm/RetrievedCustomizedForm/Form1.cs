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
namespace RetrievedCustomizedForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("settings.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            String tempLine = sr.ReadLine();
            tempLine = tempLine.Remove(0, 7);

            char cb = ']';
            tempLine = tempLine.TrimEnd(cb);
            System.Drawing.Color line = Color.FromName(tempLine);
            BackColor = line;

            tempLine = sr.ReadLine();
            this.Size =  new Size(Int32.Parse(tempLine.Substring(7,3)), Int32.Parse(tempLine.Substring(19, 3)));

            label1.Text = sr.ReadLine();
        }
    }
}
