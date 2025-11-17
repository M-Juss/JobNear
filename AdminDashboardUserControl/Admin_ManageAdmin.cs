using JobNear.Services;
using JobNear.Styles;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_ManageAdmin : UserControl
    {
        public Admin_ManageAdmin()
        {
            InitializeComponent();

            PanelStyles.RoundedPanel(info_panel, 20, Color.White);
            ButtonStyle.RoundedButton(submit_button, 25, "#3B82F6");
            ButtonStyle.RoundedButton(clear_button, 25, "#3B82F6");
            ButtonStyle.RoundedButton(update_button, 25, "#3B82F6");

            InitializeTable();
            LoadAdminAccounts();
            ShowSubmitButton();

        }

        private void sidebar_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private async void LoadAdminAccounts()
        {
            admin_table.Rows.Clear();

            var adminAccounts = await MongoDbServices.AdminAccount
                .Find(_ => true)
                .ToListAsync();

            if (adminAccounts != null) {
                adminAccounts.ForEach(admin =>
                {
                    admin_table.Rows.Add(
                        admin.Fullname,
                        admin.Email,
                        admin.Role,
                        admin.Status
                    );
                });
            }
        }
        private async void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text)
                || string.IsNullOrEmpty(name_input.Text) || role_combo.SelectedIndex == -1 || status_combo.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password_input.Text != confirm_input.Text)
                {
                    MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool response = await MongoDbServices.InsertAdminAccountAsync(email_input.Text, password_input.Text, name_input.Text,
                        role_combo.SelectedItem.ToString(), status_combo.SelectedItem.ToString());

                        if (response)
                        {
                            string res = MessageBox.Show(
                                "New admin account registered successfully and ready for review",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            ).ToString();

                        if (res == "OK") {
                            ClearForm(); 
                            LoadAdminAccounts();
                        } 
                        }
                }
            }
        }

        private async void admin_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == admin_table.Columns["Update"].Index)
            {
                string email = admin_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();

                var adminDetails = await MongoDbServices.AdminAccount
                    .Find(x => x.Email == email)
                    .FirstOrDefaultAsync();

                if (adminDetails != null)
                {
                    email_input.Text = adminDetails.Email;
                    name_input.Text = adminDetails.Fullname;
                    role_combo.SelectedItem = adminDetails.Role;
                    status_combo.SelectedItem = adminDetails.Status;
                    password_input.Text = adminDetails.Password;
                    confirm_input.Text = adminDetails.Password;

                    Session.CurrentAdminSelected = adminDetails.Id;

                    ShowUpdateButton();
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == admin_table.Columns["Delete"].Index)
            {
                string email = admin_table.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                var confirmResult = MessageBox.Show(
                    "Are you sure to delete this admin account?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (confirmResult == DialogResult.Yes)
                {
                    var deleteResult = await MongoDbServices.AdminAccount
                        .DeleteOneAsync(x => x.Email == email);

                    if (deleteResult.DeletedCount > 0)
                    {
                        admin_table.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Admin account deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete admin account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void update_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(password_input.Text) || string.IsNullOrEmpty(confirm_input.Text)
                || string.IsNullOrEmpty(name_input.Text) || role_combo.SelectedIndex == -1 || status_combo.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (password_input.Text != confirm_input.Text)
                {
                    MessageBox.Show("Passwords do not match", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool response = await MongoDbServices.UpdateAdminAccountAsync(Session.CurrentAdminSelected, email_input.Text, password_input.Text, name_input.Text,
                        role_combo.SelectedItem.ToString(), status_combo.SelectedItem.ToString());

                    if (response)
                    {
                        string res = MessageBox.Show(
                            "Admin account udpated successfully and ready for review",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        ).ToString();

                        if (res == "OK")
                        {
                            ClearForm();
                            LoadAdminAccounts();
                            ShowSubmitButton();

                            Session.CurrentAdminSelected = null;

                        }
                    }
                }
            }
        }
        private void InitializeTable() {
            TableStyles.UserTables(admin_table);

            admin_table.Columns.Add("Fullname", "Fullname");
            admin_table.Columns.Add("Email", "Email");
            admin_table.Columns.Add("Role", "Role");
            admin_table.Columns.Add("Status", "Status");

            var update = new DataGridViewButtonColumn();
            update.Name = "Update";
            update.HeaderText = "Action";
            update.Text = "Update";
            update.UseColumnTextForButtonValue = true;
            update.FlatStyle = FlatStyle.Flat;
            update.Width = 60;
            update.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            admin_table.Columns.Add(update);

            var delete = new DataGridViewButtonColumn();
            delete.Name = "Delete";
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Width = 60;
            delete.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            admin_table.Columns.Add(delete);
        }
        private void ShowSubmitButton()
        {
            submit_button.Visible = true;
            update_button.Visible = false;
        }

        private void ShowUpdateButton()
        {
            submit_button.Visible = false;
            update_button.Visible = true;
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            ClearForm();

            submit_button.Visible = true;
        }

        private void ClearForm()
        {
            email_input.Clear();
            password_input.Clear();
            confirm_input.Clear();
            name_input.Clear();
            role_combo.SelectedIndex = -1;
            status_combo.SelectedIndex = -1;
        }


    }
}
