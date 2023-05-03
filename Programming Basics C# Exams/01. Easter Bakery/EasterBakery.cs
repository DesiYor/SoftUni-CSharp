using System;

namespace _01.Easter_Bakery
{
    internal class EasterBakery
    {
        static void Main(string[] args)
        {
            double priceFlour = double.Parse(Console.ReadLine());
            double flour = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double totalF = priceFlour * flour;
            double totalS = (priceFlour * (1 - 0.25)) * sugar;
            double totalE = (priceFlour * (1 + 0.10)) * eggs;
            double totalM = ((priceFlour * (1 - 0.25)) * (1 - 0.80)) * m;

            Console.WriteLine($"{totalE + totalF + totalM + totalS:f2}");
        }
    }
}
