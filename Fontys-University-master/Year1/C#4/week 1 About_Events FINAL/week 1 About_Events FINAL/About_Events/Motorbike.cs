using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace About_Events
{
    public class Motorbike
    {
        public delegate void SpeedChangedHandler(Motorbike sender, int extraInfo);

        public event SpeedChangedHandler speedChanged;
        public event SpeedChangedHandler speedingTooFast;

        private int speed;
        private int maxSpeed;
        private String nameOfDriver;

        public Motorbike(String nameOfDriver, int maxSpeed)
        {
            this.nameOfDriver = nameOfDriver; 
            this.speed = 0;
            this.maxSpeed = maxSpeed;
        }

        public String NameOfDriver{ get {return this.nameOfDriver;} }
        
        public int Speed { get { return this.speed; } }

        public void Accelerate(int inc)
        {
            int oldSpeed = this.speed;
            this.speed += inc;
            if (this.speedChanged != null)
            { this.speedChanged(this, this.speed); }
            
            if(oldSpeed <= this.maxSpeed && this.speed > this.maxSpeed)
            {
                if (this.speedingTooFast != null)
                { this.speedingTooFast(this, this.speed - this.maxSpeed); }
            }

        }


    }
}
