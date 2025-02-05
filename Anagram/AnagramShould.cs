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
        var expectedWords = new[] { "AB", "BA" };
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

            var anagrams = new List<string>();

            for (var i = 0; i < word.Length; i++)
                for (var j = 0; j < word.Length - 1; j++)
                    anagrams.Add(word[i] + Of(DropCharacter(word, i))[j]);
            
            return anagrams;
        }

        private static string DropCharacter(string word, int index)
        {
            return new string(word.Where((_, i) => i != index).ToArray());
        }
    }
}