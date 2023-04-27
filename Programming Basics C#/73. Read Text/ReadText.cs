/*
 ⦁	Четене на думи
Напишете програма, която чете текст от конзолата (стринг) и го принтира, докато не получи командата "Stop".
 */

using System;


namespace _73.Read_Text
{
    internal class ReadText
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "Stop") { break; }
                else { Console.WriteLine(text); }
            }
        }
    }
}
