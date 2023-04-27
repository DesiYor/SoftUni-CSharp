/*
 ⦁	Подготовка за изпит
Напишете програма, в която Марин решава задачи от изпити докато не получи съобщение "Enough" от лектора си. 
При всяка решена задача той получава оценка.
Програмата трябва да приключи прочитането на данни при команда "Enough" или ако Марин получи определения брой незадоволителни оценки.
Незадоволителна е всяка оценка, която е по-малка или равна на 4.
Вход
⦁	На първи ред - брой незадоволителни оценки - цяло число в интервала [1…5]
⦁	След това многократно се четат по два реда:
⦁	Име на задача - текст (низ)
⦁	Оценка - цяло число в интервала [2…6]
Изход
⦁	Ако Марин стигне до командата "Enough", отпечатайте на 3 реда: 
⦁	"Average score: {средна оценка}"
⦁	"Number of problems: {броя на всички задачи}"
⦁	"Last problem: {името на последната задача}"
⦁	Ако получи определеният брой незадоволителни оценки:
⦁	"You need a break, {брой незадоволителни оценки} poor grades."
Средната оценка да бъде форматирана до втория знак след десетичната запетая. 
 */

using System;


namespace _82.Exam_Preparation
{
    internal class ExamPreparation
    {
        static void Main(string[] args)
        {
            int fail = int.Parse(Console.ReadLine());
            string nameExam = null;
            double scoreTotal = 0;
            int failCounter = 0;
            string lastNameExam = null;
            int examCounter = 0;
            while(true)
            {
                nameExam = Console.ReadLine();
                if(nameExam == "Enough") { break; }
                lastNameExam = nameExam;
                double score = double.Parse(Console.ReadLine());
                if (score <= 4) { failCounter++; } 
                if (failCounter == fail) { Console.WriteLine($"You need a break, {failCounter} poor grades."); break; } 
                scoreTotal += score; examCounter++; 
                
            }
            if (failCounter != fail)
            {
                Console.WriteLine($"Average score: {scoreTotal / examCounter:f2}");
                Console.WriteLine($"Number of problems: {examCounter}");
                Console.WriteLine($"Last problem: {lastNameExam}");
            }
        }
    }
}
