using System;
using System.Security.Cryptography.X509Certificates;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class Tg:ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
