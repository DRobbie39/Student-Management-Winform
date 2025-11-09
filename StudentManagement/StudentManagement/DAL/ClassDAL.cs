using Microsoft.EntityFrameworkCore;
using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL
{
    internal class ClassDAL
    {
        private readonly StudentManagementContext _context;

        public ClassDAL()
        {
            _context = new StudentManagementContext();
        }

        public List<Class> GetAllClasses()
        {
            return _context.Classes.Include(c => c.Students).ToList();
        }

        public void AddClass(Class newClass)
        {
            _context.Classes.Add(newClass);
            _context.SaveChanges();
        }

        public void UpdateClass(Class updatedClass)
        {
            var existingClass = _context.Classes.Find(updatedClass.ClassId);

            if (existingClass != null)
            {
                existingClass.ClassName = updatedClass.ClassName;
                existingClass.Department = updatedClass.Department;

                _context.SaveChanges();
            }
        }

        public void DeleteClass(int classId)
        {
            var classToDelete = _context.Classes.Find(classId);
            if (classToDelete != null)
            {
                _context.Classes.Remove(classToDelete);
                _context.SaveChanges();
            }
        }

        public List<Class> SearchClasses(string keyword)
        {
            return _context.Classes
                           .Where(c => c.ClassName.Contains(keyword) || c.Department.Contains(keyword))
                           .ToList();
        }
    }
}
