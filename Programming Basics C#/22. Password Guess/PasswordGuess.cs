/*
 ⦁	Познай паролата
Да се напише програма, която чете парола (текст), въведена от потребителя и проверява дали
въведената парола съвпада с фразата "s3cr3t!P@ssw0rd". При съвпадение да се изведе "Welcome".
При несъвпадение да се изведе "Wrong password!". 

 */

using System;


namespace _22.Password_Guess
{
    internal class PasswordGuess
    {
        static void Main(string[] args)
        {
            string p = Console.ReadLine();
            if (p == "s3cr3t!P@ssw0rd" && p != null ) { Console.WriteLine("Welcome"); }
                else { Console.WriteLine("Wrong password!"); }
        }
    }
}
