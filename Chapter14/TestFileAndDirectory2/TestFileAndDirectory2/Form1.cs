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
namespace TestFileAndDirectory2
{
    public partial class Form1 : Form
    {
        int selected;
        string file;
        String[] listOfFile = Directory.GetFiles("C:\\");
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            
            
            for(int i=0; i <listOfFile.Length;i++)
            {
                checkedListBox1.Items.Add(listOfFile[i]);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = checkedListBox1.SelectedIndex;
            label3.Text = (listOfFile[selected] + " was created " + File.GetLastAccessTime(listOfFile[selected]));
            label3.Visible = true;
        }
    }
}
