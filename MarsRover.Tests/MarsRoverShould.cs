using FluentAssertions;
using MarsRover.Api;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverShould
    {
        [Fact]
        public void MoveFromPosition00NorthTo01North()
        {
            var rover = new Rover(new Position(0,0),'N');
            char[] commands = {'f'};
            
            rover.Move(commands);

            rover.Position.Should().Be(new Position(0,1));
        }
    }
}