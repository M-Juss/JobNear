namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_ViewCoverLetter
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
            this.back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cover_input = new System.Windows.Forms.Label();
            this.header_label = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.back_button);
            this.sidebar_panel.Controls.Add(this.panel1);
            this.sidebar_panel.Controls.Add(this.header_label);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightGray;
            this.back_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(876, 656);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(106, 36);
            this.back_button.TabIndex = 108;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cover_input);
            this.panel1.Location = new System.Drawing.Point(38, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 600);
            this.panel1.TabIndex = 0;
            // 
            // cover_input
            // 
            this.cover_input.AutoEllipsis = true;
            this.cover_input.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cover_input.Location = new System.Drawing.Point(14, 17);
            this.cover_input.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cover_input.Name = "cover_input";
            this.cover_input.Size = new System.Drawing.Size(915, 570);
            this.cover_input.TabIndex = 0;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_label.ForeColor = System.Drawing.Color.Black;
            this.header_label.Location = new System.Drawing.Point(31, 11);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(199, 48);
            this.header_label.TabIndex = 76;
            this.header_label.Text = "Cover Letter:";
            // 
            // JP_ViewCoverLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JP_ViewCoverLetter";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label cover_input;
    }
}
