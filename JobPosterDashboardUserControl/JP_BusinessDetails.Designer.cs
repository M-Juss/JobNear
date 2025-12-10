namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_BusinessDetails
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
            this.business_panel = new System.Windows.Forms.Panel();
            this.footer_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.post_job_button = new System.Windows.Forms.Button();
            this.joblist_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.prev_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.footer_label);
            this.business_panel.Controls.Add(this.description_label);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.edit_button);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(22, 79);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(984, 223);
            this.business_panel.TabIndex = 0;
            // 
            // footer_label
            // 
            this.footer_label.AutoEllipsis = true;
            this.footer_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_label.ForeColor = System.Drawing.Color.Gray;
            this.footer_label.Location = new System.Drawing.Point(235, 181);
            this.footer_label.Name = "footer_label";
            this.footer_label.Size = new System.Drawing.Size(648, 22);
            this.footer_label.TabIndex = 10;
            // 
            // description_label
            // 
            this.description_label.AutoEllipsis = true;
            this.description_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(235, 54);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(648, 135);
            this.description_label.TabIndex = 11;
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(230, 19);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(652, 36);
            this.name_label.TabIndex = 9;
            // 
            // edit_button
            // 
            this.edit_button.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.White;
            this.edit_button.Location = new System.Drawing.Point(892, 20);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 30);
            this.edit_button.TabIndex = 6;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Location = new System.Drawing.Point(24, 20);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(196, 185);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // post_job_button
            // 
            this.post_job_button.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.post_job_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.post_job_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_job_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_job_button.ForeColor = System.Drawing.Color.White;
            this.post_job_button.Location = new System.Drawing.Point(22, 324);
            this.post_job_button.Name = "post_job_button";
            this.post_job_button.Size = new System.Drawing.Size(128, 35);
            this.post_job_button.TabIndex = 1;
            this.post_job_button.Text = "Post a Job";
            this.post_job_button.UseVisualStyleBackColor = false;
            // 
            // joblist_flowlayout
            // 
            this.joblist_flowlayout.Location = new System.Drawing.Point(22, 366);
            this.joblist_flowlayout.Name = "joblist_flowlayout";
            this.joblist_flowlayout.Size = new System.Drawing.Size(982, 314);
            this.joblist_flowlayout.TabIndex = 2;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Controls.Add(this.status_combo);
            this.sidebar_panel.Controls.Add(this.prev_lbl);
            this.sidebar_panel.Controls.Add(this.joblist_flowlayout);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Controls.Add(this.post_job_button);
            this.sidebar_panel.Controls.Add(this.status_lbl);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 4;
            // 
            // prev_lbl
            // 
            this.prev_lbl.AutoSize = true;
            this.prev_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_lbl.Location = new System.Drawing.Point(17, 13);
            this.prev_lbl.Name = "prev_lbl";
            this.prev_lbl.Size = new System.Drawing.Size(102, 28);
            this.prev_lbl.TabIndex = 20;
            this.prev_lbl.Text = "◀️ Previous";
            this.prev_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prev_lbl.Click += new System.EventHandler(this.prev_lbl_Click);
            // 
            // status_lbl
            // 
            this.status_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_lbl.Location = new System.Drawing.Point(22, 49);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(984, 37);
            this.status_lbl.TabIndex = 5;
            this.status_lbl.Text = "Status";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(663, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filter by status:";
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Withdrawn",
            "Closed",
            "Pending",
            "Rejected",
            "All"});
            this.status_combo.Location = new System.Drawing.Point(804, 327);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(174, 33);
            this.status_combo.TabIndex = 21;
            this.status_combo.SelectedIndexChanged += new System.EventHandler(this.status_combo_SelectedIndexChanged);
            // 
            // JP_BusinessDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_BusinessDetails";
            this.Size = new System.Drawing.Size(1031, 705);
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button post_job_button;
        private System.Windows.Forms.FlowLayoutPanel joblist_flowlayout;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Label prev_lbl;
        private System.Windows.Forms.Label footer_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox status_combo;
    }
}
