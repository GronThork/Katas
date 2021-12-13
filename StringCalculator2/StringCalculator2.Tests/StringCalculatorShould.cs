using System;
using System.Runtime.InteropServices;
using StringCalculator2.Library;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorShould
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "3")]
        [InlineData(2, "1,1")]
        [InlineData(3, "1,2")]
        [InlineData(8, "3,5")]
        [InlineData(26, "6,10,10")]
        [InlineData(15, "5,5\n5")]
        public void ReturnTheSumForAInputString(int expected, string input)
        {
            Assert.Equal(expected,StringC.Add(input));
        }

        [Fact]
        public void Return15For5And10WithASpecificSemicolonDelimiter()
        {
            Assert.Equal(15,StringC.Add("\\;\n5;10"));
        }
    }
}