using JobNear.Forms;
using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace JobNear.JobPosterDashboardUserControl
{
    public partial class JP_PostJobForm : UserControl
    {

        public JP_PostJobForm(string businessSelected)
        {
            InitializeComponent();
            payment_combo.Text = "Select Payment Type";
            paymenttype_label.Text = "";
            TextBoxValidatorController.AllowOnlyNumbers(hourly_input);
            TextBoxValidatorController.AllowOnlyNumbers(monthly_input);
            PanelStyles.RoundedPanel(job_panel, 10, Color.White);

            ButtonStyle.RoundedButton(post_button, 10, "#10B981");
            ButtonStyle.RoundedButton(cancel_button, 10, "#495057");

        }

        public  JP_PostJobForm(string mode, string id)
        {
            InitializeComponent();
            payment_combo.Text = "Select Payment Type";

            LoadPostedJobDetails(id);

            TextBoxValidatorController.AllowOnlyNumbers(hourly_input);
            TextBoxValidatorController.AllowOnlyNumbers(monthly_input);
            PanelStyles.RoundedPanel(job_panel, 10, Color.White);
            ButtonStyle.RoundedButton(post_button, 10, "#10B981");
            ButtonStyle.RoundedButton(cancel_button, 10, "#495057");
        }


        public async void LoadPostedJobDetails(string jobId)
        {
            var jobDetails = await MongoDbServices.JobPosterJobPosting
                .Find(x => x.Id == jobId)
                .FirstOrDefaultAsync();

            if (jobDetails != null)
            {
                title_input.Text = jobDetails.JobPosition;
                min_qualification_richbox.Text = jobDetails.JobMinimumQualification;
                preferred_qualification_richbox.Text = jobDetails.JobPreferredQualification;
                about_job_richbox.Text = jobDetails.JobAbout;
                responsibilities_richbox.Text = jobDetails.JobResponsibilities;
                payment_combo.Text = jobDetails.JobPaymentType;
                if (jobDetails.JobPaymentType == "Monthly Salary")
                {
                    payment_combo.SelectedIndex = 0;
                }
                else if (jobDetails.JobPaymentType == "Hourly Salary")
                {
                    payment_combo.SelectedIndex = 1;
                }
                status_combo.Text = jobDetails.JobStatus;
                if (jobDetails.JobEmploymentType.Contains("Full-Time"))
                    full_time_checkbox.Checked = true;
                if (jobDetails.JobEmploymentType.Contains("Part-Time"))
                    part_time_checkbox.Checked = true;
                if (jobDetails.JobWorkModel == "Fully Office")
                    fully_office_radiobtn.Checked = true;
                else if (jobDetails.JobWorkModel == "Fully Remote")
                    fully_remote_radiobtn.Checked = true;
                else if (jobDetails.JobWorkModel == "Hybrid")
                    hybrid_radiobtn.Checked = true;
                if (jobDetails.JobPaymentType == "Monthly Salary")
                {
                    paymenttype_label.Text = "Salary Per Month";
                    monthly_input.Text = jobDetails.JobMonthlyRate.ToString();
                    monthly_input.Visible = true;
                    hourly_input.Visible = false;
                }
                else if (jobDetails.JobPaymentType == "Hourly Salary")
                {
                    paymenttype_label.Text = "Rate Per Hour";
                    hourly_input.Text = jobDetails.JobHourlyRate.ToString();
                    hourly_input.Visible = true;
                    monthly_input.Visible = false;
                }
            }
        }
        private async void post_button_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(title_input.Text) || string.IsNullOrEmpty(min_qualification_richbox.Text) || 
                string.IsNullOrEmpty(about_job_richbox.Text) ||string.IsNullOrEmpty(responsibilities_richbox.Text) ||
                string.IsNullOrEmpty(preferred_qualification_richbox.Text) ||string.IsNullOrEmpty(payment_combo.Text) || string.IsNullOrEmpty(status_combo.Text))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!part_time_checkbox.Checked && !full_time_checkbox.Checked)
            {
                MessageBox.Show("Please select at least one employment type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!fully_remote_radiobtn.Checked && !fully_office_radiobtn.Checked && !hybrid_radiobtn.Checked)
            {
                MessageBox.Show("Please select a work model", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string payment = "";
            if (payment_combo.SelectedIndex == 0)
                payment = "Monthly Salary";
            else if (payment_combo.SelectedIndex == 1)
                payment = "Hourly Salary";
            else
            {
                MessageBox.Show("Please select a valid payment type", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string employment_type = "";
            if (full_time_checkbox.Checked) employment_type += full_time_checkbox.Text;
            if (part_time_checkbox.Checked)
            {
                if (!string.IsNullOrEmpty(employment_type)) employment_type += " | ";
                employment_type += part_time_checkbox.Text;
            }

            string work_model = "";
            if (fully_office_radiobtn.Checked) work_model = "Fully Office";
            else if (fully_remote_radiobtn.Checked) work_model = "Fully Remote";
            else if (hybrid_radiobtn.Checked) work_model = "Hybrid";


            try {
                string position = title_input.Text.Trim();
                string emptype = employment_type.Trim();
                string workmodel = work_model.Trim();
                string minqualification = min_qualification_richbox.Text.Trim();
                string preferredqualification = preferred_qualification_richbox.Text.Trim();
                string aboutjob = about_job_richbox.Text.Trim();
                string responsibilities = responsibilities_richbox.Text.Trim();
                string paytype = payment.Trim();
                double monthlysalary = monthly_input.Visible ? Convert.ToDouble(monthly_input.Text.Trim()) : 0;
                double hourlyrate = hourly_input.Visible ? Convert.ToDouble(hourly_input.Text.Trim()) : 0;
                string stat = status_combo.SelectedItem.ToString();

                var getBusinessAddress = await MongoDbServices.JobPosterBusiness
                    .Find(x => x.Id == Session.CurrentBusinessSelected)
                    .FirstOrDefaultAsync();

                if (Session.CurrentPostJobFormMode == "insert")
                {
                    bool response = await MongoDbServices.InsertJobPostingAsync(
                    Session.CurrentBusinessSelected,
                    getBusinessAddress.BusinessAddress,
                    position,
                    emptype,
                    workmodel,
                    minqualification,
                    preferredqualification,
                    aboutjob,
                    responsibilities,
                    paytype,
                    monthlysalary,
                    hourlyrate,
                    stat
                    );


                    if (response)
                    {
                            string result = MessageBox.Show("Job posted successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            ).ToString();

                            if (result == "OK")
                            {
                                sidebar_panel.Controls.Clear();
                                JP_BusinessDetails profile = new JP_BusinessDetails(Session.CurrentBusinessSelected);
                                profile.Dock = DockStyle.Fill;
                                sidebar_panel.Controls.Add(profile);
                            }
                    }
                    else
                    {
                      MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (Session.CurrentPostJobFormMode == "edit") {

                    bool response = await MongoDbServices.UpdatePostedJobAsync(
                        Session.CurrentPostedJobSelected,
                        position,
                        emptype,
                        workmodel,
                        minqualification,
                        preferredqualification,
                        aboutjob,
                        responsibilities,
                        paytype,
                        monthlysalary,
                        hourlyrate,
                        stat
                        );

                    if (response)
                    {
                        string result = MessageBox.Show("Job updated successfully!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                ).ToString();

                         if (result == "OK")
                         {
                            sidebar_panel.Controls.Clear();
                            JP_BusinessDetails profile = new JP_BusinessDetails(Session.CurrentBusinessSelected);
                            profile.Dock = DockStyle.Fill;
                            sidebar_panel.Controls.Add(profile);
                         }
                    }
                    else
                    {
                       MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception ex) {
                MessageBox.Show("An error occurred while posting the job: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void payment_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (payment_combo.SelectedIndex == 0)
            {
                paymenttype_label.Text = "Salary Per Month";
                monthly_input.Visible = true;
                hourly_input.Visible = false;
            }
            else if (payment_combo.SelectedIndex == 1)
            {
                paymenttype_label.Text = "Rate Per Hour"; 
                hourly_input.Visible = true;
                monthly_input.Visible = false;

            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            JobPosterDashboardUserControl.JP_BusinessDetails jp_businessDetails = new JobPosterDashboardUserControl.JP_BusinessDetails(Session.CurrentBusinessSelected);
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(jp_businessDetails);
            sidebar_panel.Dock = DockStyle.Fill;
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymenttype_label_Click(object sender, EventArgs e)
        {

        }

        private void hourly_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void status_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
