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
    public class PanelStyles
    {

        public static void RoundedPanel(Panel panel, int radius, Color backColor, Color shadowColor = default)
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
