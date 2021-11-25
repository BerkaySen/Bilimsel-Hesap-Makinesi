using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilimsel_Hesap_Makinem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            label1.BackColor = Color.Orange;
            label1.ForeColor = Color.Red;
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Start();
            progressBar1.Value = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value++;

            }
            else
                Application.Exit();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/berkay.sen.121");
        }
    }
}
