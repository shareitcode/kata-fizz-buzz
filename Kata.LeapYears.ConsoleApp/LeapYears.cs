namespace Kata.LeapYears.ConsoleApp
{
    public sealed class LeapYears
    {
        public static bool IsLeapYears(int year)
        {
            return year % 400 == 0 || year % 4 != 0 && year % 100 != 0;
        }
    }
}