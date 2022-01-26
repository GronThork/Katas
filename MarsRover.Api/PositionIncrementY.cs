namespace MarsRover.Api
{
    public class PositionIncrementY : IPositionAxis
    {
       public void Move(Position position)
        {
            position.IncrementY();
        }
    }
}