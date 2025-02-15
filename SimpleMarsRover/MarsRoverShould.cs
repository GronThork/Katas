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
    [InlineData("RRR", "0:0:W")]
    [InlineData("RRRR", "0:0:N")]
    public void RotateToRightDirection(string movements, string expectedPosition)
    {
        var marsRover = new MarsRover();
        
        Assert.Equal(expectedPosition, marsRover.Execute(movements));
    }
    
    [Theory]
    [InlineData("L", "0:0:W")]
    [InlineData("LL", "0:0:S")]
    [InlineData("LLL", "0:0:E")]
    [InlineData("LLLL", "0:0:N")]
    public void RotateToLeftDirection(string movements, string expectedPosition)
    {
        var marsRover = new MarsRover();
        
        Assert.Equal(expectedPosition, marsRover.Execute(movements));
    }

    [Theory]
    [InlineData("M", "1:0:N")]
    [InlineData("MM", "2:0:N")]
    public void MoveForward(string movements, string expectedPosition)
    {
        var marsRover = new MarsRover();
        Assert.Equal("1:0:N", marsRover.Execute("M"));
    }
    
}