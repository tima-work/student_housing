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
    public partial class Preview : Form
    {
        Form ap;
        private Control[] all_controls;
        private ResizeClass[] all_resizes = new ResizeClass[2];
        public Preview(Form ap, Image image)
        {
            InitializeComponent();
            all_controls = new Control[2] { pictureBox1, btnBack };
            for (int i = 0; i < all_resizes.Length; i++)
                all_resizes[i] = new ResizeClass(all_controls[i], all_controls[i].Parent);
            this.Resize += ResizeThisWindow;
            this.UpdatePicture(image);
            this.ap = ap;
        }

        public void UpdatePicture(Image image)
        {
            pictureBox1.Image = image;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainPageForm.GoToOtherForm(this, ap);
        }

        private void ResizeThisWindow(object sender, EventArgs e)
        {
            MainPageForm.ResizeSmth(all_resizes);
        }
    }
}
