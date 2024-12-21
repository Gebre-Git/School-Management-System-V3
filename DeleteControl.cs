using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class DeleteControl : UserControl
    {
        private SQLiteConnection connection;
        public DeleteControl()
        {
            InitializeComponent();
            string connstring = "Data Source = F:/Project Stuff/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);
            panelOfId.Visible = false;
        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            string id = StudentId.Texts;
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
                                for (int x = 0; x < reader.FieldCount-2; x++)
                                {
                                    if (string.IsNullOrEmpty(reader.GetString(x)))
                                    {
                                        value ="";
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
                    connection.Close();

            }

                catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
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
                    if(count2 == 0 && count1==0)
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
                        Message message = new Message("Oops,Couldn't Delete the data!!");
                        message.Show();
                    }

                }
                finally
                {
                    if (isdone==true)
                    {
                        string delaterow = $"DELETE FROM G{Grade}Status WHERE StudentId = '{id}'; ";
                        string delaterow2 = $"DELETE FROM G{Grade}Roster WHERE StudentId = '{id}'; ";
                        SQLiteCommand cmd = new SQLiteCommand(delaterow, connection);
                        SQLiteCommand cmd2 = new SQLiteCommand(delaterow2, connection);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        Message message = new Message("The Student Data Deleted Successfully");
                        message.Show();
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }

            }
        }

        private void DeleteControl_Load(object sender, EventArgs e)
        {

        }

        private void Look_Click(object sender, EventArgs e)
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
                                count++;
                                label22.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                gradee.Text = grade.ToString();
                                gen.Text = reader["Gender"].ToString();
                                pho.Text = reader["Phone"].ToString();
                                em.Text = reader["Email"].ToString();
                                adr.Text = reader["Adress"].ToString();
                                bdt.Text = reader["BirthDate"].ToString();
                                panelOfId.Visible = true;
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    Message message = new Message("Oops,Something Went Wrong!!");
                    message.Show();
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    { connection.Close(); }
                }

            }
            if (count ==0)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Message message = new Message($"There is No Student With\r\n Id :{StudentId.Texts}");
                message.Show();
            }
        }

        private void StudentId__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelOfId_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
