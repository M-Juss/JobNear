using System.Drawing;
using System.Drawing.Drawing2D;
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

        public static void StyleRoundedLabel(Label lbl, int radius = 10, Color? backColor = null, Color? foreColor = null)
        {
            lbl.AutoSize = false;
            lbl.TextAlign = ContentAlignment.MiddleCenter;

            // Set colors
            lbl.BackColor = Color.Transparent; // important so background doesn't override custom draw
            lbl.ForeColor = foreColor ?? Color.White;
            Color fillColor = backColor ?? Color.LightGray;

            lbl.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle rect = new Rectangle(0, 0, lbl.Width - 1, lbl.Height - 1);

                using (GraphicsPath path = GetRoundedPath(rect, radius))
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Draw text
                TextRenderer.DrawText(e.Graphics, lbl.Text, lbl.Font, rect, lbl.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };

            lbl.Invalidate(); // force redraw
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
