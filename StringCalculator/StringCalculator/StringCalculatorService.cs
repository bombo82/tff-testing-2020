using System;

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

            string[] tokens = text.Split(",");
            if (tokens.Length == 2)
            {
                return int.Parse(tokens[0]) + int.Parse(tokens[1]);
            }

            return int.Parse(text);
        }
    }
}
