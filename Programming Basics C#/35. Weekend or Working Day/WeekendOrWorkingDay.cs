/*
 ⦁	Почивен или работен ден
Напишете програма която, чете ден от седмицата (текст), на английски език - въведен от потребителя.
Ако денят е работен отпечатва на конзолата - "Working day", ако е почивен - "Weekend".
Ако се въведе текст различен от ден от седмицата да се отпечата - "Error".
 */

using System;


namespace _35.Weekend_or_Working_Day
{
    internal class WeekendOrWorkingDay
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Monday": Console.WriteLine("Working day"); break;
                case "Tuesday": Console.WriteLine("Working day"); break;
                case "Wednesday": Console.WriteLine("Working day"); break;
                case "Thursday": Console.WriteLine("Working day"); break;
                case "Friday": Console.WriteLine("Working day"); break;
                case "Saturday": Console.WriteLine("Weekend"); break;
                case "Sunday": Console.WriteLine("Weekend"); break;
                    default: Console.WriteLine("Error"); break;
            }
        }
    }
}
