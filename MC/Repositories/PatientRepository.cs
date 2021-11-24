using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class PatientRepository : BaseRepository<Patient>, IPatientRepository<Patient>
    {
        public List<Patient> _patients;

        public PatientRepository()
        {
            _patients = new List<Patient>();
        }

        public override Patient Get(Guid id)
        {
            return _patients.FirstOrDefault(x => x._id == id);
        }

        public void PayForServices()
        {
            Console.WriteLine("Pay for services");
        }


    }
}
