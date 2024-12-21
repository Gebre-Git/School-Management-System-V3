namespace School
{
    partial class DeleteControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.panelOfId = new Guna.UI.WinForms.GunaShadowPanel();
            this.gradee = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.em = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.adr = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.bdt = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pho = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gen = new System.Windows.Forms.Label();
            this.Look = new Guna.UI.WinForms.GunaGradientButton();
            this.StudentId = new CustomControls.RJControls.RJTextBox();
            this.panelOfId.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(127, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.AnimationHoverSpeed = 0.07F;
            this.rjButton1.AnimationSpeed = 0.03F;
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.rjButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rjButton1.FocusedColor = System.Drawing.Color.Empty;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Image = global::School.Properties.Resources.icons8_administrator_male_24;
            this.rjButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.rjButton1.Location = new System.Drawing.Point(285, 403);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.rjButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.rjButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.rjButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.rjButton1.OnHoverImage = null;
            this.rjButton1.OnPressedColor = System.Drawing.Color.Black;
            this.rjButton1.Radius = 7;
            this.rjButton1.Size = new System.Drawing.Size(130, 39);
            this.rjButton1.TabIndex = 32;
            this.rjButton1.Text = "  Delete";
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click_1);
            // 
            // panelOfId
            // 
            this.panelOfId.BackColor = System.Drawing.Color.Transparent;
            this.panelOfId.BaseColor = System.Drawing.Color.White;
            this.panelOfId.Controls.Add(this.gradee);
            this.panelOfId.Controls.Add(this.label22);
            this.panelOfId.Controls.Add(this.label17);
            this.panelOfId.Controls.Add(this.label21);
            this.panelOfId.Controls.Add(this.em);
            this.panelOfId.Controls.Add(this.label20);
            this.panelOfId.Controls.Add(this.adr);
            this.panelOfId.Controls.Add(this.label19);
            this.panelOfId.Controls.Add(this.bdt);
            this.panelOfId.Controls.Add(this.label18);
            this.panelOfId.Controls.Add(this.pho);
            this.panelOfId.Controls.Add(this.label5);
            this.panelOfId.Controls.Add(this.gen);
            this.panelOfId.Location = new System.Drawing.Point(192, 117);
            this.panelOfId.Name = "panelOfId";
            this.panelOfId.Radius = 5;
            this.panelOfId.ShadowColor = System.Drawing.Color.Black;
            this.panelOfId.ShadowDepth = 30;
            this.panelOfId.Size = new System.Drawing.Size(312, 270);
            this.panelOfId.TabIndex = 33;
            this.panelOfId.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOfId_Paint);
            // 
            // gradee
            // 
            this.gradee.AutoSize = true;
            this.gradee.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.gradee.Location = new System.Drawing.Point(141, 78);
            this.gradee.Name = "gradee";
            this.gradee.Size = new System.Drawing.Size(38, 17);
            this.gradee.TabIndex = 14;
            this.gradee.Text = "lable";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label22.Location = new System.Drawing.Point(67, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 18);
            this.label22.TabIndex = 0;
            this.label22.Text = "Student Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label17.Location = new System.Drawing.Point(43, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Grade";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label21.Location = new System.Drawing.Point(43, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Gender";
            // 
            // em
            // 
            this.em.AutoSize = true;
            this.em.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.em.Location = new System.Drawing.Point(141, 235);
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(52, 17);
            this.em.TabIndex = 12;
            this.em.Text = "label21";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label20.Location = new System.Drawing.Point(43, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Phone";
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.adr.Location = new System.Drawing.Point(141, 196);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(52, 17);
            this.adr.TabIndex = 10;
            this.adr.Text = "label19";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label19.Location = new System.Drawing.Point(41, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "BirthDate";
            // 
            // bdt
            // 
            this.bdt.AutoSize = true;
            this.bdt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.bdt.Location = new System.Drawing.Point(141, 167);
            this.bdt.Name = "bdt";
            this.bdt.Size = new System.Drawing.Size(52, 17);
            this.bdt.TabIndex = 9;
            this.bdt.Text = "label18";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label18.Location = new System.Drawing.Point(43, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Adress";
            // 
            // pho
            // 
            this.pho.AutoSize = true;
            this.pho.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.pho.Location = new System.Drawing.Point(141, 137);
            this.pho.Name = "pho";
            this.pho.Size = new System.Drawing.Size(52, 17);
            this.pho.TabIndex = 8;
            this.pho.Text = "label17";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(43, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // gen
            // 
            this.gen.AutoSize = true;
            this.gen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(10)))), ((int)(((byte)(109)))));
            this.gen.Location = new System.Drawing.Point(141, 108);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(52, 17);
            this.gen.TabIndex = 7;
            this.gen.Text = "label16";
            // 
            // Look
            // 
            this.Look.AnimationHoverSpeed = 0.07F;
            this.Look.AnimationSpeed = 0.03F;
            this.Look.BackColor = System.Drawing.Color.Transparent;
            this.Look.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.Look.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.Look.BorderColor = System.Drawing.Color.Black;
            this.Look.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Look.FocusedColor = System.Drawing.Color.Empty;
            this.Look.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Look.ForeColor = System.Drawing.Color.White;
            this.Look.Image = null;
            this.Look.ImageSize = new System.Drawing.Size(20, 20);
            this.Look.Location = new System.Drawing.Point(487, 68);
            this.Look.Name = "Look";
            this.Look.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Look.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Look.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Look.OnHoverForeColor = System.Drawing.Color.White;
            this.Look.OnHoverImage = null;
            this.Look.OnPressedColor = System.Drawing.Color.Black;
            this.Look.Radius = 4;
            this.Look.Size = new System.Drawing.Size(63, 31);
            this.Look.TabIndex = 34;
            this.Look.Text = " Look";
            this.Look.Click += new System.EventHandler(this.Look_Click);
            // 
            // StudentId
            // 
            this.StudentId.BackColor = System.Drawing.SystemColors.Window;
            this.StudentId.BorderColor = System.Drawing.Color.DarkOrchid;
            this.StudentId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.StudentId.BorderRadius = 0;
            this.StudentId.BorderSize = 2;
            this.StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudentId.Location = new System.Drawing.Point(230, 68);
            this.StudentId.Margin = new System.Windows.Forms.Padding(4);
            this.StudentId.Multiline = false;
            this.StudentId.Name = "StudentId";
            this.StudentId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.StudentId.PasswordChar = false;
            this.StudentId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.StudentId.PlaceholderText = "";
            this.StudentId.Size = new System.Drawing.Size(250, 31);
            this.StudentId.TabIndex = 0;
            this.StudentId.Texts = "";
            this.StudentId.UnderlinedStyle = false;
            this.StudentId._TextChanged += new System.EventHandler(this.StudentId__TextChanged);
            // 
            // DeleteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Look);
            this.Controls.Add(this.panelOfId);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentId);
            this.Name = "DeleteControl";
            this.Size = new System.Drawing.Size(671, 449);
            this.Load += new System.EventHandler(this.DeleteControl_Load);
            this.panelOfId.ResumeLayout(false);
            this.panelOfId.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox StudentId;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton rjButton1;
        private Guna.UI.WinForms.GunaShadowPanel panelOfId;
        private System.Windows.Forms.Label gradee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label em;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label bdt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label pho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gen;
        private Guna.UI.WinForms.GunaGradientButton Look;
    }
}
