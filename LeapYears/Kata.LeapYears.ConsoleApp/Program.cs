using System;

namespace Kata.LeapYears.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine($"|{"CUSTOM",5}|{"DOTNET",5}|");
            for (int i = 1000; i < 3000; i++)
            {
                string custom;
                string dotNet;

                if (i.IsLeapYear()) custom = i + "*";
                else custom = i.ToString();
                if (DateTime.IsLeapYear(i)) dotNet = i + "*";
                else dotNet = i.ToString();

                string isNotEqual = !custom.Equals(dotNet) ? "-----" : "";

                Console.WriteLine($"|{custom,5}|{dotNet,5}|{isNotEqual}");
            }
        }
    }
}