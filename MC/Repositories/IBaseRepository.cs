using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IBaseRepository<T>
    {
        void Add(T model);

        void Remove(T model);

        void Update(T model, int index);

        T Get(Guid id);

        List<T> GetAll();

        int IndexOf(T model);
    }
}
