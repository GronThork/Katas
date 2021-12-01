using System;
using StringCalculator2.Library;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Return0WhenTheInputIsEmpty()
        {
            Assert.Equal(0,StringC.Add(""));
        }

        [Fact]
        public void Return1WhenTheInputIs1()
        {
            Assert.Equal(1,StringC.Add("1"));
        }

        [Fact]
        public void Return2WhenTheInputIs2()
        {
            Assert.Equal(2,StringC.Add("2"));
        }

    }
}