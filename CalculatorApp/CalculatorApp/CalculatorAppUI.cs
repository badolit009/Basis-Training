using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorAppUI : Form
    {
        Calculator aCalculator = new Calculator();
        private double secondNo;
        private double firstNo;
        private double result;

        public CalculatorAppUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //aCalculator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            //aCalculator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

            //double firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            //double secondNo = Convert.ToDouble(secondNumberTextBox.Text);
            //aCalculator.firstNumber = firstNo;
            //aCalculator.secondNumber = secondNo;
            //aCalculator.Add(firstNo, secondNo);
            //resultTextBox.Text = aCalculator.result.ToString();

            InitializeFistNoAndSeconNo();
            result = aCalculator.Add(firstNo,secondNo);
            resultTextBox.Text = result.ToString();


        }

        private void InitializeFistNoAndSeconNo()
        {
            firstNo = Convert.ToDouble(firstNumberTextBox.Text);
            secondNo = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFistNoAndSeconNo();
            result = aCalculator.Subtract(firstNo,secondNo);
            resultTextBox.Text = result.ToString();


        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeFistNoAndSeconNo();
            result = aCalculator.Multiply(firstNo,secondNo);
            resultTextBox.Text = result.ToString();
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            InitializeFistNoAndSeconNo();
            result = aCalculator.Devide(firstNo,secondNo);
            resultTextBox.Text = result.ToString();
        }
    }
}
