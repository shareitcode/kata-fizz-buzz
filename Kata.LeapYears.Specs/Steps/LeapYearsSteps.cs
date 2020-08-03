using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Kata.LeapYears.Specs.Steps
{
    [Binding]
    public sealed class LeapYearsSteps
    {
        private int _year;
        private bool _isLeapYear;

        [Given(@"year (.*)")]
        public void GivenYear(int year)
        {
            this._year = year; 
        }

        [When(@"year divisible by (.*)")]
        public void WhenYearDivisibleBy(int divider)
        {
            this._isLeapYear = this._year % divider == 0;
        }

        [Then(@"the result should be leap year true")]
        public void ThenTheResultShouldBeLeapYearTrue()
        {
            Assert.IsTrue(this._isLeapYear);
        }
    }
}