using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        public void Execute(List<Command> commands)
        {
            IPositionAxis positionAxis;
            
            foreach (var command in commands)
                {
                    if (command == Command.F)
                    {
                        positionAxis = FactoryPositionMove();
                        positionAxis.Move(_position);
                    }
                }
        }

        public IPositionAxis FactoryPositionMove()
        {
            switch (_direction)
            {
                case Direction.S:
                    return new PositionDecrementY();
                    break;
                case Direction.N:
                    return new PositionIncrementY();
                    break;
                case Direction.E:
                    return new PositionIncrementX();
                    break;
                case Direction.W:
                    return new PositionDecrementX();
                    break; 
            }

            throw new Exception();
        }
    }
}