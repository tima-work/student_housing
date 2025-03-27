namespace StudentHousing
{
    partial class Login
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
            tbLoginEmail = new TextBox();
            tbLoginPassword = new TextBox();
            lblLoginPage = new Label();
            lblLoginEmail = new Label();
            lblLoginPassword = new Label();
            btnLogin = new Button();
            btnBack1 = new Button();
            panel1 = new Panel();
            pbxEye = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).BeginInit();
            SuspendLayout();
            // 
            // tbLoginEmail
            // 
            tbLoginEmail.BackColor = Color.FloralWhite;
            tbLoginEmail.BorderStyle = BorderStyle.FixedSingle;
            tbLoginEmail.Font = new Font("Times New Roman", 11.25F);
            tbLoginEmail.Location = new Point(293, 128);
            tbLoginEmail.Margin = new Padding(3, 2, 3, 2);
            tbLoginEmail.Name = "tbLoginEmail";
            tbLoginEmail.Size = new Size(172, 25);
            tbLoginEmail.TabIndex = 0;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.BackColor = Color.FloralWhite;
            tbLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            tbLoginPassword.Font = new Font("Times New Roman", 11.25F);
            tbLoginPassword.Location = new Point(293, 180);
            tbLoginPassword.Margin = new Padding(3, 2, 3, 2);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(172, 25);
            tbLoginPassword.TabIndex = 1;
            tbLoginPassword.UseSystemPasswordChar = true;
            // 
            // lblLoginPage
            // 
            lblLoginPage.AutoSize = true;
            lblLoginPage.BackColor = Color.Transparent;
            lblLoginPage.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblLoginPage.ForeColor = Color.MediumAquamarine;
            lblLoginPage.Location = new Point(260, 9);
            lblLoginPage.Name = "lblLoginPage";
            lblLoginPage.Size = new Size(177, 43);
            lblLoginPage.TabIndex = 2;
            lblLoginPage.Text = "Login Page";
            // 
            // lblLoginEmail
            // 
            lblLoginEmail.AutoSize = true;
            lblLoginEmail.BackColor = Color.Transparent;
            lblLoginEmail.Font = new Font("Times New Roman", 12F);
            lblLoginEmail.Location = new Point(236, 128);
            lblLoginEmail.Name = "lblLoginEmail";
            lblLoginEmail.Size = new Size(51, 19);
            lblLoginEmail.TabIndex = 3;
            lblLoginEmail.Text = "E-mail:";
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.BackColor = Color.Transparent;
            lblLoginPassword.Font = new Font("Times New Roman", 12F);
            lblLoginPassword.Location = new Point(215, 180);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(72, 19);
            lblLoginPassword.TabIndex = 4;
            lblLoginPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(259, 243);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnBack1
            // 
            btnBack1.BackColor = Color.MediumAquamarine;
            btnBack1.Cursor = Cursors.Hand;
            btnBack1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack1.Location = new Point(623, 11);
            btnBack1.Margin = new Padding(3, 2, 3, 2);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(65, 32);
            btnBack1.TabIndex = 6;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = false;
            btnBack1.Click += btnBack1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblLoginPage);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 68);
            panel1.TabIndex = 13;
            // 
            // pbxEye
            // 
            pbxEye.BackColor = Color.Transparent;
            pbxEye.Cursor = Cursors.Hand;
            pbxEye.Image = Properties.Resources.eye;
            pbxEye.Location = new Point(471, 180);
            pbxEye.Name = "pbxEye";
            pbxEye.Size = new Size(27, 25);
            pbxEye.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEye.TabIndex = 14;
            pbxEye.TabStop = false;
            pbxEye.Click += pbxEye_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pbxEye);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(lblLoginPassword);
            Controls.Add(lblLoginEmail);
            Controls.Add(tbLoginPassword);
            Controls.Add(tbLoginEmail);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLoginEmail;
        private TextBox tbLoginPassword;
        private Label lblLoginPage;
        private Label lblLoginEmail;
        private Label lblLoginPassword;
        private Button btnLogin;
        private Button btnBack1;
        private Panel panel1;
        private PictureBox pbxEye;
    }
}