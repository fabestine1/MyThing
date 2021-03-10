using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSearch
{
    class Person
    {
        private String _firstName;
        private String _lastName;
        private int _birthYear;
        private double _min = 10;
        private double _max = 0;
        private int br = 0;

        public Person()
        {

        }

        public double Sum { get; private set; }

        public double Score { get; private set; }

        public double Min
        {
            get
            {
                return this._min;
            }
                 
            private set
            {
                this._min = value; 
            }
        }

        public double Max
        {
            get
            {
                return this._max;
            }

            private set
            {
                this._max = value;
            }
        }

        public String FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if(value == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this._firstName = value;
                }
            }
        }
        public String LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    this._lastName = value;
                }
            }
        }
        public int BirthYear
        {
            get
            {
                return this._birthYear;
            }
            set
            {
                if(value < 1900 || value > 2017)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this._birthYear = value;
                }
            }
        }

        public void AddJudge(double score)
        {
            if(score <= Min)
            {
                Min = score;
            }

            if(score >= Max)
            {
                Max = score;
            }

            Sum += score;

            br++;

            Score = (Sum - Min - Max) / (br - 2);
        }
    }
}
