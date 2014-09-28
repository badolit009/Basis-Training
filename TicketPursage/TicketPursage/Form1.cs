using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketPursage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string customerName="";
        int numberOfTicket=0;
        double total=0;
        double unitPrice = 10;
       
        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            customerName = customerNameTextBox.Text;
            numberOfTicket =Convert.ToInt32 (numberOfticketTextBox.Text);
            total = unitPrice*numberOfTicket;
            customerNameTextBox.Text = "";
            numberOfticketTextBox.Text = "";
            
             
            MessageBox.Show(customerName+" Please Pay: "+total+" for purshes "+ numberOfTicket +" ticket");
            detailsButton.Enabled = true;


        }

        public string numberOfTicke { get; set; }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Customer Name: "+customerName+"\n Unit Price: "+unitPrice+"\n Total Price: "+total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            detailsButton.Enabled = false;
        }
    }
}
