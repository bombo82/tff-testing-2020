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

            List<string> tokens = text.Split(",").ToList();
            if (tokens.Count == 2)
            {
                return int.Parse(tokens[0]) + int.Parse(tokens[1]);
            }

            return int.Parse(text);
        }
    }
}
