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
        var text =
            "Hello, this is an example for you to practice. You should grab this text and make it as your test case.";
        var expected = new Dictionary<string, int>
        {
            { "hello", 1 },
            { "this", 2 },
            { "is", 1 },
            { "an", 1 },
            { "example", 1 },
            { "for", 1 },
            { "you", 2 },
            { "to", 1 },
            { "practice", 1 },
            { "should", 1 },
            { "grab", 1 },
            { "text", 1 },
            { "and", 1 },
            { "make", 1 },
            { "it", 1 },
            { "as", 1 },
            { "your", 1 },
            { "test", 1 },
            { "case", 1 }
        };

        Assert.Equal(expected, TextProcessing.CountRepeatedWords(text));
    }
    
    [Fact]
    public void CountTheNumberOfRepeteadWordsWithoutCaseAndCommasAndPoints()
    {
        var expected = new Dictionary<string, int>
        {
            { "hello", 2 },
            { "world", 1 }
        };

        Assert.Equal(expected, TextProcessing.CountRepeatedWords("Hello, World, hello."));
    }
}

public static class TextProcessing
{
    public static int CountNumberOfWords(string text)
    {
        return text.Split(" ").Length;
    }

    public static IEnumerable<KeyValuePair<string, int>> CountRepeatedWords(string text)
    {
        var filteredText = text.ToLower().Replace(",", "").Replace(".", "");
        var words = filteredText.Split(" ");
        var wordsCount = new Dictionary<string, int>();
        
        foreach (var word in words)
            if (!wordsCount.TryAdd(word, 1))
                wordsCount[word]++;

        return wordsCount;
    }
}