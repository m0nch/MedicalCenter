using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IWorkerRepository:IStaffRepository<Worker>, IBaseRepository<Doctor>
    {
    }
}
