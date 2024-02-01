using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
        string name;
        int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Deconstruct(out string personName, out int personAge)
        {
            personName = name;
            personAge = age;
        }
    }
}
