namespace Palindrome;

public partial class PalindromeShould
{
    public static class Palindrome
    {
        public static bool Calculate(string word)
        {
            var wordTreatedAsLowercase = word.ToLower();
            for (var i = 1; i < GetIterations(wordTreatedAsLowercase) ; i++)
            {
                if (wordTreatedAsLowercase[i-1] != wordTreatedAsLowercase[^i])
                    return false;
            }

            return true;
        }

        private static int GetIterations(string wordTreatedAsLowercase)
        {
            var n = (wordTreatedAsLowercase.Length % 2 == 0) ? wordTreatedAsLowercase.Length : wordTreatedAsLowercase.Length / 2;
            return n;
        }
    }
}