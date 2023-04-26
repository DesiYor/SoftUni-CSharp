/*
 ⦁	Сумиране на гласните букви
Да се напише програма, която чете текст (стринг), въведен от потребителя, и изчислява и отпечатва сумата от стойностите на гласните букви
според таблицата по-долу:
буква	    a	e	i	o	u
стойност	1	2	3	4	5

 */

using System;


namespace _60.Vowels_Sum
{
    internal class VowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals('a')) { total++; }
                if (text[i] == 'e') { total += 2; }
                if (text[i] == 'i') { total += 3; }
                if (text[i] == 'o') { total += 4; }
                if (text[i] == 'u') { total += 5; }
            }
            Console.WriteLine(total);
        }
    }
}
