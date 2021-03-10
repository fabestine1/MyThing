using Border_Control.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Robot : IRobot
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; private set; }

        public string Id { get; private set; }
        public bool CheckId(string ending)
        {

            if (Id.EndsWith(ending))
            {
                return true;
            }
            return false;
        }

    }
}
