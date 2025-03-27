using Newtonsoft.Json;

namespace StudentHousing
{
    public partial class Tasks : Form
    {
        private ListBox tasksListBox;
        //private Button btnGetMineTasks;
        private Button btnFinishTask;
        string current_user;
        private MainPageForm go_back_form;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[14];

        public Tasks(MainPageForm go_back_form, string email)
        {
            InitializeComponent();
            all_controls = new Control[14] { panel1, lblTasks, btnBackToHome, rbAllTasks, rbMineTasks, btnAddTask, btnFinishTask, lblTaskName, tbTaskName, lblStudent, cbAttendees, lblDeadline, Deadline, lbTasks };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
            this.go_back_form = go_back_form;
            this.current_user = email;
            LoadAttendeesFromJSON(MainPageForm.studentManager.GetStudents(), cbAttendees);
            UpdateTasksListBox();
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = tbTaskName.Text;
            DateTime deadline = Deadline.Value;
            if (MainPageForm.taskManager.SameNameTasks(taskName))
            {
                MessageBox.Show("There is already task with such a name");
                return;
            }


            if (cbAttendees.SelectedIndex == -1)
            {
                MessageBox.Show("You have to select person to assign task to");
                return;
            }

            string assignedAttendee = MainPageForm.studentManager.GetStudents()[cbAttendees.SelectedIndex].Email;

            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(assignedAttendee))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MainPageForm.taskManager.AddTask(taskName, deadline, assignedAttendee);
            UpdateTasksListBox();
        }

        private void LoadAttendeesFromJSON(Student[] students, ComboBox comboBox)
        {
            try
            {
                // Clear existing items in the ComboBox
                comboBox.Items.Clear();

                foreach (Student student in students)
                {
                    comboBox.Items.Add(student.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnFinishTask_Click(object sender, EventArgs e)
        {
            string selectedTask = lbTasks.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTask))
            {
                MainPageForm.taskManager.FinishTask(selectedTask);
                UpdateTasksListBox();
            }
        }

        private void UpdateTasksListBox()
        {
            rbAllTasks.Checked = true;
            rbMineTasks.Checked = false;
            Task[] allTasks = MainPageForm.taskManager.GetAllTasks();
            DisplayTasks(allTasks);
        }

        private void DisplayTasks(Task[] tasks)
        {
            lbTasks.Items.Clear();
            foreach (Task task in tasks)
                lbTasks.Items.Insert(0, task.GetFullTask());
        }

        private void lbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static List<T> LoadSmthFromFile<T>(string path)
        {
            try
            {
                var jsonString = File.ReadAllText(path);
                List<T> list_to_return = JsonConvert.DeserializeObject<List<T>>(jsonString);
                return list_to_return;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                List<T> list_to_return = new List<T>();
                return list_to_return;
            }
        }

        public static void SaveSmthToFile<T>(string path, List<T> list_to_save)
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(list_to_save);
            File.WriteAllText(path, jsonString);
        }

        public static void ResizeSmth(ResizeClass[] list_to_resize)
        {
            foreach (ResizeClass resizeClass in list_to_resize)
            {
                resizeClass.ResizeWidget();
            }
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            ResizeSmth(all_resizes);
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.go_back_form.UpdateTasksListBox();
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void rbAllTasks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllTasks.Checked)
            {
                Task[] mineTasks = MainPageForm.taskManager.GetAllTasks();
                DisplayTasks(mineTasks);
            }
        }

        private void rbMineTasks_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMineTasks.Checked)
            {
                Task[] mineTasks = MainPageForm.taskManager.GetMineTasks(current_user);
                DisplayTasks(mineTasks);
            }
        }
    }
}
