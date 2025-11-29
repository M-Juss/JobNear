using JobNear.AdminDashboardUserControl;
using JobNear.Controllers;
using JobNear.Forms;
using JobNear.Models;
using JobNear.Services;
using JobNear.Styles;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.JobSeekerDashboardUserControl
{
    public partial class JS_Profile : UserControl
    {

        private OpenFileDialog ofd = new OpenFileDialog();
        private Timer debounceTimer;
        private bool isEditing = false;

        private readonly GeoaptifyAutocompeteAPIServices geoServices = new GeoaptifyAutocompeteAPIServices();
        private Dictionary<string, (double lat, double lon)> suggestionData = new Dictionary<string, (double lat, double lon)>();

        private double selectedLat;
        private double selectedLon;



        public JS_Profile()
        {
            InitializeComponent();
            this.Load += JS_Profile_Load;

            InitializeUI();
            InitializeDebounce();
        }



        private void InitializeUI()
        {
            SetProfileEditable(false);


            ButtonStyle.RoundedButton(upload_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(attach_file, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(draft_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(review_button, 25, "#FFFFFF");
            ButtonStyle.RoundedButton(edit_btn, 25, "#3B82F6");


            PanelStyles.RoundedPanel(personal_panel, 20, Color.White);
            PanelStyles.RoundedPanel(address_panel, 20, Color.White);
            PanelStyles.RoundedPanel(supporting_panel, 20, Color.White);


            image_flowlayout.FlowDirection = FlowDirection.TopDown;
            image_flowlayout.WrapContents = false;
            image_flowlayout.AutoScroll = true;


            address_input.Leave += Address_input_Leave;
        }

        private void InitializeDebounce()
        {
            debounceTimer = new Timer();
            debounceTimer.Interval = 350;
            debounceTimer.Tick += DebounceTimer_Tick;
        }


        private async void JS_Profile_Load(object sender, EventArgs e)
        {
            var seeker = await MongoDbServices.LoadCurrentSeekerData();

            if (seeker == null) return;

            firstname_input.Text = seeker.Firstname;
            lastname_input.Text = seeker.Lastname;
            middlename_input.Text = seeker.Middlename;
            sex_combo.Text = seeker.Sex;
            birthdate_picker.Value = seeker.Birthdate;
            age_input.Text = seeker.Age.ToString();
            phone_input.Text = seeker.Phone;
            email_input.Text = seeker.Email;
            address_input.Text = seeker.Address;

            profile_picture.Image = ConvertDataTypeServices.ConvertBytesToImage(seeker.ProfilePicture);

            if (seeker.SupportingDocuments != null)
            {
                foreach (var doc in seeker.SupportingDocuments)
                    FlowLayoutStyles.AddSupportingDocumentToFlow(doc, image_flowlayout, image_flowlayout.Width - 20);
            }

            UserController.SetSeekerAndBusinesStatus(status_label, seeker.Status);
        }
        private void address_input_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private async void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();

            if (string.IsNullOrWhiteSpace(address_input.Text))
                return;

            suggestionData = await geoServices.GetSuggestionsAsync(address_input.Text);
            geoServices.ApplyAutoComplete(address_input, suggestionData);
        }

        private void Address_input_Leave(object sender, EventArgs e)
        {
            if (suggestionData.TryGetValue(address_input.Text, out var coords))
            {
                selectedLat = coords.lat;
                selectedLon = coords.lon;
            }
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    profile_picture.Image = Image.FromStream(stream);
                }
            }
        }

        private void attach_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                ofd.Filter = "All Files|*.*";

                if (ofd.ShowDialog() != DialogResult.OK) return;

                string saveDir = Path.Combine(Application.StartupPath, "SupportingDocs");
                Directory.CreateDirectory(saveDir);

                foreach (string file in ofd.FileNames)
                {
                    string dest = Path.Combine(saveDir, Path.GetFileName(file));
                    File.Copy(file, dest, true);

                    FlowLayoutStyles.AddFileItem(dest, image_flowlayout, image_flowlayout.Width - 20);
                }
            }
        }


        private void edit_btn_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            SetProfileEditable(isEditing);

            edit_btn.Text = isEditing ? "Cancel" : "Edit";
        }

        private void SetProfileEditable(bool editable)
        {
            ToggleEditableRecursive(this, editable);
            status_label.Enabled = false;
        }

        private void ToggleEditableRecursive(Control parent, bool editable)
        {
            foreach (Control c in parent.Controls)
            {
                switch (c)
                {
                    case TextBox tb:
                        tb.ReadOnly = !editable;
                        tb.BackColor = editable ? Color.White : Color.LightGray;
                        break;

                    case ComboBox cb:
                        cb.Enabled = editable;
                        break;

                    case DateTimePicker dtp:
                        dtp.Enabled = editable;
                        break;

                    case Button btn:
                        if (btn == upload_button ||
                            btn == attach_file ||
                            btn == draft_button ||
                            btn == review_button)
                            btn.Enabled = editable;
                        break;
                }

                if (c.HasChildren)
                    ToggleEditableRecursive(c, editable);
            }
        }


        private void draft_button_Click(object sender, EventArgs e)
        {
            SaveProfile(true, "Incomplete");
        }

        private void review_button_Click(object sender, EventArgs e)
        {
            SaveProfile(false, "Pending");
        }

        private async void SaveProfile(bool isDraft, string status)
        {
            if (!ValidateFields()) return;

            if (selectedLat == 0 && selectedLon == 0)
                await ResolveCoordinates();

            var supporting = CollectSupportingDocs();
            byte[] pictureBytes = ConvertDataTypeServices.ConvertImageToBytes(profile_picture.Image);

            bool response = await MongoDbServices.UpdateJobSeekerProfileAsync(
                Session.CurrentUserId,
                Session.CurrentEmail,
                phone_input.Text,
                lastname_input.Text,
                firstname_input.Text,
                middlename_input.Text,
                sex_combo.Text,
                birthdate_picker.Text,
                short.Parse(age_input.Text),
                address_input.Text,
                selectedLat,
                selectedLon,
                pictureBytes,
                supporting,
                isDraft,
                status
            );

            if (!response)
            {
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                isDraft ? "Profile saved as draft." : "Profile submitted for review.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            ReloadProfile();
        }

        private bool ValidateFields()
        {
            if (profile_picture.Image == null)
            {
                MessageBox.Show("Please upload a profile picture.");
                return false;
            }

            if (image_flowlayout.Controls.Count == 0)
            {
                MessageBox.Show("Attach at least one supporting document.");
                return false;
            }

            TextBoxValidatorController.ValidateEmail(email_input);
            TextBoxValidatorController.ValidatePhoneNumber(phone_input);

            var fields = new[]
            {
                firstname_input, lastname_input, middlename_input,
                age_input, phone_input, email_input, address_input
            };

            if (fields.Any(f => string.IsNullOrWhiteSpace(f.Text)))
            {
                MessageBox.Show("All fields must be filled.");
                return false;
            }

            return true;
        }

        private async Task ResolveCoordinates()
        {
            var result = await geoServices.GetSuggestionsAsync(address_input.Text);

            if (!result.Any()) return;

            var first = result.First();
            selectedLat = first.Value.lat;
            selectedLon = first.Value.lon;
        }

        private List<SupportingDocument> CollectSupportingDocs()
        {
            var list = new List<SupportingDocument>();

            foreach (Control ctrl in image_flowlayout.Controls)
            {
                if (ctrl is Panel panel)
                {
                    if (panel.Tag is SupportingDocument doc)
                    {
                        list.Add(doc);
                    }
                    else if (panel.Tag is string path && File.Exists(path))
                    {
                        list.Add(new SupportingDocument
                        {
                            FileName = Path.GetFileName(path),
                            FileContent = File.ReadAllBytes(path)
                        });
                    }
                }
            }

            return list;
        }

        private void ReloadProfile()
        {
            sidebar_panel.Controls.Clear();
            JS_Profile profile = new JS_Profile
            {
                Dock = DockStyle.Fill
            };
            sidebar_panel.Controls.Add(profile);
        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
