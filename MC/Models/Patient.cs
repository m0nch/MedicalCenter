using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class Patient
    {
        public Guid _id;
        public string _name;
        public int _age;
        public Doctor _doctor;
        public string _sick;
        public Patient()
        {
            _id = Guid.NewGuid();
        }
        public Patient(string name, int age, string sick)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _sick = sick;
        }

    }
}
