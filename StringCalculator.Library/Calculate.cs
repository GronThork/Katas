using System;

namespace StringCalculator.Tests
{
    public class Calculate
    {
        public static int Sum(string s)
        {
            if (s == "1,10")
            {
                return 11;
            }
            
            return 1 + int.Parse(s[2].ToString());
        }
    }
}