namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_ViewJobPostDetails
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
            this.status_panel = new System.Windows.Forms.Panel();
            this.cancel_button = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Button();
            this.remarks_richtext = new System.Windows.Forms.TextBox();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.job_panel = new System.Windows.Forms.Panel();
            this.rate_lbl = new System.Windows.Forms.Label();
            this.applicants_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimum_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.preffered_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.responsibilities_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.about_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jobinfo_label = new System.Windows.Forms.Label();
            this.jobtitle_label = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.status_panel.SuspendLayout();
            this.job_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.status_panel);
            this.sidebar_panel.Controls.Add(this.job_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            // 
            // status_panel
            // 
            this.status_panel.BackColor = System.Drawing.Color.White;
            this.status_panel.Controls.Add(this.cancel_button);
            this.status_panel.Controls.Add(this.submit_button);
            this.status_panel.Controls.Add(this.remarks_richtext);
            this.status_panel.Controls.Add(this.status_combo);
            this.status_panel.Controls.Add(this.label2);
            this.status_panel.Controls.Add(this.label3);
            this.status_panel.Location = new System.Drawing.Point(12, 545);
            this.status_panel.Name = "status_panel";
            this.status_panel.Size = new System.Drawing.Size(1006, 140);
            this.status_panel.TabIndex = 8;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(887, 88);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(101, 36);
            this.cancel_button.TabIndex = 115;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(887, 37);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(101, 36);
            this.submit_button.TabIndex = 114;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // remarks_richtext
            // 
            this.remarks_richtext.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarks_richtext.Location = new System.Drawing.Point(313, 37);
            this.remarks_richtext.Margin = new System.Windows.Forms.Padding(2);
            this.remarks_richtext.Multiline = true;
            this.remarks_richtext.Name = "remarks_richtext";
            this.remarks_richtext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.remarks_richtext.Size = new System.Drawing.Size(548, 87);
            this.remarks_richtext.TabIndex = 113;
            // 
            // status_combo
            // 
            this.status_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_combo.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Items.AddRange(new object[] {
            "Active",
            "Rejected"});
            this.status_combo.Location = new System.Drawing.Point(19, 37);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(264, 36);
            this.status_combo.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 111;
            this.label2.Text = "Remarks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 110;
            this.label3.Text = "Set Status:";
            // 
            // job_panel
            // 
            this.job_panel.AutoScroll = true;
            this.job_panel.BackColor = System.Drawing.Color.White;
            this.job_panel.Controls.Add(this.rate_lbl);
            this.job_panel.Controls.Add(this.applicants_lbl);
            this.job_panel.Controls.Add(this.label1);
            this.job_panel.Controls.Add(this.minimum_label);
            this.job_panel.Controls.Add(this.label9);
            this.job_panel.Controls.Add(this.preffered_label);
            this.job_panel.Controls.Add(this.label11);
            this.job_panel.Controls.Add(this.responsibilities_label);
            this.job_panel.Controls.Add(this.label7);
            this.job_panel.Controls.Add(this.about_label);
            this.job_panel.Controls.Add(this.label4);
            this.job_panel.Controls.Add(this.panel2);
            this.job_panel.Controls.Add(this.jobinfo_label);
            this.job_panel.Controls.Add(this.jobtitle_label);
            this.job_panel.Location = new System.Drawing.Point(12, 18);
            this.job_panel.Name = "job_panel";
            this.job_panel.Size = new System.Drawing.Size(1006, 521);
            this.job_panel.TabIndex = 7;
            // 
            // rate_lbl
            // 
            this.rate_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_lbl.Location = new System.Drawing.Point(673, 25);
            this.rate_lbl.Name = "rate_lbl";
            this.rate_lbl.Size = new System.Drawing.Size(264, 28);
            this.rate_lbl.TabIndex = 21;
            this.rate_lbl.Text = "Job Infos";
            this.rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // applicants_lbl
            // 
            this.applicants_lbl.AutoSize = true;
            this.applicants_lbl.BackColor = System.Drawing.Color.Transparent;
            this.applicants_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicants_lbl.Location = new System.Drawing.Point(680, 54);
            this.applicants_lbl.Name = "applicants_lbl";
            this.applicants_lbl.Size = new System.Drawing.Size(254, 28);
            this.applicants_lbl.TabIndex = 20;
            this.applicants_lbl.Text = "Number of applicants needed:";
            this.applicants_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 1);
            this.label1.TabIndex = 18;
            // 
            // minimum_label
            // 
            this.minimum_label.AutoEllipsis = true;
            this.minimum_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimum_label.Location = new System.Drawing.Point(510, 337);
            this.minimum_label.Name = "minimum_label";
            this.minimum_label.Size = new System.Drawing.Size(432, 172);
            this.minimum_label.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(508, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 34);
            this.label9.TabIndex = 16;
            this.label9.Text = "Minimum Qualities:";
            // 
            // preffered_label
            // 
            this.preffered_label.AutoEllipsis = true;
            this.preffered_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preffered_label.Location = new System.Drawing.Point(510, 127);
            this.preffered_label.Name = "preffered_label";
            this.preffered_label.Size = new System.Drawing.Size(432, 172);
            this.preffered_label.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(508, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 34);
            this.label11.TabIndex = 14;
            this.label11.Text = "Preffered Qualities:";
            // 
            // responsibilities_label
            // 
            this.responsibilities_label.AutoEllipsis = true;
            this.responsibilities_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibilities_label.Location = new System.Drawing.Point(59, 337);
            this.responsibilities_label.Name = "responsibilities_label";
            this.responsibilities_label.Size = new System.Drawing.Size(432, 172);
            this.responsibilities_label.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(58, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Responsibilities";
            // 
            // about_label
            // 
            this.about_label.AutoEllipsis = true;
            this.about_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_label.Location = new System.Drawing.Point(59, 127);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(432, 172);
            this.about_label.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(57, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "About the Job:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(57, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 1);
            this.panel2.TabIndex = 9;
            // 
            // jobinfo_label
            // 
            this.jobinfo_label.AutoSize = true;
            this.jobinfo_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobinfo_label.Location = new System.Drawing.Point(54, 54);
            this.jobinfo_label.Name = "jobinfo_label";
            this.jobinfo_label.Size = new System.Drawing.Size(82, 28);
            this.jobinfo_label.TabIndex = 7;
            this.jobinfo_label.Text = "Job Infos";
            this.jobinfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jobtitle_label
            // 
            this.jobtitle_label.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitle_label.ForeColor = System.Drawing.Color.Black;
            this.jobtitle_label.Location = new System.Drawing.Point(47, 7);
            this.jobtitle_label.Name = "jobtitle_label";
            this.jobtitle_label.Size = new System.Drawing.Size(742, 56);
            this.jobtitle_label.TabIndex = 5;
            this.jobtitle_label.Text = "Job Title";
            this.jobtitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Admin_ViewJobPostDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_ViewJobPostDetails";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.status_panel.ResumeLayout(false);
            this.status_panel.PerformLayout();
            this.job_panel.ResumeLayout(false);
            this.job_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel job_panel;
        private System.Windows.Forms.Label applicants_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label minimum_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label preffered_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label responsibilities_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label jobinfo_label;
        private System.Windows.Forms.Label jobtitle_label;
        private System.Windows.Forms.Panel status_panel;
        private System.Windows.Forms.TextBox remarks_richtext;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label rate_lbl;
    }
}
