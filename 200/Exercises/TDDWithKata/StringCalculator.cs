using System;
using System.Text.RegularExpressions;

namespace TDDWithKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            int sum = 0;

            // empty string
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            // one string number
            if (int.TryParse(numbers, out int singleNum))
            {
                return singleNum;
            }

            // multiple string numbers with different delimiters
            string regex = @"-?\d+";

            MatchCollection cleanNumbers = Regex.Matches(numbers, regex);

            var negativeNumbers = new List<int>();

            foreach (Match match in cleanNumbers)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else if (number > 1000)
                    {
                        sum += 0;
                    }
                    else
                    {
                        sum += number;
                    }

                }
            }

            if (negativeNumbers.Count > 0)
            {
                string negativeNumberString = string.Join(", ", negativeNumbers);
                throw new ArgumentException($"negatives not allowed: {negativeNumberString}");
            }

            return sum;
        }
    }
}
