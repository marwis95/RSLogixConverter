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
        char lastChar;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lastChar = richTextBox1.Text[richTextBox1.Text.Length - 1];
            MessageBox.Show(lastChar.ToString());

        }
    }
}
