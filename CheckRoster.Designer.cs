namespace School
{
    partial class CheckRoster
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
            this.Hide = new CustomControls.RJControls.RJRadioButton();
            this.Alphabet = new CustomControls.RJControls.RJRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.Rank = new CustomControls.RJControls.RJRadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Hide
            // 
            this.Hide.AutoSize = true;
            this.Hide.CheckedColor = System.Drawing.Color.Orchid;
            this.Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Hide.ForeColor = System.Drawing.Color.Indigo;
            this.Hide.Location = new System.Drawing.Point(484, 317);
            this.Hide.MinimumSize = new System.Drawing.Size(0, 21);
            this.Hide.Name = "Hide";
            this.Hide.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Hide.Size = new System.Drawing.Size(99, 21);
            this.Hide.TabIndex = 19;
            this.Hide.TabStop = true;
            this.Hide.Text = "Hide Rank";
            this.Hide.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Hide.UseVisualStyleBackColor = true;
            // 
            // Alphabet
            // 
            this.Alphabet.AutoSize = true;
            this.Alphabet.CheckedColor = System.Drawing.Color.Orchid;
            this.Alphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Alphabet.ForeColor = System.Drawing.Color.Indigo;
            this.Alphabet.Location = new System.Drawing.Point(484, 265);
            this.Alphabet.MinimumSize = new System.Drawing.Size(0, 21);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Alphabet.Size = new System.Drawing.Size(89, 21);
            this.Alphabet.TabIndex = 18;
            this.Alphabet.TabStop = true;
            this.Alphabet.Text = "Alphabet";
            this.Alphabet.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Alphabet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(531, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources.pic_7_Search;
            this.pictureBox1.Location = new System.Drawing.Point(327, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumOrchid;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 4;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(385, 58);
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
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.CheckedColor = System.Drawing.Color.Orchid;
            this.Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Rank.ForeColor = System.Drawing.Color.Indigo;
            this.Rank.Location = new System.Drawing.Point(484, 211);
            this.Rank.MinimumSize = new System.Drawing.Size(0, 21);
            this.Rank.Name = "Rank";
            this.Rank.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Rank.Size = new System.Drawing.Size(67, 21);
            this.Rank.TabIndex = 14;
            this.Rank.TabStop = true;
            this.Rank.Text = "Rank";
            this.Rank.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Rank.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School.Properties.Resources.pic_7_Search;
            this.pictureBox2.Location = new System.Drawing.Point(59, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumOrchid;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 0;
            this.rjTextBox2.BorderSize = 4;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox2.Location = new System.Drawing.Point(109, 58);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "              Student Grade";
            this.rjTextBox2.Size = new System.Drawing.Size(195, 31);
            this.rjTextBox2.TabIndex = 21;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = true;
            // 
            // CheckRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 402);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Alphabet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.Rank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckRoster";
            this.Text = "CheckRoster";
            this.Load += new System.EventHandler(this.CheckRoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJRadioButton Hide;
        private CustomControls.RJControls.RJRadioButton Alphabet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJRadioButton Rank;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
    }
}