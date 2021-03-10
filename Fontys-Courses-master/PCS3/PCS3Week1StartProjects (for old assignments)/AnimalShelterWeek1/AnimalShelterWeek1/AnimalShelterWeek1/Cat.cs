using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Cat : Animal
    {
        public string BadHabits { get; private set; }
        public Cat(string regNum, DateTime brought, string name, string badHabit) : base(regNum, brought, name)
        {
            BadHabits = badHabit;
        }
        public override string AsString()
        {
            return base.AsString() + BadHabits;
        }
        public void AddBadHabit(string newBadHabbit)
        {
            BadHabits += ", " + newBadHabbit;
        }
    }
}
