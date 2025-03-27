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
    public partial class Login : Form
    {
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[9];
        private bool isPasswordVisible = false;

        public Login()
        {
            InitializeComponent();
            all_controls = new Control[9] { panel1, lblLoginPage, btnBack1, lblLoginEmail, tbLoginEmail, lblLoginPassword, tbLoginPassword, pbxEye, btnLogin };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.tbLoginEmail.Text;
            string password = this.tbLoginPassword.Text;

            Student studentLogin = MainPageForm.studentManager.LoginStudent(email, password);

            if (studentLogin != null)
            {
                MainPageForm mainPage = new MainPageForm(studentLogin.Email);
                mainPage.UpdateAnnouncementsBox();
                MainPageForm.GoToOtherForm(this, mainPage);
            }
            else
            {
                MessageBox.Show("Please enter valid credentials");
            }

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Start());
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            this.tbLoginPassword.UseSystemPasswordChar = isPasswordVisible;
            this.isPasswordVisible = !isPasswordVisible;
        }
    }
}
