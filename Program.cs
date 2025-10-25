using JobNear.Forms;
using JobNear.Models;
using JobNear.Services;
using MongoDB.Driver;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // October 25, 2025
            // [/] Insert RegisterBusiness
            // [] May business details dynamic
            // [] Insert PostJob
        }
    }
}