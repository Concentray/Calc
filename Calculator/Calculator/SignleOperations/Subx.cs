using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class Subx : ISingleOperation
    {
        public double Calculate(double first)
        {
            return (1/first);
        }
    }
}