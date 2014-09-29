using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstViewPractice
{
    public partial class EmployeeSelaryUI : Form
    {
        private string fileLocation = @"employeeSalary.txt";

        public EmployeeSelaryUI()
        {
            InitializeComponent();
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string id = idTextBox.Text;
            string salary = salaryAmountTextBox.Text;
            string aRow = name + "," + id + "," + salary;

            FileStream aFilestream = new FileStream(fileLocation, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFilestream);
            aStreamWriter.Write(aRow);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            MessageBox.Show("File Has Been Saved");

        }

        private void showTextBox_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            //List<string> employeeList = new List<string>();
            listView1.Items.Clear();
            double totalSalary = 0;

            while (!aStreamReader.EndOfStream)
            {

                string aRow = aStreamReader.ReadLine();
                char[] separetor = {','};
                string[] employee = aRow.Split(separetor);
                ListViewItem item=new ListViewItem(employee[0]);
                item.SubItems.Add(employee[1]);
                item.SubItems.Add(employee[2]);
                listView1.Items.Add(item);
                totalSalary += Convert.ToDouble(employee[2]);

            }
            totalAmountTextBox.Text = totalSalary.ToString();
            aStreamReader.Close();
        }
    
}
}
