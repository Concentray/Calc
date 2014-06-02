using System;
using Calculator.BinaryOperations;
using Calculator.SignleOperations;
using Calculator.SingleOperations;
using NUnit.Framework;

namespace Calculator.Tests.SignleOperations
{
    [TestFixture]
    public class AddedTests
    {
        [Test]
        public void AdderTest()
        {
            double first = 2;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Abso");
            double result = calculator.Calculate(first);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void SecondAdderTest()
        {
            double first = 1;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Cos");
            double result = calculator.Calculate(first);
            Assert.AreEqual(0.5403,result,0.0001);
        }
        [Test]
        public void ThirdAdderTest()
        {
            double first = 1;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Sin");
            double result = calculator.Calculate(first);
            Assert.AreEqual(0.8414,result,0.0001);
        }
        [Test]
        public void FourthAdderTest()
        {
            double first = 1;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Ctg");
            double result = calculator.Calculate(first);
            Assert.AreEqual(0.6420, result,0.0001);
        }
        [Test]
        public void FifthAdderTest()
        {
            double first = 1;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Tg");
            double result = calculator.Calculate(first);
            Assert.AreEqual(1.5574, result, 0.0001);
        }
        [Test]
        public void SixthAdderTest()
        {
            double first = 2;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("cube");
            double result = calculator.Calculate(first);
            Assert.AreEqual(8, result);
        }
        [Test]
        public void SeventhAdderTest()
        {
            double first = 8;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("CubeRoot");
            double result = calculator.Calculate(first);
            Assert.AreEqual(2, result);
        }
        [Test]
        public void EigthAdderTest()
        {
            double first = 10;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("lg");
            double result = calculator.Calculate(first);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void NinethAdderTest()
        {
            double first = 2.7;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("ln");
            double result = calculator.Calculate(first);
            Assert.AreEqual(0.9932, result,0.0001);
        }
        [Test]
        public void TehthAdderTest()
        {
            double first = 3;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("sqr");
            double result = calculator.Calculate(first);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void EleventhAdderTest()
        {
            double first = 9;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("sqrt");
            double result = calculator.Calculate(first);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void TwelwthAdderTest()
        {
            double first = 2;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Subx");
            double result = calculator.Calculate(first);
            Assert.AreEqual(0.5, result,0.1);
        }
        [Test]
        public void ThirteenthAdderTest()
        {
            double first = 5;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("Factorial");
            double result = calculator.Calculate(first);
            Assert.AreEqual(120, result);
        }
        [Test]
        public void FourteenthAdderTest()
        {
            double first = 2;
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation("x");
            double result = calculator.Calculate(first);
            Assert.AreEqual(100, result);
        }


    }

}