namespace School
{
    partial class AdminPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Input = new CustomControls.RJControls.RJTextBox();
            this.Done = new CustomControls.RJControls.RJButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Image = global::School.Properties.Resources._8img;
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.Black;
            this.Input.BorderColor = System.Drawing.Color.LimeGreen;
            this.Input.BorderFocusColor = System.Drawing.Color.LimeGreen;
            this.Input.BorderRadius = 10;
            this.Input.BorderSize = 2;
            this.Input.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.LimeGreen;
            this.Input.Location = new System.Drawing.Point(240, 64);
            this.Input.Margin = new System.Windows.Forms.Padding(4);
            this.Input.Multiline = false;
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Input.PasswordChar = true;
            this.Input.PlaceholderColor = System.Drawing.Color.LimeGreen;
            this.Input.PlaceholderText = "                  Admin Password";
            this.Input.Size = new System.Drawing.Size(297, 33);
            this.Input.TabIndex = 5;
            this.Input.Texts = "";
            this.Input.UnderlinedStyle = false;
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress_1);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Black;
            this.Done.BackgroundColor = System.Drawing.Color.Black;
            this.Done.BorderColor = System.Drawing.Color.LimeGreen;
            this.Done.BorderRadius = 10;
            this.Done.BorderSize = 1;
            this.Done.FlatAppearance.BorderSize = 0;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ForeColor = System.Drawing.Color.LimeGreen;
            this.Done.Location = new System.Drawing.Point(344, 171);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(76, 30);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.TextColor = System.Drawing.Color.LimeGreen;
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMessage.Location = new System.Drawing.Point(213, 305);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(270, 18);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "|                    You have 5 chance left!";
           
            // 
            // AdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPassword";
            this.Load += new System.EventHandler(this.AdminPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox Input;
        private CustomControls.RJControls.RJButton Done;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
    }
}