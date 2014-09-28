using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingPercent
{
    public partial class BankingPercent : Form
    {
        public BankingPercent()
        {
            InitializeComponent();
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            double balance, year, interest;
            year = Convert.ToDouble(TimeTextBox.Text);
            balance  = Convert.ToDouble(BlanceTextBox.Text);
            if (comboBox1.Text == "BRAK")
            {
                interest = year*(balance*0.06);
                interestlabel.Text = interest.ToString();
            }
            else if (comboBox1.Text == "DBBL")
            {
                interest = year * (balance * 0.07);
                interestlabel.Text = interest.ToString();
                
            }
            else if (comboBox1.Text == "HSBC")
            {
                interest = year * (balance * 0.08);
                interestlabel.Text = interest.ToString();
            }
            
                

        
        }
    }
}
