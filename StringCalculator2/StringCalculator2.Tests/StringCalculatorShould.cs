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

        [Theory]
        [InlineData("\\;\n5;10", 15)]
        [InlineData("\\-\n10-5-7",22)]
        [InlineData("\\\n\n10\n5\n5",20)]
        public void ReturnTheCorrectSumForASpecificSemicolonDelimiter(string input, int expected)
        {
            Assert.Equal(expected,StringC.Add(input));
        }

        [Theory]
        [InlineData("-10")]
        [InlineData("-999")]
        [InlineData("-1")]
        public void ThrowAExceptionForANegativeNumber(string input)
        {
            var exception = Assert.Throws<Exception>(() => StringC.Add(input));
            Assert.Equal("negatives not allowed", exception.Message);
        }

        [Fact]
        public void ExcludeNumbersAbove999()
        {
            Assert.Equal(2,StringC.Add("1001,2"));
        }
    }
}