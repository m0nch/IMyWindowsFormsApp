using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IMyWindowsFormsApp
{
    public class BaseRepository<T> : DbContext<T>, IDbContext<T>, IBaseRepository<T>
    {
        //public List<T> models;

        public BaseRepository()
        {
            models = new List<T>();
        }
        public virtual void Add(T model)
        {
            models.Add(model);
        }
        public virtual void Remove(T model)
        {
            models.Remove(model);
        }

        public void Update(T model, int index)
        {
            models[index] = model;
        }
        public virtual T Get(Guid id)
        {
            throw new NotImplementedException();
        }
        public virtual List<T> GetAll()
        {
            return models;
        }
        public virtual int IndexOf(T model)
        {
            return models.IndexOf(model);
        }
        public virtual List<T> GetAllByTeacher(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
