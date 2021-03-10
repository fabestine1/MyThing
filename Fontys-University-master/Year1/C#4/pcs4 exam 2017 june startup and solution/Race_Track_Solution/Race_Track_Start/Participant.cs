using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    public class Participant : IComparable<Participant>
    {
        #region This code is implemented for you

        public Color Color { get; set; }
        public string Name { get; set; }
        public string Hobby { get; set; }
        public int Age { get; set; }
        public int Speed { get; set; }
        public float X { get; set; }
        private bool isFinished = false;

        public bool IsFinished
        { get { return this.isFinished; } }
        public Participant(string name, int age, string hobby, Color color)
        {
            Name = name;
            Age = age;
            Hobby = hobby;
            Color = color;
        }

        public void ChangeSpeed(int speed)
        {
            Speed = speed;
        }

        public void Reset()
        {
            X = 0;
            isFinished = false;
        }

        public override string ToString()
        {
            return Name + " is " + Age + " years old, and likes " + Hobby;
        }

        #endregion
        /// <summary>
        /// This method should increment the X value by Speed, 
        /// if X >= finishLocation then isFinished should become true.
        /// </summary>
        /// <param name="finishLocation">The distance from the start on which the finish-line is located.</param>
        public void Update(int finishLocation)
        {
            if (!this.isFinished)
            {
                this.X += this.Speed;
                if (this.X>finishLocation )
                {
                    this.isFinished = true;
                    if (raceFinished != null)
                    { raceFinished(this); }
                }
            }
            else
            {
                //nothing changed
            }         
        }

        public delegate void raceFinishedHandler(Participant p);
        public event raceFinishedHandler raceFinished;
        
        public int CompareTo(Participant other)
        {
            return this.Name.CompareTo(other.Name);
        }

        

    }
}