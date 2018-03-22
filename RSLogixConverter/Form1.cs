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

                if (numChr == 261) richTextBox2.AppendText("$B9");
                else if (numChr == 263) richTextBox2.AppendText("$E6");
                else if (numChr == 281) richTextBox2.AppendText("$EA");
                else if (numChr == 322) richTextBox2.AppendText("$B3");
                else if (numChr == 324) richTextBox2.AppendText("$F1");
                else if (numChr == 243) richTextBox2.AppendText("$F3");
                else if (numChr == 347) richTextBox2.AppendText("$9C");
                else if (numChr == 380) richTextBox2.AppendText("$BF");
                else if (numChr == 378) richTextBox2.AppendText("$9F");

                else if (numChr == 260) richTextBox2.AppendText("$A5");
                else if (numChr == 262) richTextBox2.AppendText("$C6");
                else if (numChr == 280) richTextBox2.AppendText("$CA");
                else if (numChr == 321) richTextBox2.AppendText("$A3");
                else if (numChr == 323) richTextBox2.AppendText("$D1");
                else if (numChr == 211) richTextBox2.AppendText("$D3");
                else if (numChr == 346) richTextBox2.AppendText("$8C");
                else if (numChr == 379) richTextBox2.AppendText("$AF");
                else if (numChr == 377) richTextBox2.AppendText("$8F");

                else if (numChr == 10) richTextBox2.AppendText("$R$L");

                else richTextBox2.AppendText(Chr.ToString());

                //richTextBox2.AppendText(numChr.ToString() + " ");


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
