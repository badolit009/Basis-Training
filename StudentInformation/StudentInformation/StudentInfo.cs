using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentInfo : Form
    {
        private Student aStudent = new Student();
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.id = regiNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            regiNoTextBox.Text = string.Empty;
            firstNameTextBox.Text=string.Empty;
            lastNameTextBox.Text = string.Empty;
            MessageBox.Show(aStudent.firstName+""+aStudent.lastName+"Your Registration No Is : "+aStudent.id);


        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regiNoTextBox.Text = aStudent.id;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }
    }
}
