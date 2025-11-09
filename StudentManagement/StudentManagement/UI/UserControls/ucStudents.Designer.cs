namespace StudentManagement.UI.UserControls
{
    partial class ucStudents
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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            dgvStudents = new DataGridView();
            colStudentID = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDOB = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            flpButton = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pbStudents = new PictureBox();
            lblStudents = new Label();
            btnSearchStudents = new Button();
            txtSearchStudents = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            flpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dataGridViewCellStyle11.BackColor = Color.FromArgb(238, 239, 249);
            dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvStudents.BackgroundColor = Color.White;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colStudentID, colFullName, colGender, colDOB, colAddress, colClassName });
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.Location = new Point(3, 122);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(1176, 577);
            dgvStudents.TabIndex = 6;
            // 
            // colStudentID
            // 
            colStudentID.HeaderText = "Student ID";
            colStudentID.MinimumWidth = 6;
            colStudentID.Name = "colStudentID";
            colStudentID.Width = 120;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.Width = 200;
            // 
            // colGender
            // 
            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            // 
            // colDOB
            // 
            colDOB.HeaderText = "Date Of Birth";
            colDOB.MinimumWidth = 6;
            colDOB.Name = "colDOB";
            colDOB.Width = 125;
            // 
            // colAddress
            // 
            colAddress.HeaderText = "Address";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.Width = 300;
            // 
            // colClassName
            // 
            colClassName.HeaderText = "Class Name";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.Width = 200;
            // 
            // flpButton
            // 
            flpButton.Controls.Add(btnAdd);
            flpButton.Controls.Add(btnEdit);
            flpButton.Controls.Add(btnDelete);
            flpButton.Location = new Point(833, 71);
            flpButton.Name = "flpButton";
            flpButton.Size = new Size(346, 45);
            flpButton.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 3);
            btnAdd.Margin = new Padding(10, 3, 10, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(124, 3);
            btnEdit.Margin = new Padding(10, 3, 10, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(238, 3);
            btnDelete.Margin = new Padding(10, 3, 10, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // pbStudents
            // 
            pbStudents.Image = Properties.Resources.class_icon;
            pbStudents.Location = new Point(14, 40);
            pbStudents.Name = "pbStudents";
            pbStudents.Size = new Size(27, 23);
            pbStudents.SizeMode = PictureBoxSizeMode.Zoom;
            pbStudents.TabIndex = 11;
            pbStudents.TabStop = false;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudents.Location = new Point(47, 35);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new Size(226, 28);
            lblStudents.TabIndex = 10;
            lblStudents.Text = "Students Management";
            // 
            // btnSearchStudents
            // 
            btnSearchStudents.Location = new Point(263, 87);
            btnSearchStudents.Name = "btnSearchStudents";
            btnSearchStudents.Size = new Size(94, 29);
            btnSearchStudents.TabIndex = 9;
            btnSearchStudents.Text = "Search";
            btnSearchStudents.UseVisualStyleBackColor = true;
            // 
            // txtSearchStudents
            // 
            txtSearchStudents.Location = new Point(3, 89);
            txtSearchStudents.Name = "txtSearchStudents";
            txtSearchStudents.PlaceholderText = "Search Students";
            txtSearchStudents.Size = new Size(254, 27);
            txtSearchStudents.TabIndex = 8;
            // 
            // ucStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvStudents);
            Controls.Add(flpButton);
            Controls.Add(pbStudents);
            Controls.Add(lblStudents);
            Controls.Add(btnSearchStudents);
            Controls.Add(txtSearchStudents);
            Name = "ucStudents";
            Size = new Size(1182, 702);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            flpButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private FlowLayoutPanel flpButton;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private PictureBox pbStudents;
        private Label lblStudents;
        private Button btnSearchStudents;
        private TextBox txtSearchStudents;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDOB;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colClassName;
    }
}
