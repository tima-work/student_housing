namespace StudentHousing
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            picBoxGallery = new PictureBox();
            picBoxPreview = new PictureBox();
            lblGuestPage = new Label();
            panel1 = new Panel();
            btnBack2 = new Button();
            lblInfo = new Label();
            lblGallery = new Label();
            lblAppPreview = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxGallery).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxGallery
            // 
            picBoxGallery.BorderStyle = BorderStyle.FixedSingle;
            picBoxGallery.Cursor = Cursors.Hand;
            picBoxGallery.Image = (Image)resources.GetObject("picBoxGallery.Image");
            picBoxGallery.Location = new Point(90, 232);
            picBoxGallery.Name = "picBoxGallery";
            picBoxGallery.Size = new Size(185, 162);
            picBoxGallery.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxGallery.TabIndex = 0;
            picBoxGallery.TabStop = false;
            picBoxGallery.Click += picBoxGallery_Click;
            // 
            // picBoxPreview
            // 
            picBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            picBoxPreview.Cursor = Cursors.Hand;
            picBoxPreview.Image = Properties.Resources.applicationPreview;
            picBoxPreview.Location = new Point(391, 232);
            picBoxPreview.Name = "picBoxPreview";
            picBoxPreview.Size = new Size(253, 162);
            picBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPreview.TabIndex = 1;
            picBoxPreview.TabStop = false;
            picBoxPreview.Click += picBoxPreview_Click;
            // 
            // lblGuestPage
            // 
            lblGuestPage.AutoSize = true;
            lblGuestPage.BackColor = Color.Transparent;
            lblGuestPage.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblGuestPage.ForeColor = Color.MediumAquamarine;
            lblGuestPage.Location = new Point(254, 10);
            lblGuestPage.Name = "lblGuestPage";
            lblGuestPage.Size = new Size(178, 43);
            lblGuestPage.TabIndex = 2;
            lblGuestPage.Text = "Guest Page";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnBack2);
            panel1.Controls.Add(lblGuestPage);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 63);
            panel1.TabIndex = 3;
            // 
            // btnBack2
            // 
            btnBack2.BackColor = Color.MediumAquamarine;
            btnBack2.Cursor = Cursors.Hand;
            btnBack2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack2.Location = new Point(624, 12);
            btnBack2.Margin = new Padding(3, 2, 3, 2);
            btnBack2.Name = "btnBack2";
            btnBack2.Size = new Size(65, 32);
            btnBack2.TabIndex = 12;
            btnBack2.Text = "Back";
            btnBack2.UseVisualStyleBackColor = false;
            btnBack2.Click += btnBack2_Click;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(90, 65);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(554, 134);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Info about the house";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGallery
            // 
            lblGallery.AutoSize = true;
            lblGallery.BackColor = Color.Transparent;
            lblGallery.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGallery.Location = new Point(149, 199);
            lblGallery.Name = "lblGallery";
            lblGallery.Size = new Size(59, 19);
            lblGallery.TabIndex = 5;
            lblGallery.Text = "Gallery";
            // 
            // lblAppPreview
            // 
            lblAppPreview.AutoSize = true;
            lblAppPreview.BackColor = Color.Transparent;
            lblAppPreview.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppPreview.Location = new Point(450, 199);
            lblAppPreview.Name = "lblAppPreview";
            lblAppPreview.Size = new Size(141, 19);
            lblAppPreview.TabIndex = 6;
            lblAppPreview.Text = "Application Preview";
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_597076712_LBt4mJGj8NVYCGYY03XFKBE3oOU2eIL2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 406);
            Controls.Add(lblAppPreview);
            Controls.Add(lblGallery);
            Controls.Add(lblInfo);
            Controls.Add(panel1);
            Controls.Add(picBoxPreview);
            Controls.Add(picBoxGallery);
            Name = "Guest";
            Text = "Guest";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxGallery).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPreview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxGallery;
        private PictureBox picBoxPreview;
        private Label lblGuestPage;
        private Panel panel1;
        private Label lblInfo;
        private Button btnBack2;
        private Label lblGallery;
        private Label lblAppPreview;
    }
}