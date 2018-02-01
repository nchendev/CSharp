using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlorenceFloralCreations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            listBox2.Visible = false;
            label3.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            listBox2.Visible = false;
            if (listBox1.SelectedItem.ToString() == "Get Well")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Daisies");
                listBox2.Items.Add("Peonies");
                listBox2.Items.Add("Hydrangeas");
                listBox2.Visible = true;
                label2.Visible = true;
            }
            if (listBox1.SelectedItem.ToString() == "Curse to Death")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Poison Ivy");
                listBox2.Items.Add("Clematis");
                listBox2.Items.Add("Hydrangeas");
                listBox2.Visible = true;
                label2.Visible = true;
            }
            if (listBox1.SelectedItem.ToString() == "Obligatory")
            {
                listBox2.Items.Clear();
                listBox2.Items.Add("Daisies");
                listBox2.Items.Add("Ground Ivies");
                listBox2.Items.Add("Ragwort");
                listBox2.Visible = true;
                label2.Visible = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            listBox2.Visible = false;
            label2.Visible = false;
        }
    }
}
