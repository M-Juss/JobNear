namespace JobNear.JobSeekerDashboardUserControl
{
    partial class JS_JobBrowse
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
            this.map_panel = new System.Windows.Forms.Panel();
            this.distance_combo = new System.Windows.Forms.ComboBox();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.distance_combo);
            this.sidebar_panel.Controls.Add(this.map_panel);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 4;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // map_panel
            // 
            this.map_panel.Location = new System.Drawing.Point(35, 53);
            this.map_panel.Name = "map_panel";
            this.map_panel.Size = new System.Drawing.Size(956, 616);
            this.map_panel.TabIndex = 0;
            this.map_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.map_panel_Paint);
            // 
            // distance_combo
            // 
            this.distance_combo.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_combo.FormattingEnabled = true;
            this.distance_combo.Items.AddRange(new object[] {
            "1 km",
            "5 km",
            "10 km",
            "20 km",
            "50 km",
            "Free Navigation"});
            this.distance_combo.Location = new System.Drawing.Point(35, 5);
            this.distance_combo.Name = "distance_combo";
            this.distance_combo.Size = new System.Drawing.Size(121, 42);
            this.distance_combo.TabIndex = 0;
            this.distance_combo.SelectedIndexChanged += new System.EventHandler(this.distance_combo_SelectedIndexChanged);
            // 
            // JS_JobBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JS_JobBrowse";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel map_panel;
        private System.Windows.Forms.ComboBox distance_combo;
    }
}
