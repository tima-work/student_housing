using System.Windows.Forms;

namespace AnnouncementPage
{
    public partial class Form1 : Form
    {
        private Announcement currentAnnouncement;
        private AnnouncementManager announcementManager = new AnnouncementManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.currentAnnouncement = new Announcement(txtbTitle.Text, richTxtbAdd.Text);
            announcementManager.AddAnnouncement(txtbTitle.Text, richTxtbAdd.Text);
            lbAnnouncements.Items.Insert(0, currentAnnouncement.GetInfo());

            txtbTitle.Clear();
            richTxtbAdd.Clear();
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnnouncements.SelectedIndex != -1)
            {
                int actualIndex = lbAnnouncements.Items.Count - 1 - lbAnnouncements.SelectedIndex;
                MessageBox.Show(announcementManager[actualIndex].GetAllInfo());
            }
        }
    }
}
