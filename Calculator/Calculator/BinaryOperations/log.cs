using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BinaryOperations
{
    public class log:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
