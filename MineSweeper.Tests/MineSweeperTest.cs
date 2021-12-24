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
            
            board.MineIn(new Point(0, 0)).Should().Be(true);
        }

        [Fact]
        public void CheckThatIsNotAMineIn0_0()
        {
            var input = "4 4\n....\n....\n.*..\n....";
            var board = new Board(input);
            
            board.MineIn(new Point(0, 0)).Should().Be(false);
        }

        [Fact]
        public void CheckThatIsAMineIn1_2()
        {
            var input = "4 4\n....\n..*.\n.*..\n....";
            var board = new Board(input);
            
            board.MineIn(new Point(1, 2)).Should().Be(true);
        }

        [Fact]
        public void OneNeighbourMineIn0_0()
        {
            var input = "4 4\n.*..\n..*.\n.*..\n....";
            var board = new Board(input);
            
            board.MineNeigBoursIn(new Point(0, 0)).Should().Be(1);
        }

        [Fact]
        public void TwoNeighbourMinesIn0_0()
        {
            var input = "4 4\n.*..\n*.*.\n.*..\n....";
            var board = new Board(input);
            
            board.MineNeigBoursIn(new Point(0, 0)).Should().Be(2);
        }

    }
}