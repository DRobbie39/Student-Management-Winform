namespace StudentManagement.UI.UserControls
{
    partial class ucHome
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
            btnLogout = new Button();
            pbMainForm = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbMainForm).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(964, 627);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(177, 63);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbMainForm
            // 
            pbMainForm.Image = Properties.Resources.pixel_coffee;
            pbMainForm.Location = new Point(3, 15);
            pbMainForm.Name = "pbMainForm";
            pbMainForm.Size = new Size(915, 675);
            pbMainForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMainForm.TabIndex = 2;
            pbMainForm.TabStop = false;
            // 
            // ucHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogout);
            Controls.Add(pbMainForm);
            Name = "ucHome";
            Size = new Size(1182, 702);
            ((System.ComponentModel.ISupportInitialize)pbMainForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private PictureBox pbMainForm;
    }
}
