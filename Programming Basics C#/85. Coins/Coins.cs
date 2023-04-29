
/*
 ⦁	Монети
Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто.
Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
 */

using System;
using System.Diagnostics;

namespace _85.Coins
{
    internal class Coins
    {
        static void Main(string[] args)
        {

            int allCoins = Convert.ToInt32(double.Parse(Console.ReadLine()) * 100);
            int backup = allCoins; // да държи пърмоначалния вход не променен

            //Решение 1 - не добро спрямо заделено място в рам 
            int[] c = new int[8]; // 8 вида монети
            c[0] = allCoins / 200; // монети по 2
            c[1] = (allCoins - (200 * c[0])) / 100; //монети по 1
            c[2] = (allCoins - (200 * c[0]) - (100 * c[1])) / 50 ; // монети по 50
            c[3] = (allCoins - (200 * c[0]) - (100 * c[1]) - (50 * c[2])) / 20; //монети по 20
            c[4] = (allCoins - (200 * c[0]) - (100 * c[1]) - (50 * c[2]) - (20 * c[3])) / 10; //монети по 10
            c[5] = (allCoins - (200 * c[0]) - (100 * c[1]) - (50 * c[2]) - (20 * c[3]) - (10 * c[4])) / 5; //монети по 5
            c[6] = (allCoins - (200 * c[0]) - (100 * c[1]) - (50 * c[2]) - (20 * c[3]) - (10 * c[4]) - (5 * c[5])) / 2; // монети по 2
            c[7] = (allCoins - 200 * c[0]) - (100 * c[1]) - (50 * c[2]) - (20 * c[3]) - (10 * c[4]) - (5 * c[5]) - (2 * c[6]); // монети по 1
            int count = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] > 0) { count += c[i]; }
            }

            Console.WriteLine($"A1: {count} no loop");
            
            //Решение 2 -- най-добро решения спрямо призводителност за момента 

            int counts = 0;
            if (allCoins >= 200) { counts += allCoins / 200; allCoins = allCoins % 200; } // монети по 2лв 
            if (allCoins >= 100) { counts += allCoins / 100; allCoins = allCoins % 100; }
            if (allCoins >= 50) { counts += allCoins / 50; allCoins = allCoins % 50; }
            if (allCoins >= 20) { counts += allCoins / 20; allCoins = allCoins % 20; }
            if (allCoins >= 10) { counts += allCoins / 10; allCoins = allCoins % 10; }
            if (allCoins >= 5) { counts += allCoins / 5; allCoins = allCoins % 5; }
            if (allCoins >= 2) { counts += allCoins / 2; allCoins = allCoins % 2; }
            if (allCoins >= 0) { counts += allCoins; }

            Console.WriteLine($"A2: {counts} no loop");

            // Решение 3 използвайки loop - не удачно спрямо производителснот 

            allCoins = backup;

            int counts2 = 0;
            int loopCount = 0;
            while (allCoins != 0) 
            { 
                if(allCoins - 200 >= 0) { allCoins -= 200; counts2++; }  
                else if (allCoins - 100 >= 0) { allCoins -= 100; counts2++; }
                else if (allCoins - 50 >= 0) { allCoins -= 50; counts2++; }
                else if (allCoins - 20 >= 0) { allCoins -= 20; counts2++; }
                else if (allCoins - 10 >= 0) { allCoins -= 10; counts2++; }
                else if (allCoins - 5 >= 0) { allCoins -= 5; counts2++; }
                else if (allCoins - 2 >= 0) { allCoins -= 2; counts2++; }
                else if (allCoins - 1 >= 0) { allCoins -= 1; counts2++; }
                loopCount++;
            }

            Console.WriteLine($"A3: {counts2} with {loopCount} loops");
            Console.ReadLine();
        }
    }
}
