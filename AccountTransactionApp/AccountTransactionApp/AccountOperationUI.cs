using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountTransactionApp
{
    public partial class AccountOperationUI : Form
    {
        private Account anAccount;

        public AccountOperationUI()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (accountNumberTextBox.Text != string.Empty && customerNameTextBox.Text != string.Empty)
            {

                anAccount = new Account();
                anAccount.number = accountNumberTextBox.Text;
                anAccount.name = customerNameTextBox.Text;
                MessageBox.Show(@"Account Has Been Created");
            }
            else
            {
                MessageBox.Show(@"Plz Enter All Data");  
            }

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Deposit(amount);
                MessageBox.Show(@"Amount has been deposited");
            }
            else
            {
                MessageBox.Show(@"Plz Create Your Account First Now");
            }
            amountTextBox.Text = string.Empty;

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (anAccount != null)
            {
                double amount = Convert.ToDouble(amountTextBox.Text);
                anAccount.Withdraw(amount);
                MessageBox.Show(@"Amount has been withdraw");
            }
            else
            {
                MessageBox.Show(@"Plz Create Your Account First Now");
            }
            amountTextBox.Text = string.Empty;
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anAccount.name+", Your Account Number Is :"+anAccount.number+" and Its Balance Is : "+anAccount.balance);
        }

    }
}
