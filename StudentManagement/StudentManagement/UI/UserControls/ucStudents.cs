using StudentManagement.BLL;
using StudentManagement.DAL.Models;
using StudentManagement.UI.Admin.StudentForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UI.UserControls
{
    public partial class ucStudents : UserControl
    {
        private readonly StudentBLL _studentBLL;
        private readonly ClassBLL _classBLL;

        public ucStudents()
        {
            InitializeComponent();
            _studentBLL = new StudentBLL();
            _classBLL = new ClassBLL();
            dgvStudents.AutoGenerateColumns = false;
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            var students = _studentBLL.GetAllStudents();
            dgvStudents.DataSource = students;
        }

        private void dgvStudents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if this is the ClassName column and the row is a data row
            if (e.RowIndex >= 0 && dgvStudents.Columns[e.ColumnIndex].Name == "colClassName")
            {
                var student = dgvStudents.Rows[e.RowIndex].DataBoundItem as Student;
                if (student != null && student.Class != null)
                {
                    e.Value = student.Class.ClassName;
                }
                else
                {
                    e.Value = "N/A";
                }
                e.FormattingApplied = true;
            }
        }

        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchStudents.Text;
            var searchResult = _studentBLL.SearchStudents(keyword);
            dgvStudents.DataSource = searchResult;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var classes = _classBLL.GetAllClasses();
            using (var detailsForm = new frmStudentDetailForm(classes))
            {
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    string result = _studentBLL.AddStudent(
                        detailsForm.FullName,
                        detailsForm.Gender,
                        detailsForm.DateOfBirth,
                        detailsForm.Address,
                        detailsForm.SelectedClassId
                    );

                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
            var classes = _classBLL.GetAllClasses();

            using (var detailsForm = new frmStudentDetailForm(selectedStudent, classes))
            {
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    string result = _studentBLL.UpdateStudent(
                        selectedStudent.StudentId,
                        detailsForm.FullName,
                        detailsForm.Gender,
                        detailsForm.DateOfBirth,
                        detailsForm.Address,
                        detailsForm.SelectedClassId
                    );

                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show($"Are you sure you want to delete the student '{selectedStudent.FullName}'?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string result = _studentBLL.DeleteStudent(selectedStudent.StudentId);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
