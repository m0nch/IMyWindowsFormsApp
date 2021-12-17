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

            IDbContext dbContext = new DbContext();
            IStudentRepository studentRepository = new StudentRepository(dbContext);
            IStudentService studentService = new StudentService(studentRepository);

            ITeacherRepository teacherRepository = new TeacherRepository(dbContext);
            ITeacherService teacherService = new TeacherService(teacherRepository);

            Application.Run(new MainForm(teacherService, studentService));
        }
    }
}
