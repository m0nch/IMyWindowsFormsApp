using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMyWindowsFormsApp
{
    interface IDbContext<T>
    {
        T model { get; set; }
    }
}
