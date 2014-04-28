using System;
using System.Runtime.Remoting.Channels;

namespace Calculator.BinaryOperations
{
    public static class BinaryOperationsFactory
    {
        public static IBinaryOperation CreateOperation(string calc)
        {
            switch (calc)
            {
                case "adder":
                    return new Adder();
                case "substracter":
                    return new Substracter();
                case "multiplayer":
                    return new Multiplayer();
                case "devider":
                    return new Devider();
                case "pow":
                    return new pow();
                case "power":
                    return new power();
                case "Percent":
                    return new percent();
                case "Log":
                    return new log();
                default:
                    throw new ArgumentException("Незивестный калькулятор","calc");
                }
         }

    }
}