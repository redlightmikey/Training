using Calculator.Logic;
using FluentAssertions;
using Xunit;

namespace Console.Logic.Tests
{
    public class AddingCalculatorTests
    {
        public class WhenIPassTheNumberThreeAndNumberFourItShould
        {
            public AddingCalculator sut;
            public WhenIPassTheNumberThreeAndNumberFourItShould()
            {
                sut = new AddingCalculator();
            }

            [Fact]
            public void ReturnNumberSeven()
            {
                var result = sut.Add(3, 4);

                result.Should().Be(7);
            }
        }
    }
}
