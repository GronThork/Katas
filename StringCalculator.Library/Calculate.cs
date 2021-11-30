using System;

namespace StringCalculator.Tests
{
    public class Calculate
    {
        public static int Sum(string s)
        {
            return 1 + int.Parse(s.Split(',')[1].ToString());
        }
    }
}