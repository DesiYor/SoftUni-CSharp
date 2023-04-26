/*
 ⦁	Навреме за изпит
Студент трябва да отиде на изпит в определен час (например в 9:30 часа). Той идва в изпитната зала в даден час на пристигане (например 9:40).
Счита се, че студентът е дошъл навреме, ако е пристигнал в часа на изпита или до половин час преди това.
Ако е пристигнал по-рано повече от 30 минути, той е подранил. Ако е дошъл след часа на изпита, той е закъснял.
Напишете програма, която прочита време на изпит и време на пристигане и отпечатва дали студентът е дошъл навреме, дали е подранил или е закъснял 
и с колко часа или минути е подранил или закъснял.
Вход
От конзолата се четат 4 цели числа (по едно на ред), въведени от потребителя:
⦁	Първият ред съдържа час на изпита – цяло число от 0 до 23.
⦁	Вторият ред съдържа минута на изпита – цяло число от 0 до 59.
⦁	Третият ред съдържа час на пристигане – цяло число от 0 до 23.
⦁	Четвъртият ред съдържа минута на пристигане – цяло число от 0 до 59.
Изход
На първият ред отпечатайте:
⦁	“Late”, ако студентът пристига по-късно от часа на изпита.
⦁	“On time”, ако студентът пристига точно в часа на изпита или до 30 минути по-рано.
⦁	“Early”, ако студентът пристига повече от 30 минути преди часа на изпита.
Ако студентът пристига с поне минута разлика от часа на изпита, отпечатайте на следващия ред:
⦁	
“mm minutes after the start” за закъснение под час.
⦁	“hh:mm hours after the start” за закъснение от 1 час или повече. Минутите винаги печатайте с 2 цифри, например “1:03”.

 */


using System;


namespace _53.On_Time_for_the_Exam
{
    internal class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int exHour = int.Parse(Console.ReadLine());
            int exMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            int totalMinExam = exHour * 60 + exMin;
            int totalMinArr = arrHour * 60 + arrMin;
            int diff = Math.Abs(totalMinExam - totalMinArr);
            int diffHours = diff / 60;
            int diffMin = diff % 60;

            if (totalMinArr > totalMinExam ) {
                Console.WriteLine("Late");
                if (diff < 60) { Console.WriteLine($"{diff} minutes after the start"); }
                    else { Console.WriteLine($"{diffHours}:{diffMin:00} hours after the start"); }
            }
            if (totalMinArr == totalMinExam ) {
                Console.WriteLine("On time");
            }
            if (totalMinExam > totalMinArr)
            {
                if(diff <= 30) { Console.WriteLine($"On Time"); Console.WriteLine($"{diffMin} minutes before the start"); }
                    else if (diff < 60 )  { Console.WriteLine("Early"); Console.WriteLine($"{diffMin} minutes before the start"); }
                else { Console.WriteLine($"Early"); Console.WriteLine($"{diffHours}:{diffMin:00} hours before the start"); }
            }
        }
    }
}
