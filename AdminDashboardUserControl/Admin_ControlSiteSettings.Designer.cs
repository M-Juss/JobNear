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
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.panel2);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.revoke_button);
            this.panel2.Controls.Add(this.deactivate_button);
            this.panel2.Controls.Add(this.activate_button);
            this.panel2.Controls.Add(this.end_date);
            this.panel2.Controls.Add(this.start_date);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.send_button);
            this.panel2.Controls.Add(this.description_input);
            this.panel2.Controls.Add(this.name_input);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(211, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 677);
            this.panel2.TabIndex = 2;
            // 
            // deactivate_button
            // 
            this.deactivate_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivate_button.ForeColor = System.Drawing.Color.White;
            this.deactivate_button.Location = new System.Drawing.Point(483, 590);
            this.deactivate_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deactivate_button.Name = "deactivate_button";
            this.deactivate_button.Size = new System.Drawing.Size(432, 54);
            this.deactivate_button.TabIndex = 105;
            this.deactivate_button.Text = "Deactivate Maintenance";
            this.deactivate_button.UseVisualStyleBackColor = true;
            // 
            // activate_button
            // 
            this.activate_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activate_button.ForeColor = System.Drawing.Color.White;
            this.activate_button.Location = new System.Drawing.Point(35, 590);
            this.activate_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activate_button.Name = "activate_button";
            this.activate_button.Size = new System.Drawing.Size(428, 54);
            this.activate_button.TabIndex = 104;
            this.activate_button.Text = "Activate Maintenance";
            this.activate_button.UseVisualStyleBackColor = true;
            this.activate_button.Click += new System.EventHandler(this.activate_button_Click);
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Location = new System.Drawing.Point(483, 437);
            this.end_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(431, 37);
            this.end_date.TabIndex = 103;
            // 
            // start_date
            // 
            this.start_date.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_date.Location = new System.Drawing.Point(35, 437);
            this.start_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(427, 37);
            this.start_date.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 399);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 36);
            this.label5.TabIndex = 101;
            this.label5.Text = "Expected End Date:";
            // 
            // send_button
            // 
            this.send_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_button.ForeColor = System.Drawing.Color.White;
            this.send_button.Location = new System.Drawing.Point(347, 495);
            this.send_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(240, 47);
            this.send_button.TabIndex = 99;
            this.send_button.Text = "Send Notification";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // description_input
            // 
            this.description_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_input.Location = new System.Drawing.Point(35, 212);
            this.description_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(879, 169);
            this.description_input.TabIndex = 27;
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(35, 121);
            this.name_input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(879, 37);
            this.name_input.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 399);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 70);
            this.label1.TabIndex = 12;
            this.label1.Text = "Maintenance Announcement";
            // 
            // revoke_button
            // 
            this.revoke_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revoke_button.ForeColor = System.Drawing.Color.White;
            this.revoke_button.Location = new System.Drawing.Point(347, 495);
            this.revoke_button.Margin = new System.Windows.Forms.Padding(4);
            this.revoke_button.Name = "revoke_button";
            this.revoke_button.Size = new System.Drawing.Size(240, 47);
            this.revoke_button.TabIndex = 106;
            this.revoke_button.Text = "Send Notification";
            this.revoke_button.UseVisualStyleBackColor = true;
            this.revoke_button.Click += new System.EventHandler(this.revoke_button_Click);
            // 
            // Admin_ControlSiteSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin_ControlSiteSettings";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel panel2;
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
