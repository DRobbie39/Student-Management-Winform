namespace StudentManagement.UI.UserControls
{
    partial class ucClasses
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClasses = new DataGridView();
            flpButton = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtSearchClasses = new TextBox();
            btnSearchClasses = new Button();
            colClassID = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClasses).BeginInit();
            flpButton.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClasses
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasses.Columns.AddRange(new DataGridViewColumn[] { colClassID, colClassName, colDepartment });
            dgvClasses.Location = new Point(3, 122);
            dgvClasses.Name = "dgvClasses";
            dgvClasses.RowHeadersWidth = 51;
            dgvClasses.Size = new Size(1176, 577);
            dgvClasses.TabIndex = 0;
            // 
            // flpButton
            // 
            flpButton.Controls.Add(btnAdd);
            flpButton.Controls.Add(btnEdit);
            flpButton.Controls.Add(btnDelete);
            flpButton.Location = new Point(833, 71);
            flpButton.Name = "flpButton";
            flpButton.Size = new Size(346, 45);
            flpButton.TabIndex = 1;
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
            btnAdd.Click += btnAdd_Click;
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
            btnEdit.Click += btnEdit_Click;
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
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchClasses
            // 
            txtSearchClasses.Location = new Point(3, 89);
            txtSearchClasses.Name = "txtSearchClasses";
            txtSearchClasses.PlaceholderText = "Search Classes";
            txtSearchClasses.Size = new Size(254, 27);
            txtSearchClasses.TabIndex = 2;
            // 
            // btnSearchClasses
            // 
            btnSearchClasses.Location = new Point(263, 87);
            btnSearchClasses.Name = "btnSearchClasses";
            btnSearchClasses.Size = new Size(94, 29);
            btnSearchClasses.TabIndex = 3;
            btnSearchClasses.Text = "Search";
            btnSearchClasses.UseVisualStyleBackColor = true;
            btnSearchClasses.Click += btnSearchClasses_Click;
            // 
            // colClassID
            // 
            colClassID.DataPropertyName = "ClassId";
            colClassID.HeaderText = "Class ID";
            colClassID.MinimumWidth = 6;
            colClassID.Name = "colClassID";
            colClassID.Width = 200;
            // 
            // colClassName
            // 
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "Class Name";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.Width = 500;
            // 
            // colDepartment
            // 
            colDepartment.DataPropertyName = "Department";
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 6;
            colDepartment.Name = "colDepartment";
            colDepartment.Width = 500;
            // 
            // ucClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearchClasses);
            Controls.Add(txtSearchClasses);
            Controls.Add(flpButton);
            Controls.Add(dgvClasses);
            Name = "ucClasses";
            Size = new Size(1182, 702);
            Load += ucClasses_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasses).EndInit();
            flpButton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClasses;
        private FlowLayoutPanel flpButton;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtSearchClasses;
        private Button btnSearchClasses;
        private DataGridViewTextBoxColumn colClassID;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colDepartment;
    }
}
