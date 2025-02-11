namespace SimpleMarsRover;

public class MarsRoverShould
{
    [Fact]
    public void BeAtTheInitialPositionWithoutHavingExecutedAnyMovement()
    {
        const string movements = "";
        Assert.Equal("0:0:N", MarsRover.Execute(movements));
    }
    
    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    public void RotateToRightDirection(string movements, string expectedPosition)
    {
        Assert.Equal(expectedPosition, MarsRover.Execute(movements));
    }
}

public static class MarsRover
{
    public static string Execute(string movements)
    {
        var orientation = "N";
        foreach (var movement in movements.ToCharArray())
            if (movement == 'R')
            {
                orientation = RotateRight(orientation);
            }
        
        return "0:0:" + orientation;
    }

    private static string RotateRight(string orientation)
    {
        if (orientation == "N")
        {
            orientation = "E";
        }
        else if (orientation == "E")
        {
            orientation = "S";
        }

        return orientation;
    }
}