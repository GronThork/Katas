namespace Anagram;

public abstract class AnagramShould
{
    [Fact]
    public void ReturnCodeTuningFromDocumenting()
    {
        
        Assert.Equal("code tuning", Anagram.DocumentingWord());
    }

    private static class Anagram
    {
        public static string DocumentingWord()
        {
            return string.Empty;
        }
    }
}