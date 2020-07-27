using System;

namespace FizzBuzz.ConsoleApp
{
    public sealed class FizzBuzzClass
    {
        /// <summary>
        /// Fizz constant value
        /// </summary>
        private const string Fizz = "Fizz";

        /// <summary>
        /// Buzz constant value
        /// </summary>
        private const string Buzz = "Buzz";

        /// <summary>
        /// Return Fizz, Buzz or FizzBuzz if number divisible by three, five or three and five
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return Fizz + Buzz;
            if (number % 3 == 0) return Fizz;
            if (number % 5 == 0) return Buzz;
            return number.ToString();
        }

        /// <summary>
        /// Return Fizz, Buzz or FizzBuzz if number divisible by three, five or three and five
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string FizzBuzzSecondWay(int number)
        {
            string result = number.ToString();
            if (number % 3 == 0) result = Fizz;
            if (number % 5 == 0) result += Buzz;
            return result;
        }

        /// <summary>
        /// Display FizzBuzz for number 1 to 100
        /// </summary>
        public void Compute()
        {
            for (int i = 1; i < 101; i++) Console.WriteLine(this.FizzBuzz(i));
        }
    }
}