namespace StudentHousing
{
    partial class AnnouncementForm
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
            lblAnnouncements = new Label();
            lblTitle = new Label();
            lblDesc = new Label();
            lbAnnouncements = new ListBox();
            txtbTitle = new TextBox();
            richTxtbAdd = new RichTextBox();
            btnBack = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.BackColor = Color.Transparent;
            lblAnnouncements.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblAnnouncements.ForeColor = Color.MediumAquamarine;
            lblAnnouncements.Location = new Point(269, 12);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(245, 43);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(45, 331);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(45, 19);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblDesc.Location = new Point(45, 362);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(91, 19);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description:";
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.BackColor = Color.FloralWhite;
            lbAnnouncements.BorderStyle = BorderStyle.FixedSingle;
            lbAnnouncements.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 17;
            lbAnnouncements.Location = new Point(45, 82);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(706, 189);
            lbAnnouncements.TabIndex = 3;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            // 
            // txtbTitle
            // 
            txtbTitle.BackColor = Color.FloralWhite;
            txtbTitle.BorderStyle = BorderStyle.FixedSingle;
            txtbTitle.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbTitle.Location = new Point(139, 329);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.Size = new Size(550, 25);
            txtbTitle.TabIndex = 4;
            // 
            // richTxtbAdd
            // 
            richTxtbAdd.BackColor = Color.FloralWhite;
            richTxtbAdd.BorderStyle = BorderStyle.FixedSingle;
            richTxtbAdd.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTxtbAdd.Location = new Point(139, 360);
            richTxtbAdd.Name = "richTxtbAdd";
            richTxtbAdd.Size = new Size(550, 78);
            richTxtbAdd.TabIndex = 5;
            richTxtbAdd.Text = "";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.Location = new Point(719, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 30);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(704, 360);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(47, 51);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.TextAlign = ContentAlignment.TopCenter;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblAnnouncements);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 8;
            // 
            // AnnouncementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            Controls.Add(richTxtbAdd);
            Controls.Add(txtbTitle);
            Controls.Add(lbAnnouncements);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Name = "AnnouncementForm";
            Text = "AnnouncementForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnnouncements;
        private Label lblTitle;
        private Label lblDesc;
        private ListBox lbAnnouncements;
        private TextBox txtbTitle;
        private RichTextBox richTxtbAdd;
        private Button btnBack;
        private Button btnAdd;
        private Panel panel1;
    }
}