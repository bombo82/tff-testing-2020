using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public static int Add(string text)
        {
            if (text.Length == 0) return 0;

            List<string> tokens = Tokenize(text);
            List<int> numbers = Convert(tokens);

            CheckNegatives(numbers);

            int sum = Sum(numbers);

            return sum;
        }

        private static void CheckNegatives(List<int> numbers)
        {
            List<int> negatives = new List<int>();
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negatives.Add(number);
                }
            }
            if (negatives.Count > 0)
            {
                throw new ArgumentException("Negatives not allowed: " + string.Join(", ", negatives));
            }
        }

        private static List<string> Tokenize(string text)
        {
            string[] separator = GetSeparator(text);
            string stringToTokenize = GetStringToTokenize(text);

            return stringToTokenize.Split(separator, StringSplitOptions.None).ToList();
        }

        private static string GetStringToTokenize(string text)
        {
            if (IsCustomSeparator(text))
            {
                text = text.Substring(4);
            }

            return text;
        }

        private static string[] GetSeparator(string text)
        {
            string[] separator;
            if (IsCustomSeparator(text))
            {
                separator = new string[1] { text.Substring(2, 1) };
            }
            else
            {
                separator = new string[] { ",", "/n" };
            }

            return separator;
        }

        private static bool IsCustomSeparator(string text)
        {
            return text.StartsWith("//");
        }

        private static int Sum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number > 1000)
                {
                    sum += 2;
                }
                else
                {
                    sum += number;
                }
            }

            return sum;
        }

        private static List<int> Convert(List<string> tokens)
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
