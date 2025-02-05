namespace Anagram;

public static class Anagram
{
    public static List<string> Of(string word)
    {
        if (word.Length < 2)
            return [word];

        var anagrams = new List<string>();

        for (var i = 0; i < word.Length; i++)
        {
            var droppedCharacter = word[i];
            var anagramsOfRest = Of(DropCharacter(word, i));
            foreach (var anagramOfRest in anagramsOfRest)
                anagrams.Add(droppedCharacter + anagramOfRest);
        }
        
        return anagrams;
    }

    private static string DropCharacter(string word, int index)
    {
        return new string(word.Where((_, i) => i != index).ToArray());
    }
}