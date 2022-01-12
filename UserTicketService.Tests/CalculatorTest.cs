//using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UserTicketService.Tests
{
  //  [TestFixture]
    public class CalculatorTest
    {
        [Fact]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.True(5 == calc.Subtraction(10, 5));
        }
        [Fact]
        public void DivisionMustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Fact]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Division(10,2));
        }
    }
}
