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
        [Test]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(10,2) == 5);
        }
    }
}
