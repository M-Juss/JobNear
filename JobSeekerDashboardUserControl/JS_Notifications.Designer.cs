namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_Notifications
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
            this.notif_panel = new System.Windows.Forms.Panel();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.notif_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.TabIndex = 4;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // notif_panel
            // 
            this.notif_panel.Location = new System.Drawing.Point(4, 65);
            this.notif_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notif_panel.Name = "notif_panel";
            this.notif_panel.Size = new System.Drawing.Size(1367, 754);
            this.notif_panel.TabIndex = 0;
            // 
            // JS_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JS_Notifications";
            this.Size = new System.Drawing.Size(1375, 868);
            this.sidebar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel notif_panel;
    }
}
