using System.Threading;

namespace MarsRover.Api
{
    public class PositionIncrementX : IPositionAxis
    {
        public void Move(Position position)
        {
           position.IncrementX();
        }
    }
}