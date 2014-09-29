using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Salary aSalary = new Salary();
            aSalary.name = nameTextBox.Text;
            aSalary.basic =Convert.ToDouble(basicSalaryTextBox.Text);
            aSalary.houseRentPercent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);

            double total = aSalary.GetTotal();

            MessageBox.Show(aSalary.name+"Your Amount Is : "+total);

        }

    }
}
