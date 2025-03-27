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
    public partial class Guest : Form
    {
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[8];
        public Guest()
        {
            InitializeComponent();
            all_controls = new Control[8] { panel1, lblGuestPage, btnBack2, lblInfo, lblGallery, picBoxGallery, lblAppPreview, picBoxPreview };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Start());
        }

        private void picBoxGallery_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new Gallery());
        }

        private void picBoxPreview_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, new ApplicationPreview());
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Cozy Student House in Eindhoven! Our student house is the perfect blend of comfort and convenience. Spacious rooms, modern amenities, and a vibrant atmosphere. Located near campus and surrounded by student-friendly hotspots, you'll have everything you need at your doorstep. We have a unique application for our students that offers a great living experience and makes sharing the space a breeze.";
        }
    }
}
