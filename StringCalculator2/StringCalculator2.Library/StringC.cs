using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator2.Library
{
    public class StringC
    {
        private string _numbers;
        private string[] _delimiters;
        
        public int Add(string numbers)
        {
            _numbers = numbers;
            
            if (_numbers.StartsWith("\\"))
            {
                DelimitersCalculator();
            }
            else
            {
                _delimiters = new[] {",", "\n"};
            }

            return _numbers.Length switch
            {
                0 => 0,
                1 => Convert.ToInt32(_numbers),
                _ => CheckForNegativeNumbers(_numbers, _delimiters).Select(int.Parse).ToArray().Where(x => x < 1000).Sum()
            };
        }

        private void DelimitersCalculator()
        {
            var (startIndex, endIndex) = IndexPairOfBrackets(_numbers);
            if (startIndex > 0 && endIndex > 0)
            {
                _delimiters = new[] {_numbers.Substring(startIndex, endIndex - startIndex)};
            }
            else
            {
                _delimiters = new[] {Convert.ToString(_numbers.Substring(1, 1))};
            }

            _numbers = _delimiters.First() == "\n"
                ? _numbers.Substring(_numbers.LastIndexOf("\n\n", StringComparison.Ordinal) + 2)
                : _numbers.Substring(_numbers.LastIndexOf('\n') + 1);
        }

        private string[] CheckForNegativeNumbers(string numbers, string[] delimiters)
        {
            var numbersToSum = numbers.Split(delimiters,StringSplitOptions.None);
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