using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Adder adder = new Adder();
            ResultField.Text = adder.Calculate(first, second).ToString();
        }

        private void MinusOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first - second).ToString();
            Substracter substracter = new Substracter();
            ResultField.Text = substracter.Calculate(first, second).ToString();
        }

        private void MultyOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first * second).ToString();
            Multiplayer Multiplayer = new Multiplayer();
            ResultField.Text = Multiplayer.Calculate(first, second).ToString();
        }

        private void DivOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first / second).ToString();
            Devider Devider = new Devider();
            ResultField.Text = Devider.Calculate(first, second).ToString();
        }

    }
}
