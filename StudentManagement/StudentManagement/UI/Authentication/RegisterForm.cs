using StudentManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UI.Authentication
{
    public partial class frmRegisterForm : Form
    {
        private readonly AccountBLL _accountBLL;

        public frmRegisterForm()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string result = _accountBLL.Register(username, password, confirmPassword);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Registration successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Đóng form đăng ký và quay lại form đăng nhập
                GoToLoginForm();
            }
            else
            {
                MessageBox.Show(result, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GoToLoginForm();
        }

        private void GoToLoginForm()
        {
            this.Hide();
            frmLoginForm loginForm = new frmLoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
