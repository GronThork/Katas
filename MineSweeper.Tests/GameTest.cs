using FluentAssertions;
using Xunit;

namespace MineSweeper.Tests
{
    public class GameTest
    {
        [Fact]
        public void ReturnTheCorrectFieldForAInput()
        {
            var input = "4 4\n.*..\n*.*.\n..*.\n.*..";
            var expected = "Field #1:\n2*21\n*4*2\n24*2\n1*21";
            var game = new Game(input);
            
            game.Fields().Should().Be(expected);
        }
    }
}