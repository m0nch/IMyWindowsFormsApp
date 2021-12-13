﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    public partial class MainForm : Form
    {
        StudentRepository studentRepository = new StudentRepository();
        StudentService studentService;
        List<Student> studentsList;

        TeacherRepository teacherRepository = new TeacherRepository();
        TeacherService teacherService;
        List<Teacher> teachersList;

        List<string> lastNameList = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            studentService = new StudentService(studentRepository);
            teacherService = new TeacherService(teacherRepository);
            studentsList = new List<Student>();
            teachersList = new List<Teacher>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            grdMain.AutoGenerateColumns = false;
        }

        private void tsMenuStudents_Click(object sender, EventArgs e)
        {
            //grdMain.DataSource = null;
            tsMenuStudents.Checked = true;
            tsMenuTeachers.Checked = false;

            studentService.Add(new Student() { LastName = "Doe", FirstName = "Jhon", Age = 25 });
            studentService.Add(new Student() { LastName = "Davis", FirstName = "Jane", Age = 27 });
            studentService.Add(new Student() { LastName = "Parker", FirstName = "Sara", Age = 21 });
            studentService.Add(new Student() { LastName = "Simpson", FirstName = "Jessica", Age = 21 });
            studentService.Add(new Student() { LastName = "Washington", FirstName = "Andre", Age = 21 });
            studentService.Add(new Student() { LastName = "Wilson", FirstName = "Garry", Age = 21 });
            studentService.Add(new Student() { LastName = "Wiliams", FirstName = "Amanda", Age = 21 });
            studentService.Add(new Student() { LastName = "Wanderbuilt", FirstName = "Karen", Age = 21 });
            studentService.Add(new Student() { LastName = "Walker", FirstName = "Monika", Age = 21 });
            studentService.Add(new Student() { LastName = "Wilmington", FirstName = "Andre", Age = 21 });

            studentsList = studentRepository.GetAll();
            grdMain.DataSource = studentsList;

            lblInfo.Visible = true;
            lblInfo.Text = "Students Information";

            lastNameList.Clear();
            foreach (var item in studentsList)
            {
                lastNameList.Add(item.LastName);
            }

            SetCmbLastName();
            ReadSelectedRow();
        }
        private void tsMenuTeachers_Click(object sender, EventArgs e)
        {
            //grdMain.DataSource = null;
            tsMenuTeachers.Checked = true;
            tsMenuStudents.Checked = false;
            
            teacherService.Add(new Teacher() { LastName = "Williams", FirstName = "Michael", Age = 33 });
            teacherService.Add(new Teacher() { LastName = "Anderson", FirstName = "Robert", Age = 41 });
            teacherService.Add(new Teacher() { LastName = "Wilson", FirstName = "William", Age = 44 });
            teacherService.Add(new Teacher() { LastName = "Harris", FirstName = "Richard", Age = 54 });
            teacherService.Add(new Teacher() { LastName = "Clark", FirstName = "Thomas", Age = 48 });

            teachersList = teacherRepository.GetAll();
            grdMain.DataSource = teachersList;
                       
            lblInfo.Visible = true;
            lblInfo.Text = "Teachers Information";

            lastNameList.Clear();
            foreach (var item in teachersList)
            {
                lastNameList.Add(item.LastName);
            }

            SetCmbLastName();
            ReadSelectedRow();
        }

        private void SetCmbLastName()
        {
            cmbLastName.DataSource = null;
            cmbLastName.Items.Clear();
            cmbLastName.ValueMember = "Id";
            cmbLastName.DisplayMember = "LastName";
            cmbLastName.DataSource = lastNameList;
            cmbLastName.SelectedIndex = -1;
        }
        private void AddItemToList(StudentRepository repository, string str)
        {
            if (!lastNameList.Contains(str))
            {
                lastNameList.Add(str);
            }
        }
        private void AddItemToList(TeacherRepository repository, string str)
        {
            if (!lastNameList.Contains(str))
            {
                lastNameList.Add(str);
            }
        }
        private void RemoveItemToList(List<Student> list, string str)
        {
            var st = list.Find(x => x.LastName == str);
            if (st == null)
            {
                lastNameList.Remove(str);
                SetCmbLastName();
            }
        }
        private void RemoveItemToList(List<Teacher> list, string str)
        {
            var st = list.Find(x => x.LastName == str);
            if (st == null)
            {
                lastNameList.Remove(str);
                SetCmbLastName();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tsMenuStudents.Checked)
            {
                Student student = new Student();
                student.LastName = txtLastName.Text;
                student.FirstName = txtFirstName.Text;
                student.Age = Convert.ToInt32(txtAge.Text);
                studentService.Add(student);
                AddItemToList(studentRepository, student.LastName);
                int index = studentRepository.IndexOf(student);
                SetCmbLastName();
                RefreshGridView();
                cmbLastName.SelectedItem = txtLastName.Text.ToString();
                grdMain.Rows[index].Selected = true;
                grdMain.FirstDisplayedScrollingRowIndex = grdMain.Rows[index].Index;
                ReadSelectedRow();
            }
            else if (tsMenuTeachers.Checked)
            {
                Teacher teacher = new Teacher();
                teacher.LastName = txtLastName.Text;
                teacher.FirstName = txtFirstName.Text;
                teacher.Age = Convert.ToInt32(txtAge.Text);
                teacherService.Add(teacher);
                AddItemToList(teacherRepository, teacher.LastName);
                int index = teacherRepository.IndexOf(teacher);
                SetCmbLastName();
                RefreshGridView();
                cmbLastName.SelectedItem = txtLastName.Text.ToString();
                grdMain.Rows[index].Selected = true;
                grdMain.FirstDisplayedScrollingRowIndex = grdMain.Rows[index].Index;
                ReadSelectedRow();
            }
        }
        private void btnRemove_Clik(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            if (tsMenuStudents.Checked)
            {
                Student student = studentService.Get(id);
                string lastName = student.LastName;
                studentService.Remove(student);
                RefreshGridView();
                ReadSelectedRow();
                RemoveItemToList(studentsList, lastName);
            }
            else if (tsMenuTeachers.Checked)
            {
                Teacher teacher = teacherService.Get(id);
                string lastName = teacher.LastName;
                teacherService.Remove(teacher);
                RefreshGridView();
                ReadSelectedRow();
                RemoveItemToList(teachersList, lastName);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Guid id = Guid.Parse(txtId.Text);
            if (tsMenuStudents.Checked)
            {
                Student student = studentService.Get(id);
                int age = Convert.ToInt32(txtAge.Text);
                student.Age = age;
                student.LastName = txtLastName.Text;
                student.FirstName = txtFirstName.Text;
                studentService.Update(student);
            }
            else if (tsMenuTeachers.Checked)
            {
                Teacher teacher = teacherService.Get(id);
                int age = Convert.ToInt32(txtAge.Text);
                teacher.Age = age;
                teacher.LastName = txtLastName.Text;
                teacher.FirstName = txtFirstName.Text;
                teacherService.Update(teacher);
            }
            RefreshGridView();
            ReadSelectedRow();
        }
        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReadSelectedRow();
            cmbLastName.SelectedItem = txtLastName.Text.ToString();
        }
        private void RefreshGridView()
        {
            grdMain.DataSource = null;
            if (tsMenuStudents.Checked)
            {
                grdMain.DataSource = studentsList;
            }
            else if (tsMenuTeachers.Checked)
            {
                grdMain.DataSource = teachersList; ;
            }
        }
        private void ReadSelectedRow()
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grdMain.SelectedRows[0];
                txtId.Text = row.Cells["id"].Value.ToString();
                txtLastName.Text = row.Cells["stLastName"].Value.ToString();
                txtFirstName.Text = row.Cells["stFirstName"].Value.ToString();
                txtAge.Text = row.Cells["stAge"].Value.ToString();
            }
        }

        private void grdStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count > 0)
            {
                ReadSelectedRow();
                cmbLastName.SelectedItem = txtLastName.Text.ToString();
            }
        }
        private void cmbLastName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbLastName.SelectedIndex != -1)
            {
                string lastName = cmbLastName.SelectedValue.ToString();
                if (tsMenuStudents.Checked)
                {
                    Student student = studentsList.FirstOrDefault(x => x.LastName == lastName);
                    txtId.Text = student.Id.ToString();
                    txtLastName.Text = student.LastName.ToString();
                    txtFirstName.Text = student.FirstName.ToString();
                    txtAge.Text = student.Age.ToString();
                }
                else if (tsMenuTeachers.Checked)
                {
                    Teacher teacher = teachersList.FirstOrDefault(x => x.LastName == lastName);
                    txtId.Text = teacher.Id.ToString();
                    txtLastName.Text = teacher.LastName.ToString();
                    txtFirstName.Text = teacher.FirstName.ToString();
                    txtAge.Text = teacher.Age.ToString();
                }
                foreach (DataGridViewRow row in grdMain.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(lastName))
                    {
                        row.Selected = true;
                    }
                }
            }
        }
    }
}