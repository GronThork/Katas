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
        
        [Fact]
        public void Return3IfTheStringIs1And2()
        {
            Assert.Equal(3, Calculate.Sum("1,2"));
        }

        [Fact]
        public void Return4IfTheStringIs1And3()
        {
            Assert.Equal(4, Calculate.Sum("1,3"));
        }
    }
}