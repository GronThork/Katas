using System;
using FluentAssertions;
using Xunit;

namespace FactorialKata.Tests
{
    public class FactorialShould
    {
        [Fact]
        public void Return1forInput0()
        {
            var factorial = new Factorial();

            factorial.Calculate(0).Should().Be(1);
        }
    }
}