using System;
using System.Collections.Generic;

namespace PrimeFactor.Service
{
    public class PrimeFactors
    {
        public static List<int> calculate(int number)
        {
            List<int> lists = new List<int>();
            if (number == 2)
            {
                lists.Add(2);
            }
            return lists;
        }
    }
}
