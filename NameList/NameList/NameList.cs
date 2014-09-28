using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameList
{
    public partial class NameList : Form
    {
        public NameList()
        {
            InitializeComponent();
        }

        List<string>addNumber=new List<string>();
        int count=0;
        int countLimit = 10;

        private void AddButton_Click(object sender, EventArgs e)
        {
           addNumber.Add(addTextBox.Text);
           label3.Text = Convert.ToString(++count);
           addTextBox.Text = "";
           //showListBox.Items.Clear();
           if (count == countLimit)
           {
               foreach (string aName in addNumber)
               {
                   showListBox.Items.Clear();
                   showListBox.Items.Add(aName);

               }
           }

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (string aName in addNumber)
            {
                showListBox.Items.Add(aName);
                total.Text = count.ToString();

            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            addTextBox.Text = "";
            label3.Text = "";
            total.Text = "";
            showListBox.Items.Clear();
            count = 0;
        }
    }
}
