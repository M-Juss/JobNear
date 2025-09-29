using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobNear.Styles;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using JobNear.Services;
using JobNear.Controllers;
using MongoDB.Driver.Core.Authentication;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private Timer debounceTimer;
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();

        private GeoaptifyAutocompeteAPIServices geoServices = new GeoaptifyAutocompeteAPIServices();
        public JS_Profile()
        {
            InitializeComponent();
            ButtonStyle.RoundedButton(upload_button, 25 , "#FFFFFF");
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(draft_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");

            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;

            debounceTimer = new Timer();
            debounceTimer.Interval = 300; // 3 seconds
            debounceTimer.Tick += DebounceTimer_Tick;

        }

        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            suggestionData = await geoServices.GetSuggestionsAsync(address_input.Text);

            geoServices.ApplyAutoComplete(address_input, suggestionData);
        }


        private void email_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload_button_Click(object sender, EventArgs e)
        {            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                profile_picture.Image = Image.FromFile(ofd.FileName);
            }
            else {
                MessageBox.Show("No file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void attach_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; // allow multiple uploads
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in ofd.FileNames)
                {
                    string fileName = Path.GetFileName(filePath);

                    // Save file to your SupportingDocs folder
                    string savePath = Path.Combine(Application.StartupPath, "SupportingDocs");
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);

                    string destPath = Path.Combine(savePath, fileName);
                    File.Copy(filePath, destPath, true);

                    AddFileItem(fileName);
                }
            }
        }
        private void AddFileItem(string filePath)
        {


            // Panel for file item
            Panel filePanel = new Panel();
            filePanel.Width = 765;
            filePanel.Height = 50;
            filePanel.BackColor = Color.White; // modern flat background
            filePanel.Margin = new Padding(0, 0, 0, 2);
            filePanel.Padding = new Padding(10);
            filePanel.BorderStyle = BorderStyle.None;

            // Shadow effect (optional)
            filePanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, filePanel.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            // File icon (system icon)
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

            // File name (single line, trimmed if too long)
            Label lbl = new Label();
            lbl.Text = Path.GetFileName(filePath);
            lbl.AutoSize = false;
            lbl.Width = 180;
            lbl.Height = 30;
            lbl.Location = new Point(70, 10);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Poppins", 12, FontStyle.Regular);
            lbl.ForeColor = Color.Black;

            // Preview button (eye icon)
            Button btnPreview = new Button();
            btnPreview.Width = 30;
            btnPreview.Height = 30;
            btnPreview.Location = new Point(680, 10);
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.BackColor = Color.Transparent;
            btnPreview.Text = "👁";
            btnPreview.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnPreview.ForeColor = Color.DimGray;
            btnPreview.Cursor = Cursors.Hand;
            btnPreview.Click += (s, e) =>
            {
                string fileName = Path.GetFileName(filePath);
                if (string.IsNullOrEmpty(fileName)) return;

                string folderPath = Path.Combine(Application.StartupPath, "SupportingDocs");
                string fullPath = Path.Combine(folderPath, fileName);

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

            // Delete button (trash icon)
            Button btnDelete = new Button();
            btnDelete.Width = 30;
            btnDelete.Height = 30;
            btnDelete.Location = new Point(720, 10);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Text = "🗑";
            btnDelete.Font = new Font("Segoe UI Emoji", 13, FontStyle.Bold);
            btnDelete.ForeColor = Color.DimGray;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Click += (s, e) =>
            {
                string fileName = Path.GetFileName(filePath);
                if (string.IsNullOrEmpty(fileName)) return;

                string folderPath = Path.Combine(Application.StartupPath, "SupportingDocs");
                string fullPath = Path.Combine(folderPath, fileName);

                var confirm = MessageBox.Show($"Delete {fileName}?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Delete from disk
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                    }

                    // Remove the file panel from UI
                    filePanel.Dispose();
                }
            };

            // Add controls to panel
            filePanel.Controls.Add(picIcon);
            filePanel.Controls.Add(lbl);
            filePanel.Controls.Add(btnPreview);
            filePanel.Controls.Add(btnDelete);

            // Add panel to FlowLayoutPanel
            image_flowlayout.Controls.Add(filePanel);
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();

        }

        private async void review_button_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(firstname_input.Text) || string.IsNullOrEmpty(lastname_input.Text) || string.IsNullOrEmpty(middlename_input.Text) ||
                string.IsNullOrEmpty(age_input.Text) || string.IsNullOrEmpty(phone_input.Text) || string.IsNullOrEmpty(email_input.Text)
                || string.IsNullOrEmpty(address_input.Text)) {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                TextBoxValidatorController.ValidateEmail(email_input);
                TextBoxValidatorController.ValidatePhoneNumber(phone_input);
                TextBoxValidatorController.AllowOnlyNumbers(age_input);
                TextBoxValidatorController.AllowOnlyNumbers(phone_input);
            }
            if (profile_picture.Image == null)
            {
                MessageBox.Show("Please upload a profile picture", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Please attach at least one supporting document", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

        }
    }
}
