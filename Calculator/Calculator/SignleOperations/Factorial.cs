using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class Factorial : ISingleOperation
    {
        public double Calculate(double first)
        {
            int n = 5; 
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i; 
                
            }
            return factorial;
        }
    } 
    
}