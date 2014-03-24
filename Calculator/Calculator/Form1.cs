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
            ResultField.Text = (first + second).ToString();
        }

        private void MinusOper_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(FirstField.Text);
            double second = Convert.ToDouble(SecondField.Text);
            ResultField.Text = (first - second).ToString();
        }

    }
}
