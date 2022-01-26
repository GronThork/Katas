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
            switch (_direction)
            {
                case Direction.S:
                    _position.DecrementY();
                    break;
                case Direction.N:
                    _position.IncrementY();
                    break;
                case Direction.E:
                    _position.IncrementX();
                    break;
                case Direction.W:
                    _position.DecrementX();
                    break;
            }
        }
    }
}