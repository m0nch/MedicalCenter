using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IPatientRepository<T>:IBaseRepository<T>
    {
        void PayForServices();
    }
}
