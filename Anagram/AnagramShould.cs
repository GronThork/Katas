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
    
    [Fact]
    public void ReturnAnagramsWhenInputIsAWordWith4Letters()
    {
        Assert.Equal(24, Anagram.Of("ABCD").Count);
    }
}