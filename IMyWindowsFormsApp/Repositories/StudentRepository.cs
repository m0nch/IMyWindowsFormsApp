using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    class StudentRepository : BaseRepository<Student>
    {
        public override Student Get(Guid id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }
    }
}
