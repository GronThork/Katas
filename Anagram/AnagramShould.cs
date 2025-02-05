namespace Anagram;

public class AnagramShould
{
    [Fact]
    public void ReturnEmptyListWhenInputIsNull()
    {
        
        Assert.Equal([""], Anagram.Of(""));
    }
    
    [Fact]
    public void ReturnAWhenInputIsA()
    {
        
        Assert.Equal(["A"], Anagram.Of("A"));
    }
    
    [Fact]
    public void ReturnBAWhenInputIsAB()
    {
        var expectedWords = new[] { "AB", "BA"};
        Assert.Equal(expectedWords, Anagram.Of("AB"));
    }
    
    [Fact]
    public void ReturnAnagramsWhenInputIsABC()
    {
        var expectedWords = new[] { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
        Assert.Equal(expectedWords, Anagram.Of("ABC"));
    }

    private static class Anagram
    {
        public static List<string> Of(string word)
        {
            if (word.Length < 2)
                return [word];
            if (word.Length == 2)
            {
                return
                [
                    word,
                    word[1].ToString() + word[0].ToString()
                ];
            }
            
            return
            [
                word[0] + Of(DropCharacter(word, 0))[0],
                word[0] + Of(DropCharacter(word, 0))[1],
                word[1] + Of(DropCharacter(word, 1))[0],
                word[1] + Of(DropCharacter(word, 1))[1],
                word[2] + Of(DropCharacter(word, 2))[0],
                word[2] + Of(DropCharacter(word, 2))[1]
            ];

        }

        private static string DropCharacter(string word, int index)
        {
            return new string(word.Where((_, i) => i != index).ToArray());
        }
    }
}