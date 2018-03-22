using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSLogixConverter
{
    public partial class Form1 : Form
    {
        char Chr;
        int numChr;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            for (int i = 0; i < (richTextBox1.Text.Length); i++)
            {

                Chr = richTextBox1.Text[i];
                numChr = Chr;

                richTextBox2.AppendText(numChr.ToString() + " ");

                //MessageBox.Show(numChr.ToString());


            }

        }
    }
}
