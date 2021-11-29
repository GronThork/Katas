using System;
using LeapYear.Library;
using Xunit;

namespace LeapYear.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void ReturnTrueForYear4()
        {
            bool actual = LeapYearCalculate.IsLeapYear(4);
            
            Assert.True(actual);
        }
        
        [Fact]
        public void ReturnFalseForYear5()
        {
            bool actual = LeapYearCalculate.IsLeapYear(5);
            
            Assert.False(actual);
        }

    }
}