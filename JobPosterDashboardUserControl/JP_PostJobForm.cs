using JobNear.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_PostJobForm : UserControl
    {
        private JobPosterDashboardForm JP_parent_form;
        private String job_title, job_address, employment_type, work_model, minimum_qualifications, 
                        preferred_qualifications, about_job, responsibilities;

        private void clear_draft_button_Click(object sender, EventArgs e)
        {
            job_title_textbox.Clear();
            job_address_textbox.Clear();
            part_time_checkbox.Checked = false;
            full_time_checkbox.Checked = false;
            fully_remote_radiobtn.Checked = false;
            fully_office_radiobtn.Checked = false;
            hybrid_radiobtn.Checked = false;
            min_qualification_richbox.Clear();
            pref_qualification_richbox.Clear();
            about_job_richbox.Clear();
            responsibilities_richbox.Clear();
        }

        private void post_button_Click(object sender, EventArgs e)
        {
            job_title = job_title_textbox.Text.ToString();
            job_address = job_address_textbox.Text.ToString();
            minimum_qualifications = min_qualification_richbox.Text.ToString();
            preferred_qualifications = pref_qualification_richbox.Text.ToString();
            about_job = about_job_richbox.Text.ToString() ;
            responsibilities = responsibilities_richbox.Text.ToString();

            if (full_time_checkbox.Checked && part_time_checkbox.Checked)
            {
                employment_type = "Full-time | Part-time";
            }
            else if (part_time_checkbox.Checked && !full_time_checkbox.Checked)
            {
                employment_type = part_time_checkbox.Text.ToString();
            }
            else if (full_time_checkbox.Checked && !part_time_checkbox.Checked)
            {
                employment_type = full_time_checkbox.Text.ToString();
            }
            

            if (fully_remote_radiobtn.Checked)
            {
                fully_office_radiobtn.Checked = false;
                hybrid_radiobtn.Checked = false;
                work_model = fully_remote_radiobtn.Text;
            }
            else if (fully_office_radiobtn.Checked)
            {
                fully_remote_radiobtn.Checked = false;
                hybrid_radiobtn.Checked = false;
                work_model = fully_office_radiobtn.Text;
            }
            else if (hybrid_radiobtn.Checked)
            {
                fully_office_radiobtn.Checked = false;
                fully_remote_radiobtn.Checked = false;
                work_model = hybrid_radiobtn.Text;
            }

            Console.WriteLine("Job Title: " + job_title + "\n" +
                "Job Address: " + job_address + "\n" +
                "Employment Type: " + employment_type + "\n" +
                "Work Model: " + work_model + "\n" +
                "Minimum Qualifications: " + minimum_qualifications + "\n" +
                "Preferred Qualifications: " + preferred_qualifications + "\n" +
                "About the Job: " + about_job + "\n" +
                "Responsibilities: " + responsibilities);
        }

        public JP_PostJobForm(Forms.JobPosterDashboardForm parent_form)
        {
            InitializeComponent();
            JP_parent_form = parent_form;
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            JP_parent_form.ShowPanel(JP_parent_form.business_details_panel);
        }
    }
}
