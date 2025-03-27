namespace StudentHousing
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
            lbTasks = new ListBox();
            btnFinishTask = new Button();
            btnAddTask = new Button();
            SuspendLayout();
            // 
            // lbTasks
            // 
            lbTasks.FormattingEnabled = true;
            lbTasks.ItemHeight = 15;
            lbTasks.Location = new Point(453, 23);
            lbTasks.Name = "lbTasks";
            lbTasks.Size = new Size(335, 409);
            lbTasks.TabIndex = 0;
            lbTasks.SelectedIndexChanged += lbTasks_SelectedIndexChanged;
            // 
            // btnFinishTask
            // 
            btnFinishTask.Location = new Point(238, 293);
            btnFinishTask.Name = "btnFinishTask";
            btnFinishTask.Size = new Size(75, 23);
            btnFinishTask.TabIndex = 2;
            btnFinishTask.Text = "Finish Task";
            btnFinishTask.UseVisualStyleBackColor = true;
            btnFinishTask.Click += btnFinishTask_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(130, 293);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(75, 23);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddTask);
            Controls.Add(btnFinishTask);
            Controls.Add(lbTasks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbTasks;
        private Button btnAddTask;
    }
}
