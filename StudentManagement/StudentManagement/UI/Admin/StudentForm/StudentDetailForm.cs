using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UI.Admin.StudentForm
{
    public partial class frmStudentDetailForm : Form
    {
        // Public properties to get data back from the form
        public string FullName { get; private set; }
        public string Gender { get; private set; }
        public DateOnly? DateOfBirth { get; private set; }
        public string Address { get; private set; }
        public int? SelectedClassId { get; private set; }

        // Constructor for ADD mode
        public frmStudentDetailForm(List<Class> classes)
        {
            InitializeComponent();
            LoadClasses(classes);
            // Set default gender
            cboGender.SelectedIndex = 0;
        }

        // Constructor for EDIT mode
        public frmStudentDetailForm(Student studentToEdit, List<Class> classes)
        {
            InitializeComponent();
            LoadClasses(classes);

            // Populate form with existing student data
            txtFullName.Text = studentToEdit.FullName;
            cboGender.SelectedItem = studentToEdit.Gender;

            if (studentToEdit.DateOfBirth.HasValue)
            {
                dtpDOB.Value = studentToEdit.DateOfBirth.Value.ToDateTime(TimeOnly.MinValue);
            }

            txtAddress.Text = studentToEdit.Address;

            if (studentToEdit.ClassId.HasValue)
            {
                cboClass.SelectedValue = studentToEdit.ClassId.Value;
            }
            else
            {
                cboClass.SelectedValue = -1; // "No Class" option
            }
        }

        private void LoadClasses(List<Class> classes)
        {
            var displayList = new List<Class>();

            displayList.Add(new Class { ClassId = -1, ClassName = "N/A" });

            // Thêm tất cả các lớp học thật từ database vào danh sách
            displayList.AddRange(classes);

            // Gán danh sách nhất quán này cho ComboBox
            cboClass.DataSource = displayList;
            cboClass.DisplayMember = "ClassName";
            cboClass.ValueMember = "ClassId";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set public properties
            this.FullName = txtFullName.Text;
            this.Gender = cboGender.SelectedItem.ToString();
            this.DateOfBirth = DateOnly.FromDateTime(dtpDOB.Value);
            this.Address = txtAddress.Text;

            int selectedId = (int)cboClass.SelectedValue;
            this.SelectedClassId = selectedId == -1 ? (int?)null : selectedId;

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
