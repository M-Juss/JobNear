namespace JobNear.Forms
{
    partial class AdminDashboardForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.jobnear_button = new System.Windows.Forms.Button();
            this.side_panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.settings_button);
            this.panel1.Controls.Add(this.logout_button);
            this.panel1.Controls.Add(this.user_button);
            this.panel1.Controls.Add(this.dashboard_button);
            this.panel1.Controls.Add(this.jobnear_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 705);
            this.panel1.TabIndex = 0;
            // 
            // settings_button
            // 
            this.settings_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.settings_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.Location = new System.Drawing.Point(0, 180);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(200, 60);
            this.settings_button.TabIndex = 4;
            this.settings_button.Text = "System Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // logout_button
            // 
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Location = new System.Drawing.Point(0, 645);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(200, 60);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            // 
            // user_button
            // 
            this.user_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_button.Location = new System.Drawing.Point(0, 120);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(200, 60);
            this.user_button.TabIndex = 2;
            this.user_button.Text = "User Management";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.Location = new System.Drawing.Point(0, 60);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(200, 60);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.Text = "Dashboard";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // jobnear_button
            // 
            this.jobnear_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.jobnear_button.Image = global::JobNear.Properties.Resources.JobNearDashboardLogo;
            this.jobnear_button.Location = new System.Drawing.Point(0, 0);
            this.jobnear_button.Name = "jobnear_button";
            this.jobnear_button.Size = new System.Drawing.Size(200, 60);
            this.jobnear_button.TabIndex = 0;
            this.jobnear_button.UseVisualStyleBackColor = true;
            // 
            // side_panel
            // 
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.side_panel.Location = new System.Drawing.Point(200, 0);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(1031, 705);
            this.side_panel.TabIndex = 1;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 705);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.Button jobnear_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button settings_button;
    }
}