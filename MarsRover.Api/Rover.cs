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
            foreach (var command in commands)
            {
                IPositionAxis positionAxis = null;
                MoveForward(command,new FactoryPositionForward(), positionAxis);
                MoveBackward(command, new FactoryPositionBackward(), positionAxis);
            }
        }

        private void MoveBackward(Command command, IFactoryPosition factoryPositionBackward, IPositionAxis positionAxis)
        {
            if (command == Command.B)
            {
                positionAxis = factoryPositionBackward.FactoryPositionMove(_direction);
                positionAxis.Move(_position);
            }
        }

        private void MoveForward(Command command, IFactoryPosition factoryPositionForward, IPositionAxis positionAxis)
        {
            if (command == Command.F)
            {
                positionAxis = factoryPositionForward.FactoryPositionMove(_direction);
                positionAxis.Move(_position);
            }
        }
    }
}