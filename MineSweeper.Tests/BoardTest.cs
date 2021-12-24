using System;
using FluentAssertions;
using Xunit;

namespace MineSweeper.Tests
{
    public class BoardTest
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
        public void OneNeighbourMineIn1_1()
        {
            var input = "4 4\n.*..\n....\n....\n....";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(1, 1)).Should().Be(1);
        }

        [Fact]
        public void TwoNeighbourMinesIn1_1()
        {
            var input = "4 4\n.*..\n..*.\n....\n....";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(1, 1)).Should().Be(2);
        }

        [Fact]
        public void ThreeNeighbourMinesIn1_1()
        {
            var input = "4 4\n.*..\n*.*.\n....\n....";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(1, 1)).Should().Be(3);
        }

        [Fact]
        public void CheckTopLeftCornerIndex()
        {
            var input = "4 4\n.*..\n*.*.\n....\n....";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(0, 0)).Should().Be(2);
        }

        [Fact]
        public void CheckBottomRightCornerIndex()
        {
            var input = "4 4\n.*..\n*.*.\n....\n.**.";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(3, 3)).Should().Be(1);
        }
        
        [Fact]
        public void CheckBottomLeftCornerIndex()
        {
            var input = "4 4\n.*..\n*.*.\n....\n.**.";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(3, 0)).Should().Be(1);
        }
        
        [Fact]
        public void CheckTopRightCornerIndex()
        {
            var input = "4 4\n.*..\n*.*.\n....\n.**.";
            var board = new Board(input);
            
            board.NeighboursMineIn(new Point(0, 3)).Should().Be(1);
        }

        [Fact]
        public void ReturnTheFieldWithTheNumberOfNeighbours()
        {
            var input = "4 4\n.*..\n*.*.\n..*.\n.*..";
            var expected = "2*21\n*4*2\n24*2\n1*21";
            var board = new Board(input);
            
            board.PrintField().Should().Be(expected);
        }
    }
}