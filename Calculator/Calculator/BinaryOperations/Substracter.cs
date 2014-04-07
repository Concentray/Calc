namespace Calculator.BinaryOperations
{
    public class Substracter : IBinaryOperation
    {
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}