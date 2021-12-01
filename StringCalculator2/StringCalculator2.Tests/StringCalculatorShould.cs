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
            Assert.Equal(0,StringC.Sum(""));
        }
    }
}