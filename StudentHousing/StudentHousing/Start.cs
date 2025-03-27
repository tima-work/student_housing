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
    public partial class Start : Form
    {
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[6];
        public Start()
        {
            InitializeComponent();
            this.all_controls = new Control[6] { panel1, lblWelcome, btnRegister, btnLogin, btnGuest, btnAdmin };
            for (int i = 0; i < all_controls.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ThisWindowResize;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Register());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Login());
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Guest());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Admin());
        }

        private void ThisWindowResize(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }
    }
}
