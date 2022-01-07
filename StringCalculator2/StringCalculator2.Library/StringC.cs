using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator2.Library
{
    public class StringC
    {
        private string _numbers;
        private readonly List<string> _delimiters = new();
        
        public int Add(string numbers)
        {
            _numbers = numbers;
            
            DelimitersCalculator();
            
            return _numbers.Length switch
            {
                0 => 0,
                1 => Convert.ToInt32(_numbers),
                _ => CheckForNegativeNumbers(_numbers, _delimiters).Select(int.Parse).ToArray().Where(x => x < 1000).Sum()
            };
        }

        private void DelimitersCalculator()
        {
            if (_numbers.StartsWith("\\"))
            {
                var (startIndex, endIndex) = IndexPairOfBrackets(_numbers);
                if (startIndex > 0 && endIndex > 0)
                {
                    _delimiters.Add(_numbers.Substring(startIndex, endIndex - startIndex));
                }
                else
                {
                    _delimiters.Add(Convert.ToString(_numbers.Substring(1, 1)));
                }

                _numbers = _delimiters.First() == "\n"
                    ? _numbers.Substring(_numbers.LastIndexOf("\n\n", StringComparison.Ordinal) + 2)
                    : _numbers.Substring(_numbers.LastIndexOf('\n') + 1);
            }
            else
            {
                _delimiters.Add(",");
                _delimiters.Add("\n");
            }
        }

        private string[] CheckForNegativeNumbers(string numbers, List<string> delimiters)
        {
            var numbersToSum = numbers.Split(delimiters.ToArray(), StringSplitOptions.None);
            var negativeNumbers = numbersToSum.Where(number => Convert.ToInt32(number) < 0).Aggregate<string, string>(null, (current, number) => current + number);

            if (negativeNumbers != null)
            {
                throw new Exception("negatives not allowed");
            }

            return numbersToSum;
        }

        public (int,int) IndexPairOfBrackets(string stringInput)
        {
            var startIndex = stringInput.IndexOf('[') + 1;
            var endIndex = stringInput.IndexOf(']');
            return (startIndex,endIndex);
        }
    }
}