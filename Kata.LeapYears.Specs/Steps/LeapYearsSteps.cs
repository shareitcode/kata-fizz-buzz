using Kata.LeapYears.ConsoleApp;
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
        public void WhenYearDivisibleBy(int denominator)
        {
            this._isLeapYear = this._year % denominator == 0;
        }
        
        [When(@"year not divisible by (.*)")]
        public void WhenYearNotDivisibleBy(int denominator)
        {
            this._isLeapYear = this._year % denominator != 0;
        }

        [When(@"the integer is leap year")]
        public void WhenYearIsInteger()
        {
            this._isLeapYear = this._year.IsLeapYear();
        }

        [Then(@"the result should be leap year")]
        public void ThenTheResultShouldBeLeapYear()
        {
            Assert.IsTrue(this._isLeapYear);
        }
    }
}