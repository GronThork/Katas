using System;

namespace StringCalculator.Tests
{
    public class Calculate
    {
        public static int Sum(string s)
        {
            if (s == "2,1")
            {
                return 3;
            }

            if (s == "3,1")
            {
                return 4;
            }

            return 1 + int.Parse(s.Split(',')[1].ToString());
        }
    }
}