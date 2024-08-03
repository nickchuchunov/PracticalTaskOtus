using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.FactorialParallelTreads
{
    internal class Factorial
    {
        internal void FactorialAddConcurrentDictionary(int value, ConcurrentDictionary<int, BigInteger> dictionary)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= value; i++)
            {
                factorial *= (BigInteger)i;
                dictionary.TryAdd(i, factorial);
            }

        }
    }
}
