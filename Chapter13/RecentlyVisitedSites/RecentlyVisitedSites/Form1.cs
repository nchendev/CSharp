using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecentlyVisitedSites
{
    public partial class Form1 : Form
    {
        int lastClicked = 0;
        int stlClicked = 0;
        public Form1()
        {
            
            InitializeComponent();
            linkLabel1.Location = new Point(50, 50);
            linkLabel2.Location = new Point(50, 100);
            linkLabel3.Location = new Point(50, 150);
            textBox1.Location = new Point(10, 10);
            textBox2.Location = new Point(10, 10);
            textBox3.Location = new Point(10, 10);
            linkLabel1.MouseHover += linkLabel1_MouseHover;
            linkLabel2.MouseHover += linkLabel2_MouseHover;
            linkLabel3.MouseHover += linkLabel3_MouseHover;
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
            linkLabel2.MouseLeave += linkLabel2_MouseLeave;
            linkLabel3.MouseLeave += linkLabel3_MouseLeave;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.reddit.com");
            if (lastClicked == 0 || lastClicked == 2) 
            {
                linkLabel1.Location = new Point(50, 50);
                linkLabel2.Location = new Point(50, 100);
                linkLabel3.Location = new Point(50, 150);
            }
            else if (lastClicked ==3) 
            {
                linkLabel1.Location = new Point(50, 50);
                linkLabel3.Location = new Point(50, 100);
                linkLabel2.Location = new Point(50, 150);
            }
            lastClicked = 1;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
            if (lastClicked == 0 || lastClicked == 1)
            {
                linkLabel2.Location = new Point(50, 50);
                linkLabel1.Location = new Point(50, 100);
                linkLabel3.Location = new Point(50, 150);
            }
            else if (lastClicked == 3)
            {
                linkLabel2.Location = new Point(50, 50);
                linkLabel3.Location = new Point(50, 100);
                linkLabel1.Location = new Point(50, 150);
            }
            lastClicked = 2;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.acsf.org");
            if (lastClicked == 0 || lastClicked == 1)
            {
                linkLabel3.Location = new Point(50, 50);
                linkLabel1.Location = new Point(50, 100);
                linkLabel2.Location = new Point(50, 150);
            }
            else if (lastClicked == 2) 
            {
                linkLabel3.Location = new Point(50, 50);
                linkLabel2.Location = new Point(50, 100);
                linkLabel1.Location = new Point(50, 150);
            }
            stlClicked = lastClicked;
            lastClicked = 3;
        }
        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }
        private void linkLabel2_MouseHover(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }
        private void linkLabel3_MouseHover(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }
        private void linkLabel3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.Visible = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
