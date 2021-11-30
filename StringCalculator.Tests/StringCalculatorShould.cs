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

        [Fact]
        public void Return11IfTheStringIs1And10()
        {
            Assert.Equal(11, Calculate.Sum("1,10"));
        }

        [Fact]
        public void Return12IfTheStringIs1And11()
        {
            Assert.Equal(12, Calculate.Sum("1,11"));
        }
        
        [Fact]
        public void Return13IfTheStringIs1And12()
        {
            Assert.Equal(13, Calculate.Sum("1,12"));
        }
    }
}