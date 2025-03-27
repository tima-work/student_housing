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
    public partial class Gallery : Form
    {
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[9];
        public Gallery()
        {
            InitializeComponent();
            all_controls = new Control[9] { panel1, lblGallery, btnBack, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Guest());
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;
            Preview p = new Preview(this, image);
            p.Size = this.Size;
            p.Location = this.Location;
            p.ShowDialog();
        }
    }
}
