using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TrafficSimulatorUi.Traffic
{
    public class GreenTrain : RoadUser
    {
        public GreenTrain(Point location) : base(location, 2, Properties.Resources.GreenTrain, false)
        {

        }
    }
}
