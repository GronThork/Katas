using System.Collections.Generic;
using FluentAssertions;
using MarsRover.Api;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverShould
    {
        [Fact]
        public void MoveFromPosition00NorthTo01North()
        {
            var rover = new Rover(new Position(0,0),Direction.N); 
            var commands = new List<Command> {Command.F};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(0,1));
        }
        
        [Fact]
        public void MoveFromPosition00SouthTo0Minus1South()
        {
            var rover = new Rover(new Position(0,0),Direction.S); 
            var commands = new List<Command> {Command.F};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(0,-1));
        }
        
        [Fact]
        public void MoveFromPosition00EastTo10East()
        {
            var rover = new Rover(new Position(0,0),Direction.E); 
            var commands = new List<Command> {Command.F};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(1,0));
        }
        
        [Fact]
        public void MoveFromPosition00WestToMinus10West()
        {
            var rover = new Rover(new Position(0,0),Direction.W); 
            var commands = new List<Command> {Command.F};

            rover.Execute(commands);

            rover.Position.Should().Be(new Position(-1,0));
        }
    }
}