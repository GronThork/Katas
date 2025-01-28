namespace FizzBuzz;

public class FizzBuzzShould
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void ConvertNumberToString(int input)
    {
        Assert.Equal(input.ToString(), FizzBuzz.Convert(input));
    }

    [Fact]
    public void Convert3ToFizz()
    {
        Assert.Equal("Fizz",FizzBuzz.Convert(3));
    }
}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (input == 3)
            return "Fizz";
        
        return input.ToString();
    }
}