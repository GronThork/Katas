namespace TextProcessing;

public class TextProcessingShould
{
    [Theory]
    [InlineData("Hello World", 2)]
    [InlineData("Hello im a human", 4)]
    [InlineData("Hello, this is an example for you to practice. You should grab this text and make it as your test case.", 21)]
    public void CountTheNumberOfWords(string text, int expected)
    {
        Assert.Equal(expected, TextProcessing.CountWords(text));
    }
}

public static class TextProcessing
{
    public static int CountWords(string text)
    {
        return text.Split(" ").Length;
    }
}