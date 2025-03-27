using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class ResizeClass
    {
        private Control widget;
        private Control parent;
        private float[] originalParentSize;
        private float[] originalWidgetSize;
        private string original_font;
        private FontStyle original_font_style;
        public ResizeClass(Control widget, Control parent)
        {
            this.widget = widget;
            this.parent = parent;
            originalParentSize = new float[4] { this.parent.Location.X, this.parent.Location.Y, this.parent.Size.Width, this.parent.Size.Height };
            originalWidgetSize = new float[5] { this.widget.Location.X, this.widget.Location.Y, this.widget.Size.Width, this.widget.Size.Height, this.widget.Font.Size };
            original_font = this.widget.Font.FontFamily.Name;
            original_font_style = this.widget.Font.Style;
        }

        public void ResizeWidget()
        {
            float xRatio = (float)(this.parent.Size.Width / this.originalParentSize[2]);
            float yRatio = (float)(this.parent.Size.Height / this.originalParentSize[3]);

            int newX = (int)(originalWidgetSize[0] * xRatio);
            int newY = (int)(originalWidgetSize[1] * yRatio);

            int newWidth = (int)(originalWidgetSize[2] * xRatio);
            int newHeight = (int)(originalWidgetSize[3] * yRatio);

            //float newFont = (float)(originalWidgetSize[4] * Math.Sqrt(xRatio));
            float newFont = (float)(originalWidgetSize[4] * xRatio);


            this.widget.Location = new Point(newX, newY);
            this.widget.Size = new Size(newWidth, newHeight);
            this.widget.Font = new Font(original_font, newFont, original_font_style);
            //this.widget.Text += "R";
        }
    }
}
