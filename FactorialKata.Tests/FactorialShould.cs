using System;
using FluentAssertions;
using Xunit;

namespace FactorialKata.Tests
{
    public class FactorialShould
    {
        [Theory]
        [InlineData(1,0)]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(6,3)]
        public void CalculateTheFactorialForAInput(int expected, int input)
        {
            var factorial = new Factorial();

            factorial.Calculate(input).Should().Be(expected);
        }
    }
}