using System;

namespace StringCalculator2.Library
{
    public static class StringC
    {
        public static int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                return Convert.ToInt32(numbers.Split(",")[0]) +
                       Convert.ToInt32(numbers.Split(",")[1]);
            }
            
            if (numbers.Length == 1)
            {
                return Convert.ToInt32(numbers.ToString());
            }
            
            return 0;
        }
    }
}