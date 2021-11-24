using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class Nurse : Staff
    {
        public List<Patient> _patients;
        public Nurse()
        {
            _id = Guid.NewGuid();
        }
        public Nurse(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }
    }
}
