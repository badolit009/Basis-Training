using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        Account aAccount = new Account();
        public Form1()
        {
            InitializeComponent();
        }

        private double total ;
        private void button1_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "" && nameTextBox.Text != "")
            {
                aAccount.accountNumber = numberTextBox.Text;
                aAccount.customerName = nameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Plz Enter All Data");
            }
            numberTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "")
            {
                aAccount.balance = Convert.ToDouble(amountTextBox.Text);
                aAccount.Deposit(aAccount.balance);
                total += aAccount.balance;
            }
            else
            {
                MessageBox.Show("Plz Enter Amount");
            }
            amountTextBox.Text = string.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (amountTextBox.Text != "")
            {
                aAccount.balance = Convert.ToDouble(amountTextBox.Text);
                aAccount.Withdraw(aAccount.balance);
                total -= aAccount.balance;
            }
            else
            {
                MessageBox.Show("Plz Enter Amount");
            }
            amountTextBox.Text = string.Empty;
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aAccount.GetNameAccount() +" It's Balance Is : "+total+" Taka");

        }

    }
}
