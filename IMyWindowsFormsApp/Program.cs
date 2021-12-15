using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMyWindowsFormsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StudentRepository studentRepository = new StudentRepository();
            StudentService studentService = new StudentService(studentRepository);

            TeacherRepository teacherRepository = new TeacherRepository();
            TeacherService teacherService = new TeacherService(teacherRepository);

            Application.Run(new MainForm(studentService, teacherService));
        }
    }
}
