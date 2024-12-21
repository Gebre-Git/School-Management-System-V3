using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SQLite;
using SMS.RJControls;

namespace School
{
    public partial class AdminHome : Form
    {
        private SQLiteConnection connection;
        public AdminHome()
        {
            InitializeComponent();
            string connstring = "Data Source = C:/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);

        }


        private void SearchID_Click(object sender, EventArgs e)
        {

        }



        private void rjButton1_Click(object sender, EventArgs e)
        {
            MainHome.Visible = true;
            panelRegister.Visible = false;
            PanelSearch.Visible = false;
            PanelAttendance.Visible = false;
            panelRoster.Visible = false;
            panelCheckRoster.Visible = false;
            panelDelete.Visible = false;

            IHome.Visible = true;
            IRegistration.Visible = false;
            ISearch.Visible = false;
            IAttendance.Visible = false;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = false;
            Idelete.Visible = false;
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            rjButton1_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            PanelSearch.Visible = false;
            PanelAttendance.Visible = false;
            panelRoster.Visible = false;
            panelCheckRoster.Visible = false;
            panelDelete.Visible = false;

            IHome.Visible = false;
            IRegistration.Visible = true;
            ISearch.Visible = false;
            IAttendance.Visible = false;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = false;
            Idelete.Visible = false;
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

            MainHome.Visible = true;
            panelRegister.Visible = true;
            PanelSearch.Visible = true;
            PanelAttendance.Visible = true;
            panelRoster.Visible = false;
            panelCheckRoster.Visible = false;
            panelDelete.Visible = false;


            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = false;
            IAttendance.Visible = true;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = false;
            Idelete.Visible = false;
        }



        private void rjButton6_Click(object sender, EventArgs e)
        {
            MainHome.Visible = true;
            panelRegister.Visible = true;
            PanelSearch.Visible = true;
            PanelAttendance.Visible = true;
            panelRoster.Visible = true;
            panelCheckRoster.Visible = true;
            panelDelete.Visible = false;

            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = false;
            IAttendance.Visible = false;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = true;
            Idelete.Visible = false;
        }




        public static int parentx, parenty;
        public void messageDisplayer(string text, string type)
        {
            Form modalBackground = new Form();
            using (Message2 modal = new Message2(text, type))
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                parentx = this.Location.X;
                parenty = this.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }





        private void panelCheckRoster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gradient_Panal1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton7_Click_1(object sender, EventArgs e)
        {

        }

        private void rjDropdownMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void rjDropdownMenu2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kebeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gradeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gradient_Panal2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradient_Panal3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panelRegistration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSetRoster_Paint(object sender, PaintEventArgs e)
        {

        }


        private void rjTextBox8__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox9__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox10__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox11__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox12__TextChanged(object sender, EventArgs e)
        {
        }

        private void rjTextBox13__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox14__TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAttendance_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Year_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Month_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox7__TextChanged(object sender, EventArgs e)
        {

        }

        private void Week_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void rjTextBox6__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }


        private void rjTextBox15__TextChanged(object sender, EventArgs e)
        {

        }

        private void Hide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Alphabet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void rjTextBox16__TextChanged(object sender, EventArgs e)
        {

        }

        private void Rank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            MainHome.Visible = true;
            PanelSearch.Visible = true;
            PanelAttendance.Visible = true;
            panelRoster.Visible = true;
            panelCheckRoster.Visible = false;
            panelDelete.Visible = false;

            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = false;
            IAttendance.Visible = false;
            ISetRoster.Visible = true;
            ICheckRoster.Visible = false;
            Idelete.Visible = false;
        }


        private void rjButton3_Click(object sender, EventArgs e)
        {
            panelRegister.Visible = true;
            MainHome.Visible = true;
            PanelSearch.Visible = true;
            PanelAttendance.Visible = false;
            panelCheckRoster.Visible = false;
            panelDelete.Visible = false;

            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = true;
            IAttendance.Visible = false;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = false;
            Idelete.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IHome_MouseHover(object sender, EventArgs e)
        {

        }

        private void IRegistration_MouseHover(object sender, EventArgs e)
        {

        }

        private void ISearch_MouseHover(object sender, EventArgs e)
        {

        }

        private void IAttendance_MouseHover(object sender, EventArgs e)
        {

        }

        private void ISetRoster_Click(object sender, EventArgs e)
        {

        }

        private void ISetRoster_MouseHover(object sender, EventArgs e)
        {

        }

        private void ICheckRoster_MouseHover(object sender, EventArgs e)
        {

        }

        private void IHome_MouseLeave(object sender, EventArgs e)
        {

        }

        private void IRegistration_Click(object sender, EventArgs e)
        {

        }

        private void IRegistration_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ISearch_MouseLeave(object sender, EventArgs e)
        {

        }

        private void IAttendance_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ISetRoster_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ICheckRoster_MouseLeave(object sender, EventArgs e)
        {

        }

        private void IHome_MouseEnter(object sender, EventArgs e)
        {

        }

        private void rjButton1_MouseEnter(object sender, EventArgs e)
        {
            IHome.BackColor = Color.Black;
        }

        private void rjButton1_MouseLeave(object sender, EventArgs e)
        {
            IHome.BackColor = Color.White;
        }


        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            MainHome.Visible = true;
            panelRegister.Visible = true;
            PanelSearch.Visible = true;
            PanelAttendance.Visible = true;
            panelRoster.Visible = true;
            panelCheckRoster.Visible = true;
            panelDelete.Visible = true;

            IHome.Visible = false;
            IRegistration.Visible = false;
            ISearch.Visible = false;
            IAttendance.Visible = false;
            ISetRoster.Visible = false;
            ICheckRoster.Visible = false;
            Idelete.Visible = true;
        }

        private void Teachers_Click(object sender, EventArgs e)
        {
            AdminHomeTeachers adminHomeTeachers = new AdminHomeTeachers();
            adminHomeTeachers.Show();
            this.Hide();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            AdminHomeTeachers adminHomeTeachers = new AdminHomeTeachers();
            adminHomeTeachers.Show();
            this.Hide();
        }
        public void Submite_work()
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
                messageDisplayer("Select Gender please!!", "y");

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
                if (first_name != "" && last_name != "" && phone_number != "" && adress != "" && new_email != "" && grade != "")
                {

                    string inputQuery = $"INSERT INTO G{grade}Status  VALUES ('" + first_name + "','" + last_name + "','" + email + "','" + phone_number + "','" + adress + "','" + BirthDate + "','" + gender + "','" + Id + "','" + uniquekey + "','" + username + "','" + password + "');";
                    string rosterQuery = $"INSERT INTO G{grade}Roster(FirstName,LastName,Biology,Chemistry,English,ICT,Mathematics,Physics,Average,StudentId) VALUES ('" + first_name + "','" + last_name + "','','','','','','','','" + Id + "')";
                    SQLiteCommand cmd2 = new SQLiteCommand(rosterQuery, connection);
                    SQLiteCommand cmd = new SQLiteCommand(inputQuery, connection);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    messageDisplayer("The Student Data Saved\r\n\tSuccessfully", "x");

                }
            }
            catch (Exception ex)
            {
                messageDisplayer("The data Doesn't Saved", "y");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void Submite_Click(object sender, EventArgs e)
        {
            Submite_work();
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

                messageDisplayer("Something Went Wrong!!", "y");
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
                messageDisplayer("Something Went Wrong!!", "y");
            }
            finally
            {
                if (connection.State == ConnectionState.Open) { connection.Close(); }

            }
            serialnumber = serialholder;

        }

        private void SearchGrade_Click(object sender, EventArgs e)
        {

            string gradecheck = @"^(9|10|11|12)$";
            string grade = "";
            bool endgrade = false;
            while (!endgrade)
            {
                grade = Gradeentry.Texts;
                bool reGrade = Regex.IsMatch(grade, gradecheck);
                if (reGrade == false)
                {
                    messageDisplayer("Invalid Grade Input (9-12)!!", "y");
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
                    DisplayinGrid("StudentId", grade);
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
                    string selectQuery = $"SELECT FirstName,LastName,StudentId,Adress,Gender FROM G{grade}Status ORDER BY {value} ASC;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView3.DataSource = dataTable;
                        dataGridView3.ReadOnly = true;
                        dataGridView3.BackgroundColor = Color.White;
                        panelGrid.Visible = true;
                        dataGridView3.Visible = true;
                        panelOfId.Visible = false;
                    }


                }
                else
                {
                    string selectQuery = $"SELECT FirstName,LastName,StudentId,Adress,Gender FROM G{grade}Status;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView3.DataSource = dataTable;
                        dataGridView3.ReadOnly = true;
                        dataGridView3.BackgroundColor = Color.White;
                        panelGrid.Visible = true;
                        dataGridView3.Visible = true;
                        panelOfId.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                messageDisplayer("Something Went Wrong!!", "y");

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void SearchId_Click_1(object sender, EventArgs e)
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

                    string selectQuery = $"SELECT * FROM G{grade}Status WHERE StudentId = '{StudentId.Texts}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string selectQuery2 = $"SELECT * FROM G{grade}StudentsProfile WHERE StudentId = '{StudentId.Texts}';";
                                using (SQLiteCommand command1 = new SQLiteCommand(selectQuery2, connection))
                                {
                                    using (SQLiteDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            rjCircularPictureBox1.ImageLocation = reader1["ImagePath"].ToString();
                                        }
                                        else { rjCircularPictureBox1.ImageLocation = "C:\\School\\School\\Resources\\avator.PNG"; }

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
                                panelGrid.Visible = false;
                                panelOfId.Visible = true;
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    messageDisplayer("Something Went Wrong!!", "y");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }

            }
            if (count == 0)
            {
                messageDisplayer($"There is No Student With\r\nID: '{StudentId.Texts}'", "y");

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string date1 = rjDatePicker2.Text.ToString().Replace(',', '_');
            string date2 = date1.Replace(' ', '_');
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();

                }
                string selectquery = $"SELECT RoleNumber,Name,{date2} FROM G{Gradesearch.Texts}Attendance; ";
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectquery, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    panel4.Visible = true;
                    dataGridView2.DataSource = dataTable;
                    dataGridView2.ReadOnly = true;
                    dataGridView2.BackgroundColor = Color.White;
                    dataGridView2.Visible = true;
                }
                string selectquery2 = $"SELECT count(Name) FROM G{Gradesearch.Texts}Attendance WHERE {date2}='A';";
                SQLiteCommand command = new SQLiteCommand(selectquery2, connection);
                int rowaffected = Convert.ToInt32(command.ExecuteScalar());
                NoOfAbsent.Text = rowaffected.ToString();
                label3.Visible = true;
                NoOfAbsent.Visible = true;
            }

            catch (Exception ex)
            {

                if (ex.Message == $"SQL logic error\r\nno such table: G{Gradesearch.Texts}Attendance")
                {
                    messageDisplayer("Please Check The Grade!!", "y");
                }
                else if (ex.Message == $"SQL logic error\r\nno such column: {date2}")
                {
                    messageDisplayer($"There is No Attendance record \r\non {date2}", "y");

                }
                else
                {
                    messageDisplayer("Something Went Wrong!!", "y"); ;
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string selectQuery = $"SELECT * FROM G{Gradesearch.Texts}Attendance WHERE RoleNumber = '{rjTextBox7.Texts}';";
                SQLiteCommand cmd = new SQLiteCommand(selectQuery, connection);
                int rowAffected = Convert.ToInt32(cmd.ExecuteScalar());
                if (rowAffected != 0)
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        panel4.Visible = true;
                        dataGridView2.DataSource = dataTable;
                        dataGridView2.ReadOnly = true;
                        dataGridView2.BackgroundColor = Color.White;
                        dataGridView2.Visible = true;
                        label3.Visible = false;
                        NoOfAbsent.Visible = false;

                    }
                }
                else
                {
                    messageDisplayer($"There is NO Student With\r\n Role Number {rjTextBox7.Texts}", "y");

                }

            }
            catch (Exception ex)
            {

                if (ex.Message == $"SQL logic error\r\nno such table: G{Gradesearch.Texts}Attendance")
                {
                    messageDisplayer("Please Check The Grade!!", "y");
                }

                else
                {
                    messageDisplayer("Something Went Wrong!!", "y");
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }

        }
        public void Submit_work()
        {

            BioI.Visible = false;
            ChemI.Visible = false;
            PhyI.Visible = false;
            MathI.Visible = false;
            ICTI.Visible = false;
            EngI.Visible = false;
            string gradeholder = "";
            int count = 0;
            for (int grade = 9; grade < 13; grade++)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    string selectQuery = $"SELECT * FROM G{grade}Status WHERE StudentId = '{StudID.Texts}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                count++;
                                gradeholder = grade.ToString();
                                break;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    messageDisplayer("Something Went Wrong", "y");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }
            }
            if (count == 0)
            {
                messageDisplayer($"There is No Student With\r\n Id : '{StudID.Texts}'", "y");


            }

            int rank;

            if (gradeholder != "")
            {
                string checkScore = @"^[0-9]{1,3}$";

                string Bio = "";
                bool endbio = false;
                while (!endbio)
                {
                    Bio = BioIn.Texts;
                    bool rebio = Regex.IsMatch(Bio, checkScore);
                    if (rebio == false)
                    {
                        BioI.Visible = true;
                        Bio = "";
                        break;
                    }
                    else
                    {
                        endbio = true;
                    }
                }

                string engl = "";
                bool endeng = false;
                while (!endeng)
                {
                    engl = EngIn.Texts;
                    bool reeng = Regex.IsMatch(engl, checkScore);
                    if (reeng == false)
                    {
                        EngI.Visible = true;
                        engl = "";
                        break;
                    }
                    else
                    {
                        endeng = true;
                    }
                }

                string it = "";
                bool endict = false;
                while (!endict)
                {
                    it = ictIn.Texts;
                    bool reict = Regex.IsMatch(it, checkScore);
                    if (reict == false)
                    {
                        ICTI.Visible = true;
                        it = "";
                        break;
                    }
                    else
                    {
                        endict = true;
                    }
                }

                string Chemi = "";
                bool endchem = false;
                while (!endchem)
                {
                    Chemi = ChemIn.Texts;
                    bool rechem = Regex.IsMatch(Chemi, checkScore);
                    if (rechem == false)
                    {
                        ChemI.Visible = true;
                        Chemi = "";
                        break;
                    }
                    else
                    {
                        endchem = true;
                    }
                }

                string phys = "";
                bool endphy = false;
                while (!endphy)
                {
                    phys = Phyin.Texts;
                    bool rephy = Regex.IsMatch(phys, checkScore);
                    if (rephy == false)
                    {
                        PhyI.Visible = true;
                        phys = "";
                        break;
                    }
                    else
                    {
                        endphy = true;
                    }
                }


                string maths = "";
                bool endmath = false;
                while (!endmath)
                {
                    maths = mathin.Texts;
                    bool remath = Regex.IsMatch(maths, checkScore);
                    if (remath == false)
                    {
                        MathI.Visible = true;
                        maths = "";
                        break;
                    }
                    else
                    {
                        endmath = true;
                    }
                }

                if (maths != "" && Chemi != "" && phys != "" && engl != "" && it != "" && Bio != "")
                {
                    try
                    {

                        double Temp_Average = (Convert.ToDouble(Bio) + Convert.ToDouble(phys) + Convert.ToDouble(Chemi) + Convert.ToDouble(maths) + Convert.ToDouble(engl) + Convert.ToDouble(it)) / 6;
                        double Average = Math.Round(Temp_Average, 2);
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        string inputQuery = $"UPDATE G{gradeholder}Roster SET Biology = '{BioIn.Texts}', Chemistry = '{ChemIn.Texts}', English ='{EngIn.Texts}', ICT = '{ictIn.Texts}', Mathematics = '{mathin.Texts}', Physics = '{Phyin.Texts}', Average = '{Average.ToString()}' WHERE StudentId = '{StudID.Texts}';";
                        SQLiteCommand cmd = new SQLiteCommand(inputQuery, connection);
                        cmd.ExecuteNonQuery();


                        updateRank(gradeholder);
                        messageDisplayer("The Student Roster Saved Successfully", "x");

                    }
                    catch (Exception ex)
                    {
                        messageDisplayer("Something Went Wrong", "y");
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        { connection.Close(); }
                    }


                }


            }
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            Submit_work();   
        }

        private void updateRank(string gradeholder)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string selectQuery = $"SELECT StudentId, Average FROM G{gradeholder}Roster ORDER BY Average DESC";
                using (var cmd = new SQLiteCommand(selectQuery, connection))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    int rank = 1;
                    while (reader.Read())
                    {
                        string id = reader.GetString(0);
                        string updateRankQuery = $"UPDATE G{gradeholder}Roster SET Rank = @Rank WHERE StudentId = @StudentId";
                        using (var updateCmd = new SQLiteCommand(updateRankQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@Rank", rank);
                            updateCmd.Parameters.AddWithValue("@StudentId", id);
                            updateCmd.ExecuteNonQuery();
                        }
                        rank++;
                    }
                }

            }
            catch (Exception ex)
            {
                messageDisplayer("Something Went Wrong", "y");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }
        }
        public void pictureBox2_work()
        {
            string gradecheck = @"^(9|10|11|12)$";
            string grade = "";
            bool endgrade = false;
            while (!endgrade)
            {
                grade = GradeInput.Texts;
                bool reAdress = Regex.IsMatch(grade, gradecheck);
                if (reAdress == false)
                {
                    messageDisplayer("Invalid Grade Input (9-12)!!", "y");
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
                if (Rank.Checked == true)
                {
                    DisplayinGridroster("Rank", grade);
                }
                else if (Alphabet.Checked == true)
                {
                    DisplayinGridroster("FirstName", grade);
                }
                else if (Hide.Checked == true)
                {

                    DisplayinGridroster("Average", grade);
                }
                else
                {
                    DisplayinGridroster("", grade);
                }

            }
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            pictureBox2_work();
        }

        private void DisplayinGridroster(string value, string grade)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                if (value != "")
                {
                    string selectQuery1 = $"SELECT FirstName,LastName,Average,Rank FROM G{grade}Roster ORDER BY {value} ASC;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery1, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.BackgroundColor = Color.White;
                        dataGridView1.Visible = true;
                        panelstudpro.Visible = false;
                        PanelGridRoster.Visible = true;
                    }
                }
                else
                {
                    string selectQuery = $"SELECT FirstName,LastName,Average FROM G{grade}Roster;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectQuery, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.ReadOnly = true;
                        dataGridView1.BackgroundColor = Color.White;
                        dataGridView1.Visible = true;
                        panelstudpro.Visible = false;
                        PanelGridRoster.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                messageDisplayer("Something Went Wrong", "y");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void pictureBox5_work()
        {
            GradeInput.Texts = "";
            int count = 0;
            for (int grade = 9; grade < 13; grade++)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }


                    string selectQuery = $"SELECT * FROM G{grade}Roster WHERE StudentId = '{IDinput.Texts}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {


                                string selectQuery2 = $"SELECT * FROM G{grade}StudentsProfile WHERE StudentId = '{IDinput.Texts}';";
                                using (SQLiteCommand command1 = new SQLiteCommand(selectQuery2, connection))
                                {
                                    using (SQLiteDataReader reader1 = command1.ExecuteReader())
                                    {
                                        if (reader1.Read())
                                        {
                                            rjCircularPictureBox2.ImageLocation = reader1["ImagePath"].ToString();
                                        }
                                        else { rjCircularPictureBox2.ImageLocation = "C:\\School\\School\\Resources\\avator.PNG"; }

                                    }
                                }




                                count++;
                                label10.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                bio.Text = reader["Biology"].ToString();
                                chem.Text = reader["Chemistry"].ToString();
                                phy.Text = reader["Physics"].ToString();
                                eng.Text = reader["English"].ToString();
                                ict.Text = reader["ICT"].ToString();
                                math.Text = reader["Mathematics"].ToString();
                                average.Text = reader["Average"].ToString();
                                double Average_int = Convert.ToDouble(reader["Average"].ToString());
                                if (Average_int >= 80 && Average_int <= 100) { Failed.Visible = false; Passed.Visible = true; }
                                else { Failed.Visible = true; Passed.Visible = false; }
                                dataGridView1.Visible = false;
                                panelstudpro.Visible = true;
                                PanelGridRoster.Visible = false;
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    messageDisplayer("The Student Roster Data Is Incomplete!!", "y");


                }
                finally
                {

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }

            }
            if (count == 0)
            {
                messageDisplayer($"There Is No Student With ID : {IDinput.Texts}", "y");

            }
        }
        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            pictureBox5_work();
        }
        public void Look_work()
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

                    string selectQuery = $"SELECT * FROM G{grade}Status WHERE StudentId = '{IdStud.Texts}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                string selectQuery2 = $"SELECT * FROM G{grade}StudentsProfile WHERE StudentId = '{IdStud.Texts}';";
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
                                label8.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                G.Text = grade.ToString();
                                Ge.Text = reader["Gender"].ToString();
                                p.Text = reader["Phone"].ToString();
                                E.Text = reader["Email"].ToString();
                                Ad.Text = reader["Adress"].ToString();
                                Bd.Text = reader["BirthDate"].ToString();
                                gunaShadowPanel7.Visible = true;
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    messageDisplayer("Something Went Wrong", "y");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }

            }
            if (count == 0)
            {
                messageDisplayer($"There is No Student With\r\n Id :{IdStud.Texts}", "y");

            }
        }
        private void Look_Click(object sender, EventArgs e)
        {
            Look_work();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void panelDelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton3_Click_1(object sender, EventArgs e)
        {
            Unique_Key_and_Id unique_Key_And_Id = new Unique_Key_and_Id();
            unique_Key_And_Id.Show();
        }

        private void gunaGradientButton4_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void IdStud_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GradeInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void IDinput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Phyin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Adress_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            //string url = "https://www.example.com";
            //Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            //string url = "https://www.example.com";
            //Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            //string url = "https://www.example.com";
            //Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

            string id = IdStud.Texts;
            string[] StudentData = new string[9];
            string[] studentroster = new string[9];
            string[] fulldata = new string[16];
            string Grade = "";
            for (int grade = 9; grade < 13; grade++)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    string value;
                    string selectQuery = $"SELECT *  FROM G{grade}Status WHERE StudentId = '{id}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int x = 0; x < reader.FieldCount - 2; x++)
                                {
                                    if (string.IsNullOrEmpty(reader.GetString(x)))
                                    {
                                        value = "";
                                    }
                                    else
                                    {
                                        value = reader.GetString(x);
                                    }
                                    StudentData[x] = value;
                                }
                                Grade = grade.ToString();

                            }
                        }

                    }
                    string valueRoster;
                    string selectQuery2 = $"SELECT *  FROM G{grade}Roster WHERE StudentId = '{id}';";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery2, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                for (int x = 0; x < reader.FieldCount - 2; x++)
                                {
                                    if (string.IsNullOrEmpty(reader.GetString(x)))
                                    {
                                        valueRoster = "";
                                    }
                                    else
                                    {
                                        valueRoster = reader.GetString(x);
                                    }
                                    studentroster[x] = valueRoster;
                                }


                            }
                        }

                    }


                }

                catch (Exception ex)
                {
                    messageDisplayer("Something Went Wrong", "y");
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }

            }
            int count = 2;
            for (int i = 0; i < 16; i++)
            {
                if (i < 9)
                {
                    fulldata[i] = StudentData[i];
                }
                if (i > 8)
                {
                    fulldata[i] = studentroster[count];
                    count++;
                }


            }
            bool isdone = false;
            int count2 = 0;
            int count1 = 0;
            if (!string.IsNullOrEmpty(StudentData[0]) && !string.IsNullOrEmpty(studentroster[0]))
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }


                    string stringquery = $"INSERT INTO G{Grade}_{(DateTime.Now.Year).ToString()}DeletedStatus VALUES('{fulldata[0]}','{fulldata[1]}','{fulldata[2]}','{fulldata[3]}','{fulldata[4]}','{fulldata[5]}','{fulldata[6]}','{fulldata[7]}','{fulldata[8]}','{fulldata[9]}','{fulldata[10]}','{fulldata[11]}','{fulldata[12]}','{fulldata[13]}','{fulldata[14]}','{fulldata[15]}');";
                    SQLiteCommand cmd = new SQLiteCommand(stringquery, connection);
                    cmd.ExecuteNonQuery();
                    if (count2 == 0 && count1 == 0)
                    {
                        isdone = true;
                    }

                }

                catch (Exception ex)
                {

                    if (ex.Message == $"SQL logic error\r\nno such table: G{Grade}_{(DateTime.Now.Year).ToString()}DeletedStatus")
                    {
                        string CreateTable = $"CREATE TABLE G{Grade}_{(DateTime.Now.Year).ToString()}DeletedStatus (FirstName TEXT,LastName TEXT,Email TEXT,Phone TEXT, Adress TEXT, BirthDate TEXT, Gender TEXT,StudentId TEXT,Uniquekey TEXT,Biology TEXT,Chemistry TEXT, English TEXT,ICT TEXT,Mathematics TEXT,Physics TEXT,Average TEXT );";
                        SQLiteCommand cmd2 = new SQLiteCommand(CreateTable, connection);
                        cmd2.ExecuteNonQuery();


                        string stringquery = $"INSERT INTO G{Grade}_{(DateTime.Now.Year).ToString()}DeletedStatus VALUES('{fulldata[0]}','{fulldata[1]}','{fulldata[2]}','{fulldata[3]}','{fulldata[4]}','{fulldata[5]}','{fulldata[6]}','{fulldata[7]}','{fulldata[8]}','{fulldata[9]}','{fulldata[10]}','{fulldata[11]}','{fulldata[12]}','{fulldata[13]}','{fulldata[14]}','{fulldata[15]}');";
                        SQLiteCommand cmd = new SQLiteCommand(stringquery, connection);
                        cmd.ExecuteNonQuery();
                        count2++;
                    }

                    else
                    {
                        isdone = false;
                        count1++;
                        messageDisplayer("Oops,Couldn't Delete the data", "y");
                    }

                }
                finally
                {
                    if (isdone == true)
                    {
                        string delaterow = $"DELETE FROM G{Grade}Status WHERE StudentId = '{id}'; ";
                        string delaterow2 = $"DELETE FROM G{Grade}Roster WHERE StudentId = '{id}'; ";
                        SQLiteCommand cmd = new SQLiteCommand(delaterow, connection);
                        SQLiteCommand cmd2 = new SQLiteCommand(delaterow2, connection);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        messageDisplayer("The Student Data Deleted Successfully", "x");
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }

            }
        }
    }
    }
 

