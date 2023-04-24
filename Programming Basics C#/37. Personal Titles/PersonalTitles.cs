/*
 ⦁	Обръщение според възраст и пол
Да се напише конзолна програма, която прочита възраст (реално число) и пол ('m' или 'f'), въведени от потребителя, 
и отпечатва обръщение измежду следните:
⦁	"Mr." – мъж (пол 'm') на 16 или повече години
⦁	"Master" – момче (пол 'm') под 16 години
⦁	"Ms." – жена (пол 'f') на 16 или повече години
⦁	"Miss" – момиче (пол 'f') под 16 години

 */

using System;


namespace _37.Personal_Titles
{
    internal class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            if ( age >= 16)
            {
                switch (sex)
                {
                    case 'm': Console.WriteLine("Mr."); break;
                    case 'f': Console.WriteLine("Ms."); break;
                }
            }
            else
            {
                switch (sex)
                {
                    case 'm': Console.WriteLine("Master"); break;
                    case 'f': Console.WriteLine("Miss"); break;
                }
            }
        }
    }
}
