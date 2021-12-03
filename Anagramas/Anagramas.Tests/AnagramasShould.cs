using System;
using Xunit;

namespace Anagramas.Tests
{
    public class AnagramasShould
    {
        [Theory]
        [InlineData("A")]
        [InlineData("B")]
        public void ReturnTheSameCharacterThatUseAsInput(string letter)
        {
            Assert.Equal(letter,Anagrama.Do(letter));
        }

        [Fact]
        public void ReturnTheAnagramaForTheWordAB()
        {
            Assert.Equal("BA",Anagrama.Do("AB"));
        }

        [Fact]
        public void ReturnTheAnagramaForTheWordDG()
        {
            Assert.Equal("GD",Anagrama.Do("DG"));
        }
        
        [Fact]
        public void ReturnTheAnagramaForTheWordABC()
        {
            Assert.Equal("ACB-BAC-BCA-CAB-CBA",Anagrama.Do("ABC"));
        }

    }
}