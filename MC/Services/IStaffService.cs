using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IStaffService
    {
        void Add(Staff model);

        void Remove(Staff model);

        void Update(Staff model, int index);

        Staff Get(Guid id);

        List<Staff> GetAll();
    }
}
