using System;
using System.Windows.Forms;

namespace School
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set the timer interval to 10 seconds (10000 milliseconds)
            timer2.Interval = 20000; // 10 seconds
            timer2.Start(); // Start the timer
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop(); // Stop the timer
            Form1 frm = new Form1(); // Create an instance of Form1
            frm.Show(); // Show Form1
            this.Hide(); // Hide Form2
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form2 when the button is clicked
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: Add any functionality for pictureBox1 if needed
        }
    }
}



