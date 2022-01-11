using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTicketService.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(5 == calc.Subtraction(10, 5));
        }
    }
}
