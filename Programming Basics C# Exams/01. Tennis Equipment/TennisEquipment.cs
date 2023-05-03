using System;


namespace _01.Tennis_Equipment
{
    internal class TennisEquipment
    {
        static void Main(string[] args)
        {
            double priceR = double.Parse(Console.ReadLine());
            int tenisR = int.Parse(Console.ReadLine());
            int tenisSh = int.Parse(Console.ReadLine());

            double totalPriceR = tenisR * priceR;
            double totalPriceSh = priceR / 6 * tenisSh;
            double totalExtra = (totalPriceR + totalPriceSh) * 0.20;
            double totalPrice = totalPriceSh + totalExtra + totalPriceR;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(totalPrice/8)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPrice*7/8)}");
        }
    }
}
