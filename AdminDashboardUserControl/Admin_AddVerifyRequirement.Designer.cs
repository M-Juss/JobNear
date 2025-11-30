namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_AddVerifyRequirement
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
            this.req_panel = new System.Windows.Forms.Panel();
            this.user_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.image_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.attach_file = new System.Windows.Forms.Button();
            this.requirement_combo = new System.Windows.Forms.ComboBox();
            this.description_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.req_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.req_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            // 
            // req_panel
            // 
            this.req_panel.Controls.Add(this.user_combo);
            this.req_panel.Controls.Add(this.label5);
            this.req_panel.Controls.Add(this.cancel_button);
            this.req_panel.Controls.Add(this.add_button);
            this.req_panel.Controls.Add(this.image_flowlayout);
            this.req_panel.Controls.Add(this.attach_file);
            this.req_panel.Controls.Add(this.requirement_combo);
            this.req_panel.Controls.Add(this.description_input);
            this.req_panel.Controls.Add(this.name_input);
            this.req_panel.Controls.Add(this.label4);
            this.req_panel.Controls.Add(this.label3);
            this.req_panel.Controls.Add(this.label2);
            this.req_panel.Controls.Add(this.label1);
            this.req_panel.Location = new System.Drawing.Point(157, 31);
            this.req_panel.Name = "req_panel";
            this.req_panel.Size = new System.Drawing.Size(716, 642);
            this.req_panel.TabIndex = 1;
            // 
            // user_combo
            // 
            this.user_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_combo.FormattingEnabled = true;
            this.user_combo.Items.AddRange(new object[] {
            "For Job Seeker",
            "For Job Poster"});
            this.user_combo.Location = new System.Drawing.Point(362, 355);
            this.user_combo.Name = "user_combo";
            this.user_combo.Size = new System.Drawing.Size(324, 33);
            this.user_combo.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(357, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 101;
            this.label5.Text = "User Type";
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.Color.White;
            this.cancel_button.Location = new System.Drawing.Point(496, 593);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(89, 32);
            this.cancel_button.TabIndex = 100;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(597, 593);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(89, 32);
            this.add_button.TabIndex = 99;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // image_flowlayout
            // 
            this.image_flowlayout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.image_flowlayout.Location = new System.Drawing.Point(26, 461);
            this.image_flowlayout.Name = "image_flowlayout";
            this.image_flowlayout.Size = new System.Drawing.Size(660, 116);
            this.image_flowlayout.TabIndex = 98;
            // 
            // attach_file
            // 
            this.attach_file.BackColor = System.Drawing.Color.White;
            this.attach_file.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attach_file.Location = new System.Drawing.Point(26, 408);
            this.attach_file.Name = "attach_file";
            this.attach_file.Size = new System.Drawing.Size(660, 47);
            this.attach_file.TabIndex = 78;
            this.attach_file.Text = "Click here to attach a document";
            this.attach_file.UseVisualStyleBackColor = false;
            this.attach_file.Click += new System.EventHandler(this.attach_file_Click);
            // 
            // requirement_combo
            // 
            this.requirement_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requirement_combo.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requirement_combo.FormattingEnabled = true;
            this.requirement_combo.Items.AddRange(new object[] {
            "Required",
            "Optional"});
            this.requirement_combo.Location = new System.Drawing.Point(26, 355);
            this.requirement_combo.Name = "requirement_combo";
            this.requirement_combo.Size = new System.Drawing.Size(324, 33);
            this.requirement_combo.TabIndex = 28;
            // 
            // description_input
            // 
            this.description_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_input.Location = new System.Drawing.Point(26, 172);
            this.description_input.Multiline = true;
            this.description_input.Name = "description_input";
            this.description_input.Size = new System.Drawing.Size(660, 138);
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
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(21, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Requirement Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
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
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Document Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Requirements";
            // 
            // Admin_AddVerifyRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_AddVerifyRequirement";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.req_panel.ResumeLayout(false);
            this.req_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel req_panel;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.FlowLayoutPanel image_flowlayout;
        private System.Windows.Forms.Button attach_file;
        private System.Windows.Forms.ComboBox requirement_combo;
        private System.Windows.Forms.TextBox description_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox user_combo;
        private System.Windows.Forms.Label label5;
    }
}
