using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public class TeacherRepository : BaseRepository<Teacher>
    {
        public override Teacher Get(Guid id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

        public override int IndexOf(Teacher model)
        {
            return models.IndexOf(model);
        }

    }
}
