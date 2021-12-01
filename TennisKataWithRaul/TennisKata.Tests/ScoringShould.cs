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

        [Fact]
        public void Show30WhenAPointIsMadeWhenTheScoreIs15()
        {
            ScoringSystem scoringSystem = new();

            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();
            
            Assert.Equal("30", scoringSystem.Score());
        }

        [Fact]
        public void Show40WhenAPointIsMadeWhenTheScoreIs30()
        {
            ScoringSystem scoringSystem = new();

            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();

            Assert.Equal("40", scoringSystem.Score());
        }

        [Fact]
        public void WinTheMatchWhenMakesAPointAt40()
        {
            ScoringSystem scoringSystem = new();
            
            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();

            Assert.True(scoringSystem.GetWinner());
        }
        
        [Fact]
        public void DontGetAWinnerWhenMakesAPointAtLove()
        {
            ScoringSystem scoringSystem = new();
            
            Assert.False(scoringSystem.GetWinner());
        }
        
        [Fact]
        public void DontGetAWinnerWhenMakesAPointAt15()
        {
            ScoringSystem scoringSystem = new();

            scoringSystem.MarkAPoint();

            Assert.False(scoringSystem.GetWinner());
        }

        [Fact]
        public void DontGetAWinnerWhenMakesAPointAt30()
        {
            ScoringSystem scoringSystem = new();

            scoringSystem.MarkAPoint();
            scoringSystem.MarkAPoint();

            Assert.False(scoringSystem.GetWinner());
        }

    }
}