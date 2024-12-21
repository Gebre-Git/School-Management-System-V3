using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace School
{
    public partial class RegistrationControl : UserControl
    {
        private SQLiteConnection connection;
        public RegistrationControl()
        {

            InitializeComponent();
            string connstring = "Data Source = F:/Project Stuff/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);
        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {

        }

        private void Submite_Click(object sender, EventArgs e)
        {
            FnameI.Visible = false;
            LnameI.Visible=false;
            GradeI.Visible = false;
            AdressI.Visible = false;
            emailI.Visible = false;
            PhoneI.Visible = false;
            string name_chake = @"^[a-zA-Z ]+$";
            string phone_chake = @"^(09|07)\d{8}$";
            string gradecheck = @"^(9|10|11|12)$";
            string emailCheck = @"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$";
            string adressCheck = @"^[0-9]{1,2}$";
            string first_name = "";
            bool end_f_name = false;
            while (!end_f_name)
            {
                first_name = Fname.Texts;
                bool re_first_name = Regex.IsMatch(first_name, name_chake);
                if (re_first_name == false)
                {
                    FnameI.Visible =true;
                    first_name = "";
                    break;
                }
                else { end_f_name = true; }
            }
            string last_name = "";
            bool end_l_name = false;
            while (!end_l_name)
            {
                last_name = Lname.Texts;
                bool re_last_name = Regex.IsMatch(last_name, name_chake);
                if (re_last_name == false)
                {
                    LnameI.Visible=true;
                    last_name = "";
                    break;
                }
                else { end_l_name = true; }
            }
            string email = Email.Texts;
            string grade = "";

            bool endgrade = false;
            while (!endgrade)
            {
                grade = Grade.Texts;
                bool reAdress = Regex.IsMatch(grade, gradecheck);
                if (reAdress == false)
                {
                    GradeI.Visible = true;
                    grade = "";
                    break;
                }
                else
                {
                    endgrade = true;
                }
            }

            string adress = "";
            int adress_int = 0;
            bool endAdress = false;
            while (!endAdress)
            {
                adress = Adress.Texts;
                bool reAdress = Regex.IsMatch(adress, adressCheck);
                if (reAdress == true)
                {
                    adress_int = Convert.ToInt32(adress);
                    if (adress_int > 0 && adress_int < 30)
                    {
                        endAdress = true;
                    }
                    else
                    {
                        AdressI.Visible = true;
                        adress = "";
                        break;
                    }
                }
                else
                {
                    AdressI.Visible = true;
                    adress = "";
                    break;
                }
                
            }

            string BirthDate = rjDatePicker1.Text;
            string gender = "";
            if (Male.Checked = true)
            {
                gender = "M";
            }
            else if (Female.Checked = true)
            {
                gender = "F";
            }
            else
            {
                MessageBox.Show("Please select your Gender", "Message");
            }
            string phone_number = "";
            bool end_phone_number = false;
            while (!end_phone_number)
            {
                phone_number = Phone.Texts;
                bool re_phone_number = Regex.IsMatch(phone_number, phone_chake);
                if (re_phone_number == false)
                {
                    PhoneI.Visible=true;
                    phone_number = "";
                    break;

                }
                else { end_phone_number = true; }
            }
            string new_email = "";
            bool end_email = false;
            while (!end_email)
            {
                new_email = Email.Texts;
                bool re_email = Regex.IsMatch(new_email, emailCheck);
                if(re_email == false)
                {
                    emailI.Visible=true;
                    new_email = "";
                    break;
                }
                else { end_email = true; }
            }
            string Id;
            string uniquekey;
            string username = "";
            string password = "";
            checkId(out Id);
            checkkey(out uniquekey);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                if (first_name != "" && last_name != "" && phone_number != "" && adress != "" && new_email!=""&&grade!="")
                {

                    string inputQuery = $"INSERT INTO G{grade}Status  VALUES ('" + first_name + "','" + last_name + "','" + email + "','" + phone_number + "','" + adress + "','" + BirthDate + "','" + gender + "','" + Id + "','" + uniquekey + "','" + username + "','" + password + "');";
                    string rosterQuery = $"INSERT INTO G{grade}Roster(FirstName,LastName,Biology,Chemistry,English,ICT,Mathematics,Physics,Average,StudentId) VALUES ('" + first_name + "','" + last_name + "','','','','','','','','" + Id + "')";
                    SQLiteCommand cmd2 = new SQLiteCommand(rosterQuery, connection);
                    SQLiteCommand cmd = new SQLiteCommand(inputQuery, connection);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    Message message = new Message("The Student Data Saved\r\n\tSuccessfully");
                    message.Show();
                }
            }
            catch (Exception ex)
            {
                Message message = new Message("The data doesn't Saved");
                message.Show();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        private void checkId(out string id)
        {
            string possibleId;
            int counter = 0;
            string idholder = "";

            int studs = 1;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                while (studs < 9999)
                {
                    if (studs < 10)
                    {
                        possibleId = "000" + studs;
                    }
                    else if (studs < 100 && studs > 9)
                    {
                        possibleId = "00" + studs;
                    }
                    else if (studs < 1000 && studs > 99)
                    {
                        possibleId = "0" + studs;
                    }
                    else { possibleId = "" + studs; }

                    for (int grade = 9; grade < 13; grade++)
                    {
                        string selectQuery = $"SELECT COUNT (*) FROM G{grade}Status WHERE StudentId = @StudentId;";
                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@StudentId", $"STEM{possibleId}");
                            int rowsAffected = Convert.ToInt32(command.ExecuteScalar());
                            if (rowsAffected > 0)
                            {
                                counter++;
                                break;
                            }
                        }
                    }
                    if (counter == 0)
                    {
                        idholder += $"STEM{possibleId}";
                        break;
                    }
                    else
                    {
                        idholder = "";
                        counter = 0;
                        studs++;
                    }


                }
            }
            catch (Exception ex)
            {

                Message message = new Message(ex.Message);
                message.Show();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            id = idholder;
        }
        private void checkkey(out string serialnumber)
        {

            bool istrue = true;
            string possibleid;
            string serialholder = "";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                while (istrue)
                {

                    Random rand = new Random();
                    int count = 0;
                    possibleid = Convert.ToString(rand.Next(10000, 99999));
                    for (int grade = 9; grade < 13; grade++)
                    {
                        string selectQuery = $"SELECT COUNT (*) FROM G{grade}Status WHERE UniqueKey = @UniqueKey;";
                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            // Set parameter value
                            command.Parameters.AddWithValue("@UniqueKey", possibleid);
                            int rowsAffected = Convert.ToInt32(command.ExecuteScalar());
                            if (rowsAffected > 0)
                            {
                                count++;
                                break;
                            }
                        }

                    }
                    if (count == 0)
                    {
                        serialholder = possibleid;
                        istrue = false;
                    }
                    else
                    {
                        serialholder = "";
                        count = 0;
                    }
                }




            }
            catch (Exception ex)
            {
                Message message = new Message(ex.Message);
                message.Show();
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }

            }
            serialnumber = serialholder;

        }

        private void Fname__TextChanged(object sender, EventArgs e)
        {

        }

        private void Grade__TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname__TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void emailI_Click(object sender, EventArgs e)
        {

        }

        private void Email__TextChanged(object sender, EventArgs e)
        {

        }

        private void Adress__TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void GradeI_Click(object sender, EventArgs e)
        {

        }

        private void FnameI_Click(object sender, EventArgs e)
        {

        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PhoneI_Click(object sender, EventArgs e)
        {

        }

        private void LnameI_Click(object sender, EventArgs e)
        {

        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdressI_Click(object sender, EventArgs e)
        {

        }
    }
}
