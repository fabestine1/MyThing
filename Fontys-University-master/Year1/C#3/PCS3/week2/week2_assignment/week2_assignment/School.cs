using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_assignment
{
    class School
    {
        String schoolName;
        List<Person> personsList;

        //properties
        //public School SchoolName
        //{
        //    set { value = this.schoolName; }
        //    get { return this.schoolName; }
        //}

        //constructor
        public School(String name)
        {
            schoolName = name;
            personsList = new List<Person>();
        }

        //methods
        public List<Person> GetPersonPCN(int pcn)
        {
            List<Person> temp = new List<Person>();
            foreach(Person p in personsList)
            {
                if (p.PCN == pcn)
                {
                    temp.Add(p);
                    return personsList;
                }
                else
                    return null;
            }
            return temp;
        }

        public bool AddPerson(Person p)
        {
            if(personsList.Contains(p))
            {
                return false;
            }
            else
            {
                personsList.Add(p);
                return true;
            }
        }

        public List<Person> GetPersons()
        {
            return personsList;
        }

        public List<Person> GetPersonName(String p)
        {
            List<Person> temp = new List<Person>();
            foreach(Person person in personsList)
            {
                if (person.Name.Contains(p))
                    temp.Add(person);
            }
            return temp;
        } 

        public List<Person> GetYoungPersons(int limit)
        {
            List<Person> temp = new List<Person>();
            foreach (Person person in personsList)
            {
                if (person.Age == limit)
                    temp.Add(person);
            }
            return temp;
        }
    }
}
