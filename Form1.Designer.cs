namespace School
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AboutFocus = new System.Windows.Forms.PictureBox();
            this.HelpFocus = new System.Windows.Forms.PictureBox();
            this.HomeFocus = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.PanelHelp = new System.Windows.Forms.Panel();
            this.PanelHome = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Student = new CustomControls.RJControls.RJButton();
            this.Teachers = new CustomControls.RJControls.RJButton();
            this.Admin = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Kebele = new CustomControls.RJControls.RJRadioButton();
            this.ID = new CustomControls.RJControls.RJRadioButton();
            this.Name = new CustomControls.RJControls.RJRadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new SMS.RJControls.RJCircularPictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.panelstudpro = new Guna.UI.WinForms.GunaShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Submite = new Guna.UI.WinForms.GunaGradientButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeButton = new Guna.UI.WinForms.GunaGradientButton();
            this.AboutButton = new Guna.UI.WinForms.GunaGradientButton();
            this.HelpButton = new Guna.UI.WinForms.GunaGradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AboutFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeFocus)).BeginInit();
            this.AboutPanel.SuspendLayout();
            this.PanelHelp.SuspendLayout();
            this.PanelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panelstudpro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.Color.MediumOrchid;
            this.ExitLabel.Location = new System.Drawing.Point(891, 8);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(19, 22);
            this.ExitLabel.TabIndex = 28;
            this.ExitLabel.Text = "X";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            this.ExitLabel.MouseHover += new System.EventHandler(this.ExitLabel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 30;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 20;
            this.gunaElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AboutFocus
            // 
            this.AboutFocus.Image = global::School.Properties.Resources.horizontlFocus;
            this.AboutFocus.Location = new System.Drawing.Point(706, 32);
            this.AboutFocus.Name = "AboutFocus";
            this.AboutFocus.Size = new System.Drawing.Size(36, 16);
            this.AboutFocus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutFocus.TabIndex = 36;
            this.AboutFocus.TabStop = false;
            // 
            // HelpFocus
            // 
            this.HelpFocus.Image = global::School.Properties.Resources.horizontlFocus;
            this.HelpFocus.Location = new System.Drawing.Point(773, 32);
            this.HelpFocus.Name = "HelpFocus";
            this.HelpFocus.Size = new System.Drawing.Size(47, 16);
            this.HelpFocus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpFocus.TabIndex = 35;
            this.HelpFocus.TabStop = false;
            this.HelpFocus.Click += new System.EventHandler(this.HelpFocus_Click);
            // 
            // HomeFocus
            // 
            this.HomeFocus.Image = global::School.Properties.Resources.horizontlFocus;
            this.HomeFocus.Location = new System.Drawing.Point(638, 32);
            this.HomeFocus.Name = "HomeFocus";
            this.HomeFocus.Size = new System.Drawing.Size(36, 16);
            this.HomeFocus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeFocus.TabIndex = 34;
            this.HomeFocus.TabStop = false;
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(841, 10);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = global::School.Properties.Resources.icons8_minimize_30__2_;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(36, 17);
            this.gunaAdvenceButton3.TabIndex = 59;
            this.gunaAdvenceButton3.Click += new System.EventHandler(this.gunaAdvenceButton3_Click);
            // 
            // AboutPanel
            // 
            this.AboutPanel.Controls.Add(this.lblText);
            this.AboutPanel.Controls.Add(this.panelstudpro);
            this.AboutPanel.Controls.Add(this.Submite);
            this.AboutPanel.Controls.Add(this.label16);
            this.AboutPanel.Controls.Add(this.label17);
            this.AboutPanel.Controls.Add(this.label2);
            this.AboutPanel.Controls.Add(this.label3);
            this.AboutPanel.Location = new System.Drawing.Point(502, 54);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(416, 490);
            this.AboutPanel.TabIndex = 60;
            // 
            // PanelHelp
            // 
            this.PanelHelp.Controls.Add(this.Kebele);
            this.PanelHelp.Controls.Add(this.ID);
            this.PanelHelp.Controls.Add(this.Name);
            this.PanelHelp.Controls.Add(this.label18);
            this.PanelHelp.Controls.Add(this.label20);
            this.PanelHelp.Controls.Add(this.label21);
            this.PanelHelp.Controls.Add(this.label22);
            this.PanelHelp.Controls.Add(this.label23);
            this.PanelHelp.Controls.Add(this.rjCircularPictureBox1);
            this.PanelHelp.Location = new System.Drawing.Point(502, 54);
            this.PanelHelp.Name = "PanelHelp";
            this.PanelHelp.Size = new System.Drawing.Size(410, 484);
            this.PanelHelp.TabIndex = 52;
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.pictureBox3);
            this.PanelHome.Controls.Add(this.Student);
            this.PanelHome.Controls.Add(this.Teachers);
            this.PanelHome.Controls.Add(this.Admin);
            this.PanelHome.Controls.Add(this.label4);
            this.PanelHome.Controls.Add(this.label5);
            this.PanelHome.Controls.Add(this.label6);
            this.PanelHome.Controls.Add(this.label10);
            this.PanelHome.Controls.Add(this.label12);
            this.PanelHome.Controls.Add(this.label13);
            this.PanelHome.Location = new System.Drawing.Point(502, 54);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(407, 478);
            this.PanelHome.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::School.Properties.Resources.download;
            this.pictureBox3.Location = new System.Drawing.Point(93, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(219, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 57;
            this.pictureBox3.TabStop = false;
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.White;
            this.Student.BackgroundColor = System.Drawing.Color.White;
            this.Student.BackgroundImage = global::School.Properties.Resources.pic_4;
            this.Student.BorderColor = System.Drawing.Color.White;
            this.Student.BorderRadius = 20;
            this.Student.BorderSize = 2;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.FlatAppearance.BorderSize = 0;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.Color.White;
            this.Student.Location = new System.Drawing.Point(119, 270);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(165, 72);
            this.Student.TabIndex = 56;
            this.Student.Text = "Student";
            this.Student.TextColor = System.Drawing.Color.White;
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click_1);
            // 
            // Teachers
            // 
            this.Teachers.BackColor = System.Drawing.Color.White;
            this.Teachers.BackgroundColor = System.Drawing.Color.White;
            this.Teachers.BackgroundImage = global::School.Properties.Resources.pic_4;
            this.Teachers.BorderColor = System.Drawing.Color.White;
            this.Teachers.BorderRadius = 20;
            this.Teachers.BorderSize = 2;
            this.Teachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Teachers.FlatAppearance.BorderSize = 0;
            this.Teachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teachers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teachers.ForeColor = System.Drawing.Color.White;
            this.Teachers.Location = new System.Drawing.Point(119, 334);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(165, 74);
            this.Teachers.TabIndex = 55;
            this.Teachers.Text = "Teachers";
            this.Teachers.TextColor = System.Drawing.Color.White;
            this.Teachers.UseVisualStyleBackColor = false;
            this.Teachers.Click += new System.EventHandler(this.Teachers_Click_1);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.White;
            this.Admin.BackgroundColor = System.Drawing.Color.White;
            this.Admin.BackgroundImage = global::School.Properties.Resources.pic_4;
            this.Admin.BorderColor = System.Drawing.Color.White;
            this.Admin.BorderRadius = 20;
            this.Admin.BorderSize = 2;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(119, 204);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(165, 74);
            this.Admin.TabIndex = 54;
            this.Admin.Text = "Admin";
            this.Admin.TextColor = System.Drawing.Color.White;
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(296, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = " copy right ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(282, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "©";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(26, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Don\'t try to use  it with out permition, it has ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(22, 419);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "This Desktop application is made for STEM incubation center";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(72, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "use to change the world\"— Nelson Mandela";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(39, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(336, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "\"Education is the most powerful weapon which you can ";
            // 
            // Kebele
            // 
            this.Kebele.AutoSize = true;
            this.Kebele.CheckedColor = System.Drawing.Color.Orchid;
            this.Kebele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Kebele.ForeColor = System.Drawing.Color.Indigo;
            this.Kebele.Location = new System.Drawing.Point(139, 365);
            this.Kebele.MinimumSize = new System.Drawing.Size(0, 21);
            this.Kebele.Name = "Kebele";
            this.Kebele.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Kebele.Size = new System.Drawing.Size(81, 21);
            this.Kebele.TabIndex = 61;
            this.Kebele.TabStop = true;
            this.Kebele.Text = "Newbie";
            this.Kebele.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Kebele.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.CheckedColor = System.Drawing.Color.Orchid;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ID.ForeColor = System.Drawing.Color.Indigo;
            this.ID.Location = new System.Drawing.Point(139, 325);
            this.ID.MinimumSize = new System.Drawing.Size(0, 21);
            this.ID.Name = "ID";
            this.ID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ID.Size = new System.Drawing.Size(79, 21);
            this.ID.TabIndex = 60;
            this.ID.TabStop = true;
            this.ID.Text = "Normal";
            this.ID.UnCheckedColor = System.Drawing.Color.Orchid;
            this.ID.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.CheckedColor = System.Drawing.Color.Orchid;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Name.ForeColor = System.Drawing.Color.Indigo;
            this.Name.Location = new System.Drawing.Point(139, 285);
            this.Name.MinimumSize = new System.Drawing.Size(0, 21);
            this.Name.Name = "Name";
            this.Name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Name.Size = new System.Drawing.Size(73, 21);
            this.Name.TabIndex = 59;
            this.Name.TabStop = true;
            this.Name.Text = "Expert";
            this.Name.UnCheckedColor = System.Drawing.Color.Orchid;
            this.Name.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.BlueViolet;
            this.label18.Location = new System.Drawing.Point(295, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 58;
            this.label18.Text = " copy right ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.BlueViolet;
            this.label20.Location = new System.Drawing.Point(281, 443);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 18);
            this.label20.TabIndex = 57;
            this.label20.Text = "©";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(25, 441);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(261, 17);
            this.label21.TabIndex = 56;
            this.label21.Text = "Don\'t try to use  it with out permition, it has ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(21, 424);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(362, 17);
            this.label22.TabIndex = 55;
            this.label22.Text = "This Desktop application is made for STEM incubation center";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(25, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(365, 102);
            this.label23.TabIndex = 54;
            this.label23.Text = resources.GetString("label23.Text");
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::School.Properties.Resources.a_student;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(127, 154);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 62;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblText.Location = new System.Drawing.Point(23, 3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(371, 85);
            this.lblText.TabIndex = 47;
            this.lblText.Text = resources.GetString("lblText.Text");
            // 
            // panelstudpro
            // 
            this.panelstudpro.BackColor = System.Drawing.Color.Transparent;
            this.panelstudpro.BaseColor = System.Drawing.Color.White;
            this.panelstudpro.Controls.Add(this.pictureBox2);
            this.panelstudpro.Location = new System.Drawing.Point(14, 91);
            this.panelstudpro.Name = "panelstudpro";
            this.panelstudpro.Radius = 5;
            this.panelstudpro.ShadowColor = System.Drawing.Color.Black;
            this.panelstudpro.ShadowDepth = 30;
            this.panelstudpro.ShadowShift = 7;
            this.panelstudpro.Size = new System.Drawing.Size(393, 230);
            this.panelstudpro.TabIndex = 51;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::School.Properties.Resources.annie_spratt_QckxruozjRg_unsplash__2_;
            this.pictureBox2.Location = new System.Drawing.Point(27, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Submite
            // 
            this.Submite.AnimationHoverSpeed = 0.07F;
            this.Submite.AnimationSpeed = 0.03F;
            this.Submite.BackColor = System.Drawing.Color.Transparent;
            this.Submite.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(10)))));
            this.Submite.BaseColor2 = System.Drawing.Color.Silver;
            this.Submite.BorderColor = System.Drawing.Color.Black;
            this.Submite.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Submite.FocusedColor = System.Drawing.Color.Empty;
            this.Submite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submite.ForeColor = System.Drawing.Color.White;
            this.Submite.Image = null;
            this.Submite.ImageSize = new System.Drawing.Size(20, 20);
            this.Submite.Location = new System.Drawing.Point(26, 347);
            this.Submite.Name = "Submite";
            this.Submite.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.Submite.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.Submite.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Submite.OnHoverForeColor = System.Drawing.Color.White;
            this.Submite.OnHoverImage = null;
            this.Submite.OnPressedColor = System.Drawing.Color.Black;
            this.Submite.Radius = 7;
            this.Submite.Size = new System.Drawing.Size(368, 34);
            this.Submite.TabIndex = 50;
            this.Submite.Text = "                         Vsite Our WebSite";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(42, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(261, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Don\'t try to use  it with out permition, it has ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(38, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(362, 17);
            this.label17.TabIndex = 48;
            this.label17.Text = "This Desktop application is made for STEM incubation center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(309, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = " copy right ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(295, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "©";
            // 
            // HomeButton
            // 
            this.HomeButton.AnimationHoverSpeed = 0.07F;
            this.HomeButton.AnimationSpeed = 0.03F;
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BaseColor1 = System.Drawing.Color.Transparent;
            this.HomeButton.BaseColor2 = System.Drawing.Color.Transparent;
            this.HomeButton.BorderColor = System.Drawing.Color.Transparent;
            this.HomeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HomeButton.FocusedColor = System.Drawing.Color.Empty;
            this.HomeButton.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HomeButton.ForeColor = System.Drawing.Color.DarkViolet;
            this.HomeButton.Image = null;
            this.HomeButton.ImageSize = new System.Drawing.Size(20, 20);
            this.HomeButton.Location = new System.Drawing.Point(626, 9);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.HomeButton.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.HomeButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.HomeButton.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.HomeButton.OnHoverImage = null;
            this.HomeButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.HomeButton.OnPressedDepth = 0;
            this.HomeButton.Size = new System.Drawing.Size(60, 21);
            this.HomeButton.TabIndex = 58;
            this.HomeButton.Text = "Home";
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // AboutButton
            // 
            this.AboutButton.AnimationHoverSpeed = 0.07F;
            this.AboutButton.AnimationSpeed = 0.03F;
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.BaseColor1 = System.Drawing.Color.Transparent;
            this.AboutButton.BaseColor2 = System.Drawing.Color.Transparent;
            this.AboutButton.BorderColor = System.Drawing.Color.Black;
            this.AboutButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AboutButton.FocusedColor = System.Drawing.Color.Empty;
            this.AboutButton.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.AboutButton.ForeColor = System.Drawing.Color.DarkViolet;
            this.AboutButton.Image = null;
            this.AboutButton.ImageSize = new System.Drawing.Size(20, 20);
            this.AboutButton.Location = new System.Drawing.Point(692, 11);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.AboutButton.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.AboutButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.AboutButton.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.AboutButton.OnHoverImage = null;
            this.AboutButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.AboutButton.OnPressedDepth = 0;
            this.AboutButton.Size = new System.Drawing.Size(60, 21);
            this.AboutButton.TabIndex = 61;
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click_1);
            // 
            // HelpButton
            // 
            this.HelpButton.AnimationHoverSpeed = 0.07F;
            this.HelpButton.AnimationSpeed = 0.03F;
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.BaseColor1 = System.Drawing.Color.Transparent;
            this.HelpButton.BaseColor2 = System.Drawing.Color.Transparent;
            this.HelpButton.BorderColor = System.Drawing.Color.Transparent;
            this.HelpButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.HelpButton.FocusedColor = System.Drawing.Color.Empty;
            this.HelpButton.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.HelpButton.ForeColor = System.Drawing.Color.DarkViolet;
            this.HelpButton.Image = null;
            this.HelpButton.ImageSize = new System.Drawing.Size(20, 20);
            this.HelpButton.Location = new System.Drawing.Point(767, 12);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.HelpButton.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.HelpButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.HelpButton.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.HelpButton.OnHoverImage = null;
            this.HelpButton.OnPressedColor = System.Drawing.Color.Transparent;
            this.HelpButton.Size = new System.Drawing.Size(60, 21);
            this.HelpButton.TabIndex = 62;
            this.HelpButton.Text = "Help";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School.Properties.Resources.pic_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 556);
            this.Controls.Add(this.PanelHome);
            this.Controls.Add(this.PanelHelp);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.gunaAdvenceButton3);
            this.Controls.Add(this.AboutFocus);
            this.Controls.Add(this.HelpFocus);
            this.Controls.Add(this.HomeFocus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AboutFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeFocus)).EndInit();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.PanelHelp.ResumeLayout(false);
            this.PanelHelp.PerformLayout();
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panelstudpro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox HomeFocus;
        private System.Windows.Forms.PictureBox HelpFocus;
        private System.Windows.Forms.PictureBox AboutFocus;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel AboutPanel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private System.Windows.Forms.Label lblText;
        private Guna.UI.WinForms.GunaShadowPanel panelstudpro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGradientButton Submite;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel PanelHelp;
        private CustomControls.RJControls.RJRadioButton Kebele;
        private CustomControls.RJControls.RJRadioButton ID;
        private CustomControls.RJControls.RJRadioButton Name;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private SMS.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelHome;
        private CustomControls.RJControls.RJButton Student;
        private CustomControls.RJControls.RJButton Teachers;
        private CustomControls.RJControls.RJButton Admin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaGradientButton HomeButton;
        private Guna.UI.WinForms.GunaGradientButton AboutButton;
        private Guna.UI.WinForms.GunaGradientButton HelpButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
    }
}

