using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class PersonHandler
    {
        List<Person> persons;
        public PersonHandler()
        {
            persons = new List<Person>();
        }

        public Person CreatePerson(int age, string fname, string iname, double height, double weight)
        {
            var p = new Person(age, fname, iname, height, weight);
            persons.Add(p);
            return p;
        }

        public void SetAge(Person pers, int val)
        {
            pers.Age = val;
        }
        public void SetFName(Person pers, string str)
        {
            pers.FName = str;
        }
        public void SetIName(Person pers, string str)
        {
            pers.IName = str;
        }
        public void SetHeight(Person pers, double val)
        {
            pers.Height = val;
        }
        public void SetWeight(Person pers, double val)
        {
            pers.Weight = val;
        }

        public List<Person> GetList()
        {
            return persons;
        }

    }
}
