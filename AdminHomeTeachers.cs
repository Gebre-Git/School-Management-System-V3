using SMS.RJControls;
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

namespace School
{
    public partial class AdminHomeTeachers : Form
    {
        private SQLiteConnection connection;
        public AdminHomeTeachers()
        {
            InitializeComponent();
            string connstring = "Data Source = C:/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);

            IHome.Visible = true;
            IRegistration.Visible = false;
            ISearch.Visible = false;

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            panelRegistration.Visible = false;
            panelSearch.Visible = false;
            paneHome.Visible = true;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            paneHome.Visible = false;
            panelSearch.Visible = false;
            panelRegistration.Visible = true;

        }

        private void AdminHomeTeachers_Load(object sender, EventArgs e)
        {
            rjButton1_Click(sender, e);
        }

        private void Submite_Click(object sender, EventArgs e)
        {
            FnameI.Visible = false;
            LnameI.Visible = false;
            GradeI.Visible = false;
            AdressI.Visible = false;
            emailI.Visible = false;
            PhoneI.Visible = false;
            string name_chake = @"^[a-zA-Z ]+$";
            string phone_chake = @"^(09|07)\d{8}$";
            string gradecheck = @"^(9|10|11|12)$";
            string emailCheck = @"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$";
            string adressCheck = @"^[0-9]{1,2}$";
            string subject_chake = @"^(Biology|Chemistry|English|ICT|Maths|Physics)$";
            string first_name = "";
            bool end_f_name = false;
            while (!end_f_name)
            {
                first_name = Fname.Texts;
                bool re_first_name = Regex.IsMatch(first_name, name_chake);
                if (re_first_name == false)
                {
                    FnameI.Visible = true;
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
                    LnameI.Visible = true;
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
            string subject = "";
            bool end_subject = false;
            while (!end_subject)
            {
                subject = Subject.Texts;
                bool re_subject = Regex.IsMatch(subject, subject_chake);
                if (re_subject == false)
                {
                    Subj.Visible = true;
                    subject = "";
                    break;
                }
                else { end_subject = true; Subj.Visible = false; }
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
                        AdressI.Visible = false;
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
                    PhoneI.Visible = true;
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
                if (re_email == false)
                {
                    emailI.Visible = true;
                    new_email = "";
                    break;
                }
                else { end_email = true; }
            }
            string uniquekey;
            string ID;
            checkId(out ID);
            checkkey(out uniquekey);
            connection.Open();
            string username = "";
            string password = "";
            if (first_name != "" && last_name != "" && phone_number != "" && adress != "" && new_email != "" && grade != "" && subject != "")
            {
                string inputQuery = $"INSERT INTO G9TStatus (FirstName,LastName,Email,Phone,Adress,BirthDate,Gender,Subject,UniqueKey,TeachersId,UserName,Password) VALUES ('" + first_name + "','" + last_name + "','" + email + "','" + phone_number + "','" + adress + "','" + BirthDate + "','" + gender + "','" + subject + "','" + uniquekey + "','" + ID + "','" + username + "','" + password + "');";
                SQLiteCommand cmd = new SQLiteCommand(inputQuery, connection);
                cmd.ExecuteNonQuery();
                Message message = new Message("The Data Saved Successfully");
                message.Show();
            }

            connection.Close();


        }



        private void checkId(out string id)
        {
            string possibleId;
            int counter = 0;
            string idholder = "";

            int teachs = 1;

            try
            {
                connection.Open();
                while (teachs < 9999)
                {
                    if (teachs < 10)
                    {
                        possibleId = "000" + teachs;
                    }
                    else if (teachs < 100 && teachs > 9)
                    {
                        possibleId = "00" + teachs;
                    }
                    else if (teachs < 1000 && teachs > 99)
                    {
                        possibleId = "0" + teachs;
                    }
                    else { possibleId = "" + teachs; }

                    for (int grade = 9; grade < 13; grade++)
                    {
                        // string exID = $"SELECT * FROM G{grade} WHERE ID = 'STEM-{possibleId}';";
                        string selectQuery = $"SELECT COUNT (*) FROM G{grade}TStatus WHERE TeachersId = @TeachersId;";
                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            // Set parameter value
                            command.Parameters.AddWithValue("@TeachersId", $"TSTEM{possibleId}");
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
                        idholder += $"TSTEM{possibleId}";
                        break;
                    }
                    else
                    {
                        idholder = "";
                        counter = 0;
                        teachs++;
                    }


                }
            }
            catch (Exception ex)
            {
                Message message = new Message("Something Went Wrong");
                message.Show();
            }
            finally
            {
                connection.Close();
            }

            id = idholder;
        }




        private void checkkey(out string serialnumber)
        {

            bool istrue = true;
            string possiblekey;
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
                    possiblekey = Convert.ToString(rand.Next(10000, 99999));
                    for (int grade = 9; grade < 13; grade++)
                    {
                        string selectQuery = $"SELECT COUNT (*) FROM G{grade}TStatus WHERE UniqueKey = @UniqueKey;";
                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            // Set parameter value
                            command.Parameters.AddWithValue("@UniqueKey", possiblekey);
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
                        serialholder = possiblekey;
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
                Message message = new Message("something Went Wrong!!");
                message.Show();
            }
            finally
            {
                connection.Close();
            }
            serialnumber = serialholder;

        }



        private void rjButton3_Click(object sender, EventArgs e)
        {
            paneHome.Visible = false;
            panelRegistration.Visible = false;
            panelSearch.Visible = true;
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Student_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void IDinput__TextChanged(object sender, EventArgs e)
        {

        }

        private void panelstudpro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void SearchGrade_Click_1(object sender, EventArgs e)
        {

            string gradecheck = @"^(9|10|11|12)$";
            string grade = "";
            bool endgrade = false;
            while (!endgrade)
            {
                grade = teacherGrade.Texts;
                bool reGrade = Regex.IsMatch(grade, gradecheck);
                if (reGrade == false)
                {
                    Message message = new Message("Invalid Grade Input (9-12)!!");
                    message.Show();
                    grade = "";
                    break;
                }
                else
                {
                    endgrade = true;
                }
            }
            if (grade != "")
            {

                if (Name.Checked)
                {
                    DisplayinGrid("FirstName", grade);
                }

                else if (ID.Checked)
                {
                    DisplayinGrid("TeachersId", grade);
                }
                else if (Kebele.Checked)
                {
                    DisplayinGrid("Adress", grade);
                }
                else if (Gender.Checked)
                {
                    DisplayinGrid("Gender", grade);
                }

                else
                {
                    DisplayinGrid("", grade);
                }



            }
        }

        private void DisplayinGrid(string value, string grade)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                if (value != "")
                {
                    string selectQuery = $"SELECT FirstName,LastName,TeachersId,Adress,Gender FROM G{grade}TStatus ORDER BY {value} ASC;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView3.DataSource = dataTable;
                        dataGridView3.ReadOnly = true;
                        dataGridView3.BackgroundColor = Color.White;
                        panel1.Visible = true;
                        dataGridView3.Visible = true;
                        panelOfId.Visible = false;
                    }


                }
                else
                {
                    string selectQuery = $"SELECT FirstName,LastName,TeachersId,Adress,Gender FROM G{grade}TStatus;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView3.DataSource = dataTable;
                        dataGridView3.ReadOnly = true;
                        dataGridView3.BackgroundColor = Color.White;
                        panel1.Visible = true;
                        dataGridView3.Visible = true;
                        panelOfId.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                Message message = new Message("Something Went Wrong!! ");
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


        private void SearchId_Click(object sender, EventArgs e)
        {
           


            int count = 0;
            for (int grade = 9; grade < 13; grade++)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string selectQuery = $"SELECT * FROM G{grade}TStatus WHERE TeachersId = '{TeacherId.Texts}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                string selectQuery2 = $"SELECT * FROM teachersprofile WHERE TeacherId = '{TeacherId.Texts}';";
                                using (SQLiteCommand command1 = new SQLiteCommand(selectQuery2, connection))
                                {
                                    using (SQLiteDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            image.ImageLocation = reader1["ImagePath"].ToString();
                                        }
                                        else { image.ImageLocation = "C:\\School\\School\\Resources\\avator.PNG"; }

                                    }
                                }





                                count++;
                                label22.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                gradee.Text = grade.ToString();
                                gen.Text = reader["Gender"].ToString();
                                pho.Text = reader["Phone"].ToString();
                                em.Text = reader["Email"].ToString();
                                adr.Text = reader["Adress"].ToString();
                                bdt.Text = reader["BirthDate"].ToString();
                                panel1.Visible = false;
                                panelOfId.Visible = true;
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    Message message = new Message("Something Went Wrong!! ");
                    message.Show();
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }

            }
            if (count == 0)
            {
                Message message = new Message($"There is No teacher With\r\nID: '{TeacherId.Texts}'");
                message.Show();
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdressI_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click_1(object sender, EventArgs e)
        {

            IHome.Visible = false;
            IRegistration.Visible = true;
            ISearch.Visible = false;

            paneHome.Visible = false;
            panelSearch.Visible = false;
            panelRegistration.Visible = true;
        }

        private void rjButton3_Click_1(object sender, EventArgs e)
        {
            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = true;

            paneHome.Visible = false;
            panelRegistration.Visible = false;
            panelSearch.Visible = true;
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            IHome.Visible = true;
            IRegistration.Visible = false;
            ISearch.Visible = false;


            panelRegistration.Visible = false;
            panelSearch.Visible = false;
            paneHome.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
