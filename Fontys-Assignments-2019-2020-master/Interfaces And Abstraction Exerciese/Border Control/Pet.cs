using Border_Control.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Pet : IEnter, IBirthday
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; private set; }

        public string Name { get; private set; }

        public bool CheckBirth(string year)
        {
            if (Birthdate.EndsWith(year))
            {
                return true;
            }
            return false;
        }
    }
}
