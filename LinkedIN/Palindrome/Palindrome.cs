using System;


namespace Palindrome
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets begin!");

            (bool , int , string ) Palidrome(string strr)
            {
                bool palindrome = false;
                int count = strr.Length;
                strr = strr.ToLower();
                char[] bannedChars = { ' ', '!', '?', '.', '\'' };
                foreach (char c in bannedChars)
                {
                    strr = strr.Replace(c.ToString(), string.Empty);
                }
                string reverce = null;
                for( int i = strr.Length - 1; i >= 0 ; i--)
                {
                    reverce += strr[i].ToString();
                }
                if( reverce == strr )
                {
                    palindrome = true;
                }
                return (palindrome , count , reverce);
            }
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "exit") { break; }
                (bool, int, string) result = Palidrome(str);
                Console.WriteLine($"Palindrome: {result.Item1}, Lenght: {result.Item2}, Reverced: {result.Item3}");
            }
        }
    }
}
