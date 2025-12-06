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


            // System Addition 
            // [] Add field in JobPost on how many are they looking for
            // [] JobPost should be verifeid first by admin
            // [] Active Jobs in Seekers POV must have apply button. After clicking apply button attach their resume and some description.
            // Then wait for the notification if they are hired or not
            // [] Basis on about the user report.
        }
    }
}