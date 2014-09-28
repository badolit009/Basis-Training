using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShowListNumber
{
    public partial class ShowListNumber : Form
    {
        public ShowListNumber()
        {
            InitializeComponent();
        }

        int itemNumber = 0;
        int showListNumber=0;

        private void addButton_Click(object sender, EventArgs e)
        {
            itemNumber = Convert.ToInt32(itemnumberTextBox.Text);
            showListNumber = Convert.ToInt32(showListBox.Items.Add(itemnumberTextBox.Text));
            //itemNumber++;
            itemnumberTextBox.Text = "";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Number: "+showListNumber);
        }

        public int intemNumber { get; set; }
    }
}
