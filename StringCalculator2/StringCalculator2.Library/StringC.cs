using System;
using System.Linq;

namespace StringCalculator2.Library
{
    public static class StringC
    {
        public static int Add(string numbers)
        {
            if (numbers.Contains(","))
            {
                return numbers.Split(",").Sum(Convert.ToInt32);
            }
            
            if (numbers.Length == 1)
            {
                return Convert.ToInt32(numbers);
            }
            
            return 0;
        }
    }
}