/*
 ⦁	Работно време
Да се напише програма, която чете час от денонощието(цяло число) и ден от седмицата(текст) - въведени от потребителя
и проверява дали офисът на фирма е отворен, като работното време на офисът е от 10-18 часа, 
от понеделник до събота включително

 */

using System;


namespace _40.Working_Hours
{
    internal class WorkingHours
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (h >= 10 && h <= 18)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("open");
                        break;
                    case "Tuesday":
                        Console.WriteLine("open");
                        break;
                    case "Wensday":
                        Console.WriteLine("open");
                        break;
                    case "Thursday":
                        Console.WriteLine("open");
                        break;
                    case "Friday":
                        Console.WriteLine("open");
                        break;
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;
                    default: Console.WriteLine("closed");
                        break;
                    }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
