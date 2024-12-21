namespace School
{
    partial class CheckAttendance
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
            this.Year = new CustomControls.RJControls.RJRadioButton();
            this.Month = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.Week = new CustomControls.RJControls.RJRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjDatePicker1 = new School.RJControls.RJDatePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.CheckedColor = System.Drawing.Color.Orchid;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Year.ForeColor = System.Drawing.Color.Indigo;
            this.Year.Location = new System.Drawing.Point(84, 279);
            this.Year.MinimumSize = new System.Drawing.Size(0, 21);
            this.Year.Name = "Year";
            this.Year.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Year.Size = new System.Drawing.Size(64, 21);
            this.Year.TabIndex = 19;
            this.Year.TabStop = true;
            this.Year.Text = "Year";
            this.Year.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Year.UseVisualStyleBackColor = true;
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.CheckedColor = System.Drawing.Color.Orchid;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Month.ForeColor = System.Drawing.Color.Indigo;
            this.Month.Location = new System.Drawing.Point(84, 239);
            this.Month.MinimumSize = new System.Drawing.Size(0, 21);
            this.Month.Name = "Month";
            this.Month.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Month.Size = new System.Drawing.Size(71, 21);
            this.Month.TabIndex = 18;
            this.Month.TabStop = true;
            this.Month.Text = "Month";
            this.Month.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Month.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(131, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Time Filter";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 4;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(410, 70);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "              Student  ID";
            this.rjTextBox1.Size = new System.Drawing.Size(195, 31);
            this.rjTextBox1.TabIndex = 15;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = true;
            this.rjTextBox1._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // Week
            // 
            this.Week.AutoSize = true;
            this.Week.CheckedColor = System.Drawing.Color.Orchid;
            this.Week.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Week.ForeColor = System.Drawing.Color.Indigo;
            this.Week.Location = new System.Drawing.Point(84, 199);
            this.Week.MinimumSize = new System.Drawing.Size(0, 21);
            this.Week.Name = "Week";
            this.Week.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Week.Size = new System.Drawing.Size(71, 21);
            this.Week.TabIndex = 14;
            this.Week.TabStop = true;
            this.Week.Text = "Week";
            this.Week.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Week.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School.Properties.Resources.pic_7_Search;
            this.pictureBox2.Location = new System.Drawing.Point(71, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePicker1.BorderSize = 0;
            this.rjDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjDatePicker1.Location = new System.Drawing.Point(124, 66);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(0, 35);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(200, 35);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.MediumOrchid;
            this.rjDatePicker1.TabIndex = 23;
            this.rjDatePicker1.TextColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources.pic_7_Search;
            this.pictureBox1.Location = new System.Drawing.Point(360, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // CheckAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjDatePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.Week);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckAttendance";
            this.Text = "CheckAttendance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJRadioButton Year;
        private CustomControls.RJControls.RJRadioButton Month;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJRadioButton Week;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJControls.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}