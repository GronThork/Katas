using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

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
                _ => CheckForNegativeNumbers(numbers, delimiters).Select(int.Parse).ToArray().Where(x => x < 1000).Sum()
            };
        }

        private static string[] CheckForNegativeNumbers(string numbers, char[] delimiters)
        {
            var numbersToSum = numbers.Split(delimiters);
            var negativeNumbers = numbersToSum.Where(number => Convert.ToInt32(number) < 0).Aggregate<string, string>(null, (current, number) => current + number);

            if (negativeNumbers != null)
            {
                throw new Exception("negatives not allowed");
            }

            return numbersToSum;
        }

        public static bool ThereAreBrackets(string stringInput)
        {
            var startIndex = stringInput.IndexOf('[');
            var endIndex = stringInput.IndexOf(']');
            return startIndex > 0 && endIndex > 0;
        }
    }
}