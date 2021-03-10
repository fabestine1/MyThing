using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control.Interfaces
{
    public interface IRobot : IEnter
    {
        public string Id { get; }

        public bool CheckId(string ending);
    }
}
