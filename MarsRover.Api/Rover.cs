using System;
using System.Collections.Generic;

namespace MarsRover.Api
{
    public class Rover
    {
        public Position Position => _position;
        private Position _position;
        private Direction _direction;
        

        public Rover(Position position, Direction direction)
        {
            _position = position;
            _direction = direction;
        }

        public void Move(List<Command> command)
        {
            if (_direction == Direction.S)
            {
                _position.DecrementY();
            }

            if (_direction == Direction.N)
            {
                _position.IncrementY();
            }
            if (_direction == Direction.E)
            {
                _position.IncrementX();
            }
            
            if (_direction == Direction.W)
            {
                _position.DecrementX();
            }
        }
    }
}