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
            this.log_out_button = new System.Windows.Forms.Button();
            this.notification_button = new System.Windows.Forms.Button();
            this.business_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.jobnear_button = new System.Windows.Forms.Button();
            this.JP_main_panel = new System.Windows.Forms.Panel();
            this.view_business_button = new System.Windows.Forms.Button();
            this.JP_sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JP_sidebar_panel
            // 
            this.JP_sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.JP_sidebar_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JP_sidebar_panel.Controls.Add(this.view_business_button);
            this.JP_sidebar_panel.Controls.Add(this.log_out_button);
            this.JP_sidebar_panel.Controls.Add(this.notification_button);
            this.JP_sidebar_panel.Controls.Add(this.business_button);
            this.JP_sidebar_panel.Controls.Add(this.dashboard_button);
            this.JP_sidebar_panel.Controls.Add(this.jobnear_button);
            this.JP_sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.JP_sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.JP_sidebar_panel.Name = "JP_sidebar_panel";
            this.JP_sidebar_panel.Size = new System.Drawing.Size(200, 705);
            this.JP_sidebar_panel.TabIndex = 0;
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
            // notification_button
            // 
            this.notification_button.Location = new System.Drawing.Point(29, 341);
            this.notification_button.Name = "notification_button";
            this.notification_button.Size = new System.Drawing.Size(136, 49);
            this.notification_button.TabIndex = 4;
            this.notification_button.Text = "Notification";
            this.notification_button.UseVisualStyleBackColor = true;
            this.notification_button.Click += new System.EventHandler(this.notification_button_Click);
            // 
            // business_button
            // 
            this.business_button.Location = new System.Drawing.Point(29, 183);
            this.business_button.Name = "business_button";
            this.business_button.Size = new System.Drawing.Size(136, 49);
            this.business_button.TabIndex = 2;
            this.business_button.Text = "Register Business";
            this.business_button.UseVisualStyleBackColor = true;
            this.business_button.Click += new System.EventHandler(this.business_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Location = new System.Drawing.Point(29, 104);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(136, 49);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // jobnear_button
            // 
            this.jobnear_button.Image = global::JobNear.Properties.Resources.JobNearDashboardLogo;
            this.jobnear_button.Location = new System.Drawing.Point(29, 29);
            this.jobnear_button.Name = "jobnear_button";
            this.jobnear_button.Size = new System.Drawing.Size(136, 49);
            this.jobnear_button.TabIndex = 0;
            this.jobnear_button.UseVisualStyleBackColor = true;
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
            // view_business_button
            // 
            this.view_business_button.Location = new System.Drawing.Point(29, 266);
            this.view_business_button.Name = "view_business_button";
            this.view_business_button.Size = new System.Drawing.Size(136, 49);
            this.view_business_button.TabIndex = 6;
            this.view_business_button.Text = "View Business";
            this.view_business_button.UseVisualStyleBackColor = true;
            this.view_business_button.Click += new System.EventHandler(this.view_business_button_Click);
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
        private System.Windows.Forms.Button business_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button jobnear_button;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Button view_business_button;
    }
}