/*
 ⦁	Конвертор: инчове към сантиметри
Да се напише програма, която чете от конзолата реално число и го преобразува от инчове в сантиметри.
За целта умножете инчовете по 2.54 (1 инч = 2.54 сантиметра).

 */

using System;


namespace _13.Inches_to_Centimeters
{
    internal class InchesТoCentimeters
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine()) * 2.54;
            Console.WriteLine(result);  
        }
    }
}
