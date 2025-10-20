namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_MyBusiness
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
            this.mybusiness_flowlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.my_business_panel = new System.Windows.Forms.Panel();
            this.my_business_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mybusiness_flowlayout
            // 
            this.mybusiness_flowlayout.AutoScroll = true;
            this.mybusiness_flowlayout.Location = new System.Drawing.Point(33, 38);
            this.mybusiness_flowlayout.Name = "mybusiness_flowlayout";
            this.mybusiness_flowlayout.Size = new System.Drawing.Size(959, 630);
            this.mybusiness_flowlayout.TabIndex = 0;
            // 
            // my_business_panel
            // 
            this.my_business_panel.Controls.Add(this.mybusiness_flowlayout);
            this.my_business_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.my_business_panel.Location = new System.Drawing.Point(0, 0);
            this.my_business_panel.Name = "my_business_panel";
            this.my_business_panel.Size = new System.Drawing.Size(1031, 705);
            this.my_business_panel.TabIndex = 1;
            // 
            // JP_MyBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.my_business_panel);
            this.Name = "JP_MyBusiness";
            this.Size = new System.Drawing.Size(1031, 705);
            this.my_business_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mybusiness_flowlayout;
        private System.Windows.Forms.Panel my_business_panel;
    }
}
