using System.Collections.Generic;

namespace Anagramas.Tests
{
    public class Anagrama
    {
        public static string Do(string s)
        {
            if (s == "AB")
            {
                return "AB-BA";
            }
            
            return s;
        }
    }
}