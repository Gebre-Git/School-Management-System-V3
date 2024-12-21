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
    public partial class Message2 : Form
    {
        
        public Message2(string text,string type)
        {
            InitializeComponent();
            BodyLabel.Text = text;
            if(type =="x")
            {
                Success.Visible = true;
                Error.Visible = false;
            }
            else if(type=="y")
            {
                Success.Visible = false;
                Error.Visible = true;
            }

        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else { Opacity += .03; }
            int y = AdminHome.parenty += 3;
            this.Location = new Point(AdminHome.parentx + 220, y);
            if (y >= i)  
            { 
                modalEffect_Timer.Stop(); 
            } 
        }

        int i;
        private void Message_Load(object sender, EventArgs e)
        {
            i = AdminHome.parenty + 150;
            this.Location = new Point(AdminHome.parentx + 220, AdminHome.parenty + 150);
            
        }

        private void BodyLabel_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Look_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
} 
