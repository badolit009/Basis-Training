using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductSortingApplication
{
    public partial class ProductShortingApp : Form
    {
        public ProductShortingApp()
        {
            InitializeComponent();
        }
        int i = 0;
        private void addTextBox_Click(object sender, EventArgs e)
        {
            string selectItem = selectComboBox.Text;
            double unitPrice = 0;

            switch (selectItem)
            {
                case "Asus":
                unitPrice=8000;
                break;
                    
                case "Dell":
                    unitPrice=8500;
                    break;

                case "HP":
                    unitPrice=9000;
                    break;

                case "Toshiba":
                    unitPrice=7000;
                    break;

            }

            int itemNumber=Convert.ToInt32( itemTextBox.Text);
            double totalPrice = unitPrice * itemNumber;
            label4.Text = Convert.ToString(totalPrice)+"/=";
            int counter = ++i;
            ListViewItem liv = new ListViewItem(counter.ToString());
            liv.SubItems.Add(selectItem);
            liv.SubItems.Add(unitPrice.ToString());
            liv.SubItems.Add(totalPrice.ToString());
            listView1.Items.Add(liv);
            
        }

    }
}
