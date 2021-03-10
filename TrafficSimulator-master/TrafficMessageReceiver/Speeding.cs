﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrafficMessageReceiver
{
    class Speeding
    {
        public int carID { get; private set; }
        public int carSpeed { get; private set; }
        public DateTime time { get; private set; }

        // constructor, defineert alle variabelen
        public Speeding(int carID, int carSpeed, DateTime time)
        {
            this.carID = carID;
            this.carSpeed = carSpeed;
            this.time = time;
        }

        // maakt een leesbare string van de tijd
        public string timeToString()
        {
            return time.ToLongTimeString();
        }
        // maakt een leesbare string van alle data
        override
        public String ToString() {
            return Convert.ToString(carID) + " - " + Convert.ToString(carSpeed) + "km/h - " + time.ToLongTimeString();
        }
    }
}
