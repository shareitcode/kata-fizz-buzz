using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRental;

namespace Kata.MovieRental.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TheFormatterResultShouldByInTextFormat()
        {
            Customer customer = new Customer("Bob");
            customer.addRental(new Rental(new Movie("Jaws", Movie.REGULAR), 2));
            customer.addRental(new Rental(new Movie("Short New", Movie.NEW_RELEASE), 1));
            customer.addRental(new Rental(new Movie("Long New", Movie.NEW_RELEASE), 2));
            customer.addRental(new Rental(new Movie("Toy Story", Movie.CHILDRENS), 4));

            string formatExpected = "" +
                "Rental Record for Bob\n" +
                "\tJaws\t2\n" +
                "\tShort New\t3\n" +
                "\tLong New\t6\n" +
                "\tToy Story\t3\n" +
                "Amount owed is 14\n" +
                "You earned 5 frequent renter points";
            Assert.AreEqual(formatExpected, customer.statement());
        }

        [TestMethod]
        public void TheFormatterResultShouldByInHtmlFormat()
        {
            string formatActual = @"<h1>Rental Record for <em>martin</em></h1>
<table>
  <tr><td>Ran</td><td>3.5</td></tr>
  <tr><td>Trois Couleurs: Bleu</td><td>2</td></tr>
</table>
<p>Amount owed is <em>5.5</em></p>
<p>You earned <em>2</em> frequent renter points</p>";
            string formatExpected = @"<h1>Rental Record for <em>martin</em></h1>
<table>
  <tr><td>Ran</td><td>3.5</td></tr>
  <tr><td>Trois Couleurs: Bleu</td><td>2</td></tr>
</table>
<p>Amount owed is <em>5.5</em></p>
<p>You earned <em>2</em> frequent renter points</p>";
            Assert.AreEqual(formatExpected, formatActual);
        }
    }
}
