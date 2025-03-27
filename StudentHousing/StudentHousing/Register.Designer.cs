namespace StudentHousing
{
    partial class Register
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
            lblRegister = new Label();
            btnCreateAccount = new Button();
            lblRegisterText = new Label();
            lblRegisterName = new Label();
            tbRegisterName = new TextBox();
            tbRegisterEmail = new TextBox();
            lblRegisterEmail = new Label();
            lblRegisterPassword = new Label();
            tbRegisterPassword = new TextBox();
            lblRegisterRoomNr = new Label();
            tbRegisterRoomNr = new TextBox();
            btnBack2 = new Button();
            panel1 = new Panel();
            pbxEye = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).BeginInit();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.MediumAquamarine;
            lblRegister.Location = new Point(282, 11);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(134, 43);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.MediumAquamarine;
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(220, 295);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(246, 32);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // lblRegisterText
            // 
            lblRegisterText.AutoSize = true;
            lblRegisterText.BackColor = Color.Transparent;
            lblRegisterText.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterText.Location = new Point(169, 88);
            lblRegisterText.Name = "lblRegisterText";
            lblRegisterText.Size = new Size(157, 22);
            lblRegisterText.TabIndex = 2;
            lblRegisterText.Text = "Please enter your:";
            // 
            // lblRegisterName
            // 
            lblRegisterName.AutoSize = true;
            lblRegisterName.BackColor = Color.Transparent;
            lblRegisterName.Font = new Font("Times New Roman", 12F);
            lblRegisterName.Location = new Point(280, 132);
            lblRegisterName.Name = "lblRegisterName";
            lblRegisterName.Size = new Size(49, 19);
            lblRegisterName.TabIndex = 3;
            lblRegisterName.Text = "Name:";
            // 
            // tbRegisterName
            // 
            tbRegisterName.BackColor = Color.FloralWhite;
            tbRegisterName.BorderStyle = BorderStyle.FixedSingle;
            tbRegisterName.Font = new Font("Times New Roman", 11.25F);
            tbRegisterName.Location = new Point(335, 133);
            tbRegisterName.Margin = new Padding(3, 2, 3, 2);
            tbRegisterName.Name = "tbRegisterName";
            tbRegisterName.Size = new Size(131, 25);
            tbRegisterName.TabIndex = 4;
            // 
            // tbRegisterEmail
            // 
            tbRegisterEmail.BackColor = Color.FloralWhite;
            tbRegisterEmail.BorderStyle = BorderStyle.FixedSingle;
            tbRegisterEmail.Font = new Font("Times New Roman", 11.25F);
            tbRegisterEmail.Location = new Point(335, 172);
            tbRegisterEmail.Margin = new Padding(3, 2, 3, 2);
            tbRegisterEmail.Name = "tbRegisterEmail";
            tbRegisterEmail.Size = new Size(131, 25);
            tbRegisterEmail.TabIndex = 5;
            // 
            // lblRegisterEmail
            // 
            lblRegisterEmail.AutoSize = true;
            lblRegisterEmail.BackColor = Color.Transparent;
            lblRegisterEmail.Font = new Font("Times New Roman", 12F);
            lblRegisterEmail.Location = new Point(277, 171);
            lblRegisterEmail.Name = "lblRegisterEmail";
            lblRegisterEmail.Size = new Size(51, 19);
            lblRegisterEmail.TabIndex = 6;
            lblRegisterEmail.Text = "E-mail:";
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.BackColor = Color.Transparent;
            lblRegisterPassword.Font = new Font("Times New Roman", 12F);
            lblRegisterPassword.Location = new Point(224, 250);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(105, 19);
            lblRegisterPassword.TabIndex = 7;
            lblRegisterPassword.Text = "New password:";
            // 
            // tbRegisterPassword
            // 
            tbRegisterPassword.BackColor = Color.FloralWhite;
            tbRegisterPassword.BorderStyle = BorderStyle.FixedSingle;
            tbRegisterPassword.Font = new Font("Times New Roman", 11.25F);
            tbRegisterPassword.Location = new Point(335, 250);
            tbRegisterPassword.Margin = new Padding(3, 2, 3, 2);
            tbRegisterPassword.Name = "tbRegisterPassword";
            tbRegisterPassword.Size = new Size(131, 25);
            tbRegisterPassword.TabIndex = 8;
            tbRegisterPassword.UseSystemPasswordChar = true;
            // 
            // lblRegisterRoomNr
            // 
            lblRegisterRoomNr.AutoSize = true;
            lblRegisterRoomNr.BackColor = Color.Transparent;
            lblRegisterRoomNr.Font = new Font("Times New Roman", 12F);
            lblRegisterRoomNr.Location = new Point(260, 210);
            lblRegisterRoomNr.Name = "lblRegisterRoomNr";
            lblRegisterRoomNr.Size = new Size(68, 19);
            lblRegisterRoomNr.TabIndex = 9;
            lblRegisterRoomNr.Text = "Room nr.:";
            // 
            // tbRegisterRoomNr
            // 
            tbRegisterRoomNr.BackColor = Color.FloralWhite;
            tbRegisterRoomNr.BorderStyle = BorderStyle.FixedSingle;
            tbRegisterRoomNr.Font = new Font("Times New Roman", 11.25F);
            tbRegisterRoomNr.Location = new Point(335, 211);
            tbRegisterRoomNr.Margin = new Padding(3, 2, 3, 2);
            tbRegisterRoomNr.Name = "tbRegisterRoomNr";
            tbRegisterRoomNr.Size = new Size(131, 25);
            tbRegisterRoomNr.TabIndex = 10;
            // 
            // btnBack2
            // 
            btnBack2.BackColor = Color.MediumAquamarine;
            btnBack2.Cursor = Cursors.Hand;
            btnBack2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack2.Location = new Point(625, 13);
            btnBack2.Margin = new Padding(3, 2, 3, 2);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(65, 32);
            btnBack2.TabIndex = 11;
            btnBack2.Text = "Back";
            btnBack2.UseVisualStyleBackColor = false;
            btnBack2.Click += btnBack2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblRegister);
            panel1.Controls.Add(btnBack2);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 66);
            panel1.TabIndex = 12;
            // 
            // pbxEye
            // 
            pbxEye.BackColor = Color.Transparent;
            pbxEye.Cursor = Cursors.Hand;
            pbxEye.Image = Properties.Resources.eye;
            pbxEye.Location = new Point(472, 250);
            pbxEye.Name = "pbxEye";
            pbxEye.Size = new Size(25, 25);
            pbxEye.SizeMode = PictureBoxSizeMode.Zoom;
            pbxEye.TabIndex = 13;
            pbxEye.TabStop = false;
            pbxEye.Click += pbxEye_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_597076712_LBt4mJGj8NVYCGYY03XFKBE3oOU2eIL2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pbxEye);
            Controls.Add(panel1);
            Controls.Add(tbRegisterRoomNr);
            Controls.Add(lblRegisterRoomNr);
            Controls.Add(lblRegisterPassword);
            Controls.Add(tbRegisterName);
            Controls.Add(tbRegisterPassword);
            Controls.Add(lblRegisterEmail);
            Controls.Add(tbRegisterEmail);
            Controls.Add(lblRegisterName);
            Controls.Add(lblRegisterText);
            Controls.Add(btnCreateAccount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Button btnCreateAccount;
        private Label lblRegisterText;
        private Label lblRegisterName;
        private TextBox tbRegisterName;
        private TextBox tbRegisterEmail;
        private Label lblRegisterEmail;
        private Label lblRegisterPassword;
        private TextBox tbRegisterPassword;
        private Label lblRegisterRoomNr;
        private TextBox tbRegisterRoomNr;
        private Button btnBack2;
        private Panel panel1;
        private PictureBox pbxEye;
    }
}