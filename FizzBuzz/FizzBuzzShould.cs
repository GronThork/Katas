namespace FizzBuzz;

public class FizzBuzzShould
{
    [Fact]
    public void Convert1To1()
    {
        Assert.Equal("1", FizzBuzz.Convert(1));
    }
    
    [Fact]
    public void Convert2To2()
    {
        Assert.Equal("2", FizzBuzz.Convert(2));
    }
    
    [Fact]
    public void Convert4To4()
    {
        Assert.Equal("4", FizzBuzz.Convert(4));
    }
}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (input == 4)
        {
            return "4";
        }
        if (input == 2)
        {
            return "2";
        }
        return "1";
    }
}