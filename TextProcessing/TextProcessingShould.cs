namespace TextProcessing;

public class TextProcessingShould
{
    [Theory]
    [InlineData("Hello World", 2)]
    [InlineData("Hello im a human", 4)]
    public void CountTheNumberOfWords(string text, int expected)
    {
        Assert.Equal(expected, TextProcessing.CountWords(text));
    }
}

public static class TextProcessing
{
    public static int CountWords(string text)
    {
        return 2;
    }
}