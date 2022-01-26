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

        public void Move(List<Command> commands)
        {
            IPositionAxis positionAxis;
            
            foreach (var command in commands)
                {
                    if (command == Command.F)
                    {
                        positionAxis = FactoryPositionMove();
                        positionAxis.Move();
                    }
                }
        }

        public IPositionAxis FactoryPositionMove()
        {
            switch (_direction)
            {
                case Direction.S:
                    return new PositionDecrementY(_position);
                    break;
                case Direction.N:
                    return new PositionIncrementY(_position);
                    break;
                case Direction.E:
                    return new PositionIncrementX(_position);
                    break;
                case Direction.W:
                    return new PositionDecrementX(_position);
                    break; 
            }

            throw new Exception();
        }
    }
}