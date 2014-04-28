using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.BinaryOperations
{
    public class percent:IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return ((second/first)*100);
        }
    }
}
