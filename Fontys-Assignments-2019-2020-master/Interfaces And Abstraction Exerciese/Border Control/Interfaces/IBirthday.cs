using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control.Interfaces
{
    public interface IBirthday
    {
        public string Birthdate { get; }

        public bool CheckBirth(string year);
    }
}
