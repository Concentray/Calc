using System;
using System.Security.Cryptography.X509Certificates;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class lg : ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Log10(first);
        }
    }
}
