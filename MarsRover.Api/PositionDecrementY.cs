namespace MarsRover.Api
{
    public class PositionDecrementY : IPositionAxis
    {
        private readonly Position _position;

        public PositionDecrementY(Position position)
        {
            _position = position;
        }
        
        public Position Move()
        {
            _position.DecrementY();

            return _position;
        }
    }
}