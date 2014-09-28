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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double firstName,lastName,result;
        
        private void addButton_Click(object sender, EventArgs e)
        {
            firstName = Convert.ToInt32(FirstNameTextBox.Text);
            lastName = Convert.ToInt32(LastNameTextBox.Text);
            result = firstName + lastName;
            ResultTextBox.Text = result.ToString();

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstName = Convert.ToInt32(FirstNameTextBox.Text);
            lastName = Convert.ToInt32(LastNameTextBox.Text);
            result = firstName - lastName;
            ResultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstName = Convert.ToInt32(FirstNameTextBox.Text);
            lastName = Convert.ToInt32(LastNameTextBox.Text);
            result = firstName * lastName;
            ResultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstName = Convert.ToInt32(FirstNameTextBox.Text);
            lastName = Convert.ToInt32(LastNameTextBox.Text);
            result = firstName / lastName;
            ResultTextBox.Text = result.ToString();
        }
    }
}
