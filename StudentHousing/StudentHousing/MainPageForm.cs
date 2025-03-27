using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing
{
    public partial class MainPageForm : Form
    {
        //private TaskManager taskManager = new TaskManager();
        private RuleForm rule_form;
        private ComplaintForm complaint_form;
        private AnnouncementForm announcementForm;
        private ViewComplaints view_complaints;
        private SearchForm search_form;
        private EditProfile edit_profile;
        private Tasks tasks;


        public static RuleManager ruleManager = new RuleManager();
        public static TaskManager taskManager = new TaskManager();
        public static StudentManager studentManager = new StudentManager();
        public static ComplaintManager complaintManager = new ComplaintManager();
        public static AnnouncementManager announcementManager = new AnnouncementManager();


        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[18];
        private string current_user;


        public MainPageForm(string email)
        {
            InitializeComponent();
            current_user = email;
            announcementForm = new AnnouncementForm(this, current_user);
            rule_form = new RuleForm(this);
            complaint_form = new ComplaintForm(this);
            view_complaints = new ViewComplaints(this);
            search_form = new SearchForm(this);
            tasks = new Tasks(this, current_user);
            if (current_user != "admin")
                edit_profile = new EditProfile(this, current_user);


            btnViewComplaints.Visible = UserIsAdmin();
            all_controls = new Control[18] { gbSideNav, lblMainMenu, picBoxProfile, lblMainProfile, picBoxSearch, lblMainSearch, picBoxComplaints, lblMainComplaints, picBoxRules, lblMainRules, lblMainAnnouncements, lbAnnouncementsBox, btnAddAnnouncement, lblMainTasks, lbTasksBox, btnAddTask, btnMainSignOut, btnViewComplaints };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
            UpdateTasksListBox();
        }

        public void UpdateTasksListBox()
        {
            Task[] allTasks = taskManager.GetAllTasks();
            DisplayTasks(allTasks);
        }

        private void DisplayTasks(Task[] tasks)
        {
            lbTasksBox.Items.Clear();
            foreach (Task task in tasks)
                lbTasksBox.Items.Insert(0, task.GetFullTask());
        }

        private void btnViewComplaints_Click(object sender, EventArgs e)
        {
            view_complaints.ShowAllComplaints();
            GoToOtherForm(this, view_complaints);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            ResizeSmth(all_resizes);
        }

        public bool UserIsAdmin()
        {
            return current_user == "admin";
        }

        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            GoToOtherForm(this, announcementForm);
        }

        public void UpdateAnnouncementsBox()
        {
            lbAnnouncementsBox.Items.Clear();
            foreach (Announcement announcement in announcementManager.GetAnnouncements())
                lbAnnouncementsBox.Items.Insert(0, announcement.GetInfo());
        }

        private void picBoxSearch_Click(object sender, EventArgs e)
        {
            GoToOtherForm(this, search_form);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            GoToOtherForm(this, tasks);
        }

        private void btnMainSignOut_Click(object sender, EventArgs e)
        {
            GoToOtherForm(this, new Start());
        }

        private void picBoxComplaints_Click(object sender, EventArgs e)
        {
            if (current_user == "admin")
                MessageBox.Show("Admin is not able to create complaints");
            else
            {
                GoToOtherForm(this, this.complaint_form);
            }
        }

        private void picBoxRules_Click(object sender, EventArgs e)
        {
            GoToOtherForm(this, this.rule_form);
        }

        private void picBoxProfile_Click(object sender, EventArgs e)
        {
            if (current_user == "admin")
                MessageBox.Show("Admin doesn't have a profile");
            else
            {
                edit_profile.PrepareForEdit();
                GoToOtherForm(this, edit_profile);
            }
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

        public static void GoToOtherForm(Form origin_form, Form destination_form)
        {
            destination_form.Location = origin_form.Location;
            destination_form.Size = origin_form.Size;
            destination_form.Show();
            origin_form.Hide();
        }
    }
}
