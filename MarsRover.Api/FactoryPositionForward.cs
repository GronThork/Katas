using System;

namespace MarsRover.Api
{
    public class FactoryPositionForward
    {
        public IPositionAxis FactoryPositionMove(Direction direction)
        {
            return direction switch
            {
                Direction.S => new PositionDecrementY(),
                Direction.N => new PositionIncrementY(),
                Direction.E => new PositionIncrementX(),
                Direction.W => new PositionDecrementX(),
                _ => throw new Exception()
            };
        }
    }
}