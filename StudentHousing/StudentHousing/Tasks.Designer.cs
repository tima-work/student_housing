namespace StudentHousing
{
    partial class Tasks
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
            lbTasks = new ListBox();
            btnFinishTask = new Button();
            btnAddTask = new Button();
            panel1 = new Panel();
            lblTasks = new Label();
            btnBackToHome = new Button();
            tbTaskName = new TextBox();
            cbAttendees = new ComboBox();
            Deadline = new DateTimePicker();
            lblTaskName = new Label();
            lblStudent = new Label();
            lblDeadline = new Label();
            rbAllTasks = new RadioButton();
            rbMineTasks = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.ItemHeight = 15;
            lbTasks.Location = new Point(230, 107);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(458, 244);
            lbTasks.TabIndex = 0;
            // 
            // btnFinishTask
            // 
            btnFinishTask.BackColor = Color.MediumAquamarine;
            btnFinishTask.Cursor = Cursors.Hand;
            btnFinishTask.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnFinishTask.Location = new Point(104, 145);
            btnFinishTask.Name = "btnFinishTask";
            btnFinishTask.Size = new Size(108, 32);
            btnFinishTask.TabIndex = 2;
            btnFinishTask.Text = "Finish Task";
            btnFinishTask.UseVisualStyleBackColor = false;
            btnFinishTask.Click += btnFinishTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.MediumAquamarine;
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnAddTask.Location = new Point(104, 107);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(108, 32);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.BackgroundImage = Properties.Resources.Unknown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblTasks);
            panel1.Controls.Add(btnBackToHome);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 66);
            panel1.TabIndex = 13;
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.BackColor = Color.Transparent;
            lblTasks.Font = new Font("Palatino Linotype", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTasks.ForeColor = Color.MediumAquamarine;
            lblTasks.Location = new Point(282, 11);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(100, 43);
            lblTasks.TabIndex = 0;
            lblTasks.Text = "Tasks";
            // 
            // btnBackToHome
            // 
            btnBackToHome.BackColor = Color.MediumAquamarine;
            btnBackToHome.Cursor = Cursors.Hand;
            btnBackToHome.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnBackToHome.Location = new Point(625, 13);
            btnBackToHome.Margin = new Padding(3, 2, 3, 2);
            btnBackToHome.Name = "btnBackToHome";
            btnBackToHome.Size = new Size(65, 32);
            btnBackToHome.TabIndex = 11;
            btnBackToHome.Text = "Back";
            btnBackToHome.UseVisualStyleBackColor = false;
            btnBackToHome.Click += btnBackToHome_Click;
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(14, 194);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(198, 23);
            tbTaskName.TabIndex = 14;
            // 
            // cbAttendees
            // 
            cbAttendees.FormattingEnabled = true;
            cbAttendees.Location = new Point(14, 235);
            cbAttendees.Name = "cbAttendees";
            cbAttendees.Size = new Size(198, 23);
            cbAttendees.TabIndex = 15;
            // 
            // Deadline
            // 
            Deadline.Location = new Point(12, 280);
            Deadline.Name = "Deadline";
            Deadline.Size = new Size(200, 23);
            Deadline.TabIndex = 16;
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.BackColor = Color.Transparent;
            lblTaskName.Location = new Point(14, 176);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(29, 15);
            lblTaskName.TabIndex = 17;
            lblTaskName.Text = "Task";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.BackColor = Color.Transparent;
            lblStudent.Location = new Point(14, 217);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(48, 15);
            lblStudent.TabIndex = 18;
            lblStudent.Text = "Student";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.BackColor = Color.Transparent;
            lblDeadline.Location = new Point(14, 261);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(53, 15);
            lblDeadline.TabIndex = 19;
            lblDeadline.Text = "Deadline";
            // 
            // rbAllTasks
            // 
            rbAllTasks.AutoSize = true;
            rbAllTasks.BackColor = Color.Transparent;
            rbAllTasks.Location = new Point(375, 82);
            rbAllTasks.Name = "rbAllTasks";
            rbAllTasks.Size = new Size(68, 19);
            rbAllTasks.TabIndex = 20;
            rbAllTasks.Text = "All tasks";
            rbAllTasks.UseVisualStyleBackColor = false;
            rbAllTasks.CheckedChanged += rbAllTasks_CheckedChanged;
            // 
            // rbMineTasks
            // 
            rbMineTasks.AutoSize = true;
            rbMineTasks.BackColor = Color.Transparent;
            rbMineTasks.Location = new Point(465, 82);
            rbMineTasks.Name = "rbMineTasks";
            rbMineTasks.Size = new Size(81, 19);
            rbMineTasks.TabIndex = 21;
            rbMineTasks.Text = "Mine tasks";
            rbMineTasks.UseVisualStyleBackColor = false;
            rbMineTasks.CheckedChanged += rbMineTasks_CheckedChanged;
            // 
            // Tasks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_597076712_LBt4mJGj8NVYCGYY03XFKBE3oOU2eIL2;
            ClientSize = new Size(700, 362);
            Controls.Add(rbMineTasks);
            Controls.Add(rbAllTasks);
            Controls.Add(lblDeadline);
            Controls.Add(lblStudent);
            Controls.Add(lblTaskName);
            Controls.Add(Deadline);
            Controls.Add(cbAttendees);
            Controls.Add(tbTaskName);
            Controls.Add(panel1);
            Controls.Add(btnAddTask);
            Controls.Add(btnFinishTask);
            Controls.Add(lbTasks);
            Name = "Tasks";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbTasks;
        private Button btnAddTask;
        private Panel panel1;
        private Label lblTasks;
        private Button btnBackToHome;
        private TextBox tbTaskName;
        private ComboBox cbAttendees;
        private DateTimePicker Deadline;
        private Label lblTaskName;
        private Label lblStudent;
        private Label lblDeadline;
        private RadioButton rbAllTasks;
        private RadioButton rbMineTasks;
    }
}
