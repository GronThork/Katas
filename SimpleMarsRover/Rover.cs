namespace SimpleMarsRover;

public class Rover
{
    private string Orientation { get; set; } = "N";

    public void RotateRight()
    {
        Orientation = Orientation switch
        {
            "N" => "E",
            "E" => "S",
            "S" => "W",
            "W" => "N",
            _ => Orientation
        };
    }

    public string GetPosition()
    {
        return "0:0:" + Orientation;
    }
}