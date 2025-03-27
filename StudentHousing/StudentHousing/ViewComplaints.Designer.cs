namespace StudentHousing
{
    partial class ViewComplaints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewComplaints));
            lbComplaintsBox = new ListBox();
            btnBack = new Button();
            panel1 = new Panel();
            lblviewComplaints = new Label();
            btnRemoveComplaint = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbComplaintsBox
            // 
            lbComplaintsBox.FormattingEnabled = true;
            lbComplaintsBox.ItemHeight = 15;
            lbComplaintsBox.Location = new Point(188, 98);
            lbComplaintsBox.Margin = new Padding(3, 2, 3, 2);
            lbComplaintsBox.Name = "lbComplaintsBox";
            lbComplaintsBox.Size = new Size(415, 244);
            lbComplaintsBox.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MediumAquamarine;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack.Location = new Point(717, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 30);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblviewComplaints);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 17;
            // 
            // lblviewComplaints
            // 
            lblviewComplaints.AutoSize = true;
            lblviewComplaints.BackColor = Color.Transparent;
            lblviewComplaints.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblviewComplaints.ForeColor = Color.MediumAquamarine;
            lblviewComplaints.Location = new Point(248, 12);
            lblviewComplaints.Name = "lblviewComplaints";
            lblviewComplaints.Size = new Size(265, 43);
            lblviewComplaints.TabIndex = 0;
            lblviewComplaints.Text = "View Complaints";
            // 
            // btnRemoveComplaint
            // 
            btnRemoveComplaint.BackColor = Color.MediumAquamarine;
            btnRemoveComplaint.Cursor = Cursors.Hand;
            btnRemoveComplaint.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnRemoveComplaint.Location = new Point(656, 278);
            btnRemoveComplaint.Name = "btnRemoveComplaint";
            btnRemoveComplaint.Size = new Size(131, 64);
            btnRemoveComplaint.TabIndex = 15;
            btnRemoveComplaint.Text = "Remove Complaint";
            btnRemoveComplaint.UseVisualStyleBackColor = false;
            btnRemoveComplaint.Click += btnRemoveComplaint_Click;
            // 
            // ViewComplaints
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(799, 382);
            Controls.Add(panel1);
            Controls.Add(btnRemoveComplaint);
            Controls.Add(lbComplaintsBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewComplaints";
            Text = "ViewComplaints";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbComplaintsBox;
        private Button btnBack;
        private Panel panel1;
        private Label lblviewComplaints;
        private Button btnRemoveComplaint;
    }
}