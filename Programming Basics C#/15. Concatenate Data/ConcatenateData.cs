/*
 ⦁	Съединяване на текст и числа
Напишете програма, която прочита от конзолата име, фамилия, възраст и град и печата следното съобщение:
"You are <firstName> <lastName>, a <age>-years old person from <town>."

 */


using System;


namespace _15.Concatenate_Data
{
    internal class ConcatenateData
    {
        static void Main(string[] args)
        {
            string fistName = Console.ReadLine();
            string lastName = Console.ReadLine();   
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {fistName} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
