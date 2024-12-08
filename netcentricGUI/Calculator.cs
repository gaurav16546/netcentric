using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netcentricGUI
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(textBox1.Text);
            double input2 = Convert.ToDouble(textBox2.Text);
            string operation = (string)comboBox1.SelectedItem;

            try
            {
                MessageBox.Show($"The result is {CalculateOperation(input1, input2, operation)}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private double CalculateOperation(double input1, double input2, string operation)
        {
            switch (operation)
            {
                case "Add":
                    return input1 + input2;
                case "Subtract":
                    return input1 - input2;
                case "Multiply":
                    return input1 * input2;
                case "Division":
                    {
                        if(input2 == 0)
                        {
                            throw new DivideByZeroException("cannot divide by zero");
                        }
                        return input1/input2;
                    }
                default:
                    throw new InvalidOperationException($"Operation '{operation}' is not supported.");

            }
        }
    }
}
