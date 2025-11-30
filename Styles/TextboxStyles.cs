using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public class TextboxStyles
    {
        public static void RoundedTextBoxShadow(TextBox txt, int radius, string bgHex, int shadowSize)
        {
            Control parent = txt.Parent;

            Panel shadow = new Panel();
            shadow.BackColor = Color.Transparent;
            shadow.Size = new Size(txt.Width + shadowSize * 2, txt.Height + shadowSize * 2);
            shadow.Location = new Point(txt.Left - shadowSize, txt.Top - shadowSize);

            shadow.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                for (int i = shadowSize; i > 0; i--)
                {
                    int alpha = (int)(20 * (i / (float)shadowSize));
                    using (Pen p = new Pen(Color.FromArgb(alpha, 0, 0, 0), i * 2))
                    {
                        g.DrawPath(p, Rounded(shadow.Width - i, shadow.Height - i, radius + i));
                    }
                }
            };


            Panel container = new Panel();
            container.Size = txt.Size;
            container.Location = txt.Location;
            container.BackColor = ColorTranslator.FromHtml(bgHex);

            container.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                container.Region = new Region(Rounded(container.Width, container.Height, radius));
            };


            txt.BorderStyle = BorderStyle.None;
            txt.Location = new Point(12, 8);
            txt.Width = container.Width - 24;


            parent.Controls.Add(shadow);
            parent.Controls.Add(container);
            container.Controls.Add(txt);

            shadow.SendToBack();
            container.BringToFront();
            txt.BringToFront();
        }

        public static void RoundedPasswordBox(TextBox txt, int radius, string bgHex, int shadowSize, int height = 40)
        {
            Control parent = txt.Parent;

            txt.Multiline = false;


            bool mask = txt.UseSystemPasswordChar;
            char maskChar = txt.PasswordChar;


            Panel shadow = new Panel();
            shadow.BackColor = Color.Transparent;
            shadow.Size = new Size(txt.Width + shadowSize * 2, height + shadowSize * 2);
            shadow.Location = new Point(txt.Left - shadowSize, txt.Top - shadowSize);

            shadow.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                for (int i = shadowSize; i > 0; i--)
                {
                    int alpha = (int)(20 * (i / (float)shadowSize));
                    using (Pen p = new Pen(Color.FromArgb(alpha, 0, 0, 0), i * 2))
                    {
                        g.DrawPath(p, Rounded(shadow.Width - i, shadow.Height - i, radius + i));
                    }
                }
            };


            Panel container = new Panel();
            container.Size = new Size(txt.Width, height);
            container.Location = txt.Location;
            container.BackColor = ColorTranslator.FromHtml(bgHex);

            container.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                container.Region = new Region(Rounded(container.Width, container.Height, radius));
            };

            txt.BorderStyle = BorderStyle.None;
            txt.Location = new Point(12, (container.Height - txt.Height) / 2);
            txt.Width = container.Width - 24;


            parent.Controls.Add(shadow);
            parent.Controls.Add(container);
            container.Controls.Add(txt);

            shadow.SendToBack();
            txt.BringToFront();


            txt.UseSystemPasswordChar = mask;
            txt.PasswordChar = maskChar;
        }

        private static GraphicsPath Rounded(int w, int h, int r)
        {
            GraphicsPath path = new GraphicsPath();
            int d = r * 2;

            path.StartFigure();
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(w - d, 0, d, d, 270, 90);
            path.AddArc(w - d, h - d, d, d, 0, 90);
            path.AddArc(0, h - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
