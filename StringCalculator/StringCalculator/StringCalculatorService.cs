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

            string[] tokens = text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
            List<int> numbers = ConvertToInteger(tokens);

            return numbers.Sum();
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
