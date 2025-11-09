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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminMainForm));
            btnLogout = new Button();
            pnlContent = new Panel();
            pbMainForm = new PictureBox();
            tsAdminMainForm = new ToolStrip();
            tsLogo = new ToolStripLabel();
            tsbHome = new ToolStripButton();
            tsbStudent = new ToolStripButton();
            tsbClasses = new ToolStripButton();
            tsbSubjects = new ToolStripButton();
            tsbScores = new ToolStripButton();
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
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
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
            tsAdminMainForm.Items.AddRange(new ToolStripItem[] { tsLogo, tsbHome, tsbStudent, tsbClasses, tsbSubjects, tsbScores, tslWelcome, tsbDashboard });
            tsAdminMainForm.Location = new Point(0, 0);
            tsAdminMainForm.Name = "tsAdminMainForm";
            tsAdminMainForm.Padding = new Padding(10);
            tsAdminMainForm.Size = new Size(1182, 51);
            tsAdminMainForm.TabIndex = 0;
            tsAdminMainForm.Text = "toolStrip1";
            // 
            // tsLogo
            // 
            tsLogo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsLogo.Name = "tsLogo";
            tsLogo.Size = new Size(119, 28);
            tsLogo.Text = "Student CO";
            // 
            // tsbHome
            // 
            tsbHome.Image = (Image)resources.GetObject("tsbHome.Image");
            tsbHome.ImageTransparentColor = Color.Magenta;
            tsbHome.Margin = new Padding(10, 1, 0, 2);
            tsbHome.Name = "tsbHome";
            tsbHome.Size = new Size(74, 28);
            tsbHome.Text = "Home";
            // 
            // tsbStudent
            // 
            tsbStudent.Image = (Image)resources.GetObject("tsbStudent.Image");
            tsbStudent.ImageTransparentColor = Color.Magenta;
            tsbStudent.Margin = new Padding(10, 1, 0, 2);
            tsbStudent.Name = "tsbStudent";
            tsbStudent.Size = new Size(90, 28);
            tsbStudent.Text = "Students";
            // 
            // tsbClasses
            // 
            tsbClasses.Image = (Image)resources.GetObject("tsbClasses.Image");
            tsbClasses.ImageTransparentColor = Color.Magenta;
            tsbClasses.Margin = new Padding(10, 1, 0, 2);
            tsbClasses.Name = "tsbClasses";
            tsbClasses.Size = new Size(80, 28);
            tsbClasses.Text = "Classes";
            // 
            // tsbSubjects
            // 
            tsbSubjects.Image = (Image)resources.GetObject("tsbSubjects.Image");
            tsbSubjects.ImageTransparentColor = Color.Magenta;
            tsbSubjects.Margin = new Padding(10, 1, 0, 2);
            tsbSubjects.Name = "tsbSubjects";
            tsbSubjects.Size = new Size(88, 28);
            tsbSubjects.Text = "Subjects";
            // 
            // tsbScores
            // 
            tsbScores.Image = (Image)resources.GetObject("tsbScores.Image");
            tsbScores.ImageTransparentColor = Color.Magenta;
            tsbScores.Margin = new Padding(10, 1, 0, 2);
            tsbScores.Name = "tsbScores";
            tsbScores.Size = new Size(76, 28);
            tsbScores.Text = "Scores";
            // 
            // tslWelcome
            // 
            tslWelcome.Alignment = ToolStripItemAlignment.Right;
            tslWelcome.Name = "tslWelcome";
            tslWelcome.Size = new Size(74, 28);
            tslWelcome.Text = "Welcome,";
            // 
            // tsbDashboard
            // 
            tsbDashboard.Image = (Image)resources.GetObject("tsbDashboard.Image");
            tsbDashboard.ImageTransparentColor = Color.Magenta;
            tsbDashboard.Margin = new Padding(10, 1, 0, 2);
            tsbDashboard.Name = "tsbDashboard";
            tsbDashboard.Size = new Size(106, 28);
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
        private ToolStripButton tsbSubjects;
        private ToolStripButton tsbScores;
        private ToolStripLabel tslWelcome;
        private ToolStripButton tsbDashboard;
    }
}