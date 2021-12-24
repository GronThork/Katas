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
            
            game.PrintFields().Should().Be(expected);
        }

        [Fact]
        public void ReturnTwoFields()
        {
            var input = "4 4\n.*..\n*.*.\n..*.\n.*..\n3 5\n**...\n.....\n.*...\n.*...\n0 0";
            var expected = "Field #1:\n2*21\n*4*2\n24*2\n1*21\n\nField #2:\n**100\n33200\n1*100";
            
            var game = new Game(input);
            
            game.PrintFields().Should().Be(expected);
        }

        
    }
}