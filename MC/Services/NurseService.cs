using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class NurseService : StaffService, INurseService, IStaffService
    {
        private readonly NurseRepository _nurseRepository;

        public NurseService(NurseRepository nurseRepository)
        {
            _nurseRepository = nurseRepository;
        }
        public void Add(Nurse model)
        {
            _nurseRepository.Add(model);
        }

        public new Nurse Get(Guid id)
        {
            return _nurseRepository.Get(id);
        }

        public new List<Staff> GetAll()
        {
            return _nurseRepository.GetAll();
        }

        public void Remove(Nurse model)
        {
            _nurseRepository.Remove(model);
        }

        public void Update(Nurse model)
        {
            var oldNurse = _nurseRepository.Get(model._id);
            var index = _nurseRepository.IndexOf(oldNurse);
            _nurseRepository.Update(model, index);
        }

    }
}
