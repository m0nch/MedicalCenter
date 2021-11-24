using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class Doctor : Staff
    {
        public List<Patient> _patients;
        public string _speciality;
        public Doctor()
        {
            _id = Guid.NewGuid();
        }
        public Doctor(string name, int age, string speciality)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _speciality = speciality;
        }
    }
}
