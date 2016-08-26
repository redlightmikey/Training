using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Logic;
using FluentAssertions;
using Xunit;

namespace Console.Logic.Tests
{
    public class SubCalculatorTests
    {
        public class WhenISubtractTwoNumbersItShould
        {
            public CalculatorSubtract sut;


            public WhenISubtractTwoNumbersItShould()
            {
                sut = new CalculatorSubtract();
            }

            [Fact]

            public void ReturnTheCorrectNumber()
            {
                var result = sut.Subtract(4, 1);
                result.Should().Be(3);
            }

        }
    }
}
