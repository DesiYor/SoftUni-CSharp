/*
 ⦁	Билет за кино
Да се напише програма която чете ден от седмицата (текст) – въведен от потребителя и принтира на конзолата цената на билет
за кино според деня от седмицата:
Monday	Tuesday	Wednesday	Thursday	Friday	Saturday	Sunday
12	    12	    14	        14	        12	       16	      16

 */

using System;


namespace _41.Cinema_Ticket
{
    internal class CinemaTicket
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                    Console.WriteLine(12);
                    break;
                case "Tuesday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                    Console.WriteLine(14);
                    break;
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Saturday":
                    Console.WriteLine(16);
                    break;
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
