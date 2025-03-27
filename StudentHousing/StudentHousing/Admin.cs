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
    public partial class Admin : Form
    {
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[9];
        private bool isPasswordVisible = false;
        public Admin()
        {
            InitializeComponent();
            all_controls = new Control[9] { panel2, lblAdminLoginPage, btnBack4, lblAdminUsername, tbAdminUsername, lblAdminPassword, tbAdminPassword, pbxEye, btnAdminLogin };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = tbAdminUsername.Text;
            string password = tbAdminPassword.Text;

            if (username == "admin" && password == "TheSuperStrongAdminPassword")
            {
                MainPageForm mainPage = new MainPageForm("admin");
                mainPage.UpdateAnnouncementsBox();
                MainPageForm.GoToOtherForm(this, mainPage);
            }
            else
            {
                MessageBox.Show("Please enter valid credentials");
            }
        }

        private void btnBack4_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Start());
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            this.tbAdminPassword.UseSystemPasswordChar = isPasswordVisible;
            this.isPasswordVisible = !isPasswordVisible;
        }
    }
}
