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

namespace BatteryFuckerWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("1.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Setupbat.exe ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("2.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("4.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void batteryFuckerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void secretSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("bat.exe");
        }
    }
}
