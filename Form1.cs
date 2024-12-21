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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomeFocus.Visible = true;
            AboutFocus.Visible = false;
            HelpFocus.Visible = false;


        }
        public string Path = "Data Source = D:/Projects/BackUp file/School/SchoolManagmentSystem.db;Version=3;";


        private void Teachers_Click(object sender, EventArgs e)
        {
            Teachers_Login teachers_Login = new Teachers_Login();
            teachers_Login.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void Student_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void ExitLabel_MouseHover(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.HotPink;
        }
        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.MediumOrchid;
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        


        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            HomeFocus.Visible = true;
            AboutFocus.Visible = false;
            HelpFocus.Visible = false;

            PanelHome.Visible = true;
            AboutPanel.Visible = true;
            PanelHelp.Visible = true;
        }
         
        private void AboutButton_Click_1(object sender, EventArgs e)
        {
            HomeFocus.Visible = false;
            AboutFocus.Visible = true;
            HelpFocus.Visible = false;

            PanelHome.Visible = false;
            AboutPanel.Visible = true;
            PanelHelp.Visible = false;

            text = lblText.Text;
            lblText.Text = "";
            timer2.Start();
            //Form1About form1About = new Form1About();
            //form1About.Change();
        }

        private void HelpButton_Click_1(object sender, EventArgs e)
        {
            HomeFocus.Visible = false;
            AboutFocus.Visible = false;
            HelpFocus.Visible = true;

            PanelHome.Visible = false;
            AboutPanel.Visible = true;
            PanelHelp.Visible = true;
        }

        private void HelpFocus_Click(object sender, EventArgs e)
        {

        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .1;
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminPassword adminpassword = new AdminPassword();
            adminpassword.Show();
            this.Hide();
        }

        private void Student_Click_1(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }

        private void Teachers_Click_1(object sender, EventArgs e)
        {
            Teachers_Login teacherHome = new Teachers_Login();
            teacherHome.Show();
            this.Hide();
        }
        private string text;
        private int len = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(len < text.Length)
            {
                lblText.Text = lblText.Text + text.ElementAt(len);
                len++;
            }
            else
                timer2.Stop();
        }
    }
}

