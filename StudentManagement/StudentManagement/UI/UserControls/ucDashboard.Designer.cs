namespace StudentManagement.UI.UserControls
{
    partial class ucDashboard
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            pnlStudents = new Panel();
            lblTotalStudentsCount = new Label();
            lblTotalStudentsTitle = new Label();
            pnlClasses = new Panel();
            lblTotalClassesCount = new Label();
            lblTotalClassesTitle = new Label();
            chartGenderDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStudentsPerClass = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblDashboardTitle = new Label();
            pbDashboard = new PictureBox();
            pnlStudents.SuspendLayout();
            pnlClasses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGenderDistribution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStudentsPerClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard).BeginInit();
            SuspendLayout();
            // 
            // pnlStudents
            // 
            pnlStudents.BackColor = Color.FromArgb(0, 192, 192);
            pnlStudents.Controls.Add(lblTotalStudentsCount);
            pnlStudents.Controls.Add(lblTotalStudentsTitle);
            pnlStudents.Location = new Point(14, 90);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(250, 125);
            pnlStudents.TabIndex = 0;
            // 
            // lblTotalStudentsCount
            // 
            lblTotalStudentsCount.AutoSize = true;
            lblTotalStudentsCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudentsCount.ForeColor = Color.White;
            lblTotalStudentsCount.Location = new Point(20, 45);
            lblTotalStudentsCount.Name = "lblTotalStudentsCount";
            lblTotalStudentsCount.Size = new Size(46, 54);
            lblTotalStudentsCount.TabIndex = 1;
            lblTotalStudentsCount.Text = "0";
            // 
            // lblTotalStudentsTitle
            // 
            lblTotalStudentsTitle.AutoSize = true;
            lblTotalStudentsTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalStudentsTitle.ForeColor = Color.White;
            lblTotalStudentsTitle.Location = new Point(20, 20);
            lblTotalStudentsTitle.Name = "lblTotalStudentsTitle";
            lblTotalStudentsTitle.Size = new Size(131, 25);
            lblTotalStudentsTitle.TabIndex = 0;
            lblTotalStudentsTitle.Text = "Total Students";
            // 
            // pnlClasses
            // 
            pnlClasses.BackColor = Color.FromArgb(255, 128, 0);
            pnlClasses.Controls.Add(lblTotalClassesCount);
            pnlClasses.Controls.Add(lblTotalClassesTitle);
            pnlClasses.Location = new Point(320, 90);
            pnlClasses.Name = "pnlClasses";
            pnlClasses.Size = new Size(250, 125);
            pnlClasses.TabIndex = 1;
            // 
            // lblTotalClassesCount
            // 
            lblTotalClassesCount.AutoSize = true;
            lblTotalClassesCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClassesCount.ForeColor = Color.White;
            lblTotalClassesCount.Location = new Point(20, 45);
            lblTotalClassesCount.Name = "lblTotalClassesCount";
            lblTotalClassesCount.Size = new Size(46, 54);
            lblTotalClassesCount.TabIndex = 1;
            lblTotalClassesCount.Text = "0";
            // 
            // lblTotalClassesTitle
            // 
            lblTotalClassesTitle.AutoSize = true;
            lblTotalClassesTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalClassesTitle.ForeColor = Color.White;
            lblTotalClassesTitle.Location = new Point(20, 20);
            lblTotalClassesTitle.Name = "lblTotalClassesTitle";
            lblTotalClassesTitle.Size = new Size(116, 25);
            lblTotalClassesTitle.TabIndex = 0;
            lblTotalClassesTitle.Text = "Total Classes";
            // 
            // chartGenderDistribution
            // 
            chartArea1.Name = "ChartArea1";
            chartGenderDistribution.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGenderDistribution.Legends.Add(legend1);
            chartGenderDistribution.Location = new Point(40, 240);
            chartGenderDistribution.Name = "chartGenderDistribution";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            chartGenderDistribution.Series.Add(series1);
            chartGenderDistribution.Size = new Size(530, 430);
            chartGenderDistribution.TabIndex = 2;
            chartGenderDistribution.Text = "chart1";
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Gender Distribution";
            chartGenderDistribution.Titles.Add(title1);
            // 
            // chartStudentsPerClass
            // 
            chartArea2.Name = "ChartArea1";
            chartStudentsPerClass.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            chartStudentsPerClass.Legends.Add(legend2);
            chartStudentsPerClass.Location = new Point(600, 240);
            chartStudentsPerClass.Name = "chartStudentsPerClass";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Students";
            chartStudentsPerClass.Series.Add(series2);
            chartStudentsPerClass.Size = new Size(550, 430);
            chartStudentsPerClass.TabIndex = 3;
            chartStudentsPerClass.Text = "chart2";
            title2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.Name = "Title1";
            title2.Text = "Students per Class";
            chartStudentsPerClass.Titles.Add(title2);
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.Location = new Point(47, 35);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(114, 28);
            lblDashboardTitle.TabIndex = 4;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // pbDashboard
            // 
            pbDashboard.Image = Properties.Resources.dashboard_icon;
            pbDashboard.Location = new Point(14, 40);
            pbDashboard.Name = "pbDashboard";
            pbDashboard.Size = new Size(27, 23);
            pbDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pbDashboard.TabIndex = 6;
            pbDashboard.TabStop = false;
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pbDashboard);
            Controls.Add(lblDashboardTitle);
            Controls.Add(chartStudentsPerClass);
            Controls.Add(chartGenderDistribution);
            Controls.Add(pnlClasses);
            Controls.Add(pnlStudents);
            Name = "ucDashboard";
            Size = new Size(1182, 702);
            Load += ucDashboard_Load;
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            pnlClasses.ResumeLayout(false);
            pnlClasses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGenderDistribution).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStudentsPerClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlStudents;
        private Label lblTotalStudentsCount;
        private Label lblTotalStudentsTitle;
        private Panel pnlClasses;
        private Label lblTotalClassesCount;
        private Label lblTotalClassesTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenderDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudentsPerClass;
        private Label lblDashboardTitle;
        private PictureBox pbDashboard;
    }
}
