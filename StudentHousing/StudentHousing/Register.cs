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
    public partial class Register : Form
    {

        private MainPageForm mainPageForm;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[14];
        private bool isPasswordVisible = false;

        public Register()
        {
            InitializeComponent();
            all_controls = new Control[14] { panel1, lblRegister, btnBack2, lblRegisterText, lblRegisterName, tbRegisterName, lblRegisterEmail, tbRegisterEmail, lblRegisterRoomNr, tbRegisterRoomNr, lblRegisterPassword, tbRegisterPassword, pbxEye, btnCreateAccount };
            for (int i = 0; i < all_controls.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string name = this.tbRegisterName.Text;
            string email = this.tbRegisterEmail.Text;
            string password = this.tbRegisterPassword.Text;

            try
            {
                int roomNumber = int.Parse(this.tbRegisterRoomNr.Text);
                MainPageForm.studentManager.RegisterStudent(name, roomNumber, email, password);
                this.mainPageForm = new MainPageForm(tbRegisterEmail.Text);
                this.mainPageForm.UpdateAnnouncementsBox();
                MainPageForm.GoToOtherForm(this, mainPageForm);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Start());
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void pbxEye_Click(object sender, EventArgs e)
        {
            this.tbRegisterPassword.UseSystemPasswordChar = isPasswordVisible;
            this.isPasswordVisible = !isPasswordVisible;
        }
    }
}
