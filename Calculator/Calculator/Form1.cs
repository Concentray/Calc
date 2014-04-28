using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.BinaryOperations;
using Calculator.SignleOperations;
using Calculator.SingleOperations;

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
        private void SignleCalculate(string calc)
        {
            double first = Convert.ToDouble(FirstField.Text,CultureInfo.InvariantCulture);
            ISingleOperation calculator = SingleOperationsFactory.CreateOperation(calc);
            ResultField.Text = calculator.Calculate(first).ToString();
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

        private void Pow_Click(object sender, EventArgs e)
        {
            BinaryCalculate("pow");
        }

        private void power_Click(object sender, EventArgs e)
        {
            BinaryCalculate("power");
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            SignleCalculate("sqr");
        }

        private void Cube_Click(object sender, EventArgs e)
        {
            SignleCalculate("cube");
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            SignleCalculate("sqrt");
        }

        private void lg_Click(object sender, EventArgs e)
        {
            SignleCalculate("lg");
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Percent");
        }

        private void log_Click(object sender, EventArgs e)
        {
            BinaryCalculate("Log");
        }

        private void ln_Click(object sender, EventArgs e)
        {
            SignleCalculate("ln");
        }

    }
}
