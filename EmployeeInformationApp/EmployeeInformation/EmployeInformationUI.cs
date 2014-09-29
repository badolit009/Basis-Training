using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeSelary
{
    public partial class EmployeInformationUI : Form
    {
        public EmployeInformationUI()
        {
            InitializeComponent();
        }
        
        List<int> id = new List<int>();
        List<string> name = new List<string>();
        List<double> selary = new List<double>();
        List<string> address = new List<string>();


        


        private void saveButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.id = Convert.ToInt32(idTextBox.Text);
            employee.name = nameTextBox.Text;
            employee.selary = Convert.ToDouble(selaryTextBox.Text);
            employee.address = addressTextBox.Text;

            id.Add(employee.id);
            name.Add(employee.name);
            selary.Add(employee.selary);
            address.Add(employee.address);

            ListViewItem liv = new ListViewItem(employee.id.ToString());
            liv.SubItems.Add(employee.name);
            liv.SubItems.Add(employee.selary.ToString());
            liv.SubItems.Add(employee.address);
            listView1.Items.Add(liv);

            idTextBox.Text = "";
            nameTextBox.Text = "";
            selaryTextBox.Text = "";
            addressTextBox.Text = "";

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected=listView1.SelectedIndices[0];
            idTextBox.Text = id[selected].ToString();
            nameTextBox.Text=name[selected];
            selaryTextBox.Text=selary[selected].ToString();
            addressTextBox.Text=address[selected];
        }
    }
}
