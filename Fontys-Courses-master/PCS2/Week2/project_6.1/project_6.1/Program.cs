using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation reservation = new Reservation();
            int choice;
            char option = 'Y';
            Section section;
            Console.Write("Please type 1 for First Class and Please type 2 for Economy. ");
            choice = Convert.ToInt32(Console.ReadLine());
            section = (Section)choice - 1;
            while (option == 'Y' || option == 'y')
            {
                    if (!reservation.Assign(section))
                    {
                        if (section == 0)
                        {
                            section = (Section)1;
                        }
                        else
                    {
                        section = 0;
                    }
                        Console.Write("There are not seats left! Woud you like to be placed at {0}? [Y/y N/n]: ", section);
                    }
                    else
                    {
                        Console.Write("Reservation successful!\nDo you want to assign a new seat? [Y/y N/n]: ");
                    }
                    option = Convert.ToChar(Console.ReadLine());
                }
            if (option == 'N' || option == 'n')
            {
                Console.WriteLine("Next flight leaves in 3 hours.");
            }
            Console.ReadKey();
        }
    }
}

