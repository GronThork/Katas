namespace SimpleMarsRover;

public class MarsRover
{
    private static Rover rover;

    public MarsRover()
    {
        rover = new Rover();
    }

    public string Execute(string movements)
    {
        foreach (var movement in movements.ToCharArray())
        {
            if (movement == 'R')
            {
                rover.RotateRight();
            }
            else if (movement == 'L')
            {
                rover.RotateLeft();
            }
            else if (movement == 'M')
            {
                rover.MoveForward();
            }
        }
        
        return rover.GetPosition();
    }
}