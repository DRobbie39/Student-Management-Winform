using StudentManagement.BLL;
using StudentManagement.DAL.Models;
using StudentManagement.UI.Admin.ClassForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.UI.UserControls
{
    public partial class ucClasses : UserControl
    {
        private readonly ClassBLL _classBLL;

        public ucClasses()
        {
            InitializeComponent();
            _classBLL = new ClassBLL();
            dgvClasses.AutoGenerateColumns = false;
        }

        private void ucClasses_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void LoadClasses()
        {
            var classes = _classBLL.GetAllClasses();
            dgvClasses.DataSource = classes;
        }

        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchClasses.Text;
            var searchResult = _classBLL.SearchClasses(keyword);
            dgvClasses.DataSource = searchResult;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var detailsForm = new frmClassDetailForm())
            {
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    string result = _classBLL.AddClass(detailsForm.ClassName, detailsForm.Department);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Class added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Please select a class to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected class
            var selectedClass = (Class)dgvClasses.CurrentRow.DataBoundItem;

            using (var detailsForm = new frmClassDetailForm(selectedClass.ClassName, selectedClass.Department))
            {
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    string result = _classBLL.UpdateClass(selectedClass.ClassId, detailsForm.ClassName, detailsForm.Department);
                    if (string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Class updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClasses();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow == null)
            {
                MessageBox.Show("Please select a class to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedClass = (Class)dgvClasses.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show($"Are you sure you want to delete the class '{selectedClass.ClassName}'?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string result = _classBLL.DeleteClass(selectedClass.ClassId);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Class deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClasses();
                }
                else
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
