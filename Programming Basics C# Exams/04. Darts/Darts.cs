using System;


namespace _04.Darts
{
    internal class Darts
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();  
            int countA = 0;
            int countB = 0;
            int startPoints = 301;
            while (true)
            {
                string place = Console.ReadLine();
                if (place == "Retire") break;
                int points = int.Parse(Console.ReadLine());
                switch(place)
                {
                    case "Single": if (startPoints - points >= 0) { startPoints -= points; countA++; } else { countB++; } break;
                    case "Double": if (startPoints - points * 2 >= 0) { startPoints -= points * 2;  countA++; } else { countB++; } break;
                    case "Triple": if (startPoints - points * 3 >= 0) { startPoints -= points * 3; countA++; } else { countB++; } break;
                    default: break;
                }
                if(startPoints == 0) break;  
            }
            if(startPoints == 0) { Console.WriteLine($"{name} won the leg with {countA} shots."); }
            else { Console.WriteLine($"{name} retired after {countB} unsuccessful shots."); }
            
        }
    }
}
