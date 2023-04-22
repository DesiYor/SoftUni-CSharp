using System;


namespace _2.Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine(deg);
        }
    }
}
