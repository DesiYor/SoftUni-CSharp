using System;


namespace _01.Basketball_Equipment
{
    internal class BasketballEquipment
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double shoes = tax * (1 - 0.4);
            double equip = shoes * (1 - 0.2);
            double ball = equip / 4;
            double ecc = ball / 5;
            Console.WriteLine($"{shoes+equip+ball+ecc+tax:f2}");
        }
    }
}
