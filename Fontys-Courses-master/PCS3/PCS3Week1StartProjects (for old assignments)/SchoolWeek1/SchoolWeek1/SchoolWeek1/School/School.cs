using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    [Serializable]
    class School
    {
        public string Name { get; set; }
        private List<Person> persons;

        public School(string nwName)
        {
            Name = nwName;
            persons = new List<Person>();
        }

        public Person GetPerson(int pcn)
        {
            foreach(Person person in persons)
            {
                if(person.PCN == pcn)
                {
                    return person;
                }
            }
            return null;
        }
        public bool AddPerson(Person p)
        {
            if (GetPerson(p.PCN) != null)
            {
                return false;
            }
            persons.Add(p);
            return true;
        }
        public List<Person> GetPersons()
        {
            return persons;
        }
        public List<Person> GetPersons(String p)
        {
            List<Person> foundPersons = new List<Person>();
            foreach(Person person in persons)
            {
                if (person.Name.Contains(p))
                {
                    foundPersons.Add(person);
                }
            }
            return foundPersons;
        }
        public List<Person> GetYoungPersons(int limit)
        {
            List<Person> foundPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Age <= limit)
                {
                    foundPersons.Add(person);
                }
            }
            return foundPersons;
        }
    }
}
