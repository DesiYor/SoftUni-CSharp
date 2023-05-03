using System;


namespace _06.High_Jump
{
    internal class HighJump
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int start = target - 30, counter = 0, fail = 0;
            int last = 0;
            while (true)
            {
                
                if (fail < 3)
                {
                    int jump = int.Parse(Console.ReadLine());
                    counter++;
                    if (jump > start) { last = start; start += 5; fail = 0;  }
                    else { fail++; }
                    if (jump > target && last >= target) { Console.WriteLine($"Tihomir succeeded, he jumped over {last}cm after {counter} jumps."); break; }
                }
                else { Console.WriteLine($"Tihomir failed at {start}cm after {counter} jumps."); break; }
            }
        }
    }
}
