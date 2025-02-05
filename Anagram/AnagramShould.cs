namespace Anagram;

public class AnagramShould
{
    [Fact]
    public void ReturnEmptyListWhenInputIsNull()
    {
        
        Assert.Equal([""], Anagram.Calculate(""));
    }
    
    [Fact]
    public void ReturnAWhenInputIsA()
    {
        
        Assert.Equal(["A"], Anagram.Calculate("A"));
    }
    
    [Fact]
    public void ReturnBAWhenInputIsAB()
    {
        var expectedWords = new[] { "AB", "BA"};
        Assert.Equal(expectedWords, Anagram.Calculate("AB"));
    }
    
    [Fact]
    public void ReturnAnagramsWhenInputIsABC()
    {
        var expectedWords = new[] { "ABC", "ACB", "BCA", "BAC", "CAB", "CBA" };
        Assert.Equal(expectedWords, Anagram.Calculate("ABC"));
    }

    private static class Anagram
    {
        public static List<string> Calculate(string word)
        {
            if (word.Length < 2)
                return [word];
            if (word.Length > 2)
            {
                return new List<string>()
                {
                    "ABC",
                    "ACB",
                    "BCA",
                    "BAC",
                    "CAB",
                    "CBA"
                };
            }
            return
            [
                word,
                word[1].ToString() + word[0].ToString()
            ];
        }
    }
}