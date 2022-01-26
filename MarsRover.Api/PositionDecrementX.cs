namespace MarsRover.Api
{
    public class PositionDecrementX : IPositionAxis
    {
        public void Move(Position position)
        {
            position.DecrementX();
        }
    }
}