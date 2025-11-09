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

            // To-do November 4, 2025:
            // [/] Back Navigation when viewing job poster registered business in Admin Form
            // [/] Back Navigation when viewing posts job of a specific registered business in Admin Form
            // [/] Back Navigation when editing registered business in Job Poster Form 
            // [/] Put Status label and edit button in each post jobs in Job Poster Form

            // To-do November 5, 2025:
            // [/] Posts Jobs edit button function
            // [/] Add Update Functionality

            // To-do November 10, 2025
            // [] add functionality to submit review in Admin form
        }
    }
}