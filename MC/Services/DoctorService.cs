using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class DoctorService : StaffService, IDoctorService, IStaffService
    {
        private readonly DoctorRepository _doctorRepository;

        public DoctorService(DoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
        public void Add(Doctor model)
        {
            _doctorRepository.Add(model);
        }

        public new Doctor Get(Guid id)
        {
            return _doctorRepository.Get(id);
        }

        public override List<Staff> GetAll()
        {
            return _doctorRepository.GetAll();
        }

        public void Remove(Doctor model)
        {
            _doctorRepository.Remove(model);
        }

        public void Update(Doctor model)
        {
            var oldDoctor = _doctorRepository.Get(model._id);
            var index = _doctorRepository.IndexOf(oldDoctor);
            _doctorRepository.Update(model, index);
        }
    }
}
