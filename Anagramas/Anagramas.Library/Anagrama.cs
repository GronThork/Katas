using System.Collections.Generic;

namespace Anagramas.Tests
{
    public class Anagrama
    {
        public static string Do(string s)
        {
            if (s.Length == 2)
            {
                return $"{s[1]}{s[0]}";
            }
            
            return s;
        }
    }
}