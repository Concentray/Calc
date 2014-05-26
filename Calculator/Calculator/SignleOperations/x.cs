using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
 public class x : ISingleOperation
        {
            public double Calculate(double first)
            {
                return Math.Pow(10,first);
            }
        } 
    
}