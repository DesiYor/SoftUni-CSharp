using System;

namespace _03.World_Snooker_Championship
{
    internal class WorldSnookerChampionship
    {
        static void Main(string[] args)
        {
            string etap = Console.ReadLine();
            string tickedType = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            string pic = Console.ReadLine();
            double price = 0;
            switch (etap)
            {
                case "Quarter final":
                    switch (tickedType)
                    {
                        case "Standard":
                            price = 55.50 * tickets; break;

                        case "Premium":
                            price = 105.20 * tickets; break;

                        case "VIP":
                            price = 118.90 * tickets; break;
                        default: break;
                    }
                    break;
                case "Semi final":
                    switch (tickedType)
                    {
                        case "Standard":
                            price = 75.88 * tickets; break;

                        case "Premium":
                            price = 125.22 * tickets; break;

                        case "VIP":
                            price = 300.40 * tickets; break;

                        default: break;
                    }
                    break;
                case "Final":
                    switch (tickedType)
                    {
                        case "Standard":
                            price = 110.10 * tickets; break;

                        case "Premium":
                            price = 160.66 * tickets; break;

                        case "VIP":
                            price = 400 * tickets; break;
                        default: break;
                    }
                    break;
                default: break;
            }
            double total = 0;
            if (price > 4000) { total = price * (1 - 0.25); }
            if (price > 2500 && price <= 4000 && pic == "Y") { total = price * (1 - 0.1) + (tickets * 40); }
            if (price > 2500 && price <= 4000 && pic == "N") { total = price * (1 - 0.1); }
            if (pic == "Y" && price <= 2500) { total = price + (40 * tickets); }
            if (pic == "N" && price <= 2500) { total = price; }
            Console.WriteLine($"{total:f2}");     
        }
    }
}
