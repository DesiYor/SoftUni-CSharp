using System;


namespace _03.Gymnastics
{
    internal class Gymnastics
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string game = Console.ReadLine();
            double total = 0;
            switch (country) 
            {
                case "Russia":
                    switch (game)
                    {
                        case "ribbon": total += 9.100 + 9.400; break;
                        case "hoop": total += 9.300 + 9.800; break;
                        case "rope": total += 9.600 + 9.000; break;
                        default: break;
                    }
                    break;
                case "Bulgaria":
                    switch (game)
                    {
                        case "ribbon": total += 9.600 + 9.400; break;
                        case "hoop": total += 9.550 + 9.750; break;
                        case "rope": total += 9.500 + 9.400; break;
                        default: break;
                    }
                    break;
                case "Italy":
                    switch (game)
                    {
                        case "ribbon": total += 9.200 + 9.500; break;
                        case "hoop": total += 9.450 + 9.350; break;
                        case "rope": total += 9.700 + 9.150; break;
                        default: break;
                    }
                    break;
                default: break;
            }
            Console.WriteLine($"The team of {country} get {total:f3} on {game}.");
            Console.WriteLine($"{(20 - total) / 20 * 100:f2}%");
        }
    }
}
