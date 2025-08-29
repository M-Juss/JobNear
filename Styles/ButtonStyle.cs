using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public  class ButtonStyle
    {
        public static void RoundedButton(Button btn, int radius, string hexColor)
        {
            GraphicsPath path = new GraphicsPath();

            // Rounded corners
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Apply rounded region
            btn.Region = new Region(path);

            // Style
            btn.BackColor = ColorTranslator.FromHtml(hexColor);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(hexColor);
        }
    }
}
