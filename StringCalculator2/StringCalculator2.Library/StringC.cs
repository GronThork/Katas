using System;
using System.Diagnostics;
using System.Linq;

namespace StringCalculator2.Library
{
    public static class StringC
    {
        public static int Add(string numbers)
        {
            char[] delimiters;

            if (numbers.StartsWith("\\"))
            {
                delimiters = new[] {Convert.ToChar(numbers.Substring(1, 1))};

                numbers = delimiters.First() == '\n' ? 
                    numbers.Substring(numbers.LastIndexOf("\n\n") + 2) : 
                    numbers.Substring(numbers.LastIndexOf('\n') + 1);
            }
            else
            {
                delimiters = new[] {',', '\n'};
            }
            
            return numbers.Length switch
            {
                0 => 0,
                1 => Convert.ToInt32(numbers),
                _ => numbers.Split(delimiters).Sum(Convert.ToInt32)
            };
        }
    }
}