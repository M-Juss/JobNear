namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_ManageAdmin
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
            this.seeker_table = new System.Windows.Forms.DataGridView();
            this.info_panel = new System.Windows.Forms.Panel();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.confirm_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.role_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status_combo = new System.Windows.Forms.ComboBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.sidebar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).BeginInit();
            this.info_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.info_panel);
            this.sidebar_panel.Controls.Add(this.seeker_table);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // seeker_table
            // 
            this.seeker_table.AllowUserToAddRows = false;
            this.seeker_table.AllowUserToDeleteRows = false;
            this.seeker_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seeker_table.Location = new System.Drawing.Point(29, 389);
            this.seeker_table.Name = "seeker_table";
            this.seeker_table.ReadOnly = true;
            this.seeker_table.RowHeadersWidth = 51;
            this.seeker_table.Size = new System.Drawing.Size(973, 292);
            this.seeker_table.TabIndex = 4;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.clear_button);
            this.info_panel.Controls.Add(this.submit_button);
            this.info_panel.Controls.Add(this.label6);
            this.info_panel.Controls.Add(this.status_combo);
            this.info_panel.Controls.Add(this.label5);
            this.info_panel.Controls.Add(this.role_combo);
            this.info_panel.Controls.Add(this.name_input);
            this.info_panel.Controls.Add(this.label4);
            this.info_panel.Controls.Add(this.confirm_input);
            this.info_panel.Controls.Add(this.label2);
            this.info_panel.Controls.Add(this.password_input);
            this.info_panel.Controls.Add(this.username_input);
            this.info_panel.Controls.Add(this.label3);
            this.info_panel.Controls.Add(this.Username);
            this.info_panel.Location = new System.Drawing.Point(29, 54);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(973, 315);
            this.info_panel.TabIndex = 5;
            // 
            // username_input
            // 
            this.username_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_input.Location = new System.Drawing.Point(48, 48);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(417, 31);
            this.username_input.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(43, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Username.Location = new System.Drawing.Point(43, 17);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(97, 28);
            this.Username.TabIndex = 22;
            this.Username.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 42);
            this.label1.TabIndex = 26;
            this.label1.Text = "Account Information";
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(48, 128);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(417, 31);
            this.password_input.TabIndex = 26;
            // 
            // confirm_input
            // 
            this.confirm_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_input.Location = new System.Drawing.Point(48, 209);
            this.confirm_input.Name = "confirm_input";
            this.confirm_input.Size = new System.Drawing.Size(417, 31);
            this.confirm_input.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(43, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(502, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fullname:";
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(507, 48);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(417, 31);
            this.name_input.TabIndex = 30;
            // 
            // role_combo
            // 
            this.role_combo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_combo.FormattingEnabled = true;
            this.role_combo.Location = new System.Drawing.Point(507, 128);
            this.role_combo.Name = "role_combo";
            this.role_combo.Size = new System.Drawing.Size(417, 31);
            this.role_combo.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(502, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(502, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Status:";
            // 
            // status_combo
            // 
            this.status_combo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_combo.FormattingEnabled = true;
            this.status_combo.Location = new System.Drawing.Point(507, 209);
            this.status_combo.Name = "status_combo";
            this.status_combo.Size = new System.Drawing.Size(417, 31);
            this.status_combo.TabIndex = 33;
            // 
            // submit_button
            // 
            this.submit_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(819, 263);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(105, 32);
            this.submit_button.TabIndex = 46;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(698, 263);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(106, 32);
            this.clear_button.TabIndex = 47;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            // 
            // Admin_ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_ManageAdmin";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seeker_table)).EndInit();
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.DataGridView seeker_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirm_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.ComboBox role_combo;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox status_combo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button submit_button;
    }
}
