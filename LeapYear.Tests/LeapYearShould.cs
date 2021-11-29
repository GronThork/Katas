using System;
using LeapYear.Library;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        [InlineData(12)]
        public void ReturnTrueIfTheInputIsMultipleOf4(int input)
        {
            var actual = LeapYearCalculate.IsLeapYear(input);
            
            Assert.True(actual);
        }

        [Fact]
        public void ReturnFalseForYear5()
        {
            bool actual = LeapYearCalculate.IsLeapYear(5);
            
            Assert.False(actual);
        }

        [Fact]
        public void ReturnFalseForYear100()
        {
            bool actual = LeapYearCalculate.IsLeapYear(100);
            
            Assert.False(actual);
        }

        [Fact]
        public void ReturnFalseForYear200()
        {
            bool actual = LeapYearCalculate.IsLeapYear(200);
            
            Assert.False(actual);
        }
        
        [Fact]
        public void ReturnFalseForYear300()
        {
            bool actual = LeapYearCalculate.IsLeapYear(300);
            
            Assert.False(actual);
        }

    }
}