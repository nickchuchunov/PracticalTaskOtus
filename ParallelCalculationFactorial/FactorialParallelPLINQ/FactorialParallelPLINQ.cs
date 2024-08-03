using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ParallelCalculationFactorial.OrdinaryFactorial;
using ParallelCalculationFactorial.FactorialParallelTreads;

namespace ParallelCalculationFactorial.FactorialParallelPLINQ
{
    internal class FactorialParallelPLINQ
    {
        FactorialType[] factorialTypesArrey; // записываем результат вычисления в массив 
        internal FactorialParallelPLINQ()
        {   
            

        }

      internal async void  FactorialForPlinq(int value1, int value2) 
        {
            factorialTypesArrey = new FactorialType[value2];
            OrderablePartitioner<Tuple<int, int>> t = Partitioner.Create(value1, value2, 10); //разделяем диапазон вычесления для патоков
            IList<IEnumerator<Tuple<int, int>>> t1 = t.GetPartitions(1);

            await Parallel.ForEachAsync(t1, async (item, cancellationToken) => { while (item.MoveNext()) { new OrdinsryFactorial().Factorial(item.Current.Item1, item.Current.Item2, factorialTypesArrey); } } ); //new OrdinsryFactorial().Factorial(item.Current.Item1, item.Current.Item2, factorialTypesArrey)

        }
    }
}
