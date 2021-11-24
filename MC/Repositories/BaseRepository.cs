using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class BaseRepository<T> : IBaseRepository<T>
    {
        private List<T> models;

        public BaseRepository()
        {
            models = new List<T>();
        }
        public virtual void Add(T model)
        {
            models.Add(model);
        }

        public virtual T Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetAll()
        {
            return models;
        }

        public virtual void Remove(T model)
        {
            models.Remove(model);
        }

        public void Update(T model, int index)
        {
            models[index] = model;
        }

        public int IndexOf(T model)
        {
            return models.IndexOf(model);
        }
    }
}
