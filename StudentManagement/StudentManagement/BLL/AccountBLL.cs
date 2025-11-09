using StudentManagement.DAL;
using StudentManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.BLL
{
    internal class AccountBLL
    {
        private readonly AccountDAL _accountDAL;

        public AccountBLL()
        {
            _accountDAL = new AccountDAL();
        }

        public string Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Username and Password cannot be empty.";
            }

            var account = _accountDAL.GetAccountByUsername(username);

            if (account == null)
            {
                return "Invalid username or password.";
            }

            // Xác thực mật khẩu đã hash với mật khẩu người dùng nhập vào
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, account.PasswordHash);

            if (isPasswordValid)
            {
                return string.Empty; // Đăng nhập thành công
            }
            else
            {
                return "Invalid username or password.";
            }
        }

        public string Register(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Username and Password cannot be empty.";
            }

            if (password != confirmPassword)
            {
                return "Passwords do not match.";
            }

            // Kiểm tra xem username đã tồn tại chưa
            var existingAccount = _accountDAL.GetAccountByUsername(username);
            if (existingAccount != null)
            {
                return "Username already exists.";
            }

            // Mã hóa mật khẩu trước khi lưu
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            var newAccount = new Account
            {
                Username = username,
                PasswordHash = hashedPassword,
                CreatedDate = DateOnly.FromDateTime(DateTime.Now)
            };

            try
            {
                _accountDAL.AddAccount(newAccount);
                return string.Empty; // Đăng ký thành công
            }
            catch (Exception ex)
            {
                return "An error occurred during registration. Please try again.";
            }
        }
    }
}
