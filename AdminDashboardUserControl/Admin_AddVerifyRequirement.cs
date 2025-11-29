using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_AddVerifyRequirement : UserControl
    {
        public Admin_AddVerifyRequirement()
        {
            InitializeComponent();
            TextboxStyles.RoundedTextBoxShadow(name_input, 10, "#FFFFFF", 1);
            TextboxStyles.RoundedTextBoxShadow(description_input, 10, "#FFFFFF", 1);
            PanelStyles.RoundedPanel(req_panel, 20, Color.White);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Admin_VerifyRequirement admin_VerifyRequirement = new Admin_VerifyRequirement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(admin_VerifyRequirement);
            admin_VerifyRequirement.Dock = DockStyle.Fill;
        }

        private void attach_file_Click(object sender, EventArgs e)
        {
            if (image_flowlayout.Controls.Count > 1) { 
                MessageBox.Show("You can only attach one file at a time.", "Attachment Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);

                    string savePath = Path.Combine(Application.StartupPath, "SupportingDocs");
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    string destPath = Path.Combine(savePath, fileName);
                    File.Copy(filePath, destPath, true);

                    FlowLayoutStyles.AddFileItem(destPath, image_flowlayout, image_flowlayout.Width - 20);
                }
            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_input.Text) ||
                string.IsNullOrWhiteSpace(description_input.Text) ||
                requirement_combo.SelectedItem == null ||
                user_combo.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<SupportingDocument> supportingDocuments = new List<SupportingDocument>();

            foreach (Control ctrl in image_flowlayout.Controls)
            {
                if (ctrl is Panel panel)
                {
                    if (panel.Tag is SupportingDocument existingDoc)
                    {
                        supportingDocuments.Add(existingDoc);
                    }
                    else if (panel.Tag is string filePath && File.Exists(filePath))
                    {
                        supportingDocuments.Add(new SupportingDocument
                        {
                            FileName = Path.GetFileName(filePath),
                            FileContent = File.ReadAllBytes(filePath)
                        });
                    }
                }
            }

            bool result = await MongoDbServices.InsertVerificationRequirement(
                name_input.Text.Trim(),
                description_input.Text.Trim(),
                requirement_combo.SelectedItem.ToString(),
                user_combo.SelectedItem.ToString(),
                supportingDocuments);

            if (result)
            {
                MessageBox.Show("Verification requirement added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_VerifyRequirement admin_VerifyRequirement = new Admin_VerifyRequirement();
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(admin_VerifyRequirement);
                admin_VerifyRequirement.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Failed to add verification requirement. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
