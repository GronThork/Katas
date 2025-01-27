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
}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        return input.ToString();
    }
}