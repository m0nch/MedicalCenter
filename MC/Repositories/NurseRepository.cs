using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class NurseRepository : StaffRepository
    {
        public List<Nurse> _nurses;

        public NurseRepository()
        {
            _nurses = new List<Nurse>();
        }

        public new Nurse Get(Guid id)
        {
            return _nurses.FirstOrDefault(x => x._id == id);
        }
    }
}
