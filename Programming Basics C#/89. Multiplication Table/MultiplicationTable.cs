/*
 
 ⦁	Таблица за умножение
Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
"{първи множител} * {втори множител} = {резултат}". 
 */


using System;


namespace _89.Multiplication_Table
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 11; i++)
            {
                for(int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
        }
    }
}
