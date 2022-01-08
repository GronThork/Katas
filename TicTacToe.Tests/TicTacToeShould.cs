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
            table.Put('X', new Coordinates(0, 0));
            table.GetTokenPosition(new Coordinates(0, 0)).Should().Be('X');
        }

        [Fact]
        public void PutTheTokenOInTheCoordinate10()
        {
            var table = new Table();
            table.Put('O', new Coordinates(1, 0));
            table.GetTokenPosition(new Coordinates(1, 0)).Should().Be('O');
        }

    }
}