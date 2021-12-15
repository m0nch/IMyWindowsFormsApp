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
        private readonly StudentService _studentService;

        private readonly TeacherService _teacherService;

        List<string> lastNameList = new List<string>();

        public MainForm(StudentService studentService, TeacherService teacherService)
        {
            InitializeComponent();
            _studentService = studentService;
            _teacherService = teacherService;
            //this.Load += delegate { RefreshGridView(); };
        }


        private void ShowForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void tsMenuStudents_Click(object sender, EventArgs e)
        {
            StudentsForm.Instance.LoadServices(_studentService, _teacherService);
            ShowForm(StudentsForm.Instance);
            tsMenuStudents.Checked = true;
            tsMenuTeachers.Checked = false;

            //_studentService.Add(new Student() { LastName = "Doe", FirstName = "Jhon", Age = 25 });
            //_studentService.Add(new Student() { LastName = "Davis", FirstName = "Jane", Age = 27 });
            //_studentService.Add(new Student() { LastName = "Parker", FirstName = "Sara", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Simpson", FirstName = "Jessica", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Washington", FirstName = "Andre", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Wilson", FirstName = "Garry", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Wiliams", FirstName = "Amanda", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Wanderbuilt", FirstName = "Karen", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Walker", FirstName = "Monika", Age = 21 });
            //_studentService.Add(new Student() { LastName = "Wilmington", FirstName = "Andre", Age = 21 });

            //var students = _studentService.GetAll().MapStudentsToViewModel();


            //foreach (var item in students)
            //{
            //    lastNameList.Add(item.FullName);
            //}
            ////SetCmbLastName();

        }
        private void tsMenuTeachers_Click(object sender, EventArgs e)
        {
            TeachersForm.Instance.LoadServices(_studentService, _teacherService);
            ShowForm(TeachersForm.Instance);
            tsMenuTeachers.Checked = true;
            tsMenuStudents.Checked = false;

            //_teacherService.Add(new Teacher() { LastName = "Williams", FirstName = "Michael", Age = 33 });
            //_teacherService.Add(new Teacher() { LastName = "Anderson", FirstName = "Robert", Age = 41 });
            //_teacherService.Add(new Teacher() { LastName = "Wilson", FirstName = "William", Age = 44 });
            //_teacherService.Add(new Teacher() { LastName = "Harris", FirstName = "Richard", Age = 54 });
            //_teacherService.Add(new Teacher() { LastName = "Clark", FirstName = "Thomas", Age = 48 });

            //var teachers = _teacherService.GetAll().MapTeachersToViewModel();


            ////SetCmbLastName();


            //foreach (var item in teachers)
            //{
            //    lastNameList.Add(item.FullName);
            //}


        }

        private void SetCmbLastName()
        {
        }


    }
}
