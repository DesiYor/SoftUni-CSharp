/*
 ⦁	Билети за кино
Вашата задача е да напишете програма, която да изчислява процента на билетите за всеки тип от продадените билети: 
студентски(student), стандартен(standard) и детски(kid), за всички прожекции.
Трябва да изчислите и колко процента от залата е запълнена за всяка една прожекция.
Вход
Входът е поредица от цели числа и текст:
⦁	На първия ред до получаване на командата "Finish" - име на филма – текст
⦁	На втори ред – свободните места в салона за всяка прожекция – цяло число [1 … 100]
⦁	За всеки филм, се чете по един ред до изчерпване на свободните места в залата или до получаване на командата "End":
⦁	Типа на закупения билет - текст ("student", "standard", "kid")
Изход
На конзолата трябва да се печатат следните редове:
⦁	След всеки филм да се отпечата, колко процента от кино залата е пълна
"{името на филма} - {процент запълненост на залата}% full."
⦁	При получаване на командата "Finish" да се отпечатат четири реда:
⦁	"Total tickets: {общият брой закупени билети за всички филми}"
⦁	"{процент на студентските билети}% student tickets."
⦁	"{процент на стандартните билети}% standard tickets."
⦁	"{процент на детските билети}% kids tickets."

 
 */


using System;


namespace _99.Cinema_Tickets
{
    internal class CinemaTickets
    {
        static void Main(string[] args)
        {
            int student = 0, standard = 0, kid = 0;
            bool endAll = false;
            while (!endAll)
            {
                string filmName = Console.ReadLine();
                if (filmName == "Finish") { endAll = true; }
                else
                {
                    int places = int.Parse(Console.ReadLine());
                    int counter = 0;
                    for (int i = 1; i <= places; i++)
                    {
                        string ticked = Console.ReadLine();
                        switch (ticked)
                        {
                            case "student": student++; counter++; break;
                            case "standard": standard++; counter++; break;
                            case "kid": kid++; counter++; break;
                            case "End": i = places + 1; break;
                            default: endAll = true; break;
                        }
                    }
                    if (!endAll) { Console.WriteLine($"{filmName} - {(double)(counter) / places * 100:f2}% full."); }
                }
            }
            Console.WriteLine($"Total tickets: {standard+student+kid}");
            Console.WriteLine($"{(double)student / (student+standard+kid) * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standard / (student + standard + kid) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kid / (student + standard + kid) * 100:f2}% kids tickets.");
        }
    }
}
