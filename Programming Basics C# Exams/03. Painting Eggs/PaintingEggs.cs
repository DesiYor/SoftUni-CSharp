using System;


namespace _03.Painting_Eggs
{
    internal class PaintingEggs
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string colour = Console.ReadLine();
            int pcs = int.Parse(Console.ReadLine()), total = 0;
            switch (colour)
            {
                case "Red":
                    switch(size)
                    {
                        case "Large": total += pcs * 16; break;
                        case "Medium": total += pcs * 13; break;
                        case "Small": total += pcs * 9; break;
                        default: break;
                    }
                    break;
                case "Green":
                    switch (size)
                    {
                        case "Large": total += pcs * 12; break;
                        case "Medium": total += pcs * 9; break;
                        case "Small": total += pcs * 8; break;
                        default: break;
                    }
                    break;
                case "Yellow":
                    switch (size)
                    {
                        case "Large": total += pcs * 9; break;
                        case "Medium": total += pcs * 7; break;
                        case "Small": total += pcs * 5; break;
                        default: break;
                    }
                    break;
                default: break;
            }
            Console.WriteLine($"{(double)total * (1 - 0.35):f2} leva.");
        }
    }
}
