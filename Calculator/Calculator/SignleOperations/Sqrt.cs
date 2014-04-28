using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class sqrt : ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
