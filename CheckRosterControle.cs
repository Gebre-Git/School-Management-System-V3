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
    public partial class CheckRosterControle : UserControl
    {
        private SQLiteConnection connection;

        public CheckRosterControle()
        {
            InitializeComponent();
            string connstring = "Data Source = F:/Project Stuff/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);
            panelstudpro.Visible = false;
        }

        private void SearchGrade_Click_1(object sender, EventArgs e)
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
                if (Rank.Checked == true)
                {
                    DisplayinGrid("Rank", grade);
                }
                else if (Alphabet.Checked == true)
                {
                    DisplayinGrid("FirstName", grade);
                }
                else if (Hide.Checked == true)
                {

                    DisplayinGrid("Average", grade);
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
                        panelGrid.Visible = true;
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
        private void SearchID_Click_1(object sender, EventArgs e)
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
                                if (Average_int >= 80 && Average_int <= 100) {Failed.Visible = false; Passed.Visible = true;}
                                else { Failed.Visible = true; Passed.Visible = false; }
                                dataGridView1.Visible = false;
                                panelstudpro.Visible = true;    
                                break;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    Message message = new Message("The Student Roster Data Is Incomplete!!");
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
            if (count==0)
            {
                Message message = new Message($"There Is No Student With ID : {IDinput.Texts}");
                message.Show();
            }


        }

        private void panelstudpro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GradeInput__TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelstudpro_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Rank_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Alphabet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Hide_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void IDinput__TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
