using Border_Control.Interfaces;
using System;
using System.Collections.Generic;

namespace Border_Control
{
    class Program
    {
        static void Main()
        {
            var fakeIdEnd = "";
            var robotsAndCitizens = new List<IRobot>();
            var birthdays = new List<IBirthday>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    fakeIdEnd = Console.ReadLine();
                    break;
                }
                else
                {
                    var inputArr = input.Split();
                    if (inputArr[0] == "Citizen")
                    {
                        var citizen = new Citizen(inputArr[1], int.Parse(inputArr[2]), inputArr[3], inputArr[4]);
                        robotsAndCitizens.Add(citizen);
                        birthdays.Add(citizen);
                    }
                    else if (inputArr[0] == "Pet")
                    {
                        var pet = new Pet(inputArr[1], inputArr[2]);

                        birthdays.Add(pet);

                    }
                    else
                    {
                        var robot = new Robot(inputArr[0], inputArr[1]);
                        robotsAndCitizens.Add(robot);
                    }
                }
            }

            //foreach (var rac in robotsAndCitizens)
            //{
            //    if (rac.CheckId(fakeIdEnd))
            //    {
            //        Console.WriteLine(rac.Id);
            //    }
            //}

            foreach (var b in birthdays)
            {
                if (b.CheckBirth(fakeIdEnd))
                {
                    Console.WriteLine(b.Birthdate);
                }
            }
        }
    }
}
