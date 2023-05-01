using System;

namespace _04.Cinema
{
    internal class Cinema
    {
        static void Main(string[] args)
        {
            int places = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int profit = 0;
            bool stop = true;
            while (command != "Movie time!")
            {
                int people = int.Parse(command);
                places -= people;
                if (places < 0) { Console.WriteLine("The cinema is full."); stop = false; break; }
                if (people % 3 == 0) { profit += people * 5 - 5; }
                else { profit += people * 5; }
                command = Console.ReadLine();
            }
            if(stop) { Console.WriteLine($"There are {places} seats left in the cinema."); }
            Console.WriteLine($"Cinema income - {profit} lv.");
            Console.ReadLine();
        }
    }
}
