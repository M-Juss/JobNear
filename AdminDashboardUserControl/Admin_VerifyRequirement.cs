using JobNear.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobNear.AdminDashboardUserControl
{
    public partial class Admin_VerifyRequirement : UserControl
    {
        public Admin_VerifyRequirement()
        {
            InitializeComponent();
            SetUpTable();
        }

        private void Admin_VerifyRequirement_Load(object sender, EventArgs e)
        {

        }

        private void SetUpTable()
        {
            TableStyles.UserTables(requirements_table);

            requirements_table.Columns.Add("Document Name", "Document Name");
            requirements_table.Columns.Add("Type", "Type");
            requirements_table.Columns.Add("Description", "Description");

            var viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "View";
            viewButton.HeaderText = "Action";
            viewButton.Text = "👁";
            viewButton.UseColumnTextForButtonValue = true;
            viewButton.FlatStyle = FlatStyle.Flat;
            viewButton.Width = 60;
            viewButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.Text = "🗑";
            deleteButton.UseColumnTextForButtonValue = true;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Width = 60;
            deleteButton.DefaultCellStyle.Font = new Font("Poppins", 12, FontStyle.Bold);

            requirements_table.Columns.Add(viewButton);
            requirements_table.Columns.Add(deleteButton);
        }

        private void add_button_Click_1(object sender, EventArgs e)
        {
            Admin_AddVerifyRequirement addRequirementControl = new Admin_AddVerifyRequirement();
            sidebar_panel.Controls.Clear();
            sidebar_panel.Controls.Add(addRequirementControl);
            addRequirementControl.Dock = DockStyle.Fill;
        }
    }
}
