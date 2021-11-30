using System;

namespace StringCalculator.Tests
{
    public class Calculate
    {
        public static int Sum(string s)
        {
            return int.Parse(s.Split(',')[0].ToString()) + int.Parse(s.Split(',')[1].ToString());
        }
    }
}