using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_4._7
{
    class HeartRate
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private int currentYear = DateTime.Now.Year;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public int CurrentYear
        {
            get { return currentYear; }
        }
        public int Age
        {
            get { return CurrentYear - BirthYear; }
        }
        public int MaxRate
        {
            get { return 220 - Age; }
        }
        public double LowTarget
        {
            get { return 0.5 * MaxRate; }
        }
        public double UpTarget
        {
            get { return 0.85 * MaxRate; }
        }
        public void EvaluateCurrentRate(int currentRate)
        {
            if (currentRate < LowTarget)
            {
                Console.WriteLine("Your heart rate is too low!");
            }
            else if (currentRate > UpTarget)
            {
                Console.WriteLine("Your heart rate is too high!");
            }
            else
            {
                Console.WriteLine("Your heart rate is within normal range!");
            }
        }
    }
}
