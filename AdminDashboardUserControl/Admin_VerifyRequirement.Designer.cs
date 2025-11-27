namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_VerifyRequirement
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
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.requirements_table = new System.Windows.Forms.DataGridView();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requirements_table)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.add_button);
            this.sidebar_panel.Controls.Add(this.requirements_table);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "For Job Seekers",
            "For Job Posters"});
            this.status_combo.Location = new System.Drawing.Point(29, 58);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(121, 33);
            this.status_combo.TabIndex = 51;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(836, 59);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(166, 32);
            this.add_button.TabIndex = 50;
            this.add_button.Text = "Add Requirement";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click_1);
            // 
            // requirements_table
            // 
            this.requirements_table.AllowUserToAddRows = false;
            this.requirements_table.AllowUserToDeleteRows = false;
            this.requirements_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requirements_table.Location = new System.Drawing.Point(29, 97);
            this.requirements_table.Name = "requirements_table";
            this.requirements_table.ReadOnly = true;
            this.requirements_table.RowHeadersWidth = 51;
            this.requirements_table.Size = new System.Drawing.Size(973, 550);
            this.requirements_table.TabIndex = 49;
            // 
            // Admin_VerifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_VerifyRequirement";
            this.Size = new System.Drawing.Size(1031, 705);
            this.Load += new System.EventHandler(this.Admin_VerifyRequirement_Load);
            this.sidebar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requirements_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView requirements_table;
    }
}
