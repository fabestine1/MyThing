using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seconds_to_HoursMinutesSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0, seconds, hours = 0, minutes;

            Console.Write("Enter how much secends it took you to finish: ");
            seconds = int.Parse(Console.ReadLine());



            minutes = seconds / 60;

            while(minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }

            while(hours >= 24)
            {
                hours -= 24;
                days++;
            }

            seconds %= 60;

            if (days > 0)
            {

                Console.WriteLine("{0} days and {1}:{2}:{3} hours", days, hours.ToString("00"),
                    minutes.ToString("00"), seconds.ToString("00"));

            }
                else
                {

                    Console.WriteLine("{0}:{1}:{2} hours", hours.ToString("00"),
                        minutes.ToString("00"), seconds.ToString("00"));

                }

            Console.WriteLine("Press any Key to Exit");
            Console.ReadKey();
        }
    }
}
