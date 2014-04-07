namespace Calculator.BinaryOperations
{
    public class Adder : IBinaryOperation
   {
       public double Calculate(double first, double second)
       {
           return first + second;
       }
   }
 }
