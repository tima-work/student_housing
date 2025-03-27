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
    public partial class ViewComplaints : Form
    {
        private Form go_back_form;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[5];
        public ViewComplaints(Form go_back_form)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            all_controls = new Control[5] { panel1, lblviewComplaints, btnRemoveComplaint, lbComplaintsBox, btnBack };
            for (int i = 0; i < all_controls.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        public void ShowAllComplaints()
        {
            lbComplaintsBox.Items.Clear();
            foreach (Complaint complaint in MainPageForm.complaintManager.GetComplaints())
                lbComplaintsBox.Items.Add(complaint.GetInfo());
        }

        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            if (lbComplaintsBox.SelectedItem != null)
            {
                Complaint complaint1 = MainPageForm.complaintManager.GetComplaints()[lbComplaintsBox.SelectedIndex];

                try
                {
                    MainPageForm.complaintManager.RemoveComplaint(complaint1);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                ShowAllComplaints();
            }
        }

    }
}
