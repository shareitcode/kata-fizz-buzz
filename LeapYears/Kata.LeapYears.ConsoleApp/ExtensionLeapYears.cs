namespace Kata.LeapYears.ConsoleApp
{
    public static class ExtensionLeapYears
    {
        public static bool IsLeapYear(this int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0 || year % 4000 == 0;
        }

        /// <summary>
        /// Microsoft .NET Framework approach
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeapYearDotNetFrameworkApproach(this int year)
        {
            if (year % 4 != 0)
                return false;
            return year % 100 != 0 || year % 400 == 0;
        }
    }
}