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
            int sum = Sum(numbers);

            return sum;
        }

        private static List<string> Tokenize(string text)
        {
            return text.Split(new string[] { ",", "/n" }, StringSplitOptions.None).ToList();
        }

        private static int Sum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
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
