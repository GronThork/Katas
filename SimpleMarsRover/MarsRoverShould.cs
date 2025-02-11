namespace SimpleMarsRover;

public class MarsRoverShould
{
    [Fact]
    public void BeAtTheInitialPositionWithoutHavingExecutedAnyMovement()
    {
        const string movements = "";
        var marsRover = new MarsRover();
        
        Assert.Equal("0:0:N", marsRover.Execute(movements));
    }
    
    [Theory]
    [InlineData("R", "0:0:E")]
    [InlineData("RR", "0:0:S")]
    public void RotateToRightDirection(string movements, string expectedPosition)
    {
        var marsRover = new MarsRover();
        
        Assert.Equal(expectedPosition, marsRover.Execute(movements));
    }
}