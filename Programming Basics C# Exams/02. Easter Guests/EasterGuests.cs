using System;


namespace _02.Easter_Guests
{
    internal class EasterGuests
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double bread = Math.Ceiling((double)people / 3);
            int eggs = people * 2;
            double total = bread * 4 + eggs * 0.45;
            if (total <= budget) {
                Console.WriteLine($"Lyubo bought {bread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget - total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total - budget:f2} lv. more.");
            }
        }
    }
}
