using System;


namespace _06.Favorite_Movie
{
    internal class FavoriteMovie
    {
        static void Main(string[] args)
        {
            string film = "", hold = "";
            int counter = 0, sum = 0, maxSum = 0;
            while (true)
            {
                if(counter >= 7) { Console.WriteLine("The limit is reached."); break; }
                else counter++;
                film = Console.ReadLine();
                if(film == "STOP") { break; }
                for(int i = 0; i < film.Length; i++)
                {
                    if (film[i] >= 65 && film[i] <= 90) { sum += Convert.ToInt32(film[i]) - film.Length; }
                    else if (film[i] >= 97 && film[i] <= 122) { sum += Convert.ToInt32(film[i]) - film.Length * 2;  }
                    else { sum += Convert.ToInt32(film[i]); }
                }
                if (maxSum <= sum) { maxSum = sum; hold = film; }
                sum = 0;
            }
            Console.WriteLine($"The best movie for you is {hold} with {maxSum} ASCII sum.");
        }
    }
}
