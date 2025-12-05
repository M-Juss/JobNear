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
            this.notification_button = new System.Windows.Forms.Button();
            this.log_out_button = new System.Windows.Forms.Button();
            this.view_business_button = new System.Windows.Forms.Button();
            this.business_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.jobnear_button = new System.Windows.Forms.Button();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.JP_sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // JP_sidebar_panel
            // 
            this.JP_sidebar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.JP_sidebar_panel.Controls.Add(this.notification_button);
            this.JP_sidebar_panel.Controls.Add(this.log_out_button);
            this.JP_sidebar_panel.Controls.Add(this.view_business_button);
            this.JP_sidebar_panel.Controls.Add(this.business_button);
            this.JP_sidebar_panel.Controls.Add(this.dashboard_button);
            this.JP_sidebar_panel.Controls.Add(this.jobnear_button);
            this.JP_sidebar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.JP_sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.JP_sidebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.JP_sidebar_panel.Name = "JP_sidebar_panel";
            this.JP_sidebar_panel.Size = new System.Drawing.Size(267, 868);
            this.JP_sidebar_panel.TabIndex = 0;
            // 
            // notification_button
            // 
            this.notification_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.notification_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.notification_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_button.Location = new System.Drawing.Point(0, 240);
            this.notification_button.Margin = new System.Windows.Forms.Padding(4);
            this.notification_button.Name = "notification_button";
            this.notification_button.Size = new System.Drawing.Size(267, 60);
            this.notification_button.TabIndex = 6;
            this.notification_button.Text = "  🔔   Notifications";
            this.notification_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notification_button.UseVisualStyleBackColor = false;
            this.notification_button.Click += new System.EventHandler(this.notification_button_Click);
            // 
            // log_out_button
            // 
            this.log_out_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.log_out_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_out_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_out_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_button.Location = new System.Drawing.Point(0, 819);
            this.log_out_button.Margin = new System.Windows.Forms.Padding(4);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(267, 49);
            this.log_out_button.TabIndex = 5;
            this.log_out_button.Text = "↩️ Logout";
            this.log_out_button.UseVisualStyleBackColor = false;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // view_business_button
            // 
            this.view_business_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.view_business_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_business_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_business_button.Location = new System.Drawing.Point(0, 180);
            this.view_business_button.Margin = new System.Windows.Forms.Padding(4);
            this.view_business_button.Name = "view_business_button";
            this.view_business_button.Size = new System.Drawing.Size(267, 60);
            this.view_business_button.TabIndex = 4;
            this.view_business_button.Text = "     🗂️   My Businesses";
            this.view_business_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_business_button.UseCompatibleTextRendering = true;
            this.view_business_button.UseVisualStyleBackColor = false;
            this.view_business_button.Click += new System.EventHandler(this.view_business_button_Click);
            // 
            // business_button
            // 
            this.business_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.business_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.business_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_button.Location = new System.Drawing.Point(0, 120);
            this.business_button.Margin = new System.Windows.Forms.Padding(4);
            this.business_button.Name = "business_button";
            this.business_button.Size = new System.Drawing.Size(267, 60);
            this.business_button.TabIndex = 2;
            this.business_button.Text = "  🏢   Register Business";
            this.business_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.business_button.UseVisualStyleBackColor = false;
            this.business_button.Click += new System.EventHandler(this.business_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.Location = new System.Drawing.Point(0, 60);
            this.dashboard_button.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(267, 60);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.Text = "  📊 Dashboard";
            this.dashboard_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_button.UseVisualStyleBackColor = false;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // jobnear_button
            // 
            this.jobnear_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobnear_button.Image = global::JobNear.Properties.Resources.JobNearDashboardLogo;
            this.jobnear_button.Location = new System.Drawing.Point(0, 0);
            this.jobnear_button.Margin = new System.Windows.Forms.Padding(4);
            this.jobnear_button.Name = "jobnear_button";
            this.jobnear_button.Size = new System.Drawing.Size(267, 60);
            this.jobnear_button.TabIndex = 0;
            this.jobnear_button.UseVisualStyleBackColor = true;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(267, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1374, 868);
            this.sidebar_panel.TabIndex = 1;
            // 
            // JobPosterDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 868);
            this.Controls.Add(this.sidebar_panel);
            this.Controls.Add(this.JP_sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobPosterDashboardForm";
            this.Text = "Job Poster";
            this.JP_sidebar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel JP_sidebar_panel;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Button view_business_button;
        private System.Windows.Forms.Button business_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button jobnear_button;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Button notification_button;
    }
}