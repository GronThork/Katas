namespace MarsRover.Api
{
    public class PositionDecrementX : IPositionAxis
    {
        private readonly Position _position;

        public PositionDecrementX(Position position)
        {
            _position = position;
        }
        
        public Position Move()
        {
            _position.DecrementX();

            return _position;
        }
    }
}