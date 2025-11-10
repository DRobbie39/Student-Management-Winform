using StudentManagement.BLL;
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

namespace StudentManagement.UI.UserControls
{
    public partial class ucDashboard : UserControl
    {
        private readonly DashboardBLL _dashboardBLL;

        public ucDashboard()
        {
            InitializeComponent();
            _dashboardBLL = new DashboardBLL();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                // Lấy dữ liệu từ BLL
                var students = _dashboardBLL.GetAllStudentsForStats();
                var classes = _dashboardBLL.GetAllClassesWithStudents();

                // Cập nhật các thẻ thống kê
                lblTotalStudentsCount.Text = students.Count.ToString();
                lblTotalClassesCount.Text = classes.Count.ToString();

                // Tải biểu đồ phân bố giới tính
                LoadGenderChart(students);

                // Tải biểu đồ sĩ số lớp học
                LoadStudentsPerClassChart(classes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGenderChart(List<Student> students)
        {
            // Xóa dữ liệu cũ
            chartGenderDistribution.Series["Gender"].Points.Clear();

            if (students == null || !students.Any()) return;

            // Dùng LINQ để nhóm sinh viên theo giới tính và đếm
            var genderGroups = students
                .GroupBy(s => s.Gender ?? "Unknown") // Dùng "Unknown" nếu Gender là null
                .Select(g => new { Gender = g.Key, Count = g.Count() })
                .ToList();

            // Thêm dữ liệu vào biểu đồ
            foreach (var group in genderGroups)
            {
                chartGenderDistribution.Series["Gender"].Points.AddXY(group.Gender, group.Count);
            }
        }

        private void LoadStudentsPerClassChart(List<Class> classes)
        {
            // Xóa dữ liệu cũ
            chartStudentsPerClass.Series["Students"].Points.Clear();

            if (classes == null || !classes.Any()) return;

            // Tìm lớp có sĩ số cao nhất
            var classWithMostStudents = classes
                .OrderByDescending(c => c.Students.Count)
                .FirstOrDefault();

            // Nếu tìm thấy lớp (danh sách không rỗng)
            if (classWithMostStudents != null)
            {
                // Chỉ thêm duy nhất một điểm dữ liệu cho lớp đó vào biểu đồ
                chartStudentsPerClass.Series["Students"].Points.AddXY(
                    classWithMostStudents.ClassName,
                    classWithMostStudents.Students.Count
                );
            }
        }
    }
}
