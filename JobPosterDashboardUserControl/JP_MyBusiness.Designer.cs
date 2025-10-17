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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JP_MyBusiness));
            this.mybusiness_flowlayoutpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Sample_panel = new System.Windows.Forms.Panel();
            this.description_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.mybusiness_flowlayoutpanel.SuspendLayout();
            this.Sample_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mybusiness_flowlayoutpanel
            // 
            this.mybusiness_flowlayoutpanel.AutoScroll = true;
            this.mybusiness_flowlayoutpanel.Controls.Add(this.Sample_panel);
            this.mybusiness_flowlayoutpanel.Location = new System.Drawing.Point(46, 42);
            this.mybusiness_flowlayoutpanel.Name = "mybusiness_flowlayoutpanel";
            this.mybusiness_flowlayoutpanel.Size = new System.Drawing.Size(939, 611);
            this.mybusiness_flowlayoutpanel.TabIndex = 0;
            this.mybusiness_flowlayoutpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mybusiness_flowlayoutpanel_Paint);
            // 
            // Sample_panel
            // 
            this.Sample_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sample_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sample_panel.Controls.Add(this.status_label);
            this.Sample_panel.Controls.Add(this.description_label);
            this.Sample_panel.Controls.Add(this.label2);
            this.Sample_panel.Controls.Add(this.label1);
            this.Sample_panel.Location = new System.Drawing.Point(5, 10);
            this.Sample_panel.Margin = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.Sample_panel.Name = "Sample_panel";
            this.Sample_panel.Size = new System.Drawing.Size(923, 150);
            this.Sample_panel.TabIndex = 0;
            this.Sample_panel.Click += new System.EventHandler(this.Sample_panel_Click);
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(318, 32);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(439, 81);
            this.description_label.TabIndex = 2;
            this.description_label.Text = resources.GetString("description_label.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "123 Street City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC Company";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.Location = new System.Drawing.Point(803, 9);
            this.status_label.Name = "status_label";
            this.status_label.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.status_label.Size = new System.Drawing.Size(105, 28);
            this.status_label.TabIndex = 3;
            this.status_label.Text = "Status";
            // 
            // JP_MyBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mybusiness_flowlayoutpanel);
            this.Name = "JP_MyBusiness";
            this.Size = new System.Drawing.Size(1031, 705);
            this.Load += new System.EventHandler(this.JP_MyBusiness_Load);
            this.mybusiness_flowlayoutpanel.ResumeLayout(false);
            this.Sample_panel.ResumeLayout(false);
            this.Sample_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mybusiness_flowlayoutpanel;
        private System.Windows.Forms.Panel Sample_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label status_label;
    }
}
