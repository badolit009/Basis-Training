using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaximumAndMinimumNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> number = new List<int>();

        private void maxNumberTexBox_Click(object sender, EventArgs e)
        {
            int firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            int secondNumber = Convert.ToInt32(secondNumberTextBox.Text);
            int thirdNumber = Convert.ToInt32(thirNumberTextBox.Text);
            int fourthNumber = Convert.ToInt32(fourthNumberTextBox.Text);
            int fifthNumber = Convert.ToInt32(fifthNumberTextBox.Text);

            number.Add(firstNumber);
            number.Add(secondNumber);
            number.Add(thirdNumber);
            number.Add(fourthNumber);
            number.Add(fifthNumber);
            number.Sort();

            firstNumberTextBox.Text = "";
            secondNumberTextBox.Text = "";
            thirNumberTextBox.Text = "";
            fourthNumberTextBox.Text = "";
            fifthNumberTextBox.Text = "";

            

            label6.Text= "Maximum Number Is : "+number[4].ToString();
            label7.Text = "";

        }

        private void minNumberTextBox_Click(object sender, EventArgs e)
        {
            label7.Text="Minimum Number Is : "+number[0].ToString();
            label6.Text = "";
        }
    }
}
