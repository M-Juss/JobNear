namespace JobNear.AdminDashboardUserControl
{
    partial class Admin_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebar_panel = new System.Windows.Forms.Panel();
            this.graph_panel = new System.Windows.Forms.Panel();
            this.chartApplicantsEmployers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stats_panel = new System.Windows.Forms.Panel();
            this.complaints_panel = new System.Windows.Forms.Panel();
            this.complaints_lbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.active_panel = new System.Windows.Forms.Panel();
            this.jobs_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seekers_panel = new System.Windows.Forms.Panel();
            this.seeker_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pending_panel = new System.Windows.Forms.Panel();
            this.pendingSeekers_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.verified_panel = new System.Windows.Forms.Panel();
            this.pendingBusiness_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registered_panel = new System.Windows.Forms.Panel();
            this.business_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar_panel.SuspendLayout();
            this.graph_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartApplicantsEmployers)).BeginInit();
            this.stats_panel.SuspendLayout();
            this.complaints_panel.SuspendLayout();
            this.active_panel.SuspendLayout();
            this.seekers_panel.SuspendLayout();
            this.pending_panel.SuspendLayout();
            this.verified_panel.SuspendLayout();
            this.registered_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar_panel
            // 
            this.sidebar_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar_panel.Controls.Add(this.graph_panel);
            this.sidebar_panel.Controls.Add(this.stats_panel);
            this.sidebar_panel.Controls.Add(this.label1);
            this.sidebar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar_panel.Location = new System.Drawing.Point(0, 0);
            this.sidebar_panel.Name = "sidebar_panel";
            this.sidebar_panel.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.TabIndex = 0;
            this.sidebar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_panel_Paint);
            // 
            // graph_panel
            // 
            this.graph_panel.Controls.Add(this.chartApplicantsEmployers);
            this.graph_panel.Location = new System.Drawing.Point(24, 349);
            this.graph_panel.Name = "graph_panel";
            this.graph_panel.Size = new System.Drawing.Size(979, 328);
            this.graph_panel.TabIndex = 1;
            // 
            // chartApplicantsEmployers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartApplicantsEmployers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartApplicantsEmployers.Legends.Add(legend1);
            this.chartApplicantsEmployers.Location = new System.Drawing.Point(34, 17);
            this.chartApplicantsEmployers.Name = "chartApplicantsEmployers";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartApplicantsEmployers.Series.Add(series1);
            this.chartApplicantsEmployers.Size = new System.Drawing.Size(911, 295);
            this.chartApplicantsEmployers.TabIndex = 2;
            this.chartApplicantsEmployers.Text = "chart1";
            // 
            // stats_panel
            // 
            this.stats_panel.Controls.Add(this.complaints_panel);
            this.stats_panel.Controls.Add(this.active_panel);
            this.stats_panel.Controls.Add(this.seekers_panel);
            this.stats_panel.Controls.Add(this.pending_panel);
            this.stats_panel.Controls.Add(this.verified_panel);
            this.stats_panel.Controls.Add(this.registered_panel);
            this.stats_panel.Location = new System.Drawing.Point(24, 51);
            this.stats_panel.Name = "stats_panel";
            this.stats_panel.Size = new System.Drawing.Size(979, 283);
            this.stats_panel.TabIndex = 0;
            // 
            // complaints_panel
            // 
            this.complaints_panel.BackColor = System.Drawing.Color.White;
            this.complaints_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.complaints_panel.Controls.Add(this.complaints_lbl);
            this.complaints_panel.Controls.Add(this.label10);
            this.complaints_panel.Location = new System.Drawing.Point(665, 148);
            this.complaints_panel.Name = "complaints_panel";
            this.complaints_panel.Size = new System.Drawing.Size(280, 117);
            this.complaints_panel.TabIndex = 17;
            // 
            // complaints_lbl
            // 
            this.complaints_lbl.AutoSize = true;
            this.complaints_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaints_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.complaints_lbl.Location = new System.Drawing.Point(6, 32);
            this.complaints_lbl.Name = "complaints_lbl";
            this.complaints_lbl.Size = new System.Drawing.Size(145, 84);
            this.complaints_lbl.TabIndex = 11;
            this.complaints_lbl.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(15, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Number of Active Complaints";
            // 
            // active_panel
            // 
            this.active_panel.BackColor = System.Drawing.Color.White;
            this.active_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.active_panel.Controls.Add(this.jobs_lbl);
            this.active_panel.Controls.Add(this.label4);
            this.active_panel.Location = new System.Drawing.Point(665, 16);
            this.active_panel.Name = "active_panel";
            this.active_panel.Size = new System.Drawing.Size(280, 117);
            this.active_panel.TabIndex = 15;
            // 
            // jobs_lbl
            // 
            this.jobs_lbl.AutoSize = true;
            this.jobs_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobs_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.jobs_lbl.Location = new System.Drawing.Point(6, 32);
            this.jobs_lbl.Name = "jobs_lbl";
            this.jobs_lbl.Size = new System.Drawing.Size(145, 84);
            this.jobs_lbl.TabIndex = 5;
            this.jobs_lbl.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of Active Jobs";
            // 
            // seekers_panel
            // 
            this.seekers_panel.BackColor = System.Drawing.Color.White;
            this.seekers_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seekers_panel.Controls.Add(this.seeker_lbl);
            this.seekers_panel.Controls.Add(this.label2);
            this.seekers_panel.Location = new System.Drawing.Point(350, 16);
            this.seekers_panel.Name = "seekers_panel";
            this.seekers_panel.Size = new System.Drawing.Size(280, 117);
            this.seekers_panel.TabIndex = 14;
            // 
            // seeker_lbl
            // 
            this.seeker_lbl.AutoSize = true;
            this.seeker_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeker_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.seeker_lbl.Location = new System.Drawing.Point(6, 32);
            this.seeker_lbl.Name = "seeker_lbl";
            this.seeker_lbl.Size = new System.Drawing.Size(145, 84);
            this.seeker_lbl.TabIndex = 5;
            this.seeker_lbl.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Verified Job Seekers";
            // 
            // pending_panel
            // 
            this.pending_panel.BackColor = System.Drawing.Color.White;
            this.pending_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pending_panel.Controls.Add(this.pendingSeekers_lbl);
            this.pending_panel.Controls.Add(this.label8);
            this.pending_panel.Location = new System.Drawing.Point(350, 148);
            this.pending_panel.Name = "pending_panel";
            this.pending_panel.Size = new System.Drawing.Size(280, 117);
            this.pending_panel.TabIndex = 16;
            // 
            // pendingSeekers_lbl
            // 
            this.pendingSeekers_lbl.AutoSize = true;
            this.pendingSeekers_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingSeekers_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pendingSeekers_lbl.Location = new System.Drawing.Point(6, 32);
            this.pendingSeekers_lbl.Name = "pendingSeekers_lbl";
            this.pendingSeekers_lbl.Size = new System.Drawing.Size(145, 84);
            this.pendingSeekers_lbl.TabIndex = 9;
            this.pendingSeekers_lbl.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(15, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 26);
            this.label8.TabIndex = 8;
            this.label8.Text = "Number of Pending Job Seekers";
            // 
            // verified_panel
            // 
            this.verified_panel.BackColor = System.Drawing.Color.White;
            this.verified_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verified_panel.Controls.Add(this.pendingBusiness_lbl);
            this.verified_panel.Controls.Add(this.label6);
            this.verified_panel.Location = new System.Drawing.Point(35, 148);
            this.verified_panel.Name = "verified_panel";
            this.verified_panel.Size = new System.Drawing.Size(280, 117);
            this.verified_panel.TabIndex = 17;
            // 
            // pendingBusiness_lbl
            // 
            this.pendingBusiness_lbl.AutoSize = true;
            this.pendingBusiness_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingBusiness_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.pendingBusiness_lbl.Location = new System.Drawing.Point(6, 32);
            this.pendingBusiness_lbl.Name = "pendingBusiness_lbl";
            this.pendingBusiness_lbl.Size = new System.Drawing.Size(145, 84);
            this.pendingBusiness_lbl.TabIndex = 7;
            this.pendingBusiness_lbl.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Pending Business";
            // 
            // registered_panel
            // 
            this.registered_panel.BackColor = System.Drawing.Color.White;
            this.registered_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registered_panel.Controls.Add(this.business_lbl);
            this.registered_panel.Controls.Add(this.label11);
            this.registered_panel.Location = new System.Drawing.Point(34, 16);
            this.registered_panel.Name = "registered_panel";
            this.registered_panel.Size = new System.Drawing.Size(280, 117);
            this.registered_panel.TabIndex = 13;
            // 
            // business_lbl
            // 
            this.business_lbl.AutoSize = true;
            this.business_lbl.Font = new System.Drawing.Font("Poppins SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.business_lbl.Location = new System.Drawing.Point(6, 32);
            this.business_lbl.Name = "business_lbl";
            this.business_lbl.Size = new System.Drawing.Size(145, 84);
            this.business_lbl.TabIndex = 5;
            this.business_lbl.Text = "1000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(15, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "Number of Verified Business";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "Insights and Analytics";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidebar_panel);
            this.Name = "Admin_Dashboard";
            this.Size = new System.Drawing.Size(1031, 705);
            this.sidebar_panel.ResumeLayout(false);
            this.sidebar_panel.PerformLayout();
            this.graph_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartApplicantsEmployers)).EndInit();
            this.stats_panel.ResumeLayout(false);
            this.complaints_panel.ResumeLayout(false);
            this.complaints_panel.PerformLayout();
            this.active_panel.ResumeLayout(false);
            this.active_panel.PerformLayout();
            this.seekers_panel.ResumeLayout(false);
            this.seekers_panel.PerformLayout();
            this.pending_panel.ResumeLayout(false);
            this.pending_panel.PerformLayout();
            this.verified_panel.ResumeLayout(false);
            this.verified_panel.PerformLayout();
            this.registered_panel.ResumeLayout(false);
            this.registered_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar_panel;
        private System.Windows.Forms.Panel graph_panel;
        private System.Windows.Forms.Panel stats_panel;
        private System.Windows.Forms.Panel pending_panel;
        private System.Windows.Forms.Panel verified_panel;
        private System.Windows.Forms.Panel registered_panel;
        private System.Windows.Forms.Label business_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel seekers_panel;
        private System.Windows.Forms.Label seeker_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel complaints_panel;
        private System.Windows.Forms.Label complaints_lbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel active_panel;
        private System.Windows.Forms.Label jobs_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pendingSeekers_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label pendingBusiness_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartApplicantsEmployers;
        private System.Windows.Forms.Label label1;
    }
}
