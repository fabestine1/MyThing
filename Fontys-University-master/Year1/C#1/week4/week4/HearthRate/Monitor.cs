using System;

namespace HeartRate
{
     public class Monitor
    {
        private String _firstName;
        private String _lastName;
        private int _birthYear;
        private int _currentYear = DateTime.Now.Year;
        private int _age;
        private int _maxRate;
        private double _lowTarget, _upTarget;

        public Monitor()
        {

        }

        public Monitor(String firstName, String lastName, int birthYear)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthYear = birthYear;
        }

        
        public String FirstName
        {
            get
            {
                return this._firstName;
            }

            private set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("First Name can NOT be without character");
                }

                this._firstName = value;
            }
        }
        public String LastName
        {
            get
            {
                return this._lastName;
            }

            private set
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException("First Name can NOT be without character");
                }

                this._lastName = value;
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
                if(value > 2010)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    this._birthYear = value;
                }
            }
        }


        public void EvaluateCurrentRate(double temp = 0)
        {
            _age = _currentYear - BirthYear;
            _maxRate = 220 - _age;
            temp = _maxRate;
            _lowTarget = temp / 2;
            _upTarget = temp * 85 / 100;

            Console.WriteLine("Maximum Heart Rate is: {0}", _maxRate);
            Console.WriteLine("Limits are from {0} to {1}", _lowTarget.ToString("#.##"), _upTarget.ToString("#.##"));
        }
    }
}
