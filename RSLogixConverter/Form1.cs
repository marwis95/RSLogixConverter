﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RSLogixConverter
{
    public partial class Form1 : Form
    {
        char Chr;
        int numChr;
        Font FNT;

        string[,] tab = new string[,] {
        {"261", "$B9"},
        {"263", "$E6"},
        {"281", "$EA"},
        {"322", "$B3"},
        {"324", "$F1"},
        {"243", "$F3"},
        {"347", "$9C"},
        {"380", "$BF"},
        {"378", "$9F"},
        {"260", "$A5"},
        {"262", "$C6"},
        {"280", "$CA"},
        {"321", "$A3"},
        {"323", "$D1"},
        {"211", "$D3"},
        {"346", "$8C"},
        {"379", "$AF"},
        {"377", "$8F"},
        {"10", "$R$L"}
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            bool finded = false;
            richTextBox2.Clear();
            for (int i = 0; i < (richTextBox1.Text.Length); i++)
            {
                finded = false;

                Chr = richTextBox1.Text[i];
                numChr = Chr;


                for (int j = 0; j < 19 ; j++)
                {
                    if (numChr.ToString() == tab[j, 0])
                    {
                        richTextBox2.AppendText(tab[j, 1]);
                        finded = true;
                    }
                }

                if (finded == false)
                {
                    richTextBox2.AppendText(Chr.ToString());
                }

                //if (numChr == 10) richTextBox2.AppendText("$R$L");
                //else richTextBox2.AppendText(Chr.ToString());



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp1, temp2;
            FontDialog fd = new FontDialog();

            temp1 = richTextBox1.Text;
            temp2 = richTextBox2.Text;
            richTextBox1.Clear();
            

            fd.Font = richTextBox1.SelectionFont;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                FNT = fd.Font;
                richTextBox1.SelectionFont = FNT;
            }

            richTextBox1.AppendText(temp1);
            richTextBox2.Clear();
            richTextBox2.AppendText(temp2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.SelectionFont = FNT;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (FNT != null)
            {
                richTextBox2.SelectionFont = FNT;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
            label1.Visible = true;
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void skopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
            label1.Visible = true;
            timer1.Stop();
            timer1.Start();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String temp1, temp2;
            FontDialog fd = new FontDialog();

            temp1 = richTextBox1.Text;
            temp2 = richTextBox2.Text;
            richTextBox1.Clear();


            fd.Font = richTextBox1.SelectionFont;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                FNT = fd.Font;
                richTextBox1.SelectionFont = FNT;
            }

            richTextBox1.AppendText(temp1);
            richTextBox2.Clear();
            richTextBox2.AppendText(temp2);
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Write(tab[0, 1]);
        }
    }
}
