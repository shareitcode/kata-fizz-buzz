using FizzBuzz.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Kata.FizzBuzz.Specs
{
    /// <summary>
    /// FizzBuzz test class
    /// </summary>
    [Binding]
    public class FizzBuzzTest
    {
        /// <summary>
        /// FizzBuzz class to test
        /// </summary>
        private readonly FizzBuzzClass _fizzBuzzClass;

        /// <summary>
        /// Number value to test for division
        /// </summary>
        private int _number;

        /// <summary>
        /// Result value expected
        /// </summary>
        private string _result;

        /// <summary>
        /// FizzBuzzTest constructor
        /// </summary>
        public FizzBuzzTest()
        {
            this._fizzBuzzClass = new FizzBuzzClass();
        }

        /// <summary>
        /// Give value to test
        /// </summary>
        /// <param name="number"></param>
        [Given(@"a number (.*)")]
        public void GivenANumber(int number)
        {
            this._number = number;
        }

        /// <summary>
        /// When the value is divisible by three
        /// </summary>
        [When(@"is divisible by three")]
        public void WhenIsDivisibleByThree()
        {
            this._result = this._fizzBuzzClass.FizzBuzz(this._number);
        }

        /// <summary>
        /// Test when the value is divisible by five
        /// </summary>
        [When(@"is divisible by five")]
        public void WhenIsDivisibleByFive()
        {
            this._result = this._fizzBuzzClass.FizzBuzz(this._number);
        }

        /// <summary>
        /// Test when the value is divisible by three and five
        /// </summary>
        [When(@"is divisible by three and five")]
        public void WhenIsDivisibleByThreeAndFive()
        {
            this._result = this._fizzBuzzClass.FizzBuzz(this._number);
        }

        /// <summary>
        /// Test the expected result value
        /// </summary>
        /// <param name="expect"></param>
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string expect)
        {
            Assert.AreEqual(expect, this._result);
        }
    }
}