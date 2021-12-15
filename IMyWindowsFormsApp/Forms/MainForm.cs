using IMyWindowsFormsApp.Mappers;
using IMyWindowsFormsApp.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    public partial class MainForm : Form
    {

        private readonly ITeacherService _teacherService;

        public MainForm(ITeacherService teacherService)
        {
            InitializeComponent();
            _teacherService = teacherService;
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshTeachers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher
            {
                LastName = txtLastName.Text,
                FirstName = txtFirstName.Text,
                Age = Convert.ToInt32(txtAge.Text)
            };
            _teacherService.Add(teacher);
            RefreshTeachers();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void grdTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowRow();
        }
        private void RefreshTeachers()
        {
            grdTeachers.ClearSelection();
            grdTeachers.DataSource = _teacherService.GetAll().MapTeachersToViewModel();
            if (grdTeachers.Rows.Count > 0)
            {
                grdTeachers.Rows[0].Selected = true;
            }
        }

        private void ShowRow()
        {
            lblGuid.Text = grdTeachers.SelectedRows[0].Cells["Id"].Value.ToString();
            string[] names = grdTeachers.SelectedRows[0].Cells["tchFullName"].Value.ToString().Split(' ');
            txtLastName.Text = names.Last();
            txtFirstName.Text = names.First();
            txtAge.Text = grdTeachers.SelectedRows[0].Cells["tchAge"].Value.ToString();
        }
    }
}
