using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BinaryOperations
{
    public class power:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first,1/second);
        } 
    }
}
