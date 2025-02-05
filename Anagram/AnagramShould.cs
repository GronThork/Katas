namespace Anagram;

public class AnagramShould
{
    [Fact]
    public void ReturnEmptyListWhenInputIsNull()
    {
        
        Assert.Equal("", Anagram.Calculate());
    }

    private static class Anagram
    {
        public static string Calculate()
        {
            return string.Empty;
        }
    }
}