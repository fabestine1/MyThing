using Border_Control.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public bool CheckBirth(string year)
        {
            if (Birthdate.EndsWith(year))
            {
                return true;
            }
            return false;
        }

        public bool CheckId(string ending)
        {
            var charEnding = ending.ToString();
            var charId = Id.ToString();

            if (charId.EndsWith(charEnding))
            {
                return true;
            }
            return false;
        }
    }
}
