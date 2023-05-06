using System;
using System.Configuration;

namespace Learning_c__Challenges
{
    internal class GuessTheNumber
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(20), count = 0;
            Console.WriteLine("Guess the number!");
            Console.WriteLine("I am thinking of a number between 0 and 20!");
            Console.WriteLine("Try to guess the number or enter -1 to give up!");
            while (true) 
            {
                try
                {
                    int guess = int.Parse(Console.ReadLine());
                    count++;
                    if (guess == number)
                    {
                        Console.WriteLine($"Congrats! You guessed the number {number} on your {count} try!"); break;
                    }
                    else if (guess == -1) { Console.WriteLine($"You give up!"); break; }
                    else { Console.WriteLine($"Wrong! Try Count: {count}"); }
                }
                catch 
                {
                    Console.WriteLine("You must enter number between 0 and 20! Program do not accept strings as input! Try again!");
                    continue;
                }
            } 



        }
    }
}
