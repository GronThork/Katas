namespace TextProcessing;

public class TextProcessingShould
{
    [Fact]
    public void CountTheNumberOfWords()
    {
        Assert.Equal(2, TextProcessing.Process("Hello World"));
    }
}

public static class TextProcessing
{
    public static int Process(string text)
    {
        return 0;
    }
}