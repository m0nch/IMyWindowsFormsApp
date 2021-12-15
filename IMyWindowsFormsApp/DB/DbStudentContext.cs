using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    class DbStudentContext : DbContext<Student>, IDbContext<Student>
    {

    }
}
