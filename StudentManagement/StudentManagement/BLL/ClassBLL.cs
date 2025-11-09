using StudentManagement.DAL;
using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BLL
{
    internal class ClassBLL
    {
        private readonly ClassDAL _classDAL;

        public ClassBLL()
        {
            _classDAL = new ClassDAL();
        }

        public List<Class> GetAllClasses()
        {
            return _classDAL.GetAllClasses();
        }

        public List<Class> SearchClasses(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllClasses();
            }
            return _classDAL.SearchClasses(keyword);
        }

        public string AddClass(string className, string department)
        {
            if (string.IsNullOrWhiteSpace(className))
            {
                return "Class Name cannot be empty.";
            }

            var newClass = new Class { ClassName = className, Department = department };
            try
            {
                _classDAL.AddClass(newClass);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error adding class: {ex.Message}";
            }
        }

        public string UpdateClass(int classId, string className, string department)
        {
            if (string.IsNullOrWhiteSpace(className))
            {
                return "Class Name cannot be empty.";
            }

            var updatedClass = new Class { ClassId = classId, ClassName = className, Department = department };
            try
            {
                _classDAL.UpdateClass(updatedClass);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error updating class: {ex.Message}";
            }
        }

        public string DeleteClass(int classId)
        {
            try
            {
                _classDAL.DeleteClass(classId);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error deleting class: {ex.Message}";
            }
        }
    }
}
