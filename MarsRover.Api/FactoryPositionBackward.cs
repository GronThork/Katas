using System;

namespace MarsRover.Api
{
    public class FactoryPositionBackward : IFactoryPosition
    {
        public IPositionAxis FactoryPositionMove(Direction direction)
        {
            return direction switch
            {
                Direction.N => new PositionDecrementY(),
                Direction.E => new PositionDecrementX(),
                Direction.S => new PositionIncrementY(),
                Direction.W => new PositionIncrementX(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}