using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; }
        public string Color { get; }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            string info = $"{this.Color} Seat {this.Model}\n{this.Start()}\n{this.Stop()}";

            return info.ToString();
        }
    }
}
