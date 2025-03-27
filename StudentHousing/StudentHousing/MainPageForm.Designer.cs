namespace StudentHousing
{
    partial class MainPageForm
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
            gbSideNav = new GroupBox();
            lblMainRules = new Label();
            picBoxRules = new PictureBox();
            lblMainComplaints = new Label();
            picBoxComplaints = new PictureBox();
            lblMainSearch = new Label();
            picBoxSearch = new PictureBox();
            lblMainProfile = new Label();
            picBoxProfile = new PictureBox();
            lblMainMenu = new Label();
            lbAnnouncementsBox = new ListBox();
            lblMainAnnouncements = new Label();
            lblMainTasks = new Label();
            lbTasksBox = new ListBox();
            btnAddTask = new Button();
            btnMainSignOut = new Button();
            btnAddAnnouncement = new Button();
            btnViewComplaints = new Button();
            gbSideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRules).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxComplaints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // gbSideNav
            // 
            gbSideNav.BackgroundImage = Properties.Resources.Unknown;
            gbSideNav.BackgroundImageLayout = ImageLayout.Stretch;
            gbSideNav.Controls.Add(lblMainRules);
            gbSideNav.Controls.Add(picBoxRules);
            gbSideNav.Controls.Add(lblMainComplaints);
            gbSideNav.Controls.Add(picBoxComplaints);
            gbSideNav.Controls.Add(lblMainSearch);
            gbSideNav.Controls.Add(picBoxSearch);
            gbSideNav.Controls.Add(lblMainProfile);
            gbSideNav.Controls.Add(picBoxProfile);
            gbSideNav.Controls.Add(lblMainMenu);
            gbSideNav.Location = new Point(-4, -14);
            gbSideNav.Name = "gbSideNav";
            gbSideNav.Size = new Size(129, 468);
            gbSideNav.TabIndex = 0;
            gbSideNav.TabStop = false;
            // 
            // lblMainRules
            // 
            lblMainRules.AutoSize = true;
            lblMainRules.BackColor = Color.Transparent;
            lblMainRules.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainRules.ForeColor = Color.MediumAquamarine;
            lblMainRules.Location = new Point(31, 427);
            lblMainRules.Name = "lblMainRules";
            lblMainRules.Size = new Size(58, 23);
            lblMainRules.TabIndex = 6;
            lblMainRules.Text = "Rules";
            // 
            // picBoxRules
            // 
            picBoxRules.BackColor = Color.Transparent;
            picBoxRules.Cursor = Cursors.Hand;
            picBoxRules.Image = Properties.Resources.rules;
            picBoxRules.Location = new Point(24, 374);
            picBoxRules.Name = "picBoxRules";
            picBoxRules.Size = new Size(67, 50);
            picBoxRules.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxRules.TabIndex = 7;
            picBoxRules.TabStop = false;
            picBoxRules.Click += picBoxRules_Click;
            // 
            // lblMainComplaints
            // 
            lblMainComplaints.AutoSize = true;
            lblMainComplaints.BackColor = Color.Transparent;
            lblMainComplaints.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainComplaints.ForeColor = Color.MediumAquamarine;
            lblMainComplaints.Location = new Point(16, 324);
            lblMainComplaints.Name = "lblMainComplaints";
            lblMainComplaints.Size = new Size(106, 23);
            lblMainComplaints.TabIndex = 4;
            lblMainComplaints.Text = "Complaints";
            // 
            // picBoxComplaints
            // 
            picBoxComplaints.BackColor = Color.Transparent;
            picBoxComplaints.Cursor = Cursors.Hand;
            picBoxComplaints.Image = Properties.Resources.complaints;
            picBoxComplaints.Location = new Point(24, 271);
            picBoxComplaints.Name = "picBoxComplaints";
            picBoxComplaints.Size = new Size(67, 50);
            picBoxComplaints.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxComplaints.TabIndex = 5;
            picBoxComplaints.TabStop = false;
            picBoxComplaints.Click += picBoxComplaints_Click;
            // 
            // lblMainSearch
            // 
            lblMainSearch.AutoSize = true;
            lblMainSearch.BackColor = Color.Transparent;
            lblMainSearch.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainSearch.ForeColor = Color.MediumAquamarine;
            lblMainSearch.Location = new Point(28, 221);
            lblMainSearch.Name = "lblMainSearch";
            lblMainSearch.Size = new Size(65, 23);
            lblMainSearch.TabIndex = 2;
            lblMainSearch.Text = "Search";
            // 
            // picBoxSearch
            // 
            picBoxSearch.BackColor = Color.Transparent;
            picBoxSearch.Cursor = Cursors.Hand;
            picBoxSearch.Image = Properties.Resources.search;
            picBoxSearch.Location = new Point(22, 168);
            picBoxSearch.Name = "picBoxSearch";
            picBoxSearch.Size = new Size(67, 50);
            picBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxSearch.TabIndex = 3;
            picBoxSearch.TabStop = false;
            picBoxSearch.Click += picBoxSearch_Click;
            // 
            // lblMainProfile
            // 
            lblMainProfile.AutoSize = true;
            lblMainProfile.BackColor = Color.Transparent;
            lblMainProfile.Font = new Font("Times New Roman", 16F);
            lblMainProfile.ForeColor = Color.MediumAquamarine;
            lblMainProfile.Location = new Point(24, 130);
            lblMainProfile.Name = "lblMainProfile";
            lblMainProfile.Size = new Size(71, 25);
            lblMainProfile.TabIndex = 1;
            lblMainProfile.Text = "Profile";
            // 
            // picBoxProfile
            // 
            picBoxProfile.BackColor = Color.Transparent;
            picBoxProfile.Cursor = Cursors.Hand;
            picBoxProfile.Image = Properties.Resources.profile;
            picBoxProfile.Location = new Point(22, 77);
            picBoxProfile.Name = "picBoxProfile";
            picBoxProfile.Size = new Size(67, 50);
            picBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxProfile.TabIndex = 1;
            picBoxProfile.TabStop = false;
            picBoxProfile.Click += picBoxProfile_Click;
            // 
            // lblMainMenu
            // 
            lblMainMenu.AutoSize = true;
            lblMainMenu.BackColor = Color.Transparent;
            lblMainMenu.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblMainMenu.ForeColor = Color.MediumAquamarine;
            lblMainMenu.Location = new Point(16, 23);
            lblMainMenu.Name = "lblMainMenu";
            lblMainMenu.Size = new Size(87, 32);
            lblMainMenu.TabIndex = 1;
            lblMainMenu.Text = "Menu";
            // 
            // lbAnnouncementsBox
            // 
            lbAnnouncementsBox.BackColor = Color.FloralWhite;
            lbAnnouncementsBox.Font = new Font("Times New Roman", 10.25F);
            lbAnnouncementsBox.FormattingEnabled = true;
            lbAnnouncementsBox.Location = new Point(306, 84);
            lbAnnouncementsBox.Name = "lbAnnouncementsBox";
            lbAnnouncementsBox.Size = new Size(237, 132);
            lbAnnouncementsBox.TabIndex = 1;
            // 
            // lblMainAnnouncements
            // 
            lblMainAnnouncements.AutoSize = true;
            lblMainAnnouncements.BackColor = Color.Transparent;
            lblMainAnnouncements.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainAnnouncements.Location = new Point(329, 54);
            lblMainAnnouncements.Name = "lblMainAnnouncements";
            lblMainAnnouncements.Size = new Size(168, 27);
            lblMainAnnouncements.TabIndex = 8;
            lblMainAnnouncements.Text = "Announcements";
            // 
            // lblMainTasks
            // 
            lblMainTasks.AutoSize = true;
            lblMainTasks.BackColor = Color.Transparent;
            lblMainTasks.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainTasks.Location = new Point(384, 269);
            lblMainTasks.Name = "lblMainTasks";
            lblMainTasks.Size = new Size(65, 27);
            lblMainTasks.TabIndex = 10;
            lblMainTasks.Text = "Tasks";
            // 
            // lbTasksBox
            // 
            lbTasksBox.BackColor = Color.FloralWhite;
            lbTasksBox.Font = new Font("Times New Roman", 10.25F);
            lbTasksBox.FormattingEnabled = true;
            lbTasksBox.Location = new Point(306, 299);
            lbTasksBox.Name = "lbTasksBox";
            lbTasksBox.Size = new Size(237, 132);
            lbTasksBox.TabIndex = 9;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.MediumAquamarine;
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btnAddTask.Location = new Point(503, 278);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(55, 65);
            btnAddTask.TabIndex = 11;
            btnAddTask.Text = "+";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnMainSignOut
            // 
            btnMainSignOut.BackColor = Color.MediumAquamarine;
            btnMainSignOut.Cursor = Cursors.Hand;
            btnMainSignOut.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnMainSignOut.Location = new Point(680, 12);
            btnMainSignOut.Name = "btnMainSignOut";
            btnMainSignOut.Size = new Size(108, 52);
            btnMainSignOut.TabIndex = 12;
            btnMainSignOut.Text = "Sign out";
            btnMainSignOut.UseVisualStyleBackColor = false;
            btnMainSignOut.Click += btnMainSignOut_Click;
            // 
            // btnAddAnnouncement
            // 
            btnAddAnnouncement.BackColor = Color.MediumAquamarine;
            btnAddAnnouncement.Cursor = Cursors.Hand;
            btnAddAnnouncement.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btnAddAnnouncement.Location = new Point(503, 63);
            btnAddAnnouncement.Name = "btnAddAnnouncement";
            btnAddAnnouncement.Size = new Size(55, 61);
            btnAddAnnouncement.TabIndex = 13;
            btnAddAnnouncement.Text = "+";
            btnAddAnnouncement.UseVisualStyleBackColor = false;
            btnAddAnnouncement.Click += btnAddAnnouncement_Click;
            // 
            // btnViewComplaints
            // 
            btnViewComplaints.BackColor = Color.MediumAquamarine;
            btnViewComplaints.Cursor = Cursors.Hand;
            btnViewComplaints.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnViewComplaints.Location = new Point(645, 367);
            btnViewComplaints.Name = "btnViewComplaints";
            btnViewComplaints.Size = new Size(143, 64);
            btnViewComplaints.TabIndex = 14;
            btnViewComplaints.Text = "View Complaints";
            btnViewComplaints.UseVisualStyleBackColor = false;
            btnViewComplaints.Click += btnViewComplaints_Click;
            // 
            // MainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewComplaints);
            Controls.Add(btnAddAnnouncement);
            Controls.Add(btnMainSignOut);
            Controls.Add(btnAddTask);
            Controls.Add(lblMainTasks);
            Controls.Add(lbTasksBox);
            Controls.Add(lblMainAnnouncements);
            Controls.Add(lbAnnouncementsBox);
            Controls.Add(gbSideNav);
            Name = "MainPageForm";
            Text = "MainPageForm";
            gbSideNav.ResumeLayout(false);
            gbSideNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRules).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxComplaints).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSideNav;
        private Label lblMainRules;
        private PictureBox picBoxRules;
        private Label lblMainComplaints;
        private PictureBox picBoxComplaints;
        private Label lblMainSearch;
        private PictureBox picBoxSearch;
        private Label lblMainProfile;
        private PictureBox picBoxProfile;
        private Label lblMainMenu;
        private ListBox lbAnnouncementsBox;
        private Label lblMainAnnouncements;
        private Label lblMainTasks;
        private ListBox lbTasksBox;
        private Button btnAddTask;
        private Button btnMainSignOut;
        private Button btnAddAnnouncement;
        private Button btnViewComplaints;
    }
}