
using ParallelCalculationFactorial.FactorialParallelPLINQ;
using ParallelCalculationFactorial.FactorialParallelTreads;
using ParallelCalculationFactorial.OrdinaryFactorial;
using System.Diagnostics;
using System.Numerics;

Stopwatch stopWatch = new Stopwatch();

// обычное вычисление факториала без применения распоралелливания и доп потоков
stopWatch.Start();
OrdinsryFactorial factorial = new OrdinsryFactorial();
FactorialType[] factorialTypesArrey = new FactorialType[4000];
factorial.Factorial(1, 4000, factorialTypesArrey);
stopWatch.Stop();
TimeSpan NormalTime = stopWatch.Elapsed;
stopWatch.Reset();

// каждый факториал считается в отдельном потоке
stopWatch.Start();
FactorialParallelTreads factorialParallelTreads = new FactorialParallelTreads();
factorialParallelTreads.FactorialParallel(1, 4000);
stopWatch.Stop();
TimeSpan TreadsTime = stopWatch.Elapsed;
stopWatch.Reset();

// факториала считаются параллельно
  stopWatch.Start();
  FactorialParallelPLINQ factorialParallelPLINQ = new FactorialParallelPLINQ();
  factorialParallelPLINQ.FactorialForPlinq(1, 4000);
  stopWatch.Stop();
  TimeSpan PLINQTime = stopWatch.Elapsed;
  stopWatch.Reset();




Console.WriteLine("Среда выполнения Windows 11 64 разрядная, SDK NET 8, процессор Intel Pentium 7505");
Console.WriteLine($"Время вычисления факториалов (для чисел от 1 до 4000) в последовательном коде (цикл for) {NormalTime.TotalMilliseconds} милисикунд  ");
Console.WriteLine($"Время вычисления факториалов (для чисел от 1 до 4000) для каждого факториала в отдельном потоке - параллельное вычисление {TreadsTime.TotalMilliseconds} милисикунд   ");
Console.WriteLine($"Время вычисления факториалов (для чисел от 1 до 4000) с применением  Parallel.For  {PLINQTime.TotalMilliseconds} милисикунд  ");





