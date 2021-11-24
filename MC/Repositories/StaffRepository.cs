using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class StaffRepository : BaseRepository<Staff>, IStaffRepository<Staff>, IBaseRepository<Staff>
    {
        public void PaySalary()
        {
            Console.WriteLine("Pay salary");
        }

        public override Staff Get(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}
