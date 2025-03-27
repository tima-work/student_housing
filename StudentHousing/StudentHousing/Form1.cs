using Newtonsoft.Json;

namespace StudentHousing
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();
        private ListBox tasksListBox;
        private Button btnGetMineTasks;
        private Button btnFinishTask;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[3];

        public Form1()
        {
            InitializeComponent();
            /*all_controls = new Control[3] { btnAddTask, btnFinishTask, lbTasks };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            //this.Resize += ResizeThisWindow;*/
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskName = Microsoft.VisualBasic.Interaction.InputBox("Enter task name:", "Add Task", "");
            DateTime deadline = DateTime.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter task deadline:", "Add Task", ""));
            ComboBox comboBoxAttendees = new ComboBox();
            LoadAttendeesFromCSV(comboBoxAttendees, "Attendees.csv");
            comboBoxAttendees.SelectedIndex = 0;
            DialogResult result = MessageBox.Show(comboBoxAttendees, "Select assigned attendee:", "Add Task", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string assignedAttendee = comboBoxAttendees.SelectedItem.ToString();
                taskManager.AddTask(taskName, deadline, assignedAttendee);
                UpdateTasksListBox();
            }
        }

        private void LoadAttendeesFromCSV(ComboBox comboBox, string filePath)
        {
            // TODO: Implement the logic to read attendees from the CSV file
            // For example:
            // 1. Open and read the CSV file
            // 2. Populate the ComboBox with the attendee names

            // Sample code (you should replace this with your actual logic):
            string[] attendees = File.ReadAllLines(filePath);
            comboBox.Items.AddRange(attendees);
        }

        private void btnFinishTask_Click(object sender, EventArgs e)
        {
            string selectedTask = lbTasks.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedTask))
            {
                taskManager.FinishTask(selectedTask);
                UpdateTasksListBox();
            }
        }

        private void btnGetMineTasks_Click(object sender, EventArgs e)
        {
            //List<Task> mineTasks = taskManager.GetMineTasks();
            //DisplayTasks(mineTasks);
        }

        private void UpdateTasksListBox()
        {
            //List<Task> allTasks = taskManager.GetAllTasks();
            //DisplayTasks(allTasks);
        }

        private void DisplayTasks(List<Task> tasks)
        {
            lbTasks.Items.Clear();
            foreach (Task task in tasks)
            {
                lbTasks.Items.Add(task.TaskName);
            }
        }

        private void lbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
