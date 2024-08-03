using ParallelCalculationFactorial.OrdinaryFactorial;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.FactorialParallelTreads
{
    internal class FactorialParallelTreads // Вычисляем факториал в отдельном потоке 
    {

        FactorialType[] factorialType; // записываем результат вычисления в массив индекс массива это чило а значение FactorialType


        internal FactorialParallelTreads() { }
       

        internal void FactorialParallel(int value1, int value2)
        {
            factorialType = new FactorialType[value2];
            OrderablePartitioner<Tuple<int, int>> t = Partitioner.Create(value1, value2, 10); //разделяем диапазон вычесления для патоков
            IList<IEnumerator<Tuple<int, int>>> t1 = t.GetPartitions(1);

            foreach (IEnumerator<Tuple<int, int>> t2 in t1)
            {

                while (t2.MoveNext())
                {
                    Thread newThread = new Thread(() => new OrdinsryFactorial().Factorial(t2.Current.Item1, t2.Current.Item2 - 1, factorialType));
                    newThread.Start();
                }
            }
  
        }



      

    }
}
