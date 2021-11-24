using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class WorkerRepository : StaffRepository
    {
        public List<Worker> _workers;

        public WorkerRepository()
        {
            _workers = new List<Worker>();
        }

        public new Worker Get(Guid id)
        {
            return _workers.FirstOrDefault(x => x._id == id);
        }

    }
}
