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
            this.label1 = new System.Windows.Forms.Label();
            this.distance_combo = new System.Windows.Forms.ComboBox();
            this.map_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.reset_button = new System.Windows.Forms.Button();
            this.sidebar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.reset_button);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Controls.Add(this.distance_combo);
            this.sidebar_panel.Controls.Add(this.map_panel);
            this.sidebar_panel.Controls.Add(this.label2);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 4;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "📍 Discover Jobs Near You";
            // 
            // distance_combo
            // 
            this.distance_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distance_combo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_combo.FormattingEnabled = true;
            this.distance_combo.Items.AddRange(new object[] {
            "1 km",
            "5 km",
            "10 km",
            "20 km",
            "50 km",
            "Free Navigation"});
            this.distance_combo.Location = new System.Drawing.Point(35, 73);
            this.distance_combo.Name = "distance_combo";
            this.distance_combo.Size = new System.Drawing.Size(237, 34);
            this.distance_combo.TabIndex = 0;
            this.distance_combo.SelectedIndexChanged += new System.EventHandler(this.distance_combo_SelectedIndexChanged);
            // 
            // map_panel
            // 
            this.map_panel.Location = new System.Drawing.Point(3, 113);
            this.map_panel.Name = "map_panel";
            this.map_panel.Size = new System.Drawing.Size(1025, 589);
            this.map_panel.TabIndex = 0;
            this.map_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.map_panel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(272, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Map Scale";
            // 
            // reset_button
            // 
            this.reset_button.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.Color.White;
            this.reset_button.Location = new System.Drawing.Point(828, 72);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(175, 35);
            this.reset_button.TabIndex = 51;
            this.reset_button.Text = "Reset Map Scale";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // JS_JobBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "JS_JobBrowse";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel map_panel;
        private System.Windows.Forms.ComboBox distance_combo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset_button;
    }
}
