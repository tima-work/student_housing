namespace StudentHousing
{
    partial class ComplaintForm
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
            rbHouseIssue = new RadioButton();
            rbRoommateIssue = new RadioButton();
            lblComplaints = new Label();
            tbComplaint = new TextBox();
            lblComplaintDescription = new Label();
            btnSubmitComplaint = new Button();
            gbComplaintType = new GroupBox();
            panel1 = new Panel();
            lblComplaintsTitle = new Label();
            btnBack = new Button();
            gbComplaintType.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rbHouseIssue
            // 
            rbHouseIssue.AutoSize = true;
            rbHouseIssue.BackColor = Color.Transparent;
            rbHouseIssue.Cursor = Cursors.Hand;
            rbHouseIssue.Location = new Point(31, 29);
            rbHouseIssue.Margin = new Padding(3, 2, 3, 2);
            rbHouseIssue.Name = "rbHouseIssue";
            rbHouseIssue.Size = new Size(99, 23);
            rbHouseIssue.TabIndex = 1;
            rbHouseIssue.TabStop = true;
            rbHouseIssue.Text = "House issue";
            rbHouseIssue.UseVisualStyleBackColor = false;
            // 
            // rbRoommateIssue
            // 
            rbRoommateIssue.AutoSize = true;
            rbRoommateIssue.Cursor = Cursors.Hand;
            rbRoommateIssue.Location = new Point(31, 65);
            rbRoommateIssue.Margin = new Padding(3, 2, 3, 2);
            rbRoommateIssue.Name = "rbRoommateIssue";
            rbRoommateIssue.Size = new Size(93, 23);
            rbRoommateIssue.TabIndex = 2;
            rbRoommateIssue.TabStop = true;
            rbRoommateIssue.Text = "Roommate";
            rbRoommateIssue.UseVisualStyleBackColor = true;
            // 
            // lblComplaints
            // 
            lblComplaints.AutoSize = true;
            lblComplaints.BackColor = Color.Transparent;
            lblComplaints.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplaints.Location = new Point(12, 86);
            lblComplaints.Name = "lblComplaints";
            lblComplaints.Size = new Size(267, 19);
            lblComplaints.TabIndex = 3;
            lblComplaints.Text = "Here you can file an anonymous complaint.";
            // 
            // tbComplaint
            // 
            tbComplaint.BackColor = Color.FloralWhite;
            tbComplaint.BorderStyle = BorderStyle.FixedSingle;
            tbComplaint.Location = new Point(364, 133);
            tbComplaint.Margin = new Padding(3, 2, 3, 2);
            tbComplaint.Multiline = true;
            tbComplaint.Name = "tbComplaint";
            tbComplaint.Size = new Size(324, 129);
            tbComplaint.TabIndex = 4;
            // 
            // lblComplaintDescription
            // 
            lblComplaintDescription.AutoSize = true;
            lblComplaintDescription.BackColor = Color.Transparent;
            lblComplaintDescription.Font = new Font("Times New Roman", 12F);
            lblComplaintDescription.Location = new Point(364, 86);
            lblComplaintDescription.Name = "lblComplaintDescription";
            lblComplaintDescription.Size = new Size(191, 19);
            lblComplaintDescription.TabIndex = 5;
            lblComplaintDescription.Text = "Describe the complaint below:";
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.BackColor = Color.MediumAquamarine;
            btnSubmitComplaint.Cursor = Cursors.Hand;
            btnSubmitComplaint.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnSubmitComplaint.Location = new Point(228, 283);
            btnSubmitComplaint.Margin = new Padding(3, 2, 3, 2);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(246, 31);
            btnSubmitComplaint.TabIndex = 6;
            btnSubmitComplaint.Text = "Submit";
            btnSubmitComplaint.UseVisualStyleBackColor = false;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
            // 
            // gbComplaintType
            // 
            gbComplaintType.BackColor = Color.Transparent;
            gbComplaintType.Controls.Add(rbHouseIssue);
            gbComplaintType.Controls.Add(rbRoommateIssue);
            gbComplaintType.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbComplaintType.Location = new Point(12, 125);
            gbComplaintType.Margin = new Padding(3, 2, 3, 2);
            gbComplaintType.Name = "gbComplaintType";
            gbComplaintType.Padding = new Padding(3, 2, 3, 2);
            gbComplaintType.Size = new Size(324, 137);
            gbComplaintType.TabIndex = 7;
            gbComplaintType.TabStop = false;
            gbComplaintType.Text = "Please enter the type of complaint:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblComplaintsTitle);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 64);
            panel1.TabIndex = 14;
            // 
            // lblComplaintsTitle
            // 
            lblComplaintsTitle.AutoSize = true;
            lblComplaintsTitle.BackColor = Color.Transparent;
            lblComplaintsTitle.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblComplaintsTitle.ForeColor = Color.MediumAquamarine;
            lblComplaintsTitle.Location = new Point(247, 9);
            lblComplaintsTitle.Name = "lblComplaintsTitle";
            lblComplaintsTitle.Size = new Size(186, 43);
            lblComplaintsTitle.TabIndex = 2;
            lblComplaintsTitle.Text = "Complaints";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.Location = new Point(623, 11);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 32);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ComplaintForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(gbComplaintType);
            Controls.Add(tbComplaint);
            Controls.Add(btnSubmitComplaint);
            Controls.Add(lblComplaintDescription);
            Controls.Add(lblComplaints);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComplaintForm";
            Text = "Complaints";
            gbComplaintType.ResumeLayout(false);
            gbComplaintType.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rbHouseIssue;
        private RadioButton rbRoommateIssue;
        private Label lblComplaints;
        private TextBox tbComplaint;
        private Label lblComplaintDescription;
        private Button btnSubmitComplaint;
        private GroupBox gbComplaintType;
        private Panel panel1;
        private Label lblComplaintsTitle;
        private Button btnBack;
    }
}