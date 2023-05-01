/*
 Задача 1. Приход от филм
Наети сте от "SoftUni Studios" да напишете програма която пресмята потенциалната печалба от продажбата на билети за филм.
Прожекцията на филма трае предварително зададен брой дни, като всеки ден се продават определен брой билети.
Цената на 1 билет се определя от студиото. За излъчване на продукцията, определен процент от общия приход остава за киното.  
Вход
От конзолата се четат 5 реда:
Име на филм - текст
Брой дни - цяло число в диапазона [1… 90]
Брой билети  - цяло число в диапазона [100… 100000]
Цена на билет - реално число в диапазона [5.0… 25.0]
Процент за киното - цяло число в диапазона [5... 35]
Изход 
Да се отпечата на конзолата прихода от продажбите, в следния формат:
"The profit from the movie {име на филм} is {приход на студиото} lv."
Цената на прихода да бъде форматирана до втората цифра след десетичния знак.
 
 */

using System;


namespace _01.Movie_Profit
{
    internal class MovieProfit
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double tickedPrice = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;
            double total = days * tickets * tickedPrice * (1 - percent);
            Console.WriteLine($"The profit from the movie {filmName} is {total:f2} lv.");
        }
    }
}
