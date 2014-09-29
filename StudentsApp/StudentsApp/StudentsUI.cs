using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsApp
{
    public partial class StudentsUI : Form
    {
        private List<Student> studentList = new List<Student>();
        public StudentsUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.regNo = regiNoTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            studentList.Add(aStudent);
            MessageBox.Show("Your Data Has Been Saved");

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string names = "regNo\tFullname ";
            foreach (Student stu in studentList)
            {
                names +="\n"+ stu.regNo+"\t"+stu.GetFullName()+"\n";
            }
            MessageBox.Show(names);
        }

    }
}
