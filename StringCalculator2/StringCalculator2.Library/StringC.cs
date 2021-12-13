using System;
using System.Linq;

namespace StringCalculator2.Library
{
    public static class StringC
    {
        public static int Add(string numbers)
        {
            return numbers.Length switch
            {
                0 => 0,
                1 => Convert.ToInt32(numbers),
                _ => numbers.Split(',', '\n').Sum(Convert.ToInt32)
            };
        }
    }
}