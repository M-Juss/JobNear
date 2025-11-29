namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_ViewJobList
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
            this.prev_lbl = new System.Windows.Forms.Label();
            this.job_panel = new System.Windows.Forms.Panel();
            this.minimum_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.preffered_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.responsibilities_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.about_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rate_label = new System.Windows.Forms.Label();
            this.jobinfo_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.jobtitle_label = new System.Windows.Forms.Label();
            this.business_panel = new System.Windows.Forms.Panel();
            this.description_label = new System.Windows.Forms.Label();
            this.footer_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.company_logo_picturebox = new System.Windows.Forms.PictureBox();
            this.sidebar_panel.SuspendLayout();
            this.job_panel.SuspendLayout();
            this.business_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.AutoScroll = true;
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.prev_lbl);
            this.sidebar_panel.Controls.Add(this.job_panel);
            this.sidebar_panel.Controls.Add(this.business_panel);
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // prev_lbl
            // 
            this.prev_lbl.AutoSize = true;
            this.prev_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_lbl.Location = new System.Drawing.Point(10, 4);
            this.prev_lbl.Name = "prev_lbl";
            this.prev_lbl.Size = new System.Drawing.Size(102, 28);
            this.prev_lbl.TabIndex = 18;
            this.prev_lbl.Text = "◀️ Previous";
            this.prev_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prev_lbl.Click += new System.EventHandler(this.prev_lbl_Click);
            // 
            // job_panel
            // 
            this.job_panel.BackColor = System.Drawing.Color.White;
            this.job_panel.Controls.Add(this.minimum_label);
            this.job_panel.Controls.Add(this.label9);
            this.job_panel.Controls.Add(this.preffered_label);
            this.job_panel.Controls.Add(this.label11);
            this.job_panel.Controls.Add(this.responsibilities_label);
            this.job_panel.Controls.Add(this.label7);
            this.job_panel.Controls.Add(this.about_label);
            this.job_panel.Controls.Add(this.label4);
            this.job_panel.Controls.Add(this.panel2);
            this.job_panel.Controls.Add(this.rate_label);
            this.job_panel.Controls.Add(this.jobinfo_label);
            this.job_panel.Controls.Add(this.status_label);
            this.job_panel.Controls.Add(this.jobtitle_label);
            this.job_panel.Location = new System.Drawing.Point(15, 256);
            this.job_panel.Name = "job_panel";
            this.job_panel.Size = new System.Drawing.Size(1000, 435);
            this.job_panel.TabIndex = 6;
            // 
            // minimum_label
            // 
            this.minimum_label.AutoEllipsis = true;
            this.minimum_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimum_label.Location = new System.Drawing.Point(514, 286);
            this.minimum_label.Name = "minimum_label";
            this.minimum_label.Size = new System.Drawing.Size(431, 131);
            this.minimum_label.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 34);
            this.label9.TabIndex = 16;
            this.label9.Text = "Minimum Qualities:";
            // 
            // preffered_label
            // 
            this.preffered_label.AutoEllipsis = true;
            this.preffered_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preffered_label.Location = new System.Drawing.Point(513, 119);
            this.preffered_label.Name = "preffered_label";
            this.preffered_label.Size = new System.Drawing.Size(432, 131);
            this.preffered_label.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(511, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 34);
            this.label11.TabIndex = 14;
            this.label11.Text = "Preffered Qualities:";
            // 
            // responsibilities_label
            // 
            this.responsibilities_label.AutoEllipsis = true;
            this.responsibilities_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responsibilities_label.Location = new System.Drawing.Point(63, 286);
            this.responsibilities_label.Name = "responsibilities_label";
            this.responsibilities_label.Size = new System.Drawing.Size(431, 131);
            this.responsibilities_label.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Responsibilities";
            // 
            // about_label
            // 
            this.about_label.AutoEllipsis = true;
            this.about_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_label.Location = new System.Drawing.Point(62, 119);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(432, 131);
            this.about_label.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "About the Job:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(60, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 1);
            this.panel2.TabIndex = 9;
            // 
            // rate_label
            // 
            this.rate_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_label.Location = new System.Drawing.Point(703, 54);
            this.rate_label.Name = "rate_label";
            this.rate_label.Size = new System.Drawing.Size(240, 28);
            this.rate_label.TabIndex = 8;
            this.rate_label.Text = "Salary";
            this.rate_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jobinfo_label
            // 
            this.jobinfo_label.AutoSize = true;
            this.jobinfo_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobinfo_label.Location = new System.Drawing.Point(57, 54);
            this.jobinfo_label.Name = "jobinfo_label";
            this.jobinfo_label.Size = new System.Drawing.Size(82, 28);
            this.jobinfo_label.TabIndex = 7;
            this.jobinfo_label.Text = "Job Infos";
            this.jobinfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(838, 21);
            this.status_label.Name = "status_label";
            this.status_label.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.status_label.Size = new System.Drawing.Size(105, 28);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "Status";
            // 
            // jobtitle_label
            // 
            this.jobtitle_label.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitle_label.Location = new System.Drawing.Point(50, 7);
            this.jobtitle_label.Name = "jobtitle_label";
            this.jobtitle_label.Size = new System.Drawing.Size(742, 56);
            this.jobtitle_label.TabIndex = 5;
            this.jobtitle_label.Text = "Job Title";
            this.jobtitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // business_panel
            // 
            this.business_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.business_panel.Controls.Add(this.description_label);
            this.business_panel.Controls.Add(this.footer_label);
            this.business_panel.Controls.Add(this.name_label);
            this.business_panel.Controls.Add(this.company_logo_picturebox);
            this.business_panel.Location = new System.Drawing.Point(15, 35);
            this.business_panel.Name = "business_panel";
            this.business_panel.Size = new System.Drawing.Size(1000, 211);
            this.business_panel.TabIndex = 4;
            // 
            // description_label
            // 
            this.description_label.AutoEllipsis = true;
            this.description_label.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(274, 60);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(659, 104);
            this.description_label.TabIndex = 5;
            // 
            // footer_label
            // 
            this.footer_label.AutoEllipsis = true;
            this.footer_label.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footer_label.ForeColor = System.Drawing.Color.Gray;
            this.footer_label.Location = new System.Drawing.Point(274, 171);
            this.footer_label.Name = "footer_label";
            this.footer_label.Size = new System.Drawing.Size(659, 22);
            this.footer_label.TabIndex = 4;
            // 
            // name_label
            // 
            this.name_label.AllowDrop = true;
            this.name_label.AutoEllipsis = true;
            this.name_label.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(274, 17);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(659, 36);
            this.name_label.TabIndex = 3;
            // 
            // company_logo_picturebox
            // 
            this.company_logo_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.company_logo_picturebox.Location = new System.Drawing.Point(62, 17);
            this.company_logo_picturebox.Name = "company_logo_picturebox";
            this.company_logo_picturebox.Size = new System.Drawing.Size(190, 176);
            this.company_logo_picturebox.TabIndex = 0;
            this.company_logo_picturebox.TabStop = false;
            // 
            // JS_ViewJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JS_ViewJobList";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.job_panel.ResumeLayout(false);
            this.job_panel.PerformLayout();
            this.business_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label jobtitle_label;
        private System.Windows.Forms.Panel business_panel;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label footer_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox company_logo_picturebox;
        private System.Windows.Forms.Panel job_panel;
        private System.Windows.Forms.Label jobinfo_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label rate_label;
        private System.Windows.Forms.Label about_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label minimum_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label preffered_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label responsibilities_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label prev_lbl;
    }
}
