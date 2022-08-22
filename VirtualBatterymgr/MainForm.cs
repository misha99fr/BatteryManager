using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
            try
            {
                File.WriteAllBytes("1.exe", Properties.Resources._1);
                Process.Start("1.exe");
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes("2.exe", Properties.Resources._2);
                Process.Start("2.exe");
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes("Setupbat.exe", Properties.Resources.Setupbat);
                Process.Start("Setupbat.exe");
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes("4.exe", Properties.Resources._4);
                Process.Start("4.exe");
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllBytes("bat.exe", Properties.Resources.bat);
                Process.Start("bat.exe");
            }
            catch
            {

            }
        }
    }
}
