namespace Anagram;

public static class Anagram
{
    public static List<string> Of(string word)
    {
        if (word.Length < 2)
            return [word];

        var anagrams = new List<string>();

        for (var i = 0; i < word.Length; i++)
        for (var j = 0; j < Of(DropCharacter(word, i)).Count; j++)
            anagrams.Add(word[i] + Of(DropCharacter(word, i))[j]);

        return anagrams;
    }

    private static string DropCharacter(string word, int index)
    {
        return new string(word.Where((_, i) => i != index).ToArray());
    }
}