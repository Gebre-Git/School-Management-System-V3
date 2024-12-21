namespace School
{
    partial class RegistrationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submite = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FnameI = new System.Windows.Forms.Label();
            this.LnameI = new System.Windows.Forms.Label();
            this.GradeI = new System.Windows.Forms.Label();
            this.PhoneI = new System.Windows.Forms.Label();
            this.emailI = new System.Windows.Forms.Label();
            this.AdressI = new System.Windows.Forms.Label();
            this.Female = new CustomControls.RJControls.RJRadioButton();
            this.Male = new CustomControls.RJControls.RJRadioButton();
            this.Adress = new CustomControls.RJControls.RJTextBox();
            this.Phone = new CustomControls.RJControls.RJTextBox();
            this.Email = new CustomControls.RJControls.RJTextBox();
            this.Grade = new CustomControls.RJControls.RJTextBox();
            this.Lname = new CustomControls.RJControls.RJTextBox();
            this.Fname = new CustomControls.RJControls.RJTextBox();
            this.rjDatePicker1 = new School.RJControls.RJDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Submite
            // 
            this.Submite.AnimationHoverSpeed = 0.07F;
            this.Submite.AnimationSpeed = 0.03F;
            this.Submite.BackColor = System.Drawing.Color.Transparent;
            this.Submite.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.Submite.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.Submite.BorderColor = System.Drawing.Color.Black;
            this.Submite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Submite.FocusedColor = System.Drawing.Color.Empty;
            this.Submite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite.ForeColor = System.Drawing.Color.White;
            this.Submite.Image = null;
            this.Submite.ImageSize = new System.Drawing.Size(20, 20);
            this.Submite.Location = new System.Drawing.Point(274, 660);
            this.Submite.Name = "Submite";
            this.Submite.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Submite.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Submite.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Submite.OnHoverForeColor = System.Drawing.Color.White;
            this.Submite.OnHoverImage = null;
            this.Submite.OnPressedColor = System.Drawing.Color.Black;
            this.Submite.Radius = 7;
            this.Submite.Size = new System.Drawing.Size(95, 34);
            this.Submite.TabIndex = 31;
            this.Submite.Text = "  Submite";
            this.Submite.Click += new System.EventHandler(this.Submite_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::School.Properties.Resources._8963007;
            this.pictureBox4.Location = new System.Drawing.Point(26, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(597, 421);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FnameI
            // 
            this.FnameI.AutoSize = true;
            this.FnameI.ForeColor = System.Drawing.Color.Red;
            this.FnameI.Location = new System.Drawing.Point(260, 486);
            this.FnameI.Name = "FnameI";
            this.FnameI.Size = new System.Drawing.Size(38, 13);
            this.FnameI.TabIndex = 33;
            this.FnameI.Text = "Invalid";
            this.FnameI.Visible = false;
            this.FnameI.Click += new System.EventHandler(this.FnameI_Click);
            // 
            // LnameI
            // 
            this.LnameI.AutoSize = true;
            this.LnameI.ForeColor = System.Drawing.Color.Red;
            this.LnameI.Location = new System.Drawing.Point(260, 530);
            this.LnameI.Name = "LnameI";
            this.LnameI.Size = new System.Drawing.Size(38, 13);
            this.LnameI.TabIndex = 34;
            this.LnameI.Text = "Invalid";
            this.LnameI.Visible = false;
            this.LnameI.Click += new System.EventHandler(this.LnameI_Click);
            // 
            // GradeI
            // 
            this.GradeI.AutoSize = true;
            this.GradeI.ForeColor = System.Drawing.Color.Red;
            this.GradeI.Location = new System.Drawing.Point(260, 569);
            this.GradeI.Name = "GradeI";
            this.GradeI.Size = new System.Drawing.Size(38, 13);
            this.GradeI.TabIndex = 35;
            this.GradeI.Text = "Invalid";
            this.GradeI.Visible = false;
            this.GradeI.Click += new System.EventHandler(this.GradeI_Click);
            // 
            // PhoneI
            // 
            this.PhoneI.AutoSize = true;
            this.PhoneI.ForeColor = System.Drawing.Color.Red;
            this.PhoneI.Location = new System.Drawing.Point(585, 486);
            this.PhoneI.Name = "PhoneI";
            this.PhoneI.Size = new System.Drawing.Size(38, 13);
            this.PhoneI.TabIndex = 36;
            this.PhoneI.Text = "Invalid";
            this.PhoneI.Visible = false;
            this.PhoneI.Click += new System.EventHandler(this.PhoneI_Click);
            // 
            // emailI
            // 
            this.emailI.AutoSize = true;
            this.emailI.ForeColor = System.Drawing.Color.Red;
            this.emailI.Location = new System.Drawing.Point(585, 526);
            this.emailI.Name = "emailI";
            this.emailI.Size = new System.Drawing.Size(38, 13);
            this.emailI.TabIndex = 37;
            this.emailI.Text = "Invalid";
            this.emailI.Visible = false;
            this.emailI.Click += new System.EventHandler(this.emailI_Click);
            // 
            // AdressI
            // 
            this.AdressI.AutoSize = true;
            this.AdressI.ForeColor = System.Drawing.Color.Red;
            this.AdressI.Location = new System.Drawing.Point(585, 565);
            this.AdressI.Name = "AdressI";
            this.AdressI.Size = new System.Drawing.Size(38, 13);
            this.AdressI.TabIndex = 38;
            this.AdressI.Text = "Invalid";
            this.AdressI.Visible = false;
            this.AdressI.Click += new System.EventHandler(this.AdressI_Click);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.CheckedColor = System.Drawing.Color.Plum;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Female.ForeColor = System.Drawing.Color.Navy;
            this.Female.Location = new System.Drawing.Point(127, 608);
            this.Female.MinimumSize = new System.Drawing.Size(0, 21);
            this.Female.Name = "Female";
            this.Female.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Female.Size = new System.Drawing.Size(81, 21);
            this.Female.TabIndex = 29;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UnCheckedColor = System.Drawing.Color.Plum;
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.CheckedColor = System.Drawing.Color.Plum;
            this.Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Male.ForeColor = System.Drawing.Color.Navy;
            this.Male.Location = new System.Drawing.Point(54, 608);
            this.Male.MinimumSize = new System.Drawing.Size(0, 21);
            this.Male.Name = "Male";
            this.Male.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Male.Size = new System.Drawing.Size(65, 21);
            this.Male.TabIndex = 28;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UnCheckedColor = System.Drawing.Color.Plum;
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Adress
            // 
            this.Adress.BackColor = System.Drawing.Color.White;
            this.Adress.BorderColor = System.Drawing.Color.Silver;
            this.Adress.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Adress.BorderRadius = 0;
            this.Adress.BorderSize = 5;
            this.Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adress.ForeColor = System.Drawing.Color.DimGray;
            this.Adress.Location = new System.Drawing.Point(365, 547);
            this.Adress.Margin = new System.Windows.Forms.Padding(4);
            this.Adress.Multiline = false;
            this.Adress.Name = "Adress";
            this.Adress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Adress.PasswordChar = false;
            this.Adress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Adress.PlaceholderText = "                    Adress";
            this.Adress.Size = new System.Drawing.Size(213, 31);
            this.Adress.TabIndex = 27;
            this.Adress.Texts = "";
            this.Adress.UnderlinedStyle = true;
            this.Adress._TextChanged += new System.EventHandler(this.Adress__TextChanged);
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.White;
            this.Phone.BorderColor = System.Drawing.Color.Silver;
            this.Phone.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Phone.BorderRadius = 0;
            this.Phone.BorderSize = 5;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.DimGray;
            this.Phone.Location = new System.Drawing.Point(365, 469);
            this.Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Phone.Multiline = false;
            this.Phone.Name = "Phone";
            this.Phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Phone.PasswordChar = false;
            this.Phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Phone.PlaceholderText = "                    Phone";
            this.Phone.Size = new System.Drawing.Size(213, 31);
            this.Phone.TabIndex = 26;
            this.Phone.Texts = "";
            this.Phone.UnderlinedStyle = true;
            this.Phone._TextChanged += new System.EventHandler(this.Phone__TextChanged);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.White;
            this.Email.BorderColor = System.Drawing.Color.Silver;
            this.Email.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Email.BorderRadius = 0;
            this.Email.BorderSize = 5;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.DimGray;
            this.Email.Location = new System.Drawing.Point(365, 508);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Multiline = false;
            this.Email.Name = "Email";
            this.Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Email.PasswordChar = false;
            this.Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Email.PlaceholderText = "                    E-mail";
            this.Email.Size = new System.Drawing.Size(213, 31);
            this.Email.TabIndex = 25;
            this.Email.Texts = "";
            this.Email.UnderlinedStyle = true;
            this.Email._TextChanged += new System.EventHandler(this.Email__TextChanged);
            // 
            // Grade
            // 
            this.Grade.BackColor = System.Drawing.Color.White;
            this.Grade.BorderColor = System.Drawing.Color.Silver;
            this.Grade.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Grade.BorderRadius = 0;
            this.Grade.BorderSize = 5;
            this.Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.ForeColor = System.Drawing.Color.DimGray;
            this.Grade.Location = new System.Drawing.Point(26, 551);
            this.Grade.Margin = new System.Windows.Forms.Padding(4);
            this.Grade.Multiline = false;
            this.Grade.Name = "Grade";
            this.Grade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Grade.PasswordChar = false;
            this.Grade.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Grade.PlaceholderText = "                    Grade";
            this.Grade.Size = new System.Drawing.Size(213, 31);
            this.Grade.TabIndex = 24;
            this.Grade.Texts = "";
            this.Grade.UnderlinedStyle = true;
            this.Grade._TextChanged += new System.EventHandler(this.Grade__TextChanged);
            // 
            // Lname
            // 
            this.Lname.BackColor = System.Drawing.Color.White;
            this.Lname.BorderColor = System.Drawing.Color.Silver;
            this.Lname.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Lname.BorderRadius = 0;
            this.Lname.BorderSize = 5;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.DimGray;
            this.Lname.Location = new System.Drawing.Point(26, 512);
            this.Lname.Margin = new System.Windows.Forms.Padding(4);
            this.Lname.Multiline = false;
            this.Lname.Name = "Lname";
            this.Lname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Lname.PasswordChar = false;
            this.Lname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Lname.PlaceholderText = "                    Last name";
            this.Lname.Size = new System.Drawing.Size(213, 31);
            this.Lname.TabIndex = 23;
            this.Lname.Texts = "";
            this.Lname.UnderlinedStyle = true;
            this.Lname._TextChanged += new System.EventHandler(this.Lname__TextChanged);
            // 
            // Fname
            // 
            this.Fname.BackColor = System.Drawing.Color.White;
            this.Fname.BorderColor = System.Drawing.Color.Silver;
            this.Fname.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Fname.BorderRadius = 0;
            this.Fname.BorderSize = 5;
            this.Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.DimGray;
            this.Fname.Location = new System.Drawing.Point(26, 469);
            this.Fname.Margin = new System.Windows.Forms.Padding(4);
            this.Fname.Multiline = false;
            this.Fname.Name = "Fname";
            this.Fname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Fname.PasswordChar = false;
            this.Fname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Fname.PlaceholderText = "                   First name";
            this.Fname.Size = new System.Drawing.Size(213, 31);
            this.Fname.TabIndex = 22;
            this.Fname.Texts = "";
            this.Fname.UnderlinedStyle = true;
            this.Fname._TextChanged += new System.EventHandler(this.Fname__TextChanged);
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.Black;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(365, 599);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(213, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.Gainsboro;
            this.rjDatePicker1.TabIndex = 30;
            this.rjDatePicker1.TextColor = System.Drawing.Color.DimGray;
            this.rjDatePicker1.ValueChanged += new System.EventHandler(this.rjDatePicker1_ValueChanged);
            // 
            // RegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AdressI);
            this.Controls.Add(this.emailI);
            this.Controls.Add(this.PhoneI);
            this.Controls.Add(this.GradeI);
            this.Controls.Add(this.LnameI);
            this.Controls.Add(this.FnameI);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Submite);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.rjDatePicker1);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(620, 432);
            this.Load += new System.EventHandler(this.RegistrationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI.WinForms.GunaGradientButton Submite;
        private CustomControls.RJControls.RJRadioButton Female;
        private CustomControls.RJControls.RJRadioButton Male;
        private CustomControls.RJControls.RJTextBox Adress;
        private CustomControls.RJControls.RJTextBox Phone;
        private CustomControls.RJControls.RJTextBox Email;
        private CustomControls.RJControls.RJTextBox Grade;
        private CustomControls.RJControls.RJTextBox Lname;
        private CustomControls.RJControls.RJTextBox Fname;
        private RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label FnameI;
        private System.Windows.Forms.Label LnameI;
        private System.Windows.Forms.Label GradeI;
        private System.Windows.Forms.Label PhoneI;
        private System.Windows.Forms.Label emailI;
        private System.Windows.Forms.Label AdressI;
    }
}
