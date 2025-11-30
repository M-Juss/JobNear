namespace JobNear.Forms
{
    partial class JobSeekerDashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebar = new System.Windows.Forms.Panel();
            this.notification_button = new System.Windows.Forms.Button();
            this.subSeekJob = new System.Windows.Forms.Panel();
            this.job_browsing_sub_button = new System.Windows.Forms.Button();
            this.joblist_sub_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.seekjob_button = new System.Windows.Forms.Button();
            this.profile_button = new System.Windows.Forms.Button();
            this.jobnear_button = new System.Windows.Forms.Button();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.subSeekJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.sidebar.Controls.Add(this.notification_button);
            this.sidebar.Controls.Add(this.subSeekJob);
            this.sidebar.Controls.Add(this.logout_button);
            this.sidebar.Controls.Add(this.seekjob_button);
            this.sidebar.Controls.Add(this.profile_button);
            this.sidebar.Controls.Add(this.jobnear_button);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 705);
            this.sidebar.TabIndex = 0;
            // 
            // notification_button
            // 
            this.notification_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.notification_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_button.Location = new System.Drawing.Point(0, 267);
            this.notification_button.Name = "notification_button";
            this.notification_button.Size = new System.Drawing.Size(200, 60);
            this.notification_button.TabIndex = 6;
            this.notification_button.Text = "🔔   Notifications";
            this.notification_button.UseVisualStyleBackColor = true;
            this.notification_button.Click += new System.EventHandler(this.notification_button_Click);
            // 
            // subSeekJob
            // 
            this.subSeekJob.Controls.Add(this.job_browsing_sub_button);
            this.subSeekJob.Controls.Add(this.joblist_sub_button);
            this.subSeekJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.subSeekJob.Location = new System.Drawing.Point(0, 180);
            this.subSeekJob.Name = "subSeekJob";
            this.subSeekJob.Size = new System.Drawing.Size(200, 87);
            this.subSeekJob.TabIndex = 5;
            // 
            // job_browsing_sub_button
            // 
            this.job_browsing_sub_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.job_browsing_sub_button.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_browsing_sub_button.Location = new System.Drawing.Point(0, 47);
            this.job_browsing_sub_button.Name = "job_browsing_sub_button";
            this.job_browsing_sub_button.Size = new System.Drawing.Size(200, 40);
            this.job_browsing_sub_button.TabIndex = 1;
            this.job_browsing_sub_button.Text = "          🗺️   Job Browsing";
            this.job_browsing_sub_button.UseVisualStyleBackColor = true;
            this.job_browsing_sub_button.Click += new System.EventHandler(this.job_browsing_sub_button_Click);
            // 
            // joblist_sub_button
            // 
            this.joblist_sub_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.joblist_sub_button.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joblist_sub_button.Location = new System.Drawing.Point(0, 0);
            this.joblist_sub_button.Name = "joblist_sub_button";
            this.joblist_sub_button.Size = new System.Drawing.Size(200, 47);
            this.joblist_sub_button.TabIndex = 0;
            this.joblist_sub_button.Text = "          📋   Job Lists";
            this.joblist_sub_button.UseVisualStyleBackColor = true;
            this.joblist_sub_button.Click += new System.EventHandler(this.joblist_sub_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(0, 645);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(200, 60);
            this.logout_button.TabIndex = 4;
            this.logout_button.Text = "↩️  Log Out";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // seekjob_button
            // 
            this.seekjob_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.seekjob_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seekjob_button.Location = new System.Drawing.Point(0, 120);
            this.seekjob_button.Name = "seekjob_button";
            this.seekjob_button.Size = new System.Drawing.Size(200, 60);
            this.seekjob_button.TabIndex = 2;
            this.seekjob_button.Text = "🔍   Seek Job";
            this.seekjob_button.UseVisualStyleBackColor = true;
            this.seekjob_button.Click += new System.EventHandler(this.seekjob_button_Click);
            // 
            // profile_button
            // 
            this.profile_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_button.Location = new System.Drawing.Point(0, 60);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(200, 60);
            this.profile_button.TabIndex = 1;
            this.profile_button.Text = "🧑  ‍ Profile";
            this.profile_button.UseVisualStyleBackColor = true;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // jobnear_button
            // 
            this.jobnear_button.BackColor = System.Drawing.Color.Transparent;
            this.jobnear_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobnear_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobnear_button.Image = global::JobNear.Properties.Resources.JobNearDashboardLogo;
            this.jobnear_button.Location = new System.Drawing.Point(0, 0);
            this.jobnear_button.Name = "jobnear_button";
            this.jobnear_button.Size = new System.Drawing.Size(200, 60);
            this.jobnear_button.TabIndex = 0;
            this.jobnear_button.UseVisualStyleBackColor = false;
            this.jobnear_button.Click += new System.EventHandler(this.jobnear_button_Click);
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(200, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 1;
            // 
            // JobSeekerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.sidebar_panel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "JobSeekerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobSeekerDashboardForm";
            this.sidebar.ResumeLayout(false);
            this.subSeekJob.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button seekjob_button;
        private System.Windows.Forms.Button profile_button;
        private System.Windows.Forms.Panel subSeekJob;
        private System.Windows.Forms.Button job_browsing_sub_button;
        private System.Windows.Forms.Button joblist_sub_button;
        private System.Windows.Forms.Button notification_button;
        private System.Windows.Forms.Button jobnear_button;
    }
}