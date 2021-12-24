using System;
using FluentAssertions;
using Xunit;

namespace MineSweeper.Tests
{
    public class MineSweeperTest
    {
        [Fact]
        public void CheckAMineIn0_0()
        {
            var input = "4 4\n*...\n....\n.*..\n....";
            var board = new Board(input);
            
            board.MineIn(0, 0).Should().Be(true);
        }

        [Fact]
        public void CheckThatIsNotAMineIn0_0()
        {
            var input = "4 4\n....\n....\n.*..\n....";
            var board = new Board(input);
            
            board.MineIn(0, 0).Should().Be(false);
        }

    }
}