﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VirtualBatterymgr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void включитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("1.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("2.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Setupbat.exe ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("4.exe");
        }
    }
}
