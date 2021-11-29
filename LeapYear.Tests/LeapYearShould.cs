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

        [Theory]
        [InlineData(5)]
        [InlineData(100)]
        [InlineData(200)]
        [InlineData(300)]
        public void ReturnFalseForInputMultipleOf100( int input)
        {
            bool actual = LeapYearCalculate.IsLeapYear(input);
            
            Assert.False(actual);
        }

        [Fact]
        public void ReturnTrueForYear400()
        {
            bool actual = LeapYearCalculate.IsLeapYear(400);

            Assert.True(actual);
        }

        [Fact]
        public void ReturnTrueForYear800()
        {
            bool actual = LeapYearCalculate.IsLeapYear(800);

            Assert.True(actual);
        }

    }
}