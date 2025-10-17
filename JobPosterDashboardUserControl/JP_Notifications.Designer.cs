namespace JobNear.JobPosterDashboardUserControl
{
    partial class JP_Notifications
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
            this.notif_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // notif_panel
            // 
            this.notif_panel.Location = new System.Drawing.Point(4, 57);
            this.notif_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notif_panel.Name = "notif_panel";
            this.notif_panel.Size = new System.Drawing.Size(1367, 754);
            this.notif_panel.TabIndex = 1;
            // 
            // JP_Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notif_panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "JP_Notifications";
            this.Size = new System.Drawing.Size(1375, 868);
            this.Load += new System.EventHandler(this.JP_Notifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel notif_panel;
    }
}
