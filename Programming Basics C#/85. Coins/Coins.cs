
/*
 ⦁	Монети
Производителите на вендинг машини искали да направят машините си да връщат възможно най-малко монети ресто.
Напишете програма, която приема сума - рестото, което трябва да се върне и изчислява с колко най-малко монети може да стане това.
 */

using System;


namespace _85.Coins
{
    internal class Coins
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int[] coins = new int[8];
            coins[0] = Convert.ToInt32(Math.Floor(money)) / 2; // монетите по 2 
            coins[1] = Convert.ToInt32(Math.Floor(money)) - (2 * coins[0]); // монети по 1
            coins[2] = Convert.ToInt32((money - Math.Floor(money)) * 100) / 50; // монети по 50
            coins[3] = (Convert.ToInt32((money - Math.Floor(money)) * 100) - (50 * coins[2])) / 20; // монети по 20
            coins[4] = (Convert.ToInt32((money - Math.Floor(money)) * 100) - (50 * coins[2]) - (20 * coins[3])) / 10; // монети по 10
            coins[5] = (Convert.ToInt32((money - Math.Floor(money)) * 100) - (50 * coins[2]) - (20 * coins[3]) - (10 * coins[4])) / 5; //монети по 5
            coins[6] = (Convert.ToInt32((money - Math.Floor(money)) * 100) - (50 * coins[2]) - (20 * coins[3]) - (10 * coins[4]) - (5 * coins[5])) / 2; // монети по 2
            coins[7] = Convert.ToInt32((money - Math.Floor(money)) * 100) - (50 * coins[2]) - (20 * coins[3]) - (10 * coins[4]) - (5 * coins[5]) - (2 * coins[6]); // монети по 1
            int count = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > 0) { count += coins[i]; }
            }

            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
