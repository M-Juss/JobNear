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

        public JP_PostJobForm(string businessSelected, Panel sidebar_panel)
        {
            InitializeComponent();
            payment_combo.Text = "Select Payment Type";
            paymenttype_label.Text = "";
        
        }

        private void payment_combo_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void post_button_Click_1(object sender, EventArgs e)
        {
            // --- Basic Validation ---
            if (string.IsNullOrEmpty(title_input.Text) || string.IsNullOrEmpty(address_input.Text) ||
                string.IsNullOrEmpty(min_qualification_richbox.Text) || string.IsNullOrEmpty(about_job_richbox.Text) ||
                string.IsNullOrEmpty(responsibilities_richbox.Text) || string.IsNullOrEmpty(preferred_qualification_richbox.Text) ||
                string.IsNullOrEmpty(payment_combo.Text))
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

            // --- Payment Type ---
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

            // --- Employment Type ---
            string employment_type = "";
            if (full_time_checkbox.Checked) employment_type += full_time_checkbox.Text;
            if (part_time_checkbox.Checked)
            {
                if (!string.IsNullOrEmpty(employment_type)) employment_type += " | ";
                employment_type += part_time_checkbox.Text;
            }

            // --- Work Model ---
            string work_model = "";
            if (fully_office_radiobtn.Checked) work_model = "Fully Office";
            else if (fully_remote_radiobtn.Checked) work_model = "Fully Remote";
            else if (hybrid_radiobtn.Checked) work_model = "Hybrid";

            // --- Example Output ---
            MessageBox.Show($"Payment: {payment}\nEmployment Type: {employment_type}\nWork Model: {work_model}",
                            "Job Posted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
