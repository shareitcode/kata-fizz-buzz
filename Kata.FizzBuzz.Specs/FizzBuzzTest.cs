using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Kata.FizzBuzz.Specs
{
    [Binding]
    public class FizzBuzzTest
    {
        private int number;
        private string result;

        [Given(@"a number (.*)")]
        public void GivenANumber(int number)
        {
            this.number = number;
        }

        [When(@"is divisible by three")]
        public void WhenIsDivisibleByThree()
        {
            this.result = number % 3 == 0 ? "Fizz" : number.ToString();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string expect)
        {
            Assert.AreEqual(expect, this.result);
        }
    }
}