namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_ControlSiteSettings
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
            this.maintenance_panel = new System.Windows.Forms.Panel();
            this.deactivate_button = new System.Windows.Forms.Button();
            this.activate_button = new System.Windows.Forms.Button();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.send_button = new System.Windows.Forms.Button();
            this.description_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.revoke_button = new System.Windows.Forms.Button();
            this.sidebar_panel.SuspendLayout();
            this.maintenance_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.maintenance_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // maintenance_panel
            // 
            this.maintenance_panel.BackColor = System.Drawing.Color.White;
            this.maintenance_panel.Controls.Add(this.deactivate_button);
            this.maintenance_panel.Controls.Add(this.activate_button);
            this.maintenance_panel.Controls.Add(this.end_date);
            this.maintenance_panel.Controls.Add(this.start_date);
            this.maintenance_panel.Controls.Add(this.label5);
            this.maintenance_panel.Controls.Add(this.send_button);
            this.maintenance_panel.Controls.Add(this.description_input);
            this.maintenance_panel.Controls.Add(this.name_input);
            this.maintenance_panel.Controls.Add(this.label4);
            this.maintenance_panel.Controls.Add(this.label3);
            this.maintenance_panel.Controls.Add(this.label2);
            this.maintenance_panel.Controls.Add(this.label1);
            this.maintenance_panel.Controls.Add(this.revoke_button);
            this.maintenance_panel.Location = new System.Drawing.Point(158, 62);
            this.maintenance_panel.Name = "maintenance_panel";
            this.maintenance_panel.Size = new System.Drawing.Size(714, 567);
            this.maintenance_panel.TabIndex = 2;
            // 
            // deactivate_button
            // 
            this.deactivate_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivate_button.ForeColor = System.Drawing.Color.White;
            this.deactivate_button.Location = new System.Drawing.Point(362, 504);
            this.deactivate_button.Name = "deactivate_button";
            this.deactivate_button.Size = new System.Drawing.Size(324, 44);
            this.deactivate_button.TabIndex = 105;
            this.deactivate_button.Text = "Deactivate Maintenance";
            this.deactivate_button.UseVisualStyleBackColor = true;
            this.deactivate_button.Click += new System.EventHandler(this.deactivate_button_Click);
            // 
            // activate_button
            // 
            this.activate_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activate_button.ForeColor = System.Drawing.Color.White;
            this.activate_button.Location = new System.Drawing.Point(26, 504);
            this.activate_button.Name = "activate_button";
            this.activate_button.Size = new System.Drawing.Size(321, 44);
            this.activate_button.TabIndex = 104;
            this.activate_button.Text = "Activate Maintenance";
            this.activate_button.UseVisualStyleBackColor = true;
            this.activate_button.Click += new System.EventHandler(this.activate_button_Click);
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(362, 400);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(324, 31);
            this.end_date.TabIndex = 103;
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(26, 400);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(321, 31);
            this.start_date.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 28);
            this.label5.TabIndex = 101;
            this.label5.Text = "Expected End Date:";
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.ForeColor = System.Drawing.Color.White;
            this.send_button.Location = new System.Drawing.Point(260, 450);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(180, 38);
            this.send_button.TabIndex = 99;
            this.send_button.Text = "Send Notification";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // description_input
            // 
            this.description_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_input.Location = new System.Drawing.Point(26, 172);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(660, 173);
            this.description_input.TabIndex = 27;
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(26, 98);
            this.name_input.Multiline = true;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(660, 41);
            this.name_input.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "Maintenance Announcement";
            // 
            // revoke_button
            // 
            this.revoke_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revoke_button.ForeColor = System.Drawing.Color.White;
            this.revoke_button.Location = new System.Drawing.Point(260, 450);
            this.revoke_button.Name = "revoke_button";
            this.revoke_button.Size = new System.Drawing.Size(180, 38);
            this.revoke_button.TabIndex = 106;
            this.revoke_button.Text = "Revoke Notification";
            this.revoke_button.UseVisualStyleBackColor = true;
            this.revoke_button.Click += new System.EventHandler(this.revoke_button_Click);
            // 
            // Admin_ControlSiteSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_ControlSiteSettings";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.maintenance_panel.ResumeLayout(false);
            this.maintenance_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel maintenance_panel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.TextBox description_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deactivate_button;
        private System.Windows.Forms.Button activate_button;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.DateTimePicker start_date;
        private System.Windows.Forms.Button revoke_button;
    }
}
