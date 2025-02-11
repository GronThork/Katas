namespace SimpleMarsRover;

public class Rover
{
    private int CoordinateX { get; set; } = 0;
    private CardinalPoint Orientation { get; set; } = CardinalPoint.N;


    public void RotateRight()
    {
        Orientation = Orientation switch
        {
            CardinalPoint.N => CardinalPoint.E,
            CardinalPoint.E => CardinalPoint.S,
            CardinalPoint.S => CardinalPoint.W,
            CardinalPoint.W => CardinalPoint.N,
            _ => Orientation
        };
    }

    public string GetPosition()
    {
        return CoordinateX + ":0:" + Orientation;
    }

    public void RotateLeft()
    {
        Orientation = Orientation switch
        {
            CardinalPoint.N => CardinalPoint.W,
            CardinalPoint.W => CardinalPoint.S,
            CardinalPoint.S => CardinalPoint.E,
            CardinalPoint.E => CardinalPoint.N,
            _ => Orientation
        };
    }

    public void MoveForward()
    {
        CoordinateX = 1;
    }
}