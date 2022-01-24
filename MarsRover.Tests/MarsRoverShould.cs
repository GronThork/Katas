using System.Collections.Generic;
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
            var rover = new Rover(new Position(0,0),Direction.N); 
            var commands = new List<Command> {Command.F};

            rover.Move(commands);

            rover.Position.Should().Be(new Position(0,1));
        }
        
        [Fact]
        public void MoveFromPosition00SouthTo0Minus1South()
        {
            var rover = new Rover(new Position(0,0),Direction.S); 
            var commands = new List<Command> {Command.F};

            rover.Move(commands);

            rover.Position.Should().Be(new Position(0,-1));
        }
    }
}