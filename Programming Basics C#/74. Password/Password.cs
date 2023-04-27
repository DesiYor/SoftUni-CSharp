/*
 ⦁	Парола
Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете парола за вход.
⦁	при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
⦁	при въвеждане на правилна парола: отпечатваме "Welcome {username}!".

 */

using System;


namespace _74.Password
{
    internal class Password
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            while (true)
            {
                string pass = Console.ReadLine();
                if(pass == password) { Console.WriteLine($"Welcome {user}!"); break; }
            }
        }
    }
}
