using Microsoft.EntityFrameworkCore;
using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL
{
    internal class StudentDAL
    {
        private readonly StudentManagementContext _context;

        public StudentDAL()
        {
            _context = new StudentManagementContext();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.Include(s => s.Class).ToList();
        }

        public void AddStudent(Student newStudent)
        {
            _context.Students.Add(newStudent);
            _context.SaveChanges();
        }

        public void UpdateStudent(Student updatedStudent)
        {
            var existingStudent = _context.Students.Find(updatedStudent.StudentId);

            if (existingStudent != null)
            {
                existingStudent.FullName = updatedStudent.FullName;
                existingStudent.Gender = updatedStudent.Gender;
                existingStudent.DateOfBirth = updatedStudent.DateOfBirth;
                existingStudent.Address = updatedStudent.Address;
                existingStudent.ClassId = updatedStudent.ClassId;

                _context.SaveChanges();
            }
        }

        public void DeleteStudent(int studentId)
        {
            var studentToDelete = _context.Students.Find(studentId);
            if (studentToDelete != null)
            {
                _context.Students.Remove(studentToDelete);
                _context.SaveChanges();
            }
        }

        public List<Student> SearchStudents(string keyword)
        {
            return _context.Students
                           .Include(s => s.Class)
                           .Where(s => s.FullName.Contains(keyword) ||
                                       s.Address.Contains(keyword) ||
                                       (s.Class != null && s.Class.ClassName.Contains(keyword)))
                           .ToList();
        }
    }
}
