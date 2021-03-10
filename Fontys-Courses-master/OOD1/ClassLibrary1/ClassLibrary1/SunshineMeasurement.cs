using System;

namespace WeatherStuff
{
    public class SunshineMeasurement
    {
        private String cityname;  // The name of the city.

        private int[] sunshine;  // Amount of sunshine per day in the most recent days in this city (in minutes).
        private int n;           // The number of days the sunshine has been measured and stored in array "sunshine".

        private const int MaxSize = 10;  // Maximum number of measurements to be stored in "sunshine".

        /// <summary>
        /// Creates a new SunshineMeasurement-object with cityname nm and no measurements yet.
        /// </summary>
        /// <param name="name"></param>
        public SunshineMeasurement(String nm)
        {
            this.cityname = nm;
            this.sunshine = new int[MaxSize];
            this.n = 0;            
        }

        public String Cityname { get { return this.cityname; } }

        /// <summary>
        /// The name of the method is self-explanatory.
        /// </summary>
        /// <param name="minutesOfSunshine"></param>
        public void addSunshineOfLastDay(int minutesOfSunshine)
        {
            if (this.n < this.sunshine.Length)
            {
            	// The array is not completely filled: just add it.
                this.sunshine[this.n] = minutesOfSunshine;
                this.n++;
            }
            else
            {
            	// The array is completely filled: throw away the oldest measurement and add the new one.
                for (int i = 0; i < this.sunshine.Length - 1; i++)
                {
                    this.sunshine[i] = this.sunshine[i + 1];
                }
                this.sunshine[this.sunshine.Length - 1] = minutesOfSunshine;
            }
        }

        /// <summary>
        /// Returns the average amount of sunshine according to the measurements stored in the array.
        /// It throws an exception if there are no measurements.
        /// </summary>
        /// <returns></returns>
        public int getAverageSunshine()
        {
            int sum = 0;
            for (int i = 0; i < this.sunshine.Length; i++)
            {
                sum += this.sunshine[i];
            }

            return (sum / this.n);
        }

        /// <summary>
        /// Returns the maximum amount of sunshine registered in the array.
        /// It throws an exception if there are no measurements.
        /// </summary>
        /// <returns></returns>
        public int getMaximumSunshine()
        {
            // To do
            int max = 0;
            if(n == 0) throw new InvalidOperationException();
            for (int i = 0; i < this.sunshine.Length; i++)
            {
                if (this.sunshine[i] > max) max = this.sunshine[i];
            }
            return max;
        }
    }
}
