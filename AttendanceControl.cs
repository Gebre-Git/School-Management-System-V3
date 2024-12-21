using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class AttendanceControl : UserControl
    {
        private SQLiteConnection connection;
        public AttendanceControl()
        {
            InitializeComponent();
            string connstring = "Data Source = F:/Project Stuff/School/SchoolManagmentSystem.db;Version=3;";
            connection = new SQLiteConnection(connstring);

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
                SQLiteCommand command = new SQLiteCommand(selectquery2,connection);
                int rowaffected = Convert.ToInt32(command.ExecuteScalar());
                NoOfAbsent.Text = rowaffected.ToString();
                label2.Visible = true;
                NoOfAbsent.Visible = true;
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                //MessageBoxIcon.Error);
                //textBox1.Text = ex.Message;
                if (ex.Message == $"SQL logic error\r\nno such table: G{Gradesearch.Texts}Attendance")
                {
                    Message message = new Message("Please Check The Grade!!");
                    message.Show();
                }
                else if (ex.Message ==$"SQL logic error\r\nno such column: {date2}")
                {
                    Message message = new Message($"There is No Attendance record \r\non {date2}");
                    message.Show();
                }    
                else
                {
                    Message message = new Message(ex.Message);
                    message.Show();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }

        }


        private void rjDatePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                SQLiteCommand cmd  = new SQLiteCommand(selectQuery,connection);
                int rowAffected = Convert.ToInt32(cmd.ExecuteScalar());
                if(rowAffected !=0)
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

                    }
                }
                else
                {
                    Message message = new Message($"There is NO Student With\r\n Role Number {rjTextBox7.Texts}");
                    message.Show();
                }

            }
            catch (Exception ex)
            {
              
                if (ex.Message == $"SQL logic error\r\nno such table: G{Gradesearch.Texts}Attendance")
                {
                    Message message = new Message("Please Check The Grade!!");
                    message.Show();
                }

                else
                {
                    Message message = new Message(ex.Message);
                    message.Show();
                }
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                { connection.Close(); }
            }


        }



        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
