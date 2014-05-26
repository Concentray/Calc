using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class CubeRoot:ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow((double)first,1/3);
        }
    }
}