namespace SimpleMarsRover;

public class MarsRoverShould
{
    [Fact]
    public void BeAtTheInitialPositionWithoutHavingExecutedAnyMovement()
    {
        const string movements = "";
        Assert.Equal("0:0:N", MarsRover.Execute(movements));
    }
    
    [Fact]
    public void RotateToEastFromInitialPosition()
    {
        const string movements = "R";
        Assert.Equal("0:0:E", MarsRover.Execute(movements));
    }
}

public static class MarsRover
{
    public static string Execute(string movements)
    {
        if (movements == "R")
            return "0:0:E";
        return "0:0:N";
    }
}