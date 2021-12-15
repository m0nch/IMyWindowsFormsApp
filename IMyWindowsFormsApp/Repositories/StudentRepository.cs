using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public class StudentRepository : BaseRepository<Student>
    {
        public override Student Get(Guid id)
        {
            return models.FirstOrDefault(x => x.Id == id);
        }

        public override List<Student> GetAllByTeacher(Guid id)
        {
            List<Student> group = new List<Student>();
            for (int i = 0; i < models.Count; i++)
            {
                if (models[i].teacherId == id)
                {
                    group.Add(models[i]);
                }
            }
            return group;
        }
        public override int IndexOf(Student model)
        {
            return models.IndexOf(model);
        }

    }
}
