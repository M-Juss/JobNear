namespace JobNear.Forms
{
    partial class JobPosterDashboardForm
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
            this.JP_sidebar_panel = new System.Windows.Forms.Panel();
            this.JP_main_panel = new System.Windows.Forms.Panel();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.business_button = new System.Windows.Forms.Button();
            this.job_button = new System.Windows.Forms.Button();
            this.notification_button = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.JP_sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JP_sidebar_panel
            // 
            this.JP_sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JP_sidebar_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JP_sidebar_panel.Controls.Add(this.log_out_button);
            this.JP_sidebar_panel.Controls.Add(this.notification_button);
            this.JP_sidebar_panel.Controls.Add(this.job_button);
            this.JP_sidebar_panel.Controls.Add(this.business_button);
            this.JP_sidebar_panel.Controls.Add(this.dashboard_button);
            this.JP_sidebar_panel.Controls.Add(this.button1);
            this.JP_sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.JP_sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.JP_sidebar_panel.Name = "JP_sidebar_panel";
            this.JP_sidebar_panel.Size = new System.Drawing.Size(200, 705);
            this.JP_sidebar_panel.TabIndex = 0;
            // 
            // JP_main_panel
            // 
            this.JP_main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JP_main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JP_main_panel.Location = new System.Drawing.Point(200, 0);
            this.JP_main_panel.Name = "JP_main_panel";
            this.JP_main_panel.Size = new System.Drawing.Size(1031, 705);
            this.JP_main_panel.TabIndex = 1;
            // 
            // dashboard_button
            // 
            this.dashboard_button.Location = new System.Drawing.Point(29, 104);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(136, 49);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            // 
            // business_button
            // 
            this.business_button.Location = new System.Drawing.Point(29, 183);
            this.business_button.Name = "business_button";
            this.business_button.Size = new System.Drawing.Size(136, 49);
            this.business_button.TabIndex = 2;
            this.business_button.Text = "Business";
            this.business_button.UseVisualStyleBackColor = true;
            this.business_button.Click += new System.EventHandler(this.business_button_Click);
            // 
            // job_button
            // 
            this.job_button.Location = new System.Drawing.Point(29, 262);
            this.job_button.Name = "job_button";
            this.job_button.Size = new System.Drawing.Size(136, 49);
            this.job_button.TabIndex = 3;
            this.job_button.Text = "Job";
            this.job_button.UseVisualStyleBackColor = true;
            // 
            // notification_button
            // 
            this.notification_button.Location = new System.Drawing.Point(29, 341);
            this.notification_button.Name = "notification_button";
            this.notification_button.Size = new System.Drawing.Size(136, 49);
            this.notification_button.TabIndex = 4;
            this.notification_button.Text = "Notification";
            this.notification_button.UseVisualStyleBackColor = true;
            // 
            // log_out_button
            // 
            this.log_out_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.log_out_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out_button.Location = new System.Drawing.Point(11, 661);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(74, 31);
            this.log_out_button.TabIndex = 5;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Image = global::JobNear.Properties.Resources.JobNearDashboardLogo;
            this.button1.Location = new System.Drawing.Point(29, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 49);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JobPosterDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.JP_main_panel);
            this.Controls.Add(this.JP_sidebar_panel);
            this.Name = "JobPosterDashboardForm";
            this.Text = "Job Poster";
            this.JP_sidebar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel JP_sidebar_panel;
        private System.Windows.Forms.Panel JP_main_panel;
        private System.Windows.Forms.Button notification_button;
        private System.Windows.Forms.Button job_button;
        private System.Windows.Forms.Button business_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button log_out_button;
    }
}