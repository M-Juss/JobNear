using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace JobNear.Styles
{
    public class ButtonStyle
    {
        // Track currently selected sidebar button
        private static Button selectedSidebarButton = null;

        // ============================================================
        // Rounded Button
        // ============================================================
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

        // ============================================================
        // Sidebar Button (with persistent white border on click)
        // ============================================================
        public static void SidebarButton(Button btn, string hexColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = ColorTranslator.FromHtml("#3B82F6");
            btn.ForeColor = Color.White;
            btn.Font = new Font("Poppins", 11, FontStyle.Bold);
            btn.Height = 45;
            btn.Cursor = Cursors.Hand;
            btn.Padding = new Padding(10, 0, 0, 0);
            btn.TextAlign = ContentAlignment.MiddleLeft;

            // Hover highlight
            btn.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(ColorTranslator.FromHtml(hexColor), 0.2f);

            // Add click event to apply selected border
            btn.Click += (s, e) =>
            {
                ApplySidebarSelected(btn);
            };
        }

        // ============================================================
        // Apply Selected Style (White Border)
        // ============================================================
        public static void ApplySidebarSelected(Button btn)
        {
            // Remove border from previously selected button
            if (selectedSidebarButton != null)
            {
                selectedSidebarButton.FlatAppearance.BorderSize = 0;
            }

            // Apply 2px white border to clicked button
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.WhiteSmoke;

            // Store selected button
            selectedSidebarButton = btn;
        }
    }
}
