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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void Apply2_MouseHover(object sender, EventArgs e)
        {
            Apply2.ForeColor = Color.Black;
        }

        private void Apply2_MouseLeave(object sender, EventArgs e)
        {
            Apply2.ForeColor= Color.White;
        }

        private void Visit_MouseHover(object sender, EventArgs e)
        {
            Visit.ForeColor = Color.Black;
        }

        private void Visit_MouseLeave(object sender, EventArgs e)
        {
            Visit.ForeColor = Color.White;
        }

        private void Apply_MouseLeave(object sender, EventArgs e)
        {
            Apply.ForeColor = Color.White;
        }

        private void Apply_MouseHover(object sender, EventArgs e)
        {
            Apply.ForeColor = Color.Black;
        }

        private void Apply2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jossywbc.com/?p=513 (scolar)");
        }

        private void Visit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Library.com");
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.codemy.com");
        }
    }
}
