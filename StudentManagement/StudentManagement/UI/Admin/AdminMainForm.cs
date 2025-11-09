using StudentManagement.UI.Authentication;
using StudentManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentManagement.UI.Admin
{
    public partial class frmAdminMainForm : Form
    {
        private string _loggedInUsername;

        public frmAdminMainForm(string username)
        {
            InitializeComponent();
            _loggedInUsername = username;
        }

        private void frmAdminMainForm_Load(object sender, EventArgs e)
        {
            tslWelcome.Text = $"Welcome, {_loggedInUsername}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to log out?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var loginForm = new frmLoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void ShowUserControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        private void tsbClasses_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucClasses());
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ucHome());
        }
    }
}
