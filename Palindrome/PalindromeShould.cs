namespace Palindrome;

public partial class PalindromeShould
{
    [Theory]
    [InlineData("Anna")]
    [InlineData("12321")]
    public void ReturnTrueWhenIsPalindrome(string word)
    {
        Assert.True(Palindrome.Calculate(word));
    }
    
    [Fact]
    public void ReturnTrueWhenInputIsWalter()
    {
        Assert.False(Palindrome.Calculate("Walter"));
    }
}