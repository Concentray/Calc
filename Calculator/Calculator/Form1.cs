﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BinaryOperations;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BinaryCalculate(string calc)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            IBinaryOperation calculator = BinaryOperationsFactory.CreateOperation(calc);
            ResultField.Text = calculator.Calculate(first, second).ToString();
        }
    
        private void PlusOper_Click(object sender, EventArgs e)
        {
            BinaryCalculate("adder");
        }

        private void MinusOper_Click(object sender, EventArgs e)
        {
           BinaryCalculate("substracter");
        }

        private void MultyOper_Click(object sender, EventArgs e)
        {
          BinaryCalculate("multiplayer");
        }

        private void DivOper_Click(object sender, EventArgs e)
        {
          BinaryCalculate("devider"); 
        }

    }
}
