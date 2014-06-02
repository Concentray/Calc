using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class Abso : ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Abs(first);
        }
    }
}