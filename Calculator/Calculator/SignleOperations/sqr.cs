using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class sqr:ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,2);
        } 
    }
}
