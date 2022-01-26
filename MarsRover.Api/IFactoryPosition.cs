namespace MarsRover.Api
{
    public interface IFactoryPosition
    {
        IPositionAxis FactoryPositionMove(Direction direction);
    }
}