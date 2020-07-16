using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public static int Add(string text)
        {
            if (text.Length == 0)
            {
                return 0;
            }

            string[] delimiter = GetDelimiter(text);
            string[] tokens = Tokenizer(text, delimiter);
            List<int> numbers = ConvertToInteger(tokens);

            return numbers.Sum();
        }

        private static string[] Tokenizer(string text, string[] delimiter)
        {
            string numbersWithDelimiter = IsCustomDelimiter(text) ? text.Substring(4) : text;
            return numbersWithDelimiter.Split(delimiter, StringSplitOptions.None);
        }

        private static string[] GetDelimiter(string text)
        {
            return IsCustomDelimiter(text) ? new string[] { text.Substring(2, 1) } : new string[] { ",", "\n" };
        }

        private static bool IsCustomDelimiter(string text)
        {
            return text.StartsWith("//");
        }

        private static List<int> ConvertToInteger(string[] tokens)
        {
            List<int> numbers = new List<int>();
            foreach (string token in tokens)
            {
                numbers.Add(int.Parse(token));
            }

            return numbers;
        }
    }
}
