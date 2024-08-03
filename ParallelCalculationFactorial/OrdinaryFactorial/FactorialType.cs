using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCalculationFactorial.OrdinaryFactorial
{
    public record class FactorialType
    {
     public int FactorialKey { get; set; }
     public BigInteger Factorial { get; set; }
    }
}
