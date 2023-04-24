/*
 ⦁	Клас животно
Напишете програма, която отпечатва класа на животното според неговото име, въведено от потребителя.
⦁	dog -> mammal
⦁	crocodile, tortoise, snake -> reptile
⦁	others -> unknown
 */

using System;


namespace _36.Animal_Type
{
    internal class AnimalType
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog": Console.WriteLine("mammal"); break;
                case "crocodile": case "tortoise": case "snake":  Console.WriteLine("reptile"); break;
                default: Console.WriteLine("unknown"); break;
            }

        }
    }
}
