using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module24
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Addition(4, 2) == 6);
        }
        [Test]
        public void SubstractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(4, 2) == 2);
        }
        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Miltiplication(4, 2) == 8);
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(8, 2) == 4);
        }
    }
}
