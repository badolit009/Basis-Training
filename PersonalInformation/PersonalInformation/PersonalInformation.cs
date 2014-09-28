using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }
        string FastName;
        string LastName;
        string FathersName;
        string MothersName;
        string Address;
        private void saveButton_Click(object sender, EventArgs e)
        {
            FastName = FastNameTextBox.Text;
            LastName = LastNameTextBox.Text;
            FathersName = FatherNameTextBox.Text;
            MothersName = MotherNameTextBox.Text;
            Address = AddressTextBox.Text;

            FastNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            FatherNameTextBox.Text = "";
            MotherNameTextBox.Text = "";
            AddressTextBox.Text = "";

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name = " +FastName +" "+LastName);
        }

        private void prantsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name:"+FathersName+"\n Mother's Name:");
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address:"+Address);
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name:"+FastName+"  "+LastName+"\n Father's Name:"+FathersName+"\n Mother's Name: "+MothersName+"\n Address: "+Address);
        }

        private void nameButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name = " + FastName + "  " + LastName);
        }

        private void prantsNameButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name:" + FathersName + "\n Mother's Name:"+MothersName);
        }

    }
}
