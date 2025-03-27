namespace StudentHousing
{
    partial class Admin
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
            lblAdminUsername = new Label();
            tbAdminUsername = new TextBox();
            lblAdminPassword = new Label();
            tbAdminPassword = new TextBox();
            btnAdminLogin = new Button();
            panel2 = new Panel();
            btnBack4 = new Button();
            lblAdminLoginPage = new Label();
            pbxEye = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).BeginInit();
            SuspendLayout();
            // 
            // lblAdminUsername
            // 
            lblAdminUsername.AutoSize = true;
            lblAdminUsername.BackColor = Color.Transparent;
            lblAdminUsername.Font = new Font("Times New Roman", 12F);
            lblAdminUsername.Location = new Point(200, 127);
            lblAdminUsername.Name = "lblAdminUsername";
            lblAdminUsername.Size = new Size(73, 19);
            lblAdminUsername.TabIndex = 4;
            lblAdminUsername.Text = "Username:";
            // 
            // tbAdminUsername
            // 
            tbAdminUsername.BackColor = Color.FloralWhite;
            tbAdminUsername.BorderStyle = BorderStyle.FixedSingle;
            tbAdminUsername.Font = new Font("Times New Roman", 11.25F);
            tbAdminUsername.Location = new Point(288, 126);
            tbAdminUsername.Margin = new Padding(3, 2, 3, 2);
            tbAdminUsername.Name = "tbAdminUsername";
            tbAdminUsername.Size = new Size(172, 25);
            tbAdminUsername.TabIndex = 5;
            // 
            // lblAdminPassword
            // 
            lblAdminPassword.AutoSize = true;
            lblAdminPassword.BackColor = Color.Transparent;
            lblAdminPassword.Font = new Font("Times New Roman", 12F);
            lblAdminPassword.Location = new Point(200, 176);
            lblAdminPassword.Name = "lblAdminPassword";
            lblAdminPassword.Size = new Size(72, 19);
            lblAdminPassword.TabIndex = 6;
            lblAdminPassword.Text = "Password:";
            // 
            // tbAdminPassword
            // 
            tbAdminPassword.BackColor = Color.FloralWhite;
            tbAdminPassword.BorderStyle = BorderStyle.FixedSingle;
            tbAdminPassword.Font = new Font("Times New Roman", 11.25F);
            tbAdminPassword.Location = new Point(288, 175);
            tbAdminPassword.Margin = new Padding(3, 2, 3, 2);
            tbAdminPassword.Name = "tbAdminPassword";
            tbAdminPassword.Size = new Size(172, 25);
            tbAdminPassword.TabIndex = 7;
            tbAdminPassword.UseSystemPasswordChar = true;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.MediumAquamarine;
            btnAdminLogin.Cursor = Cursors.Hand;
            btnAdminLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdminLogin.Location = new Point(257, 245);
            btnAdminLogin.Margin = new Padding(3, 2, 3, 2);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(171, 28);
            btnAdminLogin.TabIndex = 9;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Unknown;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnBack4);
            panel2.Controls.Add(lblAdminLoginPage);
            panel2.Location = new Point(-1, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 72);
            panel2.TabIndex = 15;
            // 
            // btnBack4
            // 
            btnBack4.BackColor = Color.MediumAquamarine;
            btnBack4.Cursor = Cursors.Hand;
            btnBack4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack4.Location = new Point(612, 19);
            btnBack4.Margin = new Padding(3, 2, 3, 2);
            btnBack4.Name = "btnBack4";
            btnBack4.Size = new Size(65, 32);
            btnBack4.TabIndex = 7;
            btnBack4.Text = "Back";
            btnBack4.UseVisualStyleBackColor = false;
            btnBack4.Click += btnBack4_Click;
            // 
            // lblAdminLoginPage
            // 
            lblAdminLoginPage.AutoSize = true;
            lblAdminLoginPage.BackColor = Color.Transparent;
            lblAdminLoginPage.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblAdminLoginPage.ForeColor = Color.MediumAquamarine;
            lblAdminLoginPage.Location = new Point(209, 19);
            lblAdminLoginPage.Name = "lblAdminLoginPage";
            lblAdminLoginPage.Size = new Size(281, 43);
            lblAdminLoginPage.TabIndex = 3;
            lblAdminLoginPage.Text = "Admin Login Page";
            // 
            // pbxEye
            // 
            pbxEye.BackColor = Color.Transparent;
            pbxEye.Cursor = Cursors.Hand;
            pbxEye.Image = Properties.Resources.eye;
            pbxEye.Location = new Point(466, 176);
            pbxEye.Name = "pbxEye";
            pbxEye.Size = new Size(25, 24);
            pbxEye.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEye.TabIndex = 16;
            pbxEye.TabStop = false;
            pbxEye.Click += pbxEye_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pbxEye);
            Controls.Add(panel2);
            Controls.Add(btnAdminLogin);
            Controls.Add(tbAdminPassword);
            Controls.Add(lblAdminPassword);
            Controls.Add(tbAdminUsername);
            Controls.Add(lblAdminUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdminUsername;
        private TextBox tbAdminUsername;
        private Label lblAdminPassword;
        private TextBox tbAdminPassword;
        private Button btnAdminLogin;
        private Panel panel2;
        private Label lblAdminLoginPage;
        private Button btnBack4;
        private PictureBox pbxEye;
    }
}