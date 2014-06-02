using System;
using Calculator.BinaryOperations;
using Calculator.SignleOperations;
using NUnit.Framework;

namespace Calculator.Tests.BinaryOperations
{
   [TestFixture]
    public class AddedTests
    {
       [Test]
       public void AdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("adder");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(3,result);

       }

       [Test]
       public void SecondAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("substructer");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(1, result);

       }
       [Test]
       public void TrirdAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("devider");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(2, result);

       }
       [Test]
       public void FourthAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("multiplayer");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(2, result);

       }
       [Test]
       public void FifthAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("pow");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(2, result);

       }
       [Test]
       public void SixthAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("power");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(2, result);

       }
       [Test]
       public void SeventhAdderTest()
       {
           double first = 9;
           double second = 9;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("log");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(2, result);

       }
       [Test]
       public void EigthAdderTest()
       {
           double first = 2;
           double second = 1;
           IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation("percent");
           double result = calculator.Calculate(first, second);
           Assert.AreEqual(50, result);

       }
    }
}