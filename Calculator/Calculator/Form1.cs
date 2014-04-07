using System;
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
        
        private void PlusOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            IBinaryOperation adder = BinaryOperationsFactory.CreateOperation("adder");
            ResultField.Text = adder.Calculate(first, second).ToString();
        }

        private void MinusOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first - second).ToString();
            IBinaryOperation substracter = BinaryOperationsFactory.CreateOperation("substracter");
            ResultField.Text = substracter.Calculate(first, second).ToString();
        }

        private void MultyOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first * second).ToString();
            IBinaryOperation multiplayer = BinaryOperationsFactory.CreateOperation("multiplayer");
            ResultField.Text = multiplayer.Calculate(first, second).ToString();
        }

        private void DivOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first / second).ToString();
            IBinaryOperation devider = BinaryOperationsFactory.CreateOperation("devider");
            ResultField.Text = devider.Calculate(first, second).ToString();
        }

    }
}
