using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control.Interfaces
{
    public interface ICitizen : IRobot, IBirthday
    {
        public int Age { get; }
    }
}
