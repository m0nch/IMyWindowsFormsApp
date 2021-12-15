using IMyWindowsFormsApp.Mappers;
using IMyWindowsFormsApp.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    public partial class StudentsForm : Form
    {
        private static StudentsForm _instance;

        public static StudentsForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StudentsForm();
                return _instance;
            }
        }

        private StudentService _studentService;
        private TeacherService _teacherService;

        List<string> lastNameList = new List<string>();
        public StudentsForm()
        {
            InitializeComponent();
            //this.Load += delegate { RefreshGridView(); };
        }

        public void LoadServices(StudentService studentService, TeacherService teacherService) 
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
        private void StudentsForm_Load(object sender, EventArgs e)
        {
            _studentService.Add(new Student() { LastName = "Doe", FirstName = "Jhon", Age = 25 });
            _studentService.Add(new Student() { LastName = "Davis", FirstName = "Jane", Age = 27 });
            _studentService.Add(new Student() { LastName = "Parker", FirstName = "Sara", Age = 21 });
            _studentService.Add(new Student() { LastName = "Simpson", FirstName = "Jessica", Age = 21 });
            _studentService.Add(new Student() { LastName = "Washington", FirstName = "Andre", Age = 21 });
            _studentService.Add(new Student() { LastName = "Wilson", FirstName = "Garry", Age = 21 });
            _studentService.Add(new Student() { LastName = "Wiliams", FirstName = "Amanda", Age = 21 });
            _studentService.Add(new Student() { LastName = "Wanderbuilt", FirstName = "Karen", Age = 21 });
            _studentService.Add(new Student() { LastName = "Walker", FirstName = "Monika", Age = 21 });
            _studentService.Add(new Student() { LastName = "Wilmington", FirstName = "Andre", Age = 21 });

            var students = _studentService.GetAll().MapStudentsToViewModel();
            grdStudents.AutoGenerateColumns = false;
            grdStudents.DataSource = students;

            foreach (var item in students)
            {
                lastNameList.Add(item.FullName);
            }
            //SetCmbLastName();

            ReadSelectedRow();
        }

        //private void SetCmbLastName()
        //{
        //    cmbLastName.DataSource = null;
        //    cmbLastName.Items.Clear();
        //    cmbLastName.ValueMember = "Id";
        //    cmbLastName.DisplayMember = "LastName";
        //    cmbLastName.DataSource = lastNameList;
        //    cmbLastName.SelectedIndex = -1;
        //}
        private void AddItemToList(string str)
        {
            if (!lastNameList.Contains(str))
            {
                lastNameList.Add(str);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.LastName = txtLastName.Text;
            student.FirstName = txtFirstName.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            _studentService.Add(student);
            AddItemToList(student.LastName);
            int index = _studentService.IndexOf(student);
            //SetCmbLastName();
            RefreshStudentsView();
            //cmbLastName.SelectedItem = txtLastName.Text.ToString();
            grdStudents.Rows[index].Selected = true;
            grdStudents.FirstDisplayedScrollingRowIndex = grdStudents.Rows[index].Index;
            ReadSelectedRow();
        }
        private void btnRemove_Clik(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            Student student = _studentService.Get(id);
            string lastName = student.LastName;
            _studentService.Remove(student);
            RefreshStudentsView();
            ReadSelectedRow();
            //cmbLastName.DataSource = studentService.GetAll().MapStudentsToViewModel().Select(x => x.FullName).ToArray();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            Student student = _studentService.Get(id);
            int age = Convert.ToInt32(txtAge.Text);
            student.Age = age;
            student.LastName = txtLastName.Text;
            student.FirstName = txtFirstName.Text;
            _studentService.Update(student);
            RefreshStudentsView();
            ReadSelectedRow();
        }
        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReadSelectedRow();
            //cmbLastName.SelectedItem = txtLastName.Text.ToString();
        }
        private void RefreshStudentsView()
        {
            grdStudents.DataSource = _studentService.GetAll().MapStudentsToViewModel(); ;
        }

        private void RefreshTeachersView()
        {
            grdStudents.DataSource = _teacherService.GetAll().MapTeachersToViewModel(); ;
        }
        private void ReadSelectedRow()
        {
            if (grdStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdStudents.SelectedRows[0];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtLastName.Text = row.Cells["stFullName"].Value.ToString().Split(' ').Last();
                txtFirstName.Text = row.Cells["stFullName"].Value.ToString().Split(' ').First();
                txtAge.Text = row.Cells["stAge"].Value.ToString();
            }
        }

        private void grdStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (grdStudents.SelectedRows.Count > 0)
            {
                ReadSelectedRow();
                //cmbLastName.SelectedItem = txtLastName.Text.ToString();
            }
        }
        private void cmbLastName_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (cmbLastName.SelectedIndex != -1)
            //{
            //    string lastName = cmbLastName.SelectedValue.ToString();
            //    StudentViewModel student = studentService.GetAll().MapStudentsToViewModel().FirstOrDefault(x => x.FullName == lastName);
            //    txtId.Text = student.Id.ToString();
            //    txtLastName.Text = student.FullName.Split(' ').Last();
            //    txtFirstName.Text = student.FullName.Split(' ').First();
            //    txtAge.Text = student.Age.ToString();
            //    foreach (DataGridViewRow row in grdStudents.Rows)
            //    {
            //        if (row.Cells[1].Value.ToString().Equals(lastName))
            //        {
            //            row.Selected = true;
            //        }
            //    }
            //}
        }

        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
