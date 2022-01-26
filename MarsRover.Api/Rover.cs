using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MarsRover.Api
{
    public class Rover
    {
        public Position Position => _position;
        private Position _position;
        private readonly Direction _direction;


        public Rover(Position position, Direction direction)
        {
            _position = position;
            _direction = direction;
        }

        public void Execute(List<Command> commands)
        {
            IPositionAxis positionAxis;
            var factoryPositionForward = new FactoryPositionForward();
            
            foreach (var command in commands)
            {
                if (command == Command.F)
                {
                    positionAxis = factoryPositionForward.FactoryPositionMove(_direction);
                    positionAxis.Move(_position);
                }

                if (command == Command.B)
                {
                    if (_direction == Direction.N)
                    {
                        _position.DecrementY();
                    }
                    if (_direction == Direction.E)
                    {
                        _position.DecrementX();
                    }
                }
            }
        }
    }
}