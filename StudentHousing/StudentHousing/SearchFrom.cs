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
    public partial class SearchForm : Form
    {
        private MainPageForm go_back_form;
        private EditProfile edit_profile;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[11];
        public SearchForm(MainPageForm go_back_form)
        {
            InitializeComponent();
            this.go_back_form = go_back_form;
            all_controls = new Control[11] { panel1, lblSearchTitle, btnBack, gbSearchBy, rbStudentName, rbStudentEmail, rbStudentRoomNr, tbSearchText, btnSearchStudents, lbAllStudents, btnShowStudents };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
            ShowStudentArray(MainPageForm.studentManager.GetStudents());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            if (!rbStudentEmail.Checked && !rbStudentName.Checked && !rbStudentRoomNr.Checked)
                MessageBox.Show("You havent chosen, what to search by");
            else if (tbSearchText.Text == string.Empty)
                MessageBox.Show("You haven't entered query");
            else
            {
                Student[] found_students = null;
                bool[] arr1 = new bool[3] { rbStudentEmail.Checked, rbStudentName.Checked, rbStudentRoomNr.Checked };
                switch (Array.IndexOf(arr1, true))
                {
                    case 0:
                        found_students = MainPageForm.studentManager.SearchManyByEmail(tbSearchText.Text);
                        break;
                    case 1:
                        found_students = MainPageForm.studentManager.SearchByName(tbSearchText.Text);
                        break;
                    case 2:
                        try
                        {
                            int number = Convert.ToInt32(tbSearchText.Text);
                            found_students = MainPageForm.studentManager.SearchByRoom(number);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                }
                if (found_students != null)
                    ShowStudentArray(found_students);
            }
        }

        public void ShowStudentArray(Student[] students)
        {
            lbAllStudents.Items.Clear();
            foreach (Student student in students)
                lbAllStudents.Items.Add(student.GetListBoxDescription());
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            ShowStudentArray(MainPageForm.studentManager.GetStudents());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, go_back_form);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void lbAllStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllStudents.SelectedIndex != -1)
            {
                Student current_student = null;
                foreach (Student student in MainPageForm.studentManager.GetStudents())
                {
                    if (student.GetListBoxDescription() == lbAllStudents.SelectedItem.ToString())
                    {
                        current_student = student;
                        break;
                    }
                }
                if (current_student != null)
                {
                    edit_profile = new EditProfile(this, current_student.Email);
                    edit_profile.PrepareForView();
                    MainPageForm.GoToOtherForm(this, edit_profile);
                }

            }
        }
    }
}
