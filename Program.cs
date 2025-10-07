using JobNear.Forms;
using System;
using System.Windows.Forms;

namespace JobNear
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JobNearUserForm());
        }
    }
}