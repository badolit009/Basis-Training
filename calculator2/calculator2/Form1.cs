using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNumber = 0;
        double lastName = 0;
        double result;


        private void button1_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(fistNumberTextBox.Text);
            lastName = Convert.ToDouble(LastNameTextBox.Text);
            result = firstNumber + lastName;
            resultTextBox.Text = Convert.ToString(result);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(fistNumberTextBox.Text);
            lastName = Convert.ToDouble(LastNameTextBox.Text);
            result = firstNumber - lastName;
            resultTextBox.Text = Convert.ToString(result);

            
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(fistNumberTextBox.Text);
            lastName = Convert.ToDouble(LastNameTextBox.Text);
            result = firstNumber * lastName;
            resultTextBox.Text = Convert.ToString(result);

        }

        private void divideButton_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(fistNumberTextBox.Text);
            lastName = Convert.ToDouble(LastNameTextBox.Text);
            result = firstNumber / lastName;
            resultTextBox.Text = Convert.ToString(result);

        }
    }
}
