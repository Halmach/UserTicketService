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

        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}
