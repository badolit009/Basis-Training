using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employeesalaryexample
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        List<int> idList= new List<int>();
        List<string> namelist=new List<string>();
        List<double> selaryList = new List<double>();
        List<string>addressList=new List<string>();
        private void saveTextBox_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(idTextBox.Text);
            string name=nameTextBox.Text;
            double selary=Convert.ToDouble(selaryTextBox.Text);
            string address=addressTextBox.Text;

            idList.Add(id);
            namelist.Add(name);
            selaryList.Add(selary);
            addressList.Add(address);

            idTextBox.Text = "";
            nameTextBox.Text = "";
            selaryTextBox.Text = "";
            addressTextBox.Text = "";

            ListViewItem items = new ListViewItem(id.ToString());
            items.SubItems.Add(name);
            items.SubItems.Add(selary.ToString());
            items.SubItems.Add(address);
            listView1.Items.Add(items);


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selected = listView1.SelectedIndices[0];
            idTextBox.Text = idList[selected].ToString();
            nameTextBox.Text=namelist[selected];
            selaryTextBox.Text=selaryList[selected].ToString();
            addressTextBox.Text=addressList[selected];
        }
    }
}
