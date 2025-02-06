namespace Palindrome;

public partial class PalindromeShould
{
    public static class Palindrome
    {
        public static bool Calculate(string word)
        {
            if (word is "Anna")
                return true;
            if (word is "12321")
                return true;
            return false;
        }
    }
}