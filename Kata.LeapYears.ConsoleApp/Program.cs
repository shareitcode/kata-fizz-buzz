using System;
using System.Collections.Generic;

namespace Kata.LeapYears.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> intDivisibleByCent = new List<string>();
            for (int i = 1000; i < 3000; i++)
            {
                if (LeapYears.IsLeapYears(i))
                {
                    intDivisibleByCent.Add(i + "*");
                    Console.WriteLine(i + "*");
                }
                else
                {
                    intDivisibleByCent.Add(i.ToString());
                    Console.WriteLine(i);
                }
            }
            var res = intDivisibleByCent;
        }
    }
}
