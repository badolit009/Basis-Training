using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserDefineType
{
    public partial class Form1 : Form
    {
        employee aemployee = new employee();
        public Form1()
        {
            InitializeComponent();
        }
        //int id;
        //string name;
        //double salary;

        private void showButton_Click(object sender, EventArgs e)
        {
            aemployee.id =Convert.ToInt32( idTextBox.Text);
            aemployee.name = nameTextBox.Text;
            aemployee.salary = Convert.ToDouble(salaryTextBox.Text);

            MessageBox.Show("Employee ID "+aemployee.id+"\nEmaployee Name "+aemployee.name+"\nEmployee Salary "+aemployee.salary);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = aemployee.id.ToString();
            nameTextBox.Text = aemployee.name;
            salaryTextBox.Text = aemployee.salary.ToString();
        }
    }
}
