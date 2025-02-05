namespace Anagram;

public class AnagramShould
{
    [Fact]
    public void ReturnEmptyListWhenInputIsNull()
    {
        
        Assert.Equal("", Anagram.Calculate(""));
    }
    
    [Fact]
    public void ReturnAWhenInputIsA()
    {
        
        Assert.Equal("A", Anagram.Calculate("A"));
    }

    private static class Anagram
    {
        public static string Calculate(string word)
        {
            return word;
        }
    }
}