using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterWeek1
{
    class Dog : Animal
    {
        public DateTime LastWalk { get; private set; }
        public Dog(string regNum, DateTime brought, string name, DateTime lastWalk) : base(regNum, brought, name)
        {
            LastWalk = lastWalk;
        }
        public override string AsString()
        {
            return base.AsString() + LastWalk;
        }
        public void TakeForAWalk()
        {
            LastWalk = DateTime.Now;
        }
    }
}
