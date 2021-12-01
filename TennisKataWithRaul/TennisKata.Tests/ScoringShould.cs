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
        
        [Fact]
        public void Show15WhenAPointIsMade()
        {
            ScoringSystem scoringSystem = new();

             scoringSystem.MarkAPoint();
            
            Assert.Equal("15", scoringSystem.Score());
        }

    }
}