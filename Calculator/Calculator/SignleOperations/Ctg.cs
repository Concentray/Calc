using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
        public class Ctg:ISingleOperation
        {
            public double Calculate(double first)
            {
                return 1/Math.Tan(first);
            }
        } 
    
}