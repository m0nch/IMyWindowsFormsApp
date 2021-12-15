using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    public class DbContext<T> : IDbContext<T>
    {
        public T model { get ; set; }
        public List<T> models;
    }
}
