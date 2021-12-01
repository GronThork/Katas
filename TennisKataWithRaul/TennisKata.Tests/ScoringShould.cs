using System;
using Xunit;

namespace TennisKata
{
    public class ScoringShould
    {
        [Fact]
        public void StartAtLove()
        {
            ScoringSystem scoringSystem = new();
            Assert.Equal("love", scoringSystem.Score());
        }
    }
}