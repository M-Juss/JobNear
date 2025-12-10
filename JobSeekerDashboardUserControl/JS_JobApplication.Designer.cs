namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_JobApplication
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
            this.details_panel = new System.Windows.Forms.Panel();
            this.attach_file = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.coverletter_input = new System.Windows.Forms.TextBox();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.documents_lbl = new System.Windows.Forms.Label();
            this.prev_lbl = new System.Windows.Forms.Label();
            this.job_panel = new System.Windows.Forms.Panel();
            this.rate_lbl = new System.Windows.Forms.Label();
            this.about_lbl = new System.Windows.Forms.Label();
            this.applicants_lbl = new System.Windows.Forms.Label();
            this.jobinfo_label = new System.Windows.Forms.Label();
            this.jobtitle_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.details_panel.SuspendLayout();
            this.job_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.details_panel);
            this.sidebar_panel.Controls.Add(this.prev_lbl);
            this.sidebar_panel.Controls.Add(this.job_panel);
            this.sidebar_panel.Controls.Add(this.status_label);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // details_panel
            // 
            this.details_panel.BackColor = System.Drawing.Color.White;
            this.details_panel.Controls.Add(this.attach_file);
            this.details_panel.Controls.Add(this.back_button);
            this.details_panel.Controls.Add(this.coverletter_input);
            this.details_panel.Controls.Add(this.image_flowlayout);
            this.details_panel.Controls.Add(this.submit_button);
            this.details_panel.Controls.Add(this.label1);
            this.details_panel.Controls.Add(this.documents_lbl);
            this.details_panel.Location = new System.Drawing.Point(20, 286);
            this.details_panel.Margin = new System.Windows.Forms.Padding(4);
            this.details_panel.Name = "details_panel";
            this.details_panel.Size = new System.Drawing.Size(1333, 566);
            this.details_panel.TabIndex = 21;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.ForeColor = System.Drawing.Color.DimGray;
            this.attach_file.Location = new System.Drawing.Point(39, 270);
            this.attach_file.Margin = new System.Windows.Forms.Padding(4);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(1257, 49);
            this.attach_file.TabIndex = 55;
            this.attach_file.Text = "Attach here your resume and sample works to strengthen your proposal";
            this.attach_file.UseVisualStyleBackColor = false;
            this.attach_file.Click += new System.EventHandler(this.attach_file_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(1168, 507);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(127, 43);
            this.back_button.TabIndex = 59;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // coverletter_input
            // 
            this.coverletter_input.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coverletter_input.Location = new System.Drawing.Point(39, 43);
            this.coverletter_input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coverletter_input.Multiline = true;
            this.coverletter_input.Name = "coverletter_input";
            this.coverletter_input.ReadOnly = true;
            this.coverletter_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coverletter_input.Size = new System.Drawing.Size(1256, 218);
            this.coverletter_input.TabIndex = 58;
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.image_flowlayout.Location = new System.Drawing.Point(39, 327);
            this.image_flowlayout.Margin = new System.Windows.Forms.Padding(4);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(1257, 169);
            this.image_flowlayout.TabIndex = 56;
            this.image_flowlayout.WrapContents = false;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.Color.White;
            this.submit_button.Location = new System.Drawing.Point(1048, 507);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(248, 43);
            this.submit_button.TabIndex = 54;
            this.submit_button.Text = "Submit Application";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 57;
            this.label1.Text = "Cover Letter:";
            // 
            // documents_lbl
            // 
            this.documents_lbl.AutoSize = true;
            this.documents_lbl.BackColor = System.Drawing.Color.Transparent;
            this.documents_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documents_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.documents_lbl.Location = new System.Drawing.Point(33, 287);
            this.documents_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.documents_lbl.Name = "documents_lbl";
            this.documents_lbl.Size = new System.Drawing.Size(137, 36);
            this.documents_lbl.TabIndex = 60;
            this.documents_lbl.Text = "Documents:";
            // 
            // prev_lbl
            // 
            this.prev_lbl.AutoSize = true;
            this.prev_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_lbl.ForeColor = System.Drawing.Color.Black;
            this.prev_lbl.Location = new System.Drawing.Point(13, 9);
            this.prev_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prev_lbl.Name = "prev_lbl";
            this.prev_lbl.Size = new System.Drawing.Size(125, 36);
            this.prev_lbl.TabIndex = 20;
            this.prev_lbl.Text = "◀️ Previous";
            this.prev_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prev_lbl.Click += new System.EventHandler(this.prev_lbl_Click);
            // 
            // job_panel
            // 
            this.job_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.job_panel.Controls.Add(this.rate_lbl);
            this.job_panel.Controls.Add(this.about_lbl);
            this.job_panel.Controls.Add(this.applicants_lbl);
            this.job_panel.Controls.Add(this.jobinfo_label);
            this.job_panel.Controls.Add(this.jobtitle_label);
            this.job_panel.Location = new System.Drawing.Point(20, 48);
            this.job_panel.Margin = new System.Windows.Forms.Padding(4);
            this.job_panel.Name = "job_panel";
            this.job_panel.Size = new System.Drawing.Size(1333, 228);
            this.job_panel.TabIndex = 19;
            // 
            // rate_lbl
            // 
            this.rate_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_lbl.Location = new System.Drawing.Point(892, 28);
            this.rate_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rate_lbl.Name = "rate_lbl";
            this.rate_lbl.Size = new System.Drawing.Size(363, 34);
            this.rate_lbl.TabIndex = 25;
            this.rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // about_lbl
            // 
            this.about_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_lbl.Location = new System.Drawing.Point(81, 106);
            this.about_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.about_lbl.Name = "about_lbl";
            this.about_lbl.Size = new System.Drawing.Size(1173, 107);
            this.about_lbl.TabIndex = 24;
            this.about_lbl.Text = "About Job";
            // 
            // applicants_lbl
            // 
            this.applicants_lbl.AutoSize = true;
            this.applicants_lbl.BackColor = System.Drawing.Color.Transparent;
            this.applicants_lbl.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicants_lbl.Location = new System.Drawing.Point(916, 64);
            this.applicants_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicants_lbl.Name = "applicants_lbl";
            this.applicants_lbl.Size = new System.Drawing.Size(306, 34);
            this.applicants_lbl.TabIndex = 23;
            this.applicants_lbl.Text = "Number of applicants needed:";
            this.applicants_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // jobinfo_label
            // 
            this.jobinfo_label.AutoSize = true;
            this.jobinfo_label.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobinfo_label.Location = new System.Drawing.Point(81, 66);
            this.jobinfo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobinfo_label.Name = "jobinfo_label";
            this.jobinfo_label.Size = new System.Drawing.Size(100, 34);
            this.jobinfo_label.TabIndex = 22;
            this.jobinfo_label.Text = "Job Infos";
            this.jobinfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // jobtitle_label
            // 
            this.jobtitle_label.Font = new System.Drawing.Font("Poppins SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobtitle_label.ForeColor = System.Drawing.Color.DimGray;
            this.jobtitle_label.Location = new System.Drawing.Point(72, 9);
            this.jobtitle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobtitle_label.Name = "jobtitle_label";
            this.jobtitle_label.Size = new System.Drawing.Size(989, 69);
            this.jobtitle_label.TabIndex = 21;
            this.jobtitle_label.Text = "Job Title";
            this.jobtitle_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_label
            // 
            this.status_label.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(1203, 9);
            this.status_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status_label.Name = "status_label";
            this.status_label.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.status_label.Size = new System.Drawing.Size(150, 34);
            this.status_label.TabIndex = 22;
            this.status_label.Text = "Status";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JS_JobApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JS_JobApplication";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.details_panel.ResumeLayout(false);
            this.details_panel.PerformLayout();
            this.job_panel.ResumeLayout(false);
            this.job_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label prev_lbl;
        private System.Windows.Forms.Panel job_panel;
        private System.Windows.Forms.Label rate_lbl;
        private System.Windows.Forms.Label about_lbl;
        private System.Windows.Forms.Label applicants_lbl;
        private System.Windows.Forms.Label jobinfo_label;
        private System.Windows.Forms.Label jobtitle_label;
        private System.Windows.Forms.Panel details_panel;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Button attach_file;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coverletter_input;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label documents_lbl;
        private System.Windows.Forms.Label status_label;
    }
}
