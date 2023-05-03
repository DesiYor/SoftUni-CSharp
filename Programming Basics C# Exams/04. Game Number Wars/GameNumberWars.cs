using System;


namespace _04.Game_Number_Wars
{
    internal class GameNumberWars
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            int counter1 = 0 , counter2 = 0 ;
            bool numberWar = false ;
            while (true)
            {
                string card1 = Console.ReadLine();
                
                if (card1 == "End of game") {
                    Console.WriteLine($"{name1} has {counter1} points");
                    Console.WriteLine($"{name2} has {counter2} points");
                    break; }
                string card2 = Console.ReadLine();
                int card11 = int.Parse(card1);
                int card22 = int.Parse(card2);
                if(card11 > card22 && !numberWar) { counter1 += card11 - card22; }
                if(card11 < card22 && !numberWar) {  counter2 += card22 - card11; }
                if(card22 == card11 && !numberWar) { Console.WriteLine($"Number wars!"); numberWar = true; }
                if(numberWar) { 
                    if( card11 < card22 ) { Console.WriteLine($"{name2} is winner with {counter2} points"); break; }
                    if( card11 > card22 ) { Console.WriteLine($"{name1} is winner with {counter1} points"); break; }
                }
            }
        }
    }
}
