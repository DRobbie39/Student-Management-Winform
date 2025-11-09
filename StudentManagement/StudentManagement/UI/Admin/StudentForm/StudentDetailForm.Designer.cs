using System.Reflection.Metadata;

namespace StudentManagement.UI.Admin.StudentForm
{
    partial class frmStudentDetailForm
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
            lblStudentDetail = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtAddress = new TextBox();
            txtFullName = new TextBox();
            lblAddress = new Label();
            lblFullName = new Label();
            lblGender = new Label();
            lblDOB = new Label();
            lblClass = new Label();
            cboGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            cboClass = new ComboBox();
            SuspendLayout();
            // 
            // lblStudentDetail
            // 
            lblStudentDetail.AutoSize = true;
            lblStudentDetail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentDetail.Location = new Point(328, 40);
            lblStudentDetail.Name = "lblStudentDetail";
            lblStudentDetail.Size = new Size(168, 31);
            lblStudentDetail.TabIndex = 27;
            lblStudentDetail.Text = "Student Detail";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(286, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(422, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(310, 314);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(281, 62);
            txtAddress.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(310, 114);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(281, 27);
            txtFullName.TabIndex = 0;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(203, 317);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 19;
            lblAddress.Text = "Address";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(203, 117);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 18;
            lblFullName.Text = "Full Name";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(203, 166);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 28;
            lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(203, 219);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(94, 20);
            lblDOB.TabIndex = 29;
            lblDOB.Text = "Date of Birth";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(203, 270);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(42, 20);
            lblClass.TabIndex = 30;
            lblClass.Text = "Class";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Male", "Female" });
            cboGender.Location = new Point(310, 163);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(151, 28);
            cboGender.TabIndex = 1;
            // 
            // dtpDOB
            // 
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            dtpDOB.Format = DateTimePickerFormat.Custom;
            dtpDOB.Location = new Point(310, 214);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(281, 27);
            dtpDOB.TabIndex = 2;
            // 
            // cboClass
            // 
            cboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(310, 267);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(281, 28);
            cboClass.TabIndex = 3;
            // 
            // frmStudentDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 520);
            Controls.Add(cboClass);
            Controls.Add(dtpDOB);
            Controls.Add(cboGender);
            Controls.Add(lblClass);
            Controls.Add(lblDOB);
            Controls.Add(lblGender);
            Controls.Add(lblStudentDetail);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmStudentDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentDetail;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtAddress;
        private TextBox txtFullName;
        private Label lblAddress;
        private Label lblFullName;
        private Label lblGender;
        private Label lblDOB;
        private Label lblClass;
        private ComboBox cboGender;
        private DateTimePicker dtpDOB;
        private ComboBox cboClass;
    }
}