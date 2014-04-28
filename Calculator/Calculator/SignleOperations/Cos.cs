using System;
using System.Security.Cryptography.X509Certificates;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class Cos:ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
