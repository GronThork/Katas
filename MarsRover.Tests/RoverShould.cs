using System.Collections.Generic;
using System.Xml.Schema;
using FluentAssertions;
using MarsRover.Api;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverShould
    {
        [Theory]
        [InlineData(Direction.N,0,1)]
        [InlineData(Direction.S,0,-1)]
        [InlineData(Direction.E,1,0)]
        [InlineData(Direction.W,-1,0)]
        public void MoveForwardFromPosition00(Direction direction, int x, int y)
        {
            var rover = new Rover(new Position(0,0),direction); 
            var commands = new List<Command> {Command.F};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(x,y));
        }
        
        [Fact]
        public void MoveFromPosition01NorthTo00North()
        {
            var rover = new Rover(new Position(0,1),Direction.N); 
            var commands = new List<Command> {Command.B};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(0,0));
        }
    }
}