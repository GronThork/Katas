namespace Palindrome;

public partial class PalindromeShould
{
    [Fact]
    public void ReturnTrueWhenInputIsAnna()
    {
        Assert.True(Palindrome.Calculate("Anna"));
    }
    
    [Fact]
    public void ReturnTrueWhenInputIsWalter()
    {
        Assert.False(Palindrome.Calculate("Walter"));
    }
}