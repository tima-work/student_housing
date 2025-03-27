namespace StudentHousing
{
    partial class SearchForm
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
            panel1 = new Panel();
            btnBack = new Button();
            lblSearchTitle = new Label();
            gbSearchBy = new GroupBox();
            rbStudentRoomNr = new RadioButton();
            rbStudentName = new RadioButton();
            rbStudentEmail = new RadioButton();
            btnSearchStudents = new Button();
            lbAllStudents = new ListBox();
            btnShowStudents = new Button();
            tbSearchText = new TextBox();
            panel1.SuspendLayout();
            gbSearchBy.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(lblSearchTitle);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 71);
            panel1.TabIndex = 14;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.Location = new Point(722, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 32);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.AutoSize = true;
            lblSearchTitle.BackColor = Color.Transparent;
            lblSearchTitle.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblSearchTitle.ForeColor = Color.MediumAquamarine;
            lblSearchTitle.Location = new Point(334, 9);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(113, 43);
            lblSearchTitle.TabIndex = 0;
            lblSearchTitle.Text = "Search";
            // 
            // gbSearchBy
            // 
            gbSearchBy.BackColor = Color.Transparent;
            gbSearchBy.Controls.Add(rbStudentRoomNr);
            gbSearchBy.Controls.Add(rbStudentName);
            gbSearchBy.Controls.Add(rbStudentEmail);
            gbSearchBy.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbSearchBy.Location = new Point(12, 91);
            gbSearchBy.Margin = new Padding(3, 2, 3, 2);
            gbSearchBy.Name = "gbSearchBy";
            gbSearchBy.Padding = new Padding(3, 2, 3, 2);
            gbSearchBy.Size = new Size(247, 121);
            gbSearchBy.TabIndex = 16;
            gbSearchBy.TabStop = false;
            gbSearchBy.Text = "Search by";
            // 
            // rbStudentRoomNr
            // 
            rbStudentRoomNr.AutoSize = true;
            rbStudentRoomNr.Cursor = Cursors.Hand;
            rbStudentRoomNr.Location = new Point(9, 87);
            rbStudentRoomNr.Margin = new Padding(3, 2, 3, 2);
            rbStudentRoomNr.Name = "rbStudentRoomNr";
            rbStudentRoomNr.Size = new Size(113, 23);
            rbStudentRoomNr.TabIndex = 3;
            rbStudentRoomNr.TabStop = true;
            rbStudentRoomNr.Text = "Room number";
            rbStudentRoomNr.UseVisualStyleBackColor = true;
            rbStudentRoomNr.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbStudentName
            // 
            rbStudentName.AutoSize = true;
            rbStudentName.BackColor = Color.Transparent;
            rbStudentName.Cursor = Cursors.Hand;
            rbStudentName.Location = new Point(9, 33);
            rbStudentName.Margin = new Padding(3, 2, 3, 2);
            rbStudentName.Name = "rbStudentName";
            rbStudentName.Size = new Size(64, 23);
            rbStudentName.TabIndex = 1;
            rbStudentName.TabStop = true;
            rbStudentName.Text = "Name";
            rbStudentName.UseVisualStyleBackColor = false;
            // 
            // rbStudentEmail
            // 
            rbStudentEmail.AutoSize = true;
            rbStudentEmail.Cursor = Cursors.Hand;
            rbStudentEmail.Location = new Point(9, 60);
            rbStudentEmail.Margin = new Padding(3, 2, 3, 2);
            rbStudentEmail.Name = "rbStudentEmail";
            rbStudentEmail.Size = new Size(60, 23);
            rbStudentEmail.TabIndex = 2;
            rbStudentEmail.TabStop = true;
            rbStudentEmail.Text = "Email";
            rbStudentEmail.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudents
            // 
            btnSearchStudents.BackColor = Color.MediumAquamarine;
            btnSearchStudents.Cursor = Cursors.Hand;
            btnSearchStudents.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSearchStudents.Location = new Point(71, 274);
            btnSearchStudents.Name = "btnSearchStudents";
            btnSearchStudents.Size = new Size(107, 45);
            btnSearchStudents.TabIndex = 15;
            btnSearchStudents.Text = "Search";
            btnSearchStudents.UseVisualStyleBackColor = false;
            btnSearchStudents.Click += btnSearchStudents_Click;
            // 
            // lbAllStudents
            // 
            lbAllStudents.FormattingEnabled = true;
            lbAllStudents.ItemHeight = 15;
            lbAllStudents.Location = new Point(285, 139);
            lbAllStudents.Name = "lbAllStudents";
            lbAllStudents.Size = new Size(365, 259);
            lbAllStudents.TabIndex = 17;
            lbAllStudents.SelectedIndexChanged += lbAllStudents_SelectedIndexChanged;
            // 
            // btnShowStudents
            // 
            btnShowStudents.BackColor = Color.MediumAquamarine;
            btnShowStudents.Cursor = Cursors.Hand;
            btnShowStudents.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnShowStudents.Location = new Point(672, 389);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(116, 49);
            btnShowStudents.TabIndex = 18;
            btnShowStudents.Text = "Show all students";
            btnShowStudents.UseVisualStyleBackColor = false;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // tbSearchText
            // 
            tbSearchText.Location = new Point(12, 232);
            tbSearchText.Name = "tbSearchText";
            tbSearchText.Size = new Size(247, 23);
            tbSearchText.TabIndex = 19;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSearchText);
            Controls.Add(btnShowStudents);
            Controls.Add(lbAllStudents);
            Controls.Add(btnSearchStudents);
            Controls.Add(gbSearchBy);
            Controls.Add(panel1);
            Name = "SearchForm";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gbSearchBy.ResumeLayout(false);
            gbSearchBy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBack;
        private Label lblSearchTitle;
        private GroupBox gbSearchBy;
        private RadioButton rbStudentName;
        private RadioButton rbStudentEmail;
        private RadioButton rbStudentRoomNr;
        private Button btnSearchStudents;
        private ListBox lbAllStudents;
        private Button btnShowStudents;
        private TextBox tbSearchText;
    }
}