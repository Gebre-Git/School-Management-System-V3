using System;
using System.IO;
using System.Windows.Forms;

namespace School
{
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
        }

        private const string correctPassword = "123456";
        private const int maxAttempts = 5;
        private const int lockoutMinutes = 5;
        private int attempts = 0;
        private DateTime lockoutEndTime;
        private string lockoutFilePath = "C:/School/lockout.txt"; // File path to store lockout info

        private void AdminPassword_Load(object sender, EventArgs e)
        {
            CheckLockoutStatus(); // Check if the system is locked when the form loads
        }

        private void CheckLockoutStatus()
        {
            if (File.Exists(lockoutFilePath))
            {
                // Read the lockout end time from the file
                string lockoutData = File.ReadAllText(lockoutFilePath);
                lockoutEndTime = DateTime.Parse(lockoutData);

                // Check if the lockout period has expired
                if (DateTime.Now < lockoutEndTime)
                {
                    // Lockout is still in effect, show the remaining lockout time
                    ShowLockoutStatus();
                }
                else
                {
                    // Lockout period has expired, allow login
                    File.Delete(lockoutFilePath); // Clear the lockout file
                    attempts = 0; // Reset the number of attempts
                    lblMessage.Text = "You can try again now.";
                    Done.Enabled = true; // Enable the login button
                }
            }
            else
            {
                // No lockout file exists, system is not locked
                attempts = 0;
                Done.Enabled = true;
            }
        }

        private void ShowLockoutStatus()
        {
            // Show the remaining time of the lockout period
            TimeSpan timeRemaining = lockoutEndTime - DateTime.Now;

            // Format the countdown time
            lblMessage.Text = $"System is locked. Try again in {timeRemaining.Minutes:D2}:{timeRemaining.Seconds:D2}.";
            Done.Enabled = false; // Disable the login button
            timer1.Start(); // Start the timer to update the remaining time
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Done_work();
        }

        public void Done_work()
        {
            if (Input.Texts == correctPassword)
            {
                attempts = 0; // Reset attempts on successful login
                this.Hide();
                AdminHome Admin = new AdminHome();
                Admin.ShowDialog();
            }
            else
            {
                attempts++;
                lblMessage.Text = $"Invalid password. {maxAttempts - attempts} attempts remaining.";

                if (attempts >= maxAttempts)
                {
                    LockSystem();
                }
            }
        }

        private void LockSystem()
        {
            lockoutEndTime = DateTime.Now.AddMinutes(lockoutMinutes);
            File.WriteAllText(lockoutFilePath, lockoutEndTime.ToString());
            ShowLockoutStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update lockout status in real-time
            TimeSpan timeRemaining = lockoutEndTime - DateTime.Now;

            // If the remaining time is negative, stop the lockout
            if (timeRemaining.TotalSeconds <= 0)
            {
                timer1.Stop();
                lblMessage.Text = "You can try again now.";
                Done.Enabled = true;
                attempts = 0;
                File.Delete(lockoutFilePath); // Remove lockout file
            }
            else
            {
                // Continue showing the lockout status with countdown format
                lblMessage.Text = $"System is locked. Try again in {timeRemaining.Minutes:D2}:{timeRemaining.Seconds:D2}.";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void Input_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Done_work();
            }
        }
    }
}