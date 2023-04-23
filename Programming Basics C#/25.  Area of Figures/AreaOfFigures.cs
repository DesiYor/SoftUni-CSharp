/*
 ⦁	Лица на фигури
Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.
Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle).
На първия ред на входа се чете вида на фигурата (текст със следните възможности: square, rectangle, circle или triangle). 
⦁	Ако фигурата е квадрат (square): на следващия ред се чете едно дробно число - дължина на страната му
⦁	Ако фигурата е правоъгълник (rectangle): на следващите два реда четат две дробни числа - дължините на страните му
⦁	Ако фигурата е кръг (circle): на следващия ред чете едно дробно число - радиусът на кръга
⦁	Ако фигурата е триъгълник (triangle): на следващите два реда четат две дробни числа - дължината на страната му
и дължината на височината към нея
Резултатът да се закръгли до 3 цифри след десетичната запетая. 

 */

using System;


namespace _25.Area_of_Figures
{
    internal class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "square") {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * a, 3));
            }
            else if (input == "rectangle") {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b, 3));
            }
            else if (input == "circle") {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * Math.Pow(a, 2), 3));
            }
            else if (input == "triangle") {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * b, 3));
            }
        }
    }
}
