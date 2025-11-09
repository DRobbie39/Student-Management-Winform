using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BLL
{
    internal class DashboardBLL
    {
        private readonly StudentBLL _studentBLL;
        private readonly ClassBLL _classBLL;

        public DashboardBLL()
        {
            _studentBLL = new StudentBLL();
            _classBLL = new ClassBLL();
        }

        public List<Student> GetAllStudentsForStats()
        {
            return _studentBLL.GetAllStudents();
        }

        public List<Class> GetAllClassesWithStudents()
        {
            return _classBLL.GetAllClasses();
        }
    }
}
