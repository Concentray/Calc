using System;
namespace Calculator.Sorts
{
    public static class SortOperationFactory
    {
        public static ISort Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Qsort":
                    return new Qsort();
                case "InsertionSort":
                    return new InsertionSort;
                case "Pozyrek":
                    return new Pozyrek;
                case "SelectionSort":
                    return new SelectionSort;
                default:
                    throw new ArgumentException("Пиши правильно!","calculatorName");
            }
        }
    }
}