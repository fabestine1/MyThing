using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carClass
{
    public class Car
    {
        private int _speed;
        private double _fuel;
        
        public Car()
        {

        }

        public Car(string carName, int carSpeed, string carColor, double carFuel)
        {
            this.Name = carName;
            this.Speed = carSpeed;
            this.Color = carColor;
            this.Fuel = carFuel;
        }


        public string Color { get; set; }
        public string Name { get; set; }
        public double Fuel
        {
            get
            {
                return this._fuel;
            }
            private set
            {
                if(value < 0 || value > 50)
                {
                    throw new ArgumentException("_fuel can be only Gas, Diesel or Metan");
                }

                this._fuel = value;
            }
        }
        public int Speed
        {
            get
            {   
                return this._speed;
            }
            private set
            {
                if(value < 0 || value > 260)
                {
                    throw new ArgumentException("_speed can NOT be negative");
                }

                this._speed = value;
            }
        }
        
        public int Accerelate(int new_speed = 10, int step = 3)
        {
            if (Fuel != 0)
            {
                if (Name == "BMW")
                {
                    this.Speed += step;
                    return this.Speed;
                }
                    else
                    {
                        this.Speed += new_speed;
                        return this.Speed;
                    }
            }
                else
                {
                    Console.WriteLine("No fuel left");
                    this.Speed = 0;
                    return this.Speed;
                }
        }

        public int Break(int new_speed = 10, int step = 3)
        {
            if(Fuel != 0)
            {
                if (Name == "BMW")
                {
                    this.Speed -= step;
                    return this.Speed;
                }
                    else
                    {
                        this.Speed -= new_speed;
                        return this.Speed;
                    }
            }
                else
                {
                    Console.WriteLine("No fuel left");
                    this.Speed = 0;
                    return this.Speed;
                }
        }

        public double Refill(double fill)
        {
            this.Fuel += fill;
            return this.Fuel;
        }
    }
}
