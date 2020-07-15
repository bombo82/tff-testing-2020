using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> calculate(int number)
        {
            List<int> lists = new List<int>();

            while(number > 1)
            {
                for (int value = 2; value <= 3; value++)
                {
                    if (number % value == 0)
                    {
                        lists.Add(value);
                        number /= value;
                    }
                }
            }
            return lists;
        }
    }
}
