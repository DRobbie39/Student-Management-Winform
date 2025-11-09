using ClosedXML.Excel;
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ BLL của bạn
                var studentBLL = new StudentBLL();

                var students = studentBLL.GetAllStudents();

                // Tạo một Workbook (tương đương 1 file Excel)
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Danh sách Sinh viên");

                    // Tạo tiêu đề cho các cột
                    worksheet.Cell("A1").Value = "Student ID";
                    worksheet.Cell("B1").Value = "Full Name";
                    worksheet.Cell("C1").Value = "Gender";
                    worksheet.Cell("D1").Value = "Date of Birth";
                    worksheet.Cell("E1").Value = "Class Name";
                    worksheet.Cell("F1").Value = "Department";

                    // Định dạng cho dòng tiêu đề (in đậm, màu nền)
                    var headerRange = worksheet.Range("A1:F1");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

                    // Đổ dữ liệu vào các dòng
                    int currentRow = 2;
                    foreach (var student in students)
                    {
                        worksheet.Cell(currentRow, 1).Value = student.StudentId;
                        worksheet.Cell(currentRow, 2).Value = student.FullName;
                        worksheet.Cell(currentRow, 3).Value = student.Gender;
                        worksheet.Cell(currentRow, 4).Value = student.DateOfBirth.Value.ToDateTime(TimeOnly.MinValue);
                        worksheet.Cell(currentRow, 5).Value = student.Class.ClassName;
                        worksheet.Cell(currentRow, 6).Value = student.Class.Department;
                        currentRow++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet.Columns().AdjustToContents();

                    // Lưu file
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    sfd.Title = "Save Excel report file";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Export Excel file successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when exporting Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
