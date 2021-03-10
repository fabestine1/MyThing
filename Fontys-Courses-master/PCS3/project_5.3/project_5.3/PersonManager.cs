using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._3
{
    class PersonManager
    {
        private List<Person> people = new List<Person>();
        public bool AddPerson(Person p)
        {
            if (GetPerson(p.PCN) == null)
            {
                people.Add(p);
                return true;
            }
            else return false;
        }

        public bool RemovePerson(int pcn)
        {
            foreach(Person p in people)
            {
                if(p.PCN == pcn)
                {
                    people.Remove(p);
                    return true;
                }
            }
            return false;
        }

        public bool RemovePerson(Person p)
        {
            if (people.Remove(p)) return true;
            else return false;
        }

        public Person GetPerson(int pcn)
        {
            foreach (Person p in people)
            {
                if(p.PCN == pcn)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Person> GetAllPeople()
        {
            return people;
        }
    }
}
