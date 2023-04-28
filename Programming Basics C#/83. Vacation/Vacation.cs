/*
 ⦁	Почивка
Джеси е решила да събира пари за екскурзия и иска от вас да ѝ помогнете да разбере дали ще успее да събере необходимата сума.
Тя спестява или харчи част от парите си всеки ден. Ако иска да похарчи повече от наличните си пари, то тя ще похарчи колкото има и ще ѝ останат 0 лева.
Вход
От конзолата се четат:
⦁	Пари нужни за екскурзията - реално число в интервала [1.00...25000.00]
⦁	Налични пари - реално число в интервала [0.00...25000.00]
След това многократно се четат по два реда:
⦁	Вид действие – текст с възможности "spend" и "save"
⦁	Сумата, която ще спести / похарчи - реално число в интервала [0.01… 25000.00]
Изход
Програмата трябва да приключи при следните случаи:
⦁	Ако 5 последователни дни Джеси само харчи, на конзолата да се изпише:
⦁	"You can't save the money."
⦁	"{Общ брой изминали дни}"
⦁	Ако Джеси събере парите за почивката на конзолата се изписва:
⦁	"You saved the money for {общ брой изминали дни} days."

 */


using System;


namespace _83.Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            double totalMoney = double.Parse(Console.ReadLine());
            int counterSpend = 0;
            int counterTrend = 0;
            while (true)
            {
                string action = Console.ReadLine();
                double spendSave = double.Parse(Console.ReadLine());
                switch (action)
                {
                    case "spend": totalMoney -= spendSave; counterSpend++; break;
                    case "save": totalMoney += spendSave; counterSpend = 0; break;
                    default: break;
                }
                counterTrend++;
                if(totalMoney < 0) { totalMoney = 0; }
                if(totalMoney >= holidayPrice) { Console.WriteLine($"You saved the money for {counterTrend} days."); break; }
                if(counterSpend >= 5 ) { Console.WriteLine($"You can't save the money."); Console.WriteLine($"{counterTrend}"); break; }
            }
            Console.ReadLine();
        }
    }
}
