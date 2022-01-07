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
        
        [Fact]
        public void Return1forInput1()
        {
            var factorial = new Factorial();

            factorial.Calculate(1).Should().Be(1);
        }

        [Fact]
        public void Return2forInput2()
        {
            var factorial = new Factorial();

            factorial.Calculate(2).Should().Be(2);
        }

    }
}