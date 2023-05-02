using System;


namespace _05.Fitness_Center
{
    internal class FitnessCenter
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            int countBAck = 0, countChest = 0, countLegs = 0, countAbs = 0, countPshake = 0, countPbar = 0;
            for(int i = 0; i < ppl; i++)
            {
                string activity = Console.ReadLine();
                switch(activity)
                {
                    case "Back": countBAck++; break;
                    case "Chest": countChest++; break;
                    case "Legs": countLegs++; break;
                    case "Abs": countAbs++; break;
                    case "Protein shake": countPshake++; break;
                    case "Protein bar": countPbar++; break;
                    default: break;
                }
            }
            Console.WriteLine($"{countBAck} - back");
            Console.WriteLine($"{countChest} - chest");
            Console.WriteLine($"{countLegs} - legs");
            Console.WriteLine($"{countAbs} - abs");
            Console.WriteLine($"{countPshake} - protein shake");
            Console.WriteLine($"{countPbar} - protein bar");
            Console.WriteLine($"{(double)(countBAck+countChest+countLegs+countAbs)/ ppl * 100:f2}% - work out");
            Console.WriteLine($"{(double)(countPshake+countPbar) / ppl * 100:f2}% - protein");
        }
    }
}
