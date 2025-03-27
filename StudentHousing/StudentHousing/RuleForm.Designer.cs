namespace StudentHousing
{
    partial class RuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
            flpRules = new FlowLayoutPanel();
            panel1 = new Panel();
            lblRules = new Label();
            btnBack = new Button();
            btnAddRule = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpRules
            // 
            flpRules.AutoScroll = true;
            flpRules.BackColor = Color.Transparent;
            flpRules.Location = new Point(197, 112);
            flpRules.Name = "flpRules";
            flpRules.Size = new Size(507, 286);
            flpRules.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblRules);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 68);
            panel1.TabIndex = 9;
            // 
            // lblRules
            // 
            lblRules.AutoSize = true;
            lblRules.BackColor = Color.Transparent;
            lblRules.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            lblRules.ForeColor = Color.MediumAquamarine;
            lblRules.Location = new Point(344, 7);
            lblRules.Name = "lblRules";
            lblRules.Size = new Size(98, 43);
            lblRules.TabIndex = 0;
            lblRules.Text = "Rules";
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
            // btnAddRule
            // 
            btnAddRule.BackColor = Color.MediumAquamarine;
            btnAddRule.Cursor = Cursors.Hand;
            btnAddRule.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btnAddRule.Location = new Point(34, 112);
            btnAddRule.Name = "btnAddRule";
            btnAddRule.Size = new Size(123, 60);
            btnAddRule.TabIndex = 13;
            btnAddRule.Text = "Add rule";
            btnAddRule.UseVisualStyleBackColor = false;
            btnAddRule.Click += btnAddRule_Click;
            // 
            // RuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddRule);
            Controls.Add(panel1);
            Controls.Add(flpRules);
            Name = "RuleForm";
            Text = "RuleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpRules;
        private Panel panel1;
        private Label lblRules;
        private Button btnBack;
        private Button btnAddRule;
    }
}