using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear
{
    public partial class JobPosterSignupForm : Form
    {
        public JobPosterSignupForm()
        {
            InitializeComponent();
            int radius = 40; // corner radius
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(register_btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(register_btn.Width - radius, register_btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, register_btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            register_btn.Region = new Region(path);

            register_btn.BackColor = ColorTranslator.FromHtml("#10B981"); // Orange-ish
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#10B981");



        }

        private void JobPosterSignupForm_Load(object sender, EventArgs e)
        {

        }

    }
}
