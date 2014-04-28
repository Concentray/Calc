using System;
using System.Drawing.Drawing2D;
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
                case "cube":
                    return new cube();
                case"sqrt":
                    return new sqrt();
                case"lg":
                    return new lg();
                default:
                    throw new ArgumentException("Незивестный калькулятор","calc");
                }
         }

    }
}