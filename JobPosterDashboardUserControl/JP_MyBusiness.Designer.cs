﻿namespace JobNear.JobPosterDashboardUserControl
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
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mybusiness_flowlayout
            // 
            this.mybusiness_flowlayout.AutoScroll = true;
            this.mybusiness_flowlayout.Location = new System.Drawing.Point(35, 81);
            this.mybusiness_flowlayout.Name = "mybusiness_flowlayout";
            this.mybusiness_flowlayout.Size = new System.Drawing.Size(957, 587);
            this.mybusiness_flowlayout.TabIndex = 0;
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.mybusiness_flowlayout);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 1;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.my_business_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Businesses";
            // 
            // JP_MyBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JP_MyBusiness";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mybusiness_flowlayout;
        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Label label1;
    }
}
