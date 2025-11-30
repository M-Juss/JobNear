using System.Windows.Forms;

namespace JobNear.Controller
{
    public class FormsController
    {
        public static void FormLoad(Form form, Panel app_panel)
        {
            app_panel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            app_panel.Controls.Add(form);
            form.Show();
        }
    }
}
