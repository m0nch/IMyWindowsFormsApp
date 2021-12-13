using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    class TeacherRepository : BaseRepository<Teacher>
    {
        public override Teacher Get(Guid id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

    }
}
