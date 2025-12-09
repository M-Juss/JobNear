namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_TermsAndPolicy
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
            this.label1 = new System.Windows.Forms.Label();
            this.tems_panel = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.read_lbl = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.tems_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.tems_panel);
            this.sidebar_panel.Controls.Add(this.back_button);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 70);
            this.label1.TabIndex = 10;
            this.label1.Text = "JobNear Terms and Policy";
            // 
            // tems_panel
            // 
            this.tems_panel.AutoScroll = true;
            this.tems_panel.Controls.Add(this.read_lbl);
            this.tems_panel.Location = new System.Drawing.Point(57, 64);
            this.tems_panel.Name = "tems_panel";
            this.tems_panel.Size = new System.Drawing.Size(1260, 740);
            this.tems_panel.TabIndex = 11;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightGray;
            this.back_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(1176, 813);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 44);
            this.back_button.TabIndex = 108;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // read_lbl
            // 
            this.read_lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_lbl.Location = new System.Drawing.Point(24, 20);
            this.read_lbl.Name = "read_lbl";
            this.read_lbl.Size = new System.Drawing.Size(1192, 856);
            this.read_lbl.TabIndex = 0;
            // 
            // Admin_TermsAndPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_TermsAndPolicy";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.tems_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel tems_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label read_lbl;
        private System.Windows.Forms.Button back_button;
    }
}
