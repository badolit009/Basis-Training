using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tryNumber
{
    public partial class EmployeeNumberUI : Form
    {
        public EmployeeNumberUI()
        {
            InitializeComponent();
        }
        string[] NameList=new string[5];
        int count=0;
        int setCount;

        private void addButton_Click(object sender, EventArgs e)
        { 
            NameList[count]=addTextBox.Text;
            showAllButton.Enabled = true;
            clearButton.Enabled = true;
            count++;
            countLevel.Text = count.ToString();
            addTextBox.Text = "";

            if (count == setCount)
            {
                addButton.Enabled = false;

                showListBox.Items.Clear();
                //foreach (string aName in NameList)
                //{
                //    showListBox.Items.Add(aName);

                //}
                for (int j = 0; j < count; j++)
                {
                    showListBox.Items.Add(NameList[j]);


                }
            }
      

            }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            for (int j = 0; j < count; j++)
            {
                showListBox.Items.Add(NameList[j]);


            }

            //foreach (string aName in NameList)
            //{
            //    showListBox.Items.Add(aName);

            //}

        
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            countLevel.Text = "";
            addButton.Enabled = true;
            setButton.Enabled = true;
            setTextBox.Text = "";
            count = 0;
            setCount = 0;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            showAllButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            setCount =Convert.ToInt32( setTextBox.Text);
            setTextBox.Text = "";
            addButton.Enabled = true;

        }


        }

}
