
using JobNear.Controllers;
using JobNear.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using JobNear.Services;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using MongoDB.Driver;

namespace JobNear.Styles
{
    public class FlowLayoutStyles
    {
        public static void AddFileItem(string filePath, FlowLayoutPanel docu_flowlayout, int width)
        {
            Panel filePanel = new Panel();
            filePanel.Width = width;
            filePanel.Height = 50;
            filePanel.BackColor = Color.White;
            filePanel.Margin = new Padding(0, 0, 0, 2);
            filePanel.Padding = new Padding(10);
            filePanel.BorderStyle = BorderStyle.None;

            // ✅ Save filePath inside Tag so we can retrieve it later
            filePanel.Tag = filePath;

            filePanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, filePanel.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            PictureBox picIcon = new PictureBox();
            picIcon.Width = 30;
            picIcon.Height = 30;
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.Location = new Point(10, 10);

            try
            {
                Icon sysIcon = Icon.ExtractAssociatedIcon(filePath);
                picIcon.Image = sysIcon.ToBitmap();
            }
            catch
            {
                picIcon.Image = SystemIcons.Application.ToBitmap();
            }

            Label lbl = new Label();
            lbl.Text = Path.GetFileName(filePath);
            lbl.AutoSize = false;
            lbl.Width = 180;
            lbl.Height = 30;
            lbl.Location = new Point(70, 10);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Poppins", 12, FontStyle.Regular);
            lbl.ForeColor = Color.Black;

            Button btnPreview = new Button();
            btnPreview.Width = 30;
            btnPreview.Height = 30;
            btnPreview.Location = new Point(width - 105, 10);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.BackColor = Color.Transparent;
            btnPreview.Text = "👁";
            btnPreview.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnPreview.ForeColor = Color.DimGray;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Click += (s, e) =>
            {
                string fullPath = filePanel.Tag?.ToString(); // ✅ Use Tag
                if (File.Exists(fullPath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = fullPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("File not found!");
                }
            };

            Button btnDelete = new Button();
            btnDelete.Width = 30;
            btnDelete.Height = 30;
            btnDelete.Location = new Point(width - 65, 10);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Text = "🗑";
            btnDelete.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += (s, e) =>
            {
                string fullPath = filePanel.Tag?.ToString(); // ✅ Use Tag
                string fileName = Path.GetFileName(fullPath);

                var confirm = MessageBox.Show($"Delete {fileName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }
                    filePanel.Dispose();
                }
            };

            filePanel.Controls.Add(picIcon);
            filePanel.Controls.Add(lbl);
            filePanel.Controls.Add(btnPreview);
            filePanel.Controls.Add(btnDelete);

            docu_flowlayout.Controls.Add(filePanel);
        }

        public static void AddSupportingDocumentToFlow(SupportingDocument doc, FlowLayoutPanel docu_flowlayout, int width)
        {
            Panel filePanel = new Panel();
            filePanel.Width = width;
            filePanel.Height = 50;
            filePanel.BackColor = Color.White;
            filePanel.Margin = new Padding(0, 0, 0, 2);
            filePanel.Padding = new Padding(10);
            filePanel.BorderStyle = BorderStyle.None;

            filePanel.Tag = doc;

            filePanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, filePanel.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            PictureBox picIcon = new PictureBox();
            picIcon.Width = 30;
            picIcon.Height = 30;
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.Location = new Point(10, 10);

            try
            {
                string tempFile = Path.Combine(Path.GetTempPath(), doc.FileName);
                File.WriteAllBytes(tempFile, doc.FileContent);
                Icon sysIcon = Icon.ExtractAssociatedIcon(tempFile);
                picIcon.Image = sysIcon?.ToBitmap() ?? SystemIcons.Application.ToBitmap();
                File.Delete(tempFile);
            }
            catch
            {
                picIcon.Image = SystemIcons.Application.ToBitmap();
            }

            Label lbl = new Label();
            lbl.Text = doc.FileName;
            lbl.AutoSize = false;
            lbl.Width = 180;
            lbl.Height = 30;
            lbl.Location = new Point(70, 10);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Poppins", 12, FontStyle.Regular);
            lbl.ForeColor = Color.Black;

            Button btnPreview = new Button();
            btnPreview.Width = 30;
            btnPreview.Height = 30;
            btnPreview.Location = new Point(width - 105, 10);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.BackColor = Color.Transparent;
            btnPreview.Text = "👁";
            btnPreview.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnPreview.ForeColor = Color.DimGray;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Click += (s, e) =>
            {
                string tempPath = Path.Combine(Path.GetTempPath(), doc.FileName);
                File.WriteAllBytes(tempPath, doc.FileContent);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            };

            Button btnDelete = new Button();
            btnDelete.Width = 30;
            btnDelete.Height = 30;
            btnDelete.Location = new Point(width - 65, 10);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Text = "🗑";
            btnDelete.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += (s, e) =>
            {
                var confirm = MessageBox.Show($"Delete {doc.FileName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    filePanel.Dispose();
                }
            };

            filePanel.Controls.Add(picIcon);
            filePanel.Controls.Add(lbl);
            filePanel.Controls.Add(btnPreview);
            filePanel.Controls.Add(btnDelete);

            docu_flowlayout.Controls.Add(filePanel);
        }

        public static void AddMyBusiness(string businessSpecificId, string businessName, string businessDescription, string businessaddress, string businessStatus , FlowLayoutPanel file_flowlayout, Panel my_business_panel) {
            Panel businessPanel = new Panel();
            businessPanel.Height = 150;
            businessPanel.Width = file_flowlayout.Width - 20;
            businessPanel.Margin = new Padding(10, 10, 10, 10);
            businessPanel.BackColor = Color.WhiteSmoke;
            businessPanel.BorderStyle = BorderStyle.None;

            Label nameLabel = new Label();
            nameLabel.AutoSize = false;
            nameLabel.Text = businessName;
            nameLabel.Width = 550;
            nameLabel.Height = 50;
            nameLabel.AutoEllipsis = true;
            nameLabel.BorderStyle = BorderStyle.None;
            nameLabel.Location = new Point(40, 10);
            nameLabel.TextAlign = ContentAlignment.TopLeft;
            nameLabel.Font = new Font("Poppins", 22, FontStyle.Bold);
            nameLabel.ForeColor = Color.Black;


            Label statusLabel = new Label();
            statusLabel.AutoSize = true;
            statusLabel.AutoEllipsis = true;
            statusLabel.Height = 25;
            statusLabel.BorderStyle = BorderStyle.None;
            statusLabel.Location = new Point(800, 20);
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            statusLabel.Font = new Font("Poppins", 12, FontStyle.Bold);

            UserController.SetSeekerAndBusinesStatus(statusLabel, businessStatus);

            Label descriptionLabel = new Label();
            descriptionLabel.AutoSize = false;
            descriptionLabel.Text = $"{businessDescription}";
            descriptionLabel.Width = 700;
            descriptionLabel.Height = 55;
            descriptionLabel.BorderStyle = BorderStyle.None;
            descriptionLabel.Location = new Point(40, 57);
            descriptionLabel.TextAlign = ContentAlignment.TopLeft;
            descriptionLabel.Font = new Font("Poppins", 11, FontStyle.Regular);
            descriptionLabel.ForeColor = Color.Black;


            Label addresLabel = new Label();
            addresLabel.AutoSize = false;
            addresLabel.Text = businessaddress;
            addresLabel.Width = 605;
            addresLabel.Height = 20;
            addresLabel.BorderStyle = BorderStyle.None;
            addresLabel.Location = new Point(40, 120);
            addresLabel.TextAlign = ContentAlignment.MiddleLeft;
            addresLabel.Font = new Font("Poppins", 9, FontStyle.Regular);
            addresLabel.ForeColor = Color.Gray;

            businessPanel.Click +=  (s, e) =>
            {
                Session.CurrentBusinessSelected = businessSpecificId;

                if (Session.CurrentUserType == "admin")
                {
                    AdminDashboardUserControl.JP_ViewBusinessDetails businessDetails = new AdminDashboardUserControl.JP_ViewBusinessDetails(Session.CurrentBusinessSelected);
                    my_business_panel.Controls.Clear();
                    my_business_panel.Controls.Add(businessDetails);
                    businessDetails.Dock = DockStyle.Fill;
                }

                else {
                        JobPosterDashboardUserControl.JP_BusinessDetails jp_businessDeets = new JobPosterDashboardUserControl.JP_BusinessDetails(Session.CurrentBusinessSelected);
                        my_business_panel.Controls.Clear();
                        my_business_panel.Controls.Add(jp_businessDeets);
                        jp_businessDeets.Dock = DockStyle.Fill;

                }
            };

            businessPanel.Controls.Add(nameLabel);
            businessPanel.Controls.Add(addresLabel);
            businessPanel.Controls.Add(descriptionLabel);
            businessPanel.Controls.Add(statusLabel);

            PanelStyles.RoundedPanel(businessPanel, 20, Color.White);

            file_flowlayout.Controls.Add(businessPanel);
        }

        public static void AddPostJob(string job_id, string job_postion, string work_model, string employment_type, string job_description, string job_status, FlowLayoutPanel joblist_flowlayout, Panel sidebar_panel)
        {
            Panel postJobPanel = new Panel();
            postJobPanel.AutoSize = false;
            postJobPanel.Height = 150;
            postJobPanel.Width = 780;
            postJobPanel.Margin = new Padding(0, 10, 0, 10);
            postJobPanel.BackColor = Color.WhiteSmoke;
            postJobPanel.BorderStyle = BorderStyle.None;

            Label jobPosition = new Label();
            jobPosition.AutoSize = false;
            jobPosition.Text = job_postion;
            jobPosition.Width = 500;
            jobPosition.Height = 30;
            jobPosition.BorderStyle = BorderStyle.None;
            jobPosition.Location = new Point(40, 10);
            jobPosition.Font = new Font("Poppins", 16, FontStyle.Bold);
            jobPosition.ForeColor = Color.Black;

            Label jobStatus = new Label();
            jobStatus.AutoSize = false;
            jobStatus.Width = 100;
            jobStatus.Height = 25;
            jobStatus.BorderStyle = BorderStyle.None;
            jobStatus.Location = new Point(joblist_flowlayout.Width - 175, 14);
            jobStatus.TextAlign = ContentAlignment.MiddleCenter;
            jobStatus.Font = new Font("Poppins", 12, FontStyle.Bold);
            
            UserController.SetJobPostStatus(jobStatus, job_status);

            Label jobInfo= new Label();
            jobInfo.AutoSize = false;
            jobInfo.Text = $" {work_model} | {employment_type}";
            jobInfo.Width = 700;
            jobInfo.AutoEllipsis = true;
            jobInfo.BorderStyle = BorderStyle.None;
            jobInfo.Location = new Point(40, 40);
            jobInfo.Font = new Font("Poppins", 12, FontStyle.Regular);
            jobInfo.ForeColor = Color.Black;

            Label jobDescription = new Label();
            jobDescription.AutoSize = false;
            jobDescription.AutoEllipsis = true;
            jobDescription.Text = job_description;
            jobDescription.Width = 795;
            jobDescription.Height = 70;
            jobDescription.AutoEllipsis = true;
            jobDescription.BorderStyle = BorderStyle.None;
            jobDescription.TextAlign = ContentAlignment.TopLeft;
            jobDescription.Location = new Point(45, 70);
            jobDescription.Font = new Font("Poppins", 9, FontStyle.Regular);
            jobDescription.ForeColor = Color.Gray;

            Button jobEditPost = new Button();
            jobEditPost.Text = "Edit";
            jobEditPost.AutoSize = false;
            jobEditPost.Width = 55;
            jobEditPost.Height = 25;
            jobEditPost.TextAlign = ContentAlignment.TopCenter;
            jobEditPost.Location = new Point(joblist_flowlayout.Width - 250, 14);
            jobEditPost.Font = new Font("Poppins", 10, FontStyle.Bold);
            jobEditPost.ForeColor = Color.White;

            if (Session.CurrentUserType == "poster") {
                jobEditPost.Click += (s, e) =>
                {
                    string mode = "edit";
                    Session.CurrentPostJobFormMode = mode;
                    Session.CurrentPostedJobSelected = job_id;

                    Console.WriteLine(Session.CurrentPostedJobSelected);

                    JobPosterDashboardUserControl.JP_PostJobForm editJobForm = new JobPosterDashboardUserControl.JP_PostJobForm(mode, job_id);
                    sidebar_panel.Controls.Clear();
                    sidebar_panel.Controls.Add(editJobForm);
                    editJobForm.Dock = DockStyle.Fill;
                };
            } else jobEditPost.Visible = false;



            ButtonStyle.RoundedButton(jobEditPost, 5, "#3B82F6");
            PanelStyles.RoundedPanel(postJobPanel, 20, Color.White);
            
            postJobPanel.Controls.Add(jobPosition);
            postJobPanel.Controls.Add(jobInfo);
            postJobPanel.Controls.Add(jobDescription);
            postJobPanel.Controls.Add(jobStatus);
            postJobPanel.Controls.Add(jobEditPost);

            joblist_flowlayout.Controls.Add(postJobPanel);

        }

        public static void LoadActivePostedJob(string job_id, string job_postion, string work_model, string employment_type, string job_description, string job_status, string job_address, FlowLayoutPanel joblist_flowlayout, Panel sidebar_panel) {
            Panel postJobPanel = new Panel();
            postJobPanel.Height = 150;
            postJobPanel.Width = joblist_flowlayout.Width - 20;
            postJobPanel.Margin = new Padding(10, 10, 10, 10);
            postJobPanel.BackColor = Color.WhiteSmoke;
            postJobPanel.BorderStyle = BorderStyle.None;

            Label jobPosition = new Label();
            jobPosition.AutoSize = false;
            jobPosition.Text = job_postion;
            jobPosition.Width = 500;
            jobPosition.Height = 30;
            jobPosition.BorderStyle = BorderStyle.None;
            jobPosition.Location = new Point(40, 10);
            jobPosition.Font = new Font("Poppins", 16, FontStyle.Bold);
            jobPosition.ForeColor = Color.Black;

            Label jobStatus = new Label();
            jobStatus.AutoSize = false;
            jobStatus.Width = 100;
            jobStatus.Height = 25;
            jobStatus.BorderStyle = BorderStyle.None;
            jobStatus.Location = new Point(joblist_flowlayout.Width - 180   , 14);
            jobStatus.TextAlign = ContentAlignment.MiddleCenter;
            jobStatus.Font = new Font("Poppins", 12, FontStyle.Bold);

            UserController.SetJobPostStatus(jobStatus, job_status);

            Label jobInfo = new Label();
            jobInfo.AutoSize = false;
            jobInfo.Text = $" {work_model} | {employment_type}";
            jobInfo.Width = 700;
            jobInfo.AutoEllipsis = true;
            jobInfo.BorderStyle = BorderStyle.None;
            jobInfo.Location = new Point(39, 40);
            jobInfo.Font = new Font("Poppins", 12, FontStyle.Regular);
            jobInfo.ForeColor = Color.Black;

            Label jobDescription = new Label();
            jobDescription.AutoSize = false;
            jobDescription.AutoEllipsis = true;
            jobDescription.Text = job_description;
            jobDescription.Width = 700;
            jobDescription.Height = 50;
            jobDescription.AutoEllipsis = true;
            jobDescription.BorderStyle = BorderStyle.None;
            jobDescription.TextAlign = ContentAlignment.TopLeft;
            jobDescription.Location = new Point(43, 70);
            jobDescription.Font = new Font("Poppins", 10, FontStyle.Regular);
            jobDescription.ForeColor = Color.Gray;

            Label jobAddress = new Label();
            jobAddress.AutoSize = false;
            jobAddress.Text = job_address;
            jobAddress.Width = 605;
            jobAddress.Height = 20;
            jobAddress.BorderStyle = BorderStyle.None;
            jobAddress.Location = new Point(45, 117);
            jobAddress.TextAlign = ContentAlignment.TopLeft;
            jobAddress.Font = new Font("Poppins", 9, FontStyle.Regular);
            jobAddress.ForeColor = Color.Gray;

            PanelStyles.RoundedPanel(postJobPanel, 20, Color.White);

            postJobPanel.Click += (s, e) =>
            {
                Session.CurrentPostedJobSelected = job_id;
                JobSeekerDashboardUserControl.JS_ViewJobList activeJobDetails = new JobSeekerDashboardUserControl.JS_ViewJobList(Session.CurrentPostedJobSelected);
                sidebar_panel.Controls.Clear();
                sidebar_panel.Controls.Add(activeJobDetails);
                activeJobDetails.Dock = DockStyle.Fill;
            };  

            postJobPanel.Controls.Add(jobPosition);
            postJobPanel.Controls.Add(jobInfo);
            postJobPanel.Controls.Add(jobDescription);
            postJobPanel.Controls.Add(jobStatus);
            postJobPanel.Controls.Add(jobAddress);

            joblist_flowlayout.Controls.Add(postJobPanel);

        }
    }
}
