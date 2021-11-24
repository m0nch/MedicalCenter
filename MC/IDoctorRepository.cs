using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    interface IDoctorRepository : IStaffRepository<Doctor>, IBaseRepository<Doctor>
    {
        void AssignSpeciality(string speciality);
        void AssignPatient(Patient patient);
        void Cure();
    }
}
