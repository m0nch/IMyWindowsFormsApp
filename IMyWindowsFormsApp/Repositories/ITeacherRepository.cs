using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public interface ITeacherRepository
    {
        void Add(Teacher model);
        void Remove(Teacher model);
        Teacher Get(Guid id);
        void Update(Teacher model, int index);
        List<Teacher> GetAll();
        int IndexOf(Teacher model);

    }
}
