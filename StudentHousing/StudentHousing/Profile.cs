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
    public partial class EditProfile : Form
    {
        private Form go_back_form;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[12];
        string current_user;

        public EditProfile(Form go_back_form, string current_user)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            this.current_user = current_user;
            all_controls = new Control[12] { panel1, lblProfile, btnBackToMain, lblChangeName, lblChangeEmail, lblChangeRoomNr, lblAddDescription, tbChangeName, tbChangeEmail, tbChangeRoomNr, tbDescription, btnSave };
            for (int i = 0; i < all_controls.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(tbChangeRoomNr.Text);
                MainPageForm.studentManager.ChangeStudentInfo(MainPageForm.studentManager.SearchByEmail(current_user), tbChangeName.Text, tbChangeEmail.Text, number, tbDescription.Text);
                MessageBox.Show("Changes saved succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*MessageBox.Show("Changes saved succesfully");

            this.go_back_form.Show();
            this.Close();*/
        }

        public void PrepareForEdit()
        {
            ShowStudentData();
            EnableTextBoxes(false);
            lblProfile.Text = "Edit profile";
            btnSave.Visible = true;
        }

        public void PrepareForView()
        {
            ShowStudentData();
            EnableTextBoxes(true);
            lblProfile.Text = "Profile";
            btnSave.Visible = false;
        }

        public void ShowStudentData()
        {
            Student student = MainPageForm.studentManager.SearchByEmail(current_user);
            tbChangeEmail.Text = student.Email;
            tbChangeName.Text = student.Name;
            tbChangeRoomNr.Text = student.RoomNumber.ToString();
            tbDescription.Text = student.Description;
        }

        public void EnableTextBoxes(bool enabled)
        {
            tbChangeEmail.ReadOnly = enabled;
            tbChangeName.ReadOnly = enabled;
            tbChangeRoomNr.ReadOnly = enabled;
            tbDescription.ReadOnly = enabled;
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }
    }
}
