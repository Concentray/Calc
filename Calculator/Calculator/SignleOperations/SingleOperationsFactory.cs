using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;
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
                case "Ctg":
                    return new Ctg();
                case "x":
                    return new x();
                case "CubeRoot":
                    return new CubeRoot();
                case "Subx":
                    return new Subx();
                case "Factorial":
                    return new Factorial();
                case "Abso":
                    return new Abso();
                default:
                    throw new ArgumentException("Незивестный калькулятор","calc");
                }
         }

    }
}