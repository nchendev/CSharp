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
///   Purpose: Program that displays "Hello World" visually
///-----------------------------------------------------------------
namespace HelloVisualWorld
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            helloLabel.Visible = true;
            changeOutputButton.Enabled = true;
        }

        private void changeOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }
    }
}
