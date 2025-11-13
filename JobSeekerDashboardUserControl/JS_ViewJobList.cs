using JobNear.Controllers;
using JobNear.Models;
using JobNear.Services; 
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_ViewJobList : UserControl
    {
        public JS_ViewJobList(string id)
        {
            InitializeComponent();
            PanelStyles.RoundedPanel(business_panel, 20, Color.White);
            PanelStyles.RoundedPanel(job_panel, 20, Color.White);
            LoadJobDetails(id);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)  
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public async void LoadJobDetails(string jobId)
        {
            var job = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == jobId)
                .FirstOrDefaultAsync();

            if (job != null) { 
                jobtitle_label.Text = job.JobPosition;
                jobinfo_label.Text = $"{job.JobWorkModel} | {job.JobEmploymentType}" ;
                about_label.Text = job.JobAbout;
                responsibilities_label.Text = job.JobResponsibilities;
                preffered_label.Text = job.JobPreferredQualification;
                minimum_label.Text = job.JobMinimumQualification;
                status_label.Text = job.JobStatus;

                if (job.JobHourlyRate == 0) {
                    rate_label.Text = $"Monthly Salary: ₱{job.JobMonthlyRate}";
                } else rate_label.Text = $"Hourly Rate: ₱{job.JobHourlyRate}";

                UserController.SetJobPostStatus(status_label, job.JobStatus);

                

            }
        }
    }
}
