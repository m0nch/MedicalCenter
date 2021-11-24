using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class Worker : Staff
    {
        public Worker()
        {
            _id = Guid.NewGuid();
        }
        public Worker(string name, int age)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
        }

    }
}
