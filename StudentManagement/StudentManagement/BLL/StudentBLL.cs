using StudentManagement.DAL;
using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BLL
{
    internal class StudentBLL
    {
        private readonly StudentDAL _studentDAL;

        public StudentBLL()
        {
            _studentDAL = new StudentDAL();
        }

        public List<Student> GetAllStudents()
        {
            return _studentDAL.GetAllStudents();
        }

        public List<Student> SearchStudents(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return GetAllStudents();
            }
            return _studentDAL.SearchStudents(keyword);
        }

        public string AddStudent(string fullName, string gender, DateOnly? dateOfBirth, string address, int? classId)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "Full Name cannot be empty.";
            }

            var newStudent = new Student
            {
                FullName = fullName,
                Gender = gender,
                DateOfBirth = dateOfBirth,
                Address = address,
                ClassId = classId
            };

            try
            {
                _studentDAL.AddStudent(newStudent);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error adding student: {ex.Message}";
            }
        }

        public string UpdateStudent(int studentId, string fullName, string gender, DateOnly? dateOfBirth, string address, int? classId)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "Full Name cannot be empty.";
            }

            var updatedStudent = new Student
            {
                StudentId = studentId,
                FullName = fullName,
                Gender = gender,
                DateOfBirth = dateOfBirth,
                Address = address,
                ClassId = classId
            };

            try
            {
                _studentDAL.UpdateStudent(updatedStudent);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error updating student: {ex.Message}";
            }
        }

        public string DeleteStudent(int studentId)
        {
            try
            {
                _studentDAL.DeleteStudent(studentId);
                return string.Empty; // Success
            }
            catch (Exception ex)
            {
                return $"Error deleting student: {ex.Message}";
            }
        }
    }
}
