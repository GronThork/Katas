using System;

namespace MarsRover.Api
{
    public class Rover
    {
        private readonly Position _position;
        private readonly char _direction;

        public Rover(Position position, char direction)
        {
            _position = position;
            _direction = direction;
        }

        public void Move(char[] commands)
        {
            _position.IncrementY();
        }

        public Position GetPosition()
        {
            return _position;
        }
    }
}