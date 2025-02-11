namespace SimpleMarsRover;

public class MarsRoverShould
{
    [Fact]
    public void BeAtTheInitialPositionWithoutHavingExecutedAnyMovement()
    {
        const string movements = "";
        Assert.Equal("0:0:N", MarsRover.Execute(movements));
    }
}

public static class MarsRover
{
    public static string Execute(string movements)
    {
        return string.Empty;
    }
}