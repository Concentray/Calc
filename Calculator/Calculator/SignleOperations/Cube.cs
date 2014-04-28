using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class cube:ISingleOperation
    {
        public double Calculate(double first)
        {
            return first*first*first;
        }
    }
}
