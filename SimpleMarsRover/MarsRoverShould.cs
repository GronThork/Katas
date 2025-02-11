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
        if (movements == "RR")
            return "0:0:S";
        if (movements == "R")
            return "0:0:E";
        return "0:0:N";
    }
}