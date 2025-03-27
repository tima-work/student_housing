namespace AnnouncementPage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnnouncements = new Label();
            btnBack = new Button();
            btnAdd = new Button();
            lbAnnouncements = new ListBox();
            richTxtbAdd = new RichTextBox();
            lblTitle = new Label();
            lblDescription = new Label();
            txtbTitle = new TextBox();
            SuspendLayout();
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnouncements.Location = new Point(260, 9);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(201, 32);
            lblAnnouncements.TabIndex = 0;
            lblAnnouncements.Text = "Announcements";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(224, 224, 224);
            btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(613, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(224, 224, 224);
            btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(640, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(52, 53);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbAnnouncements
            // 
            lbAnnouncements.BackColor = Color.FromArgb(224, 224, 224);
            lbAnnouncements.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbAnnouncements.FormattingEnabled = true;
            lbAnnouncements.ItemHeight = 20;
            lbAnnouncements.Location = new Point(29, 58);
            lbAnnouncements.Name = "lbAnnouncements";
            lbAnnouncements.Size = new Size(633, 184);
            lbAnnouncements.TabIndex = 3;
            lbAnnouncements.SelectedIndexChanged += lbAnnouncements_SelectedIndexChanged;
            // 
            // richTxtbAdd
            // 
            richTxtbAdd.BackColor = Color.FromArgb(224, 224, 224);
            richTxtbAdd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTxtbAdd.Location = new Point(126, 316);
            richTxtbAdd.Name = "richTxtbAdd";
            richTxtbAdd.Size = new Size(508, 63);
            richTxtbAdd.TabIndex = 4;
            richTxtbAdd.Text = "";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(29, 285);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(29, 333);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // txtbTitle
            // 
            txtbTitle.BackColor = Color.FromArgb(224, 224, 224);
            txtbTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtbTitle.Location = new Point(126, 284);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.Size = new Size(508, 25);
            txtbTitle.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(700, 391);
            Controls.Add(txtbTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblTitle);
            Controls.Add(richTxtbAdd);
            Controls.Add(lbAnnouncements);
            Controls.Add(btnAdd);
            Controls.Add(btnBack);
            Controls.Add(lblAnnouncements);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnnouncements;
        private Button btnBack;
        private Button btnAdd;
        private ListBox lbAnnouncements;
        private RichTextBox richTxtbAdd;
        private Label lblTitle;
        private Label lblDescription;
        private TextBox txtbTitle;
    }
}
