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
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reports_table = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reports_table)).BeginInit();
            this.SuspendLayout();
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
            this.status_combo.Location = new System.Drawing.Point(881, 36);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(121, 33);
            this.status_combo.TabIndex = 5;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reports_table);
            this.panel1.Location = new System.Drawing.Point(24, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 593);
            this.panel1.TabIndex = 6;
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
            this.reports_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reports_table_CellContentClick);
            // 
            // Admin_ReportsAndComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status_combo);
            this.Name = "Admin_ReportsAndComplaints";
            this.Size = new System.Drawing.Size(1031, 705);
            this.Load += new System.EventHandler(this.Admin_ReportsAndComplaints_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reports_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView reports_table;
    }
}
