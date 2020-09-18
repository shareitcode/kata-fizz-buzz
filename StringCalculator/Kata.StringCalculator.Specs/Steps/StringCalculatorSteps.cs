using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Kata.StringCalculator.Specs.Steps
{
    [Binding]
    public class StringCalculatorSteps
    {
        private readonly char[] _separators = new char[] { ',', '\n' };
        private string _numbers = string.Empty;
        private double _sumOfNumbers = 0.0;

        [Given(@"numbers (.*)")]
        public void GivenString(string numbers)
        {
            _numbers = numbers;
        }

        [When(@"the numbers are separated by a comma, their sums are computed")]
        public void WhenNumbersIsString()
        {
            Add();
        }

        [Then(@"sum of numbers equal (.*)")]
        public void ThenSumOfNumberEqual(string sums)
        {
            Assert.AreEqual(sums, _sumOfNumbers.ToString("0.#"));
        }

        private void Add()
        {
            string[] numbers = _numbers.Split(_separators);
            if (numbers.Length > 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    double.TryParse(numbers[i], out double numberParsed);
                    _sumOfNumbers += numberParsed;
                }
            }
        }
    }
}
