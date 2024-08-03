using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.OrdinaryFactorial
{
    internal class OrdinsryFactorial
    {
        /// <summary>
        /// считаем  фактриал последовательно
        /// </summary>
        /// <param name="value1"> значение начала диаапазано</param>
        /// <param name="value2">значение конца диапазона</param>
        /// <param name="factorialTypesArrey">массив в который записываем результат вычислений</param>
       internal void Factorial(int value1, int value2, FactorialType[] factorialTypesArrey )
        {
            Dictionary<int, BigInteger> factorialDictionary = new Dictionary<int, BigInteger>();

            for (int i = value1; i< value2; i++) 
            {
                BigInteger FactorialNumber = 1;
                for (int j = 1; j < i; j++)
                {
                      FactorialNumber = FactorialNumber *(BigInteger)j;
                }
                factorialTypesArrey[i] = new FactorialType { FactorialKey = i, Factorial = FactorialNumber };
            }
        }
    }
}