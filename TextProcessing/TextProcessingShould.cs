namespace TextProcessing;

public class TextProcessingShould
{
    [Theory]
    [InlineData("Hello World", 2)]
    [InlineData("Hello im a human", 4)]
    [InlineData("Hello, this is an example for you to practice. You should grab this text and make it as your test case.", 21)]
    public void CountTheNumberOfWords(string text, int expected)
    {
        Assert.Equal(expected, TextProcessing.CountNumberOfWords(text));
    }

    [Fact]
    public void CountTheNumberOfRepeteadWords()
    {
        var expected = new Dictionary<string, int>
        {
            { "Hello", 1 },
            { "World", 1 }
        };

        Assert.Equal(expected, TextProcessing.CountRepeatedWords());
    }
}

public static class TextProcessing
{
    public static int CountNumberOfWords(string text)
    {
        return text.Split(" ").Length;
    }

    public static IEnumerable<KeyValuePair<string, int>> CountRepeatedWords()
    {
        return [];
    }
}