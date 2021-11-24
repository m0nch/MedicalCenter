using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class DoctorRepository : StaffRepository
    {
        string _speciality;
        public List<Doctor> _doctors;

        public DoctorRepository()
        {
            _doctors = new List<Doctor>();
        }
        public void AssignSpeciality(string speciality)
        {
            _speciality = speciality;
        }

        public void AssignPatient(Patient patient)
        {

        }

        public void Cure()
        {
            Console.WriteLine("Cure");
        }
        public new Doctor Get(Guid id)
        {
            return _doctors.FirstOrDefault(x => x._id == id);
        }

    }
}
