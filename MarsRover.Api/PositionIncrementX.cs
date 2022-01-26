using System.Threading;

namespace MarsRover.Api
{
    public class PositionIncrementX : IPositionAxis
    {
        private readonly Position _position;

        public PositionIncrementX(Position position)
        {
            _position = position;
        }
        
        public Position Move()
        {
           _position.IncrementX();

           return _position;
        }
    }
}