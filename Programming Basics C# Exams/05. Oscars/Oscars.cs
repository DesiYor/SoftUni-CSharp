using System;


namespace _05.Oscars
{
    internal class Oscars
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int focusGroup = int.Parse(Console.ReadLine());
            for(int i = 0; i < focusGroup; i++)
            {
                string nameFgroup = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                startPoints += (nameFgroup.Length * points / 2);
                if (startPoints >= 1250.5) break;
            }
            if(startPoints >= 1250.5) { Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startPoints:f1}!"); }
            else { Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startPoints:f1} more!"); }
            Console.ReadLine();
        }
    }
}
