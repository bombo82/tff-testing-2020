using System;

namespace StringCalculator
{
    public class StringCalculatorService
    {
        public static int Add(string text)
        {
            if (text.Length == 0) return 0;

            return int.Parse(text);
        }
    }
}
