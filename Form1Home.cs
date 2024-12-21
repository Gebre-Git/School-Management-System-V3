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
    public partial class Form1Home : UserControl
    {
       // public string path { get; set; }

        public Form1Home()
        
        {
            InitializeComponent();
           
        }


        private void studentsHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHome studentHome = new AdminHome();
            studentHome.Show();
            
        }

        private void teachersHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminHomeTeachers adminHomeTeachers = new AdminHomeTeachers();
            adminHomeTeachers.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
          
        }

        private void Student_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            Teachers_Login teachers_Login = new Teachers_Login();
            teachers_Login.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
