using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IStaffRepository<T> : IBaseRepository<T>
    {
        void PaySalary();
    }
}
