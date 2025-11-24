namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_ReportsAndComplaints
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reports_table = new System.Windows.Forms.DataGridView();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.sidebar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports_table)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reports_table);
            this.panel1.Location = new System.Drawing.Point(26, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 593);
            this.panel1.TabIndex = 8;
            // 
            // reports_table
            // 
            this.reports_table.AllowUserToAddRows = false;
            this.reports_table.AllowUserToDeleteRows = false;
            this.reports_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports_table.Location = new System.Drawing.Point(3, 3);
            this.reports_table.Name = "reports_table";
            this.reports_table.ReadOnly = true;
            this.reports_table.RowHeadersWidth = 51;
            this.reports_table.Size = new System.Drawing.Size(973, 587);
            this.reports_table.TabIndex = 5;
            this.reports_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reports_table_CellContentClick_1);
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Active",
            "Resolved",
            "Closed",
            "All"});
            this.status_combo.Location = new System.Drawing.Point(877, 33);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(128, 33);
            this.status_combo.TabIndex = 7;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged_1);
            // 
            // Admin_ReportsAndComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_ReportsAndComplaints";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reports_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView reports_table;
        private System.Windows.Forms.ComboBox status_combo;
    }
}
