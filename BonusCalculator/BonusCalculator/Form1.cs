using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BonusCalculator
{
    public partial class BonusCulculator : Form
    {
        public BonusCulculator()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            int selary = Convert.ToInt32(selaryTextBox.Text);
            if (10000 <= selary)
            {
                MessageBox.Show("he get:"+(selary/100)*5);
            }
            else if(10000>=8000)
            {
                MessageBox.Show("he get: "+(selary/100)*6);
            }
            else if (8000 >= 6000)
            {
                MessageBox.Show("he get: " + (selary / 100) * 7);
            }
            else
            {
                MessageBox.Show("he is null");
            }

        }
    }
}
