using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_5._10a
{
    class Talent
    {
        private string firstName;
        private string lastName;
        private int birthYear;
        private double min;
        private double max;
        private double sum;
        private double count;
        private double score;

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
        public double Min
        {
            get { return min; }
        }
        public double Max
        {
            get { return max; }
        }
        public double Sum
        {
            get { return sum; }
        }
        public double Count
        {
            get { return count; }
        }
        public double Score
        {
            get { return (Sum - (Max + Min)) / (Count - 2); }
        }
        public void AddJudge(double score)
        {
            if (score > max)
            {
                max = score;
            }
            if (score < min || count == 0)
            {
                min = score;
            }

            sum += score;
            count += 1;
        }
    }
}
