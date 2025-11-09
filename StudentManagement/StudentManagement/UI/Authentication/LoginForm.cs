using StudentManagement.BLL;
using StudentManagement.UI.Admin;
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
    public partial class frmLoginForm : Form
    {
        private readonly AccountBLL _accountBLL;

        public frmLoginForm()
        {
            InitializeComponent();
            _accountBLL = new AccountBLL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string result = _accountBLL.Login(username, password);

            if (string.IsNullOrEmpty(result)) // Nếu kết quả trả về là rỗng -> thành công
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainForm = new frmAdminMainForm(username);
                mainForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRegisterForm registerForm = new frmRegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
