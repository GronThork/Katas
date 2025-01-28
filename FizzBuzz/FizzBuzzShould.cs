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

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void ConvertMultipleOf3ToFizz(int input)
    {
        Assert.Equal("Fizz",FizzBuzz.Convert(input));
    }
}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (input % 3 == 0)
            return "Fizz";
        
        return input.ToString();
    }
}