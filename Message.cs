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
    public partial class Message : Form
    {
        public Message(string message)
        {
            InitializeComponent();
            BodyLabel.Text = message;
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Look_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
