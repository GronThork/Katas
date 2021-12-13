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
            Assert.Equal(0,StringC.Add(""));
        }

        [Fact]
        public void Return1WhenTheInputIs1()
        {
            Assert.Equal(1,StringC.Add("1"));
        }

        [Fact]
        public void Return2WhenTheInputIs2()
        {
            Assert.Equal(2,StringC.Add("2"));
        }

        [Fact]
        public void Return3WhenTheInputIs3()
        {
            Assert.Equal(3,StringC.Add("3"));
        }

        [Fact]
        public void Return2WhenTheInputIs1And1()
        {
            Assert.Equal(2,StringC.Add("1,1"));
        }

        [Fact]
        public void Return3WhenTheInputIs1And2()
        {
            Assert.Equal(3,StringC.Add("1,2"));
        }

        [Fact]
        public void Return8WhenTheInputIs3And5()
        {
            Assert.Equal(8,StringC.Add("3,5"));
        }

        [Fact]
        public void Return26WhenTheInputIs6And10And10()
        {
            Assert.Equal(26,StringC.Add("6,10,10"));
        }

    }
}