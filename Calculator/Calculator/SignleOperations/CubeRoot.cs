﻿using System;
using Calculator.SingleOperations;

namespace Calculator.SignleOperations
{
    public class CubeRoot:ISingleOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,(1.0/3));
        }
    }
}