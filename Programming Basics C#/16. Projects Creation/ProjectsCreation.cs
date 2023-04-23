/*
 ⦁	Изготвяне на проекти
Напишете програма, която изчислява колко часа ще са необходими на един архитект, за да изготви проектите на
няколко строителни обекта. Изготвянето на един проект отнема три часа.
Вход
От конзолата се четат 2 реда:
⦁	Името на архитекта - текст
⦁	Брой на проектите, които трябва да изготви - цяло число в интервала [0 … 100]
Изход
На конзолата се отпечатва:
⦁	"The architect {името на архитекта} will need {необходими часове} hours to complete {брой на проектите} project/s."

 */


using System;


namespace _16.Projects_Creation
{
    internal class ProjectsCreation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {a * 3} hours to complete {a} project/s.");

        }
    }
}
