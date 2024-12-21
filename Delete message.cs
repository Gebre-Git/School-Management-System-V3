using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Delete_message : Form
    {
        public Delete_message()
        {
            InitializeComponent();
        }

        private void gunaGradientButton1_MouseHover(object sender, EventArgs e)
        {
            gunaGradientButton1.Radius = 17;
        }

        private void gunaGradientButton1_MouseLeave(object sender, EventArgs e)
        {
            gunaGradientButton1.Radius = 12;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
