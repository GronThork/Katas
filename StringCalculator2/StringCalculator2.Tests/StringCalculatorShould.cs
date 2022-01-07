using System;
using System.Runtime.InteropServices;
using StringCalculator2.Library;
using Xunit;
using Xunit.Sdk;

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
            var stringC = new StringC();
            
            Assert.Equal(expected,stringC.Add(input));
        }

        [Theory]
        [InlineData("\\;\n5;10", 15)]
        [InlineData("\\-\n10-5-7",22)]
        [InlineData("\\\n\n10\n5\n5",20)]
        public void ReturnTheCorrectSumForASpecificSemicolonDelimiter(string input, int expected)
        {
            var stringC = new StringC();
            
            Assert.Equal(expected,stringC.Add(input));
        }

        [Theory]
        [InlineData("-10")]
        [InlineData("-999")]
        [InlineData("-1")]
        public void ThrowAExceptionForANegativeNumber(string input)
        {
            var stringC = new StringC();
            
            var exception = Assert.Throws<Exception>(() => stringC.Add(input));
            Assert.Equal("negatives not allowed", exception.Message);
        }

        [Theory]
        [InlineData(2,"1001,2")]
        [InlineData(13,"1001,13")]
        [InlineData(23,"1000,23")]
        public void ExcludeNumbersAbove999(int expected, string input)
        {
            var stringC = new StringC();
            
            Assert.Equal(expected,stringC.Add(input));
        }

        [Fact]
        public void DetectAPairOfBracketsInTheString()
        {
            var stringC = new StringC();
            
            Assert.Equal((2,5),stringC.IndexPairOfBrackets("\\[***]\n50***4***1"));
        }
        
        [Fact]
        public void HaveASeparatorInsideBrackets()
        {
            var stringC = new StringC();
            
            Assert.Equal(55,stringC.Add("\\[***]\n50***4***1"));
        }
        
        [Fact]
        public void HaveSeveralSeparatorsInsideBrackets()
        {
            var stringC = new StringC();
            
            Assert.Equal(55,stringC.Add("\\[***][...]\n50***4...1"));
        }
    }
}