using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public interface IDbContext
    {
        List<Teacher> Teachers { get; set; }
        List<Student> Students { get; set; }
    }
}
