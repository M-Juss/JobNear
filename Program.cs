using System;
using System.Windows.Forms;
using JobNear.Forms;
using JobNear.Services;

namespace JobNear
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "mongodb+srv://jusssayson:12345@projectexercises.luow6uq.mongodb.net/";
            string databaseName = "JobNearDB";
            string collectionName = "SampleCollection";

            var mongoService = new MongoDbServices(connectionString, databaseName);

            try
            {
                // Run async code in sync Main
                mongoService.CheckConnectionAsync().GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JobSeekerDashboardForm());
        }
    }
}
