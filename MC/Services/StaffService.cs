using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class StaffService : IStaffService
    {
        //private readonly StaffRepository _staffRepository;

        //public StaffService(StaffRepository staffRepository)
        //{
        //    _staffRepository = staffRepository;
        //}

        public virtual void Add(Staff model)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Staff model)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(Staff model, int index)
        {
            throw new NotImplementedException();
        }

        public virtual Staff Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual List<Staff> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
