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

    [Fact]
    public void Convert15ToFizzBuzz()
    {
        Assert.Equal("FizzBuzz",FizzBuzz.Convert(15));
    }
    
    [Fact]
    public void Convert30ToFizzBuzz()
    {
        Assert.Equal("FizzBuzz",FizzBuzz.Convert(30));
    }
}

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (input == 15)
            return "FizzBuzz";
        
        if (input % 5 == 0)
            return "Buzz";

        if (input % 3 == 0)
            return "Fizz";
        
        return input.ToString();
    }
}