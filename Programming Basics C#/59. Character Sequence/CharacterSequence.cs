/*
 * ⦁	Поток от символи
Напишете програма, която чете текст (стринг), въведен от потребителя и печата всеки символ от текста на отделен ред.

 */

using System;


namespace _59.Character_Sequence
{
    internal class CharacterSequence
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for(int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
