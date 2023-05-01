

using System;


namespace _03.Film_Premiere
{
    internal class FilmPremiere
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string menu = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double bill = 0;
            switch(film)
            {
                case "John Wick": 
                    switch(menu)
                    {
                        case "Drink": bill = tickets * 12.00;  break;
                        case "Popcorn": bill = tickets * 15.00; break;
                        case "Menu": bill = tickets * 19.00; break;
                        default: break;
                    }
                    break;
                case "Star Wars":
                    switch (menu)
                    {
                        case "Drink": bill = tickets * 18.00; if (tickets >= 4) { bill = bill * (1 - 0.30); } break;
                        case "Popcorn": bill = tickets * 25.00; if (tickets >= 4) { bill = bill * (1 - 0.30); } break;
                        case "Menu": bill = tickets * 30.00; if (tickets >= 4) { bill = bill * (1 - 0.30); } break;
                        default: break;
                    }
                    break;
                case "Jumanji":
                    switch (menu)
                    {
                        case "Drink": bill = tickets * 9.00; if (tickets == 2) { bill = bill * (1 - 0.15); } break;
                        case "Popcorn": bill = tickets * 11.00; if (tickets == 2) { bill = bill * (1 - 0.15); } break;
                        case "Menu": bill = tickets * 14.00; if (tickets == 2) { bill = bill * (1 - 0.15); } break;
                        default: break;
                    }
                    break;
                default: break;
            }
            Console.WriteLine($"Your bill is {bill:f2} leva.");

        }
    }
}
