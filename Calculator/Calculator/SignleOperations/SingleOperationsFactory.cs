using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public static class SingleOperationsFactory
    {
        public static ISingleOperation CreateOperation(string calc)
        {
            switch (calc)
            {
                case "sqr":
                    return new sqr();
               
                default:
                    throw new ArgumentException("Незивестный калькулятор","calc");
                }
         }

    }
}