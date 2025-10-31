namespace JobNear.AdminDashboardUserControl
{
    partial class JP_ViewInformation
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
            this.username_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mybusiness_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.phone_input);
            this.sidebar_panel.Controls.Add(this.mybusiness_flowlayout);
            this.sidebar_panel.Controls.Add(this.username_label);
            this.sidebar_panel.Controls.Add(this.panel2);
            this.sidebar_panel.Controls.Add(this.email_input);
            this.sidebar_panel.Controls.Add(this.label9);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(28, 22);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(134, 39);
            this.username_label.TabIndex = 102;
            this.username_label.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(36, 61);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 1);
            this.panel2.TabIndex = 101;
            // 
            // email_input
            // 
            this.email_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_input.Location = new System.Drawing.Point(35, 104);
            this.email_input.Margin = new System.Windows.Forms.Padding(2);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(460, 28);
            this.email_input.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 28);
            this.label9.TabIndex = 98;
            this.label9.Text = "Email Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 97;
            this.label1.Text = "Phone Number:";
            // 
            // mybusiness_flowlayout
            // 
            this.mybusiness_flowlayout.AutoScroll = true;
            this.mybusiness_flowlayout.Location = new System.Drawing.Point(37, 167);
            this.mybusiness_flowlayout.Name = "mybusiness_flowlayout";
            this.mybusiness_flowlayout.Size = new System.Drawing.Size(957, 500);
            this.mybusiness_flowlayout.TabIndex = 103;
            // 
            // phone_input
            // 
            this.phone_input.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_input.Location = new System.Drawing.Point(531, 104);
            this.phone_input.Margin = new System.Windows.Forms.Padding(2);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(460, 28);
            this.phone_input.TabIndex = 104;
            // 
            // JP_ViewInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_ViewInformation";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_input;
        private System.Windows.Forms.FlowLayoutPanel mybusiness_flowlayout;
    }
}
