using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public class DbContext : IDbContext
    {
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public DbContext()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }
    }
}
