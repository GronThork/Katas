using System;
using Xunit;

namespace Anagramas.Tests
{
    public class AnagramasShould
    {
        [Fact]
        public void ReturnAWithTheWordA()
        {
            Assert.Equal("A",Anagrama.Do("A"));
        }
    }
}