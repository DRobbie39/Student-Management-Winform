using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.DAL
{
    internal class AccountDAL
    {
        private readonly StudentManagementContext _context;

        public AccountDAL()
        {
            _context = new StudentManagementContext();
        }

        public Account GetAccountByUsername(string username)
        {
            return _context.Accounts.FirstOrDefault(a => a.Username == username);
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }
    }
}
