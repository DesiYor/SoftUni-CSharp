using System;


namespace TestCode
{
    internal class TestCode
    {
        static void Main(string[] args)
        {

            int penPacetsQuantity = int.Parse(Console.ReadLine()); // Вход 1 химикали
            int markersPacetsQuantity = int.Parse(Console.ReadLine()); // вход 2 маркери
            int litersPreparationsQuantity = int.Parse(Console.ReadLine()); // вход 3 препарат

            //липсва ти това жход за процент 
            int percent = int.Parse(Console.ReadLine()); //вход 4 процент 

            double penPrice = penPacetsQuantity * 5.8;
            double markersPrice = markersPacetsQuantity * 7.20;
            double litersPrice = litersPreparationsQuantity * 1.20;



            double totalPrice = penPrice + markersPrice + litersPrice;
            //double percentReduction = totalPrice * 0.01;
            double reductionPrice = totalPrice * percent / 100; //
            //double percentreduction = totalPrice - (totalPrice * 0.01); излишно

            Console.WriteLine(totalPrice - reductionPrice);
        }
    }
}
