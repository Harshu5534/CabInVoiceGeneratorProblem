using CabInVoiceGeneratorProblem;
using NUnit.Framework;

namespace InvoiceTester
{
    public class Tests
    {
        [Test]
        public void GivenTimeAndDistance_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double actual = invoice.CalculateFare(6, 5);
            Assert.AreEqual(actual, 65);
        }
    }
}