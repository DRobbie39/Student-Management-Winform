using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UI.Admin.ClassForm
{
    public partial class frmClassDetailForm : Form
    {
        // Public properties to get data back from the form
        public string ClassName { get; private set; }
        public string Department { get; private set; }

        // Constructor for ADD mode
        public frmClassDetailForm()
        {
            InitializeComponent();
        }

        // Constructor for EDIT mode
        public frmClassDetailForm(string currentClassName, string currentDepartment)
        {
            InitializeComponent();
            txtClassName.Text = currentClassName;
            txtDepartment.Text = currentDepartment;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                MessageBox.Show("Class Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set public properties
            this.ClassName = txtClassName.Text;
            this.Department = txtDepartment.Text;

            // Set DialogResult and close
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
