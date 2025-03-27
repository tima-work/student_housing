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
    public partial class AnnouncementForm : Form
    {
        private Announcement currentAnnouncement;
        private MainPageForm go_back_form;
        private string current_user;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[9];

        public AnnouncementForm(MainPageForm go_back_form, string current_user)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            this.current_user = current_user;
            foreach (Announcement announcement in MainPageForm.announcementManager.GetAnnouncements())
                lbAnnouncements.Items.Insert(0, announcement.GetInfo());
            all_controls = new Control[9] { panel1, lblAnnouncements, btnBack, lbAnnouncements, lblTitle, txtbTitle, lblDesc, richTxtbAdd, btnAdd };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbTitle.Text == string.Empty)
                MessageBox.Show("You haven't entered title of announcement");
            else if (richTxtbAdd.Text == string.Empty)
                MessageBox.Show("You haven't entered description of announcement");
            else
            {
                currentAnnouncement = MainPageForm.announcementManager.AddAnnouncement(txtbTitle.Text, richTxtbAdd.Text, current_user);
                lbAnnouncements.Items.Insert(0, currentAnnouncement.GetInfo());

                txtbTitle.Clear();
                richTxtbAdd.Clear();
                MessageBox.Show("Successfully added");
            }
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnnouncements.SelectedIndex != -1)
            {
                int actualIndex = lbAnnouncements.Items.Count - 1 - lbAnnouncements.SelectedIndex;
                MessageBox.Show(MainPageForm.announcementManager[actualIndex].GetAllInfo());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.go_back_form.UpdateAnnouncementsBox();
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }
    }
}
