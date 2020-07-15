using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> calculate(int number)
        {
            if (number <= 0) throw new InvalidOperationException();

            List<int> lists = new List<int>();

            int value = 2;
            while (value <= number)
            {
                if (number % value == 0)
                {
                    lists.Add(value);
                    number /= value;
                } else
                {
                    value++;
                }
            }

            return lists;
        }
    }
}
