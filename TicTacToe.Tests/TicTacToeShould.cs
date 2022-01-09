using FluentAssertions;
using Xunit;

namespace TicTacToe.Tests
{
    public class TicTacToeShould
    {
        [Fact]
        public void PutTheTokenXInTheCoordinate00()
        {
            var table = new Table();
            table.Put(new Token('X'), new Position(0, 0));
            table.GetTokenPosition(new Position(0, 0)).Should().Be('X');
        }

        [Fact]
        public void PutTheTokenOInTheCoordinate00()
        {
            var table = new Table();
            table.Put(new Token('O'), new Position(0, 0));
            table.GetTokenPosition(new Position(0, 0)).Should().Be('O');
        }

        [Fact]
        public void PutTheTokenOInTheCoordinate10AndTheTokenXInTheCoordinate00()
        {
            var table = new Table();
            table.Put(new Token('X'), new Position(0, 0));
            table.Put(new Token('O'), new Position(1, 0));
            table.GetTokenPosition(new Position(1, 0)).Should().Be('O');
            table.GetTokenPosition(new Position(0, 0)).Should().Be('X');
        }

        [Fact]
        public void HaveA3x3Grid()
        {
            var table = new Table();
            table.GetTokenPosition(new Position(0, 0)).Should().Be(' ');
            table.GetTokenPosition(new Position(0, 1)).Should().Be(' ');
            table.GetTokenPosition(new Position(0, 2)).Should().Be(' ');
            table.GetTokenPosition(new Position(1, 0)).Should().Be(' ');
            table.GetTokenPosition(new Position(1, 1)).Should().Be(' ');
            table.GetTokenPosition(new Position(1, 2)).Should().Be(' ');
            table.GetTokenPosition(new Position(2, 0)).Should().Be(' ');
            table.GetTokenPosition(new Position(2, 1)).Should().Be(' ');
            table.GetTokenPosition(new Position(2, 2)).Should().Be(' ');
        }
        
    }
}