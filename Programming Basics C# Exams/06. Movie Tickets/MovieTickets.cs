using System;


namespace _06.Movie_Tickets
{
    internal class MovieTickets
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (char i = (char)a1; i < (char)a2; i++)
            {
                for(int j = 1; j < n; j++)
                {
                    for(int k = 1; k < n / 2; k++)
                    {
                        if (i % 2 > 0 && (j + k + i) % 2 > 0) { Console.WriteLine($"{i}-{j}{k}{(int)i}"); }
                    }
                }
                
            }
        }
    }
}
