/*
 ⦁	Торта
Поканени сте на 30-ти рожден ден, на който рожденикът черпи с огромна торта. Той обаче не знае колко парчета могат да си вземат гостите от нея.
Вашата задача е да напишете програма, която изчислява броя на парчетата, които гостите са взели, преди тя да свърши.
Ще получите размерите на тортата (широчина и дължина – цели числа в интервала [1...1000]) и след това на всеки ред,
до получаване на командата "STOP" или докато не свърши тортата, броят на парчетата, които гостите вземат от нея. 
Бележка: Едно парче торта е с размер 1х1 см.
Да се отпечата на конзолата един от следните редове:
⦁	"{брой парчета} pieces are left." - ако стигнете до STOP и не са свършили парчетата торта
⦁	"No more cake left! You need {брой недостигащи парчета} pieces more."

 
 */


using System;


namespace _86.Cake
{
    internal class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            bool loop = true;
            int pieces = width * height;
            while (loop)
            {
                string take = Console.ReadLine();
                switch (take)
                {
                    case "STOP": loop = false; Console.WriteLine($"{pieces} pieces are left."); break;
                    default:
                        if (pieces - int.Parse(take) > 0) { pieces -= int.Parse(take); }
                        else { Console.WriteLine($"No more cake left! You need {Math.Abs(pieces - int.Parse(take))} pieces more."); loop = false; }
                        break;
                }
            }
        }
    }
}
