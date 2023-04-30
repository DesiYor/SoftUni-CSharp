/*
 ⦁	Еднакви суми на четни и нечетни позиции
Напишете програма, която чете от конзолата две шестцифрени цели числа в диапазона от 100000 до 300000.
Винаги първото въведено число ще бъде по малко от второто.
На конзолата да се отпечатат на 1 ред разделени с интервал всички числа, които се намират между двете,
прочетени от конзолата числа и отговарят на следното условие:
⦁	сумата от цифрите на четни и нечетни позиции да са равни. Ако няма числа, отговарящи на условието на конзолата не се извежда резултат.
 */
// Решение 1 с масиви 
/*for (int i = min; i <= max; i++)
{
    string digits = i.ToString();
    even = 0;
    odd = 0;
    for( int d = 0; d < digits.Length; d++)
    {
        int digit = int.Parse(digits[d].ToString());
        if (d % 2 == 0) { odd += digit;  } //Нечетни
        else { even += digit; }
    }
    if(even == odd) { Console.Write(i + " "); }
}
*/

using System;


namespace _95.Equal_Sums_Even_Odd_Position
{
    internal class EqualSumsEvenOddPosition
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int count, even, odd;
            //Решения 2 с остатък
            
            for (int i = min; i <= max; i++)
            {
                count = 0;
                even = 0;
                odd = 0;
                for (int d = 10; d <= 1000000; d*=10)
                {
                    int digit;
                    if(d == 10) digit = i % d; 
                    else  digit = (i % d) / ( d / 10); 
                    if(count % 2 == 0)  even += digit; 
                    else  odd += digit; 
                    count++;
                }
                if (even == odd) { Console.Write(i + " "); }
            }
        }
    }
}
