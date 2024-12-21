using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace School
{
    public partial class Form1About : UserControl
    {
        public string text = "";
        private int len = 0;
        public Form1About()
        {
            InitializeComponent();
        }

        private void panelstudpro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1About_Load(object sender, EventArgs e)
        {
            text = lblText.Text;
            lblText.Text = "";
            timer1.Start();
        }
        public void Change()
        {
            text = lblText.Text;
            lblText.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                lblText.Text = lblText.Text + text.ElementAt(len);
                len++;
            }
            else
                timer1.Stop();
        }

        private void Submite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.upwork.com");
        }
    }
}
