namespace Palindrome;

public partial class PalindromeShould
{
    [Fact]
    public void ReturnTrueWhenInputIsAnna()
    {
        Assert.True(Palindrome.Calculate("Anna"));
    }
}