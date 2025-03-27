namespace StudentHousing
{
    partial class ApplicationPreview
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
            lblPreview = new Label();
            btnBack = new Button();
            pbxMenu = new PictureBox();
            pbxAnnouncements = new PictureBox();
            pbxComplaints = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAnnouncements).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxComplaints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblPreview);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 73);
            panel1.TabIndex = 14;
            // 
            // lblPreview
            // 
            lblPreview.AutoSize = true;
            lblPreview.BackColor = Color.Transparent;
            lblPreview.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblPreview.ForeColor = Color.MediumAquamarine;
            lblPreview.Location = new Point(236, 9);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(312, 43);
            lblPreview.TabIndex = 0;
            lblPreview.Text = "Application Preview";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.Location = new Point(723, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 32);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // pbxMenu
            // 
            pbxMenu.BorderStyle = BorderStyle.FixedSingle;
            pbxMenu.Cursor = Cursors.Hand;
            pbxMenu.Image = Properties.Resources.menuPreview;
            pbxMenu.Location = new Point(25, 114);
            pbxMenu.Name = "pbxMenu";
            pbxMenu.Size = new Size(204, 118);
            pbxMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMenu.TabIndex = 16;
            pbxMenu.TabStop = false;
            pbxMenu.Click += PicBox_Click;
            // 
            // pbxAnnouncements
            // 
            pbxAnnouncements.BorderStyle = BorderStyle.FixedSingle;
            pbxAnnouncements.Cursor = Cursors.Hand;
            pbxAnnouncements.Image = Properties.Resources.announcementsPreview;
            pbxAnnouncements.Location = new Point(297, 114);
            pbxAnnouncements.Name = "pbxAnnouncements";
            pbxAnnouncements.Size = new Size(204, 118);
            pbxAnnouncements.SizeMode = PictureBoxSizeMode.Zoom;
            pbxAnnouncements.TabIndex = 17;
            pbxAnnouncements.TabStop = false;
            pbxAnnouncements.Click += PicBox_Click;
            // 
            // pbxComplaints
            // 
            pbxComplaints.BorderStyle = BorderStyle.FixedSingle;
            pbxComplaints.Cursor = Cursors.Hand;
            pbxComplaints.Image = Properties.Resources.complaintsPreview;
            pbxComplaints.Location = new Point(572, 114);
            pbxComplaints.Name = "pbxComplaints";
            pbxComplaints.Size = new Size(204, 118);
            pbxComplaints.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxComplaints.TabIndex = 17;
            pbxComplaints.TabStop = false;
            pbxComplaints.Click += PicBox_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.taskPreview;
            pictureBox4.Location = new Point(25, 282);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(204, 118);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            pictureBox4.Click += PicBox_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = Properties.Resources.searchPreview;
            pictureBox5.Location = new Point(297, 282);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(204, 118);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += PicBox_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.complaintsPreview;
            pictureBox6.Location = new Point(572, 282);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(204, 118);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            pictureBox6.Click += PicBox_Click;
            // 
            // ApplicationPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pbxComplaints);
            Controls.Add(pbxAnnouncements);
            Controls.Add(pbxMenu);
            Controls.Add(panel1);
            Name = "ApplicationPreview";
            Text = "ApplicationPreview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAnnouncements).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxComplaints).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPreview;
        private Button btnBack;
        private PictureBox pbxMenu;
        private PictureBox pbxAnnouncements;
        private PictureBox pbxComplaints;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}