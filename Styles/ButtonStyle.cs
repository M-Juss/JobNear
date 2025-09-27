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


        public static void SidebarButton(Button btn, string hexColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ColorTranslator.FromHtml(hexColor);
            btn.ForeColor = Color.White;
            btn.Font = new Font("Poppins", 11, FontStyle.Bold);
            btn.Height = 45;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(ColorTranslator.FromHtml(hexColor), 0.2f);
        }

        public static void MakeRoundedPanel(Panel panel, int radius, Color backColor, Color shadowColor = default)
        {
            if (shadowColor == default) shadowColor = Color.FromArgb(50, Color.Black); // default thin shadow

            panel.BorderStyle = BorderStyle.None;
            panel.BackColor = Color.Transparent;
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = panel.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                // Shadow rectangle (draw slightly offset without clipping it)
                Rectangle shadowRect = new Rectangle(rect.X + 4, rect.Y + 4, rect.Width, rect.Height);

                using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, radius))
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }

                // Main rounded panel
                using (GraphicsPath path = GetRoundedPath(rect, radius))
                using (SolidBrush brush = new SolidBrush(backColor))
                {
                    panel.Region = new Region(path);
                    e.Graphics.FillPath(brush, path);
                }
            };
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curve = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curve, curve, 180, 90);
            path.AddArc(rect.Right - curve, rect.Y, curve, curve, 270, 90);
            path.AddArc(rect.Right - curve, rect.Bottom - curve, curve, curve, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curve, curve, curve, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
