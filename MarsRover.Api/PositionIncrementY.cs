namespace MarsRover.Api
{
    public class PositionIncrementY : IPositionAxis
    {
        private readonly Position _position;

        public PositionIncrementY(Position position)
        {
            _position = position;
        }

        public Position Move()
        {
            _position.IncrementY();

            return _position;
        }
    }
}