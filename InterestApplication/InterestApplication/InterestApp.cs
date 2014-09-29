using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestApplication
{
    public partial class InterestApp : Form
    {
        public InterestApp()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            double principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
            double interestPercent = Convert.ToDouble(interestPercentTextBox.Text);
            double timePeriod = Convert.ToDouble(timePeriodTextBox.Text);

            double interest = (principalAmount*(interestPercent/100));

            totalAmountTextBox.Text = (principalAmount + (interest*timePeriod)).ToString();
        }
    }
}
