namespace MarsRover.Api
{
    public class PositionDecrementY : IPositionAxis
    {
        public void Move(Position position)
        {
            position.DecrementY();
        }
    }
}