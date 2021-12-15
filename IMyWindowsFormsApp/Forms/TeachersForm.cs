using IMyWindowsFormsApp.Mappers;
using IMyWindowsFormsApp.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    public partial class TeachersForm : Form
    {
        private static TeachersForm _instance;

        public static TeachersForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TeachersForm();
                return _instance;
            }
        }

        StudentService _studentService;
        TeacherService _teacherService;

        List<string> lastNameList = new List<string>();

        public void LoadServices(StudentService studentService, TeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }

        public TeachersForm()
        {
            InitializeComponent();

            //this.Load += delegate { RefreshGridView(); };
        }
        private void TeachersForm_Load(object sender, EventArgs e)
        {
            _teacherService.Add(new Teacher() { LastName = "Williams", FirstName = "Michael", Age = 33 });
            _teacherService.Add(new Teacher() { LastName = "Anderson", FirstName = "Robert", Age = 41 });
            _teacherService.Add(new Teacher() { LastName = "Wilson", FirstName = "William", Age = 44 });
            _teacherService.Add(new Teacher() { LastName = "Harris", FirstName = "Richard", Age = 54 });
            _teacherService.Add(new Teacher() { LastName = "Clark", FirstName = "Thomas", Age = 48 });

            var teachers = _teacherService.GetAll().MapTeachersToViewModel();
            grdTeachers.AutoGenerateColumns = false;
            grdTeachers.DataSource = teachers;

            var students = _studentService.GetAllByTeacher(Guid.Parse(grdTeachers.SelectedRows[0].Cells["Id"].Value.ToString())).MapStudentsToViewModel();
            grdStudents.AutoGenerateColumns = false;
            grdStudents.DataSource = students;

            //SetCmbLastName();

            foreach (var item in teachers)
            {
                lastNameList.Add(item.FullName);
            }

            ReadSelectedRow();
        }


        private void SetCmbLastName()
        {
            //cmbLastName.DataSource = null;
            //cmbLastName.Items.Clear();
            //cmbLastName.ValueMember = "Id";
            //cmbLastName.DisplayMember = "LastName";
            //cmbLastName.DataSource = lastNameList;
            //cmbLastName.SelectedIndex = -1;
        }
        private void AddItemToList(string str)
        {
            if (!lastNameList.Contains(str))
            {
                lastNameList.Add(str);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.LastName = txtLastName.Text;
            teacher.FirstName = txtFirstName.Text;
            teacher.Age = Convert.ToInt32(txtAge.Text);
            _teacherService.Add(teacher);
            AddItemToList(teacher.LastName);
            int index = _teacherService.IndexOf(teacher);
            //SetCmbLastName();
            RefreshTeachersView();
            //cmbLastName.SelectedItem = txtLastName.Text.ToString();
            grdTeachers.Rows[index].Selected = true;
            grdTeachers.FirstDisplayedScrollingRowIndex = grdTeachers.Rows[index].Index;
            ReadSelectedRow();
        }
        private void btnRemove_Clik(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            Teacher teacher = _teacherService.Get(id);
            string lastName = teacher.LastName;
            _teacherService.Remove(teacher);
            RefreshTeachersView();
            ReadSelectedRow();
            //cmbLastName.DataSource = teacherService.GetAll().MapTeachersToViewModel().Select(x => x.FullName).ToArray();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            Teacher teacher = _teacherService.Get(id);
            int age = Convert.ToInt32(txtAge.Text);
            teacher.Age = age;
            teacher.LastName = txtLastName.Text;
            teacher.FirstName = txtFirstName.Text;
            _teacherService.Update(teacher);
            RefreshTeachersView();
            ReadSelectedRow();
        }
        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReadSelectedRow();
            //cmbLastName.SelectedItem = txtLastName.Text.ToString();
        }
        private void RefreshStudentsView()
        {
            grdTeachers.DataSource = _studentService.GetAll().MapStudentsToViewModel(); ;
        }

        private void RefreshTeachersView()
        {
            grdTeachers.DataSource = _teacherService.GetAll().MapTeachersToViewModel(); ;
        }
        private void ReadSelectedRow()
        {
            if (grdTeachers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdTeachers.SelectedRows[0];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtLastName.Text = row.Cells["tchFullName"].Value.ToString().Split(' ').Last();
                txtFirstName.Text = row.Cells["tchFullName"].Value.ToString().Split(' ').First();
                txtAge.Text = row.Cells["tchAge"].Value.ToString();
            }
        }

        private void grdStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTeachers.SelectedRows.Count > 0)
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
            //    TeacherViewModel teacher = teacherService.GetAll().MapTeachersToViewModel().FirstOrDefault(x => x.FullName == lastName);
            //    txtId.Text = teacher.Id.ToString();
            //    txtLastName.Text = teacher.FullName.Split(' ').Last();
            //    txtFirstName.Text = teacher.FullName.Split(' ').First();
            //    txtAge.Text = teacher.Age.ToString();
            //    foreach (DataGridViewRow row in grdTeachers.Rows)
            //    {
            //        if (row.Cells[1].Value.ToString().Equals(lastName))
            //        {
            //            row.Selected = true;
            //        }
            //    }
            //}
        }

        private void TeachersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void grdTeachers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void menuItemAssignStudent_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(grdTeachers.SelectedRows[0].Cells["Id"].Value.ToString());
            using (AddEditStudentForm frm = new AddEditStudentForm())
            {
                frm.StudentInfo = new Student();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    frm.StudentInfo.teacherId = id;
                    _studentService.Add(frm.StudentInfo);
                    frm.Close();
                }
                grdStudents.DataSource = _studentService.GetAllByTeacher(id).MapStudentsToViewModel().ToList();
            }
        }

        private void menuItemShowStudents_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(grdTeachers.SelectedRows[0].Cells["Id"].Value.ToString());
            //using (StudentsForm frm = new StudentsForm(id))
            //{
            //    //studentService.GetAll().MapStudentsToViewModel().ToList();
            //    studentService.GetAllByTeacher(id).MapStudentsToViewModel().ToList();
            //    frm.Show();
            //    frm.Activate();
            //}
            // StudentsForm frm = new StudentsForm();

        }

        private void menuItemEditStudent_Click(object sender, EventArgs e)
        {
            Guid idS = Guid.Parse(grdStudents.SelectedRows[0].Cells["stId"].Value.ToString());
            Guid idT = Guid.Parse(grdTeachers.SelectedRows[0].Cells["Id"].Value.ToString());
            Student student = _studentService.Get(idS);
            using (AddEditStudentForm frm = new AddEditStudentForm())
            {
                frm.StudentInfo = student;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _studentService.Update(frm.StudentInfo);
                    frm.Close();
                }
                grdStudents.DataSource = _studentService.GetAllByTeacher(idT).MapStudentsToViewModel().ToList();
            }

        }
    }
}
