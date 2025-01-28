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

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void ConvertMultipleOf5ToBuzz(int input)
    {
        Assert.Equal("Buzz",FizzBuzz.Convert(input));
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void ConvertMultipleOf3And5ToFizzBuzz(int input)
    {
        Assert.Equal("FizzBuzz",FizzBuzz.Convert(input));
    }

}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (MultipleOf3(input) && MultipleOf5(input))
            return "FizzBuzz";
        
        if (MultipleOf5(input))
            return "Buzz";

        if (MultipleOf3(input))
            return "Fizz";
        
        return input.ToString();
    }

    private static bool MultipleOf3(int input)
    {
        return input % 3 == 0;
    }

    private static bool MultipleOf5(int input)
    {
        return input % 5 == 0;
    }
}