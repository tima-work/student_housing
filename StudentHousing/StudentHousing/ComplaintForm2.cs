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
    public partial class ComplaintForm : Form
    {
        private Form go_back_form;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[10];

        public ComplaintForm(Form go_back_form)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            all_controls = new Control[10] { panel1, lblComplaintsTitle, btnBack, lblComplaints, gbComplaintType, rbHouseIssue, rbRoommateIssue, lblComplaintDescription, tbComplaint, btnSubmitComplaint };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            if (!rbHouseIssue.Checked && !rbRoommateIssue.Checked)
                MessageBox.Show("You have to choose complaint type");
            else
            {
                bool[] arr1 = new bool[2] { rbHouseIssue.Checked, rbRoommateIssue.Checked };
                ComplaintType complaint = (ComplaintType)(Array.IndexOf(arr1, true));
                string description = tbComplaint.Text;

                try 
                {
                    MainPageForm.complaintManager.AddComplaint(DateTime.Now, complaint, description);

                    rbHouseIssue.Checked = false;
                    rbRoommateIssue.Checked = false;
                    tbComplaint.Text = string.Empty;
                    MessageBox.Show("Successfully created");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }
    }
}
