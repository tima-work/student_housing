namespace StudentHousing
{
    partial class NewRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRule));
            tbRuleText = new TextBox();
            btnAddRule = new Button();
            lblEnterRule = new Label();
            panel2 = new Panel();
            btnBack4 = new Button();
            lblAddNewRuleTitle = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbRuleText
            // 
            tbRuleText.BackColor = Color.FloralWhite;
            tbRuleText.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbRuleText.Location = new Point(159, 141);
            tbRuleText.Multiline = true;
            tbRuleText.Name = "tbRuleText";
            tbRuleText.Size = new Size(335, 51);
            tbRuleText.TabIndex = 2;
            // 
            // btnAddRule
            // 
            btnAddRule.BackColor = Color.MediumAquamarine;
            btnAddRule.Cursor = Cursors.Hand;
            btnAddRule.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnAddRule.Location = new Point(266, 278);
            btnAddRule.Name = "btnAddRule";
            btnAddRule.Size = new Size(123, 60);
            btnAddRule.TabIndex = 14;
            btnAddRule.Text = "Add rule";
            btnAddRule.UseVisualStyleBackColor = false;
            btnAddRule.Click += btnAddRule_Click;
            // 
            // lblEnterRule
            // 
            lblEnterRule.AutoSize = true;
            lblEnterRule.BackColor = Color.Transparent;
            lblEnterRule.Font = new Font("Times New Roman", 12F);
            lblEnterRule.Location = new Point(287, 108);
            lblEnterRule.Name = "lblEnterRule";
            lblEnterRule.Size = new Size(70, 19);
            lblEnterRule.TabIndex = 15;
            lblEnterRule.Text = "Enter rule:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Unknown;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnBack4);
            panel2.Controls.Add(lblAddNewRuleTitle);
            panel2.Location = new Point(2, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 72);
            panel2.TabIndex = 16;
            // 
            // btnBack4
            // 
            btnBack4.BackColor = Color.MediumAquamarine;
            btnBack4.Cursor = Cursors.Hand;
            btnBack4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBack4.Location = new Point(612, 19);
            btnBack4.Margin = new Padding(3, 2, 3, 2);
            btnBack4.Name = "btnBack4";
            btnBack4.Size = new Size(65, 32);
            btnBack4.TabIndex = 7;
            btnBack4.Text = "Back";
            btnBack4.UseVisualStyleBackColor = false;
            btnBack4.Click += btnBack_Click;
            // 
            // lblAddNewRuleTitle
            // 
            lblAddNewRuleTitle.AutoSize = true;
            lblAddNewRuleTitle.BackColor = Color.Transparent;
            lblAddNewRuleTitle.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblAddNewRuleTitle.ForeColor = Color.MediumAquamarine;
            lblAddNewRuleTitle.Location = new Point(224, 8);
            lblAddNewRuleTitle.Name = "lblAddNewRuleTitle";
            lblAddNewRuleTitle.Size = new Size(207, 43);
            lblAddNewRuleTitle.TabIndex = 3;
            lblAddNewRuleTitle.Text = "Add new rule";
            // 
            // NewRule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(685, 350);
            Controls.Add(panel2);
            Controls.Add(lblEnterRule);
            Controls.Add(btnAddRule);
            Controls.Add(tbRuleText);
            Name = "NewRule";
            Text = "NewRule";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbRuleText;
        private Button btnAddRule;
        private Button button1;
        private Label lblEnterRule;
        private Panel panel2;
        private Button btnBack4;
        private Label lblAddNewRuleTitle;
    }
}