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
                case "ln":
                    return new ln();
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                default:
                    throw new ArgumentException("Незивестный калькулятор","calc");
                }
         }

    }
}