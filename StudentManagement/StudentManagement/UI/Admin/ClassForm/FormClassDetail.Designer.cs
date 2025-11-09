namespace StudentManagement.UI.Admin.ClassForm
{
    partial class frmClassDetailForm
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
            lblClassName = new Label();
            lblDepartment = new Label();
            txtClassName = new TextBox();
            txtDepartment = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lblClassDetail = new Label();
            SuspendLayout();
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Location = new Point(219, 165);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(86, 20);
            lblClassName.TabIndex = 0;
            lblClassName.Text = "Class Name";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(219, 235);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(89, 20);
            lblDepartment.TabIndex = 1;
            lblDepartment.Text = "Department";
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(326, 162);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(238, 27);
            txtClassName.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(326, 232);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(238, 27);
            txtDepartment.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(438, 307);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(302, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblClassDetail
            // 
            lblClassDetail.AutoSize = true;
            lblClassDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassDetail.Location = new Point(371, 83);
            lblClassDetail.Name = "lblClassDetail";
            lblClassDetail.Size = new Size(137, 31);
            lblClassDetail.TabIndex = 17;
            lblClassDetail.Text = "Class Detail";
            // 
            // frmClassDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblClassDetail);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDepartment);
            Controls.Add(txtClassName);
            Controls.Add(lblDepartment);
            Controls.Add(lblClassName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClassDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Class Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClassName;
        private Label lblDepartment;
        private TextBox txtClassName;
        private TextBox txtDepartment;
        private Button btnCancel;
        private Button btnSave;
        private Label lblClassDetail;
    }
}