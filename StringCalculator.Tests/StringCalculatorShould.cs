using System;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Fact]
        public void Return2IfTheStringIs1And1()
        {
            Assert.Equal(2, Calculate.Sum("1,1"));
        }
    }
}