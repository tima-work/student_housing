namespace StudentHousing
{
    partial class Start
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
            lblWelcome = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            btnGuest = new Button();
            panel1 = new Panel();
            btnAdmin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblWelcome.ForeColor = Color.MediumAquamarine;
            lblWelcome.Location = new Point(42, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(623, 43);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to the student house application!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.MediumAquamarine;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnRegister.Location = new Point(260, 112);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(170, 31);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(260, 166);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(170, 31);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.MediumAquamarine;
            btnGuest.Cursor = Cursors.Hand;
            btnGuest.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnGuest.Location = new Point(260, 219);
            btnGuest.Margin = new Padding(3, 2, 3, 2);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(170, 31);
            btnGuest.TabIndex = 3;
            btnGuest.Text = "Guest";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 67);
            panel1.TabIndex = 13;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.MediumAquamarine;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAdmin.Location = new Point(260, 269);
            btnAdmin.Margin = new Padding(3, 2, 3, 2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(170, 31);
            btnAdmin.TabIndex = 14;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAdmin);
            Controls.Add(panel1);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Start";
            Text = "Start";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button btnRegister;
        private Button btnLogin;
        private Button btnGuest;
        private Panel panel1;
        private Button btnAdmin;
    }
}