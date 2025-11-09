namespace StudentManagement.UI.Admin
{
    partial class frmAdminMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogout = new Button();
            pnlContent = new Panel();
            pbMainForm = new PictureBox();
            tsAdminMainForm = new ToolStrip();
            tsLogo = new ToolStripLabel();
            tsbHome = new ToolStripButton();
            tsbStudent = new ToolStripButton();
            tsbClasses = new ToolStripButton();
            tslWelcome = new ToolStripLabel();
            tsbDashboard = new ToolStripButton();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMainForm).BeginInit();
            tsAdminMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(964, 627);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(177, 63);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "😉 Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(btnLogout);
            pnlContent.Controls.Add(pbMainForm);
            pnlContent.Location = new Point(0, 51);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1182, 702);
            pnlContent.TabIndex = 1;
            // 
            // pbMainForm
            // 
            pbMainForm.Image = Properties.Resources.pixel_coffee;
            pbMainForm.Location = new Point(3, 15);
            pbMainForm.Name = "pbMainForm";
            pbMainForm.Size = new Size(915, 675);
            pbMainForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMainForm.TabIndex = 0;
            pbMainForm.TabStop = false;
            // 
            // tsAdminMainForm
            // 
            tsAdminMainForm.BackColor = SystemColors.ScrollBar;
            tsAdminMainForm.ImageScalingSize = new Size(20, 20);
            tsAdminMainForm.Items.AddRange(new ToolStripItem[] { tsLogo, tsbHome, tsbStudent, tsbClasses, tslWelcome, tsbDashboard });
            tsAdminMainForm.Location = new Point(0, 0);
            tsAdminMainForm.Name = "tsAdminMainForm";
            tsAdminMainForm.Padding = new Padding(10);
            tsAdminMainForm.Size = new Size(1182, 55);
            tsAdminMainForm.TabIndex = 0;
            tsAdminMainForm.Text = "toolStrip1";
            // 
            // tsLogo
            // 
            tsLogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsLogo.Name = "tsLogo";
            tsLogo.Size = new Size(135, 32);
            tsLogo.Text = "Student CO";
            // 
            // tsbHome
            // 
            tsbHome.Font = new Font("Segoe UI", 12F);
            tsbHome.Image = Properties.Resources.home_icon;
            tsbHome.ImageTransparentColor = Color.Magenta;
            tsbHome.Margin = new Padding(10, 1, 0, 2);
            tsbHome.Name = "tsbHome";
            tsbHome.Size = new Size(89, 32);
            tsbHome.Text = "Home";
            tsbHome.Click += tsbHome_Click;
            // 
            // tsbStudent
            // 
            tsbStudent.Font = new Font("Segoe UI", 12F);
            tsbStudent.Image = Properties.Resources.student_icon;
            tsbStudent.ImageTransparentColor = Color.Magenta;
            tsbStudent.Margin = new Padding(10, 1, 0, 2);
            tsbStudent.Name = "tsbStudent";
            tsbStudent.Size = new Size(112, 32);
            tsbStudent.Text = "Students";
            tsbStudent.Click += tsbStudent_Click;
            // 
            // tsbClasses
            // 
            tsbClasses.Font = new Font("Segoe UI", 12F);
            tsbClasses.Image = Properties.Resources.class_icon;
            tsbClasses.ImageTransparentColor = Color.Magenta;
            tsbClasses.Margin = new Padding(10, 1, 0, 2);
            tsbClasses.Name = "tsbClasses";
            tsbClasses.Size = new Size(97, 32);
            tsbClasses.Text = "Classes";
            tsbClasses.Click += tsbClasses_Click;
            // 
            // tslWelcome
            // 
            tslWelcome.Alignment = ToolStripItemAlignment.Right;
            tslWelcome.Font = new Font("Segoe UI", 12F);
            tslWelcome.Name = "tslWelcome";
            tslWelcome.Size = new Size(97, 32);
            tslWelcome.Text = "Welcome,";
            // 
            // tsbDashboard
            // 
            tsbDashboard.Font = new Font("Segoe UI", 12F);
            tsbDashboard.Image = Properties.Resources.dashboard_icon;
            tsbDashboard.ImageTransparentColor = Color.Magenta;
            tsbDashboard.Margin = new Padding(10, 1, 0, 2);
            tsbDashboard.Name = "tsbDashboard";
            tsbDashboard.Size = new Size(132, 32);
            tsbDashboard.Text = "Dashboard";
            // 
            // frmAdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(pnlContent);
            Controls.Add(tsAdminMainForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Main Form";
            Load += frmAdminMainForm_Load;
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMainForm).EndInit();
            tsAdminMainForm.ResumeLayout(false);
            tsAdminMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private Panel pnlContent;
        private PictureBox pbMainForm;
        private ToolStrip tsAdminMainForm;
        private ToolStripLabel tsLogo;
        private ToolStripButton tsbHome;
        private ToolStripButton tsbStudent;
        private ToolStripButton tsbClasses;
        private ToolStripLabel tslWelcome;
        private ToolStripButton tsbDashboard;
    }
}