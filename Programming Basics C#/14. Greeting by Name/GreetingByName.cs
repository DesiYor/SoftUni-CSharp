/*
 ⦁	Поздрав по име
Да се напише програма, която чете от конзолата текст (име на човек) и отпечатва "Hello, <name>!",
където <name> е въведеното име от конзолата.
Насоки
⦁	Създайте променливата name от тип string и запазете в нея името, което получавате от конзолата.

 */

using System;


namespace _14.Greeting_by_Name
{
    internal class GreetingByName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
