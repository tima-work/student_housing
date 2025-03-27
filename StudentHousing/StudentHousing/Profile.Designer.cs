namespace StudentHousing
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            panel1 = new Panel();
            btnBackToMain = new Button();
            lblProfile = new Label();
            tbChangeName = new TextBox();
            lblChangeName = new Label();
            lblChangeEmail = new Label();
            tbChangeEmail = new TextBox();
            lblAddDescription = new Label();
            tbDescription = new TextBox();
            btnSave = new Button();
            tbChangeRoomNr = new TextBox();
            lblChangeRoomNr = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBackToMain);
            panel1.Controls.Add(lblProfile);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 68);
            panel1.TabIndex = 10;
            // 
            // btnBackToMain
            // 
            btnBackToMain.BackColor = Color.MediumAquamarine;
            btnBackToMain.Cursor = Cursors.Hand;
            btnBackToMain.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBackToMain.Location = new Point(620, 16);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(69, 30);
            btnBackToMain.TabIndex = 17;
            btnBackToMain.Text = "Back";
            btnBackToMain.UseVisualStyleBackColor = false;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.BackColor = Color.Transparent;
            lblProfile.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblProfile.ForeColor = Color.MediumAquamarine;
            lblProfile.Location = new Point(278, 9);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(182, 43);
            lblProfile.TabIndex = 0;
            lblProfile.Text = "Edit Profile";
            // 
            // tbChangeName
            // 
            tbChangeName.Location = new Point(206, 104);
            tbChangeName.Margin = new Padding(3, 2, 3, 2);
            tbChangeName.Name = "tbChangeName";
            tbChangeName.Size = new Size(268, 23);
            tbChangeName.TabIndex = 11;
            // 
            // lblChangeName
            // 
            lblChangeName.AutoSize = true;
            lblChangeName.BackColor = Color.Transparent;
            lblChangeName.Font = new Font("Times New Roman", 12F);
            lblChangeName.Location = new Point(145, 105);
            lblChangeName.Name = "lblChangeName";
            lblChangeName.Size = new Size(49, 19);
            lblChangeName.TabIndex = 16;
            lblChangeName.Text = "Name:";
            // 
            // lblChangeEmail
            // 
            lblChangeEmail.AutoSize = true;
            lblChangeEmail.BackColor = Color.Transparent;
            lblChangeEmail.Font = new Font("Times New Roman", 12F);
            lblChangeEmail.Location = new Point(145, 147);
            lblChangeEmail.Name = "lblChangeEmail";
            lblChangeEmail.Size = new Size(51, 19);
            lblChangeEmail.TabIndex = 17;
            lblChangeEmail.Text = "E-mail:";
            // 
            // tbChangeEmail
            // 
            tbChangeEmail.Location = new Point(206, 145);
            tbChangeEmail.Margin = new Padding(3, 2, 3, 2);
            tbChangeEmail.Name = "tbChangeEmail";
            tbChangeEmail.Size = new Size(268, 23);
            tbChangeEmail.TabIndex = 18;
            // 
            // lblAddDescription
            // 
            lblAddDescription.AutoSize = true;
            lblAddDescription.BackColor = Color.Transparent;
            lblAddDescription.Font = new Font("Times New Roman", 12F);
            lblAddDescription.Location = new Point(40, 289);
            lblAddDescription.Name = "lblAddDescription";
            lblAddDescription.Size = new Size(81, 19);
            lblAddDescription.TabIndex = 19;
            lblAddDescription.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(127, 240);
            tbDescription.Margin = new Padding(3, 2, 3, 2);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(426, 103);
            tbDescription.TabIndex = 20;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumAquamarine;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSave.Location = new Point(620, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(69, 34);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // tbChangeRoomNr
            // 
            tbChangeRoomNr.Location = new Point(206, 192);
            tbChangeRoomNr.Margin = new Padding(3, 2, 3, 2);
            tbChangeRoomNr.Name = "tbChangeRoomNr";
            tbChangeRoomNr.Size = new Size(268, 23);
            tbChangeRoomNr.TabIndex = 23;
            // 
            // lblChangeRoomNr
            // 
            lblChangeRoomNr.AutoSize = true;
            lblChangeRoomNr.BackColor = Color.Transparent;
            lblChangeRoomNr.Font = new Font("Times New Roman", 12F);
            lblChangeRoomNr.Location = new Point(126, 192);
            lblChangeRoomNr.Name = "lblChangeRoomNr";
            lblChangeRoomNr.Size = new Size(68, 19);
            lblChangeRoomNr.TabIndex = 22;
            lblChangeRoomNr.Text = "Room nr.:";
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 361);
            Controls.Add(tbChangeRoomNr);
            Controls.Add(lblChangeRoomNr);
            Controls.Add(btnSave);
            Controls.Add(tbDescription);
            Controls.Add(lblAddDescription);
            Controls.Add(tbChangeEmail);
            Controls.Add(lblChangeEmail);
            Controls.Add(lblChangeName);
            Controls.Add(tbChangeName);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditProfile";
            Text = "Edit Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblProfile;
        //private Button btnBack;
        private Button btnBackToMain;
        private TextBox tbChangeName;
        private Label lblChangeName;
        private Label lblChangeEmail;
        private TextBox tbChangeEmail;
        private Label lblAddDescription;
        private TextBox tbDescription;
        private Button btnSave;
        private TextBox tbChangeRoomNr;
        private Label lblChangeRoomNr;
    }
}