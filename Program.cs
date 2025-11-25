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
            // [/] add functionality to submit review in Admin form

            // To-do November 11, 2025
            // [/] Business Marker clik in Job Browse shoudl show the Business Info and Active Posted Jobs of a specific of business
            // [/] Make a template form of the Posted Active Job for the seeker to see

            // To-do November 14, 2025
            // [/] Back naviagtion when clicking specific joblist in JobList side button
            // [/] Back Navigation when clicking business in Joob Browse, Panel should go back to the map
            // [/] Back Navigation whcn click specific business inthe the business details in Job Browse 
            // [/] Map can now naviage base on radius 

            // To-do November 21, 2025
            // [/] Update Function in RegisterBusinessForm

            // To-do November 25, 2025
            // [] if Report  status is Resolved, send notif to the jobposter about the closing of their business 
            // [] if Report Statis is Closed , send notif to the jobposter about the report attempt and notif to the jobseekr about their closing of their report
            // [] Closed Business the business is not visible in the Job Browse Map and Job List Job posts are on Review and it cant be updated anymore
            // [] Dashboard Analytics for Admin Form

            // after seekr submit a repot it will notify the jp
            // valid / invalid 
            // valid > send notif to jp give warning count. on the third warnign business will terminate > send nur report has benn taken an action
            // invalid > send notif to seeker

        }
    }
}