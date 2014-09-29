using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileLocation = @"firstfile.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream afileStream = new FileStream(fileLocation,FileMode.Append);
            StreamWriter aWriter = new StreamWriter(afileStream);
            aWriter.WriteLine(enterNameTextBox.Text);
            aWriter.Close();
            enterNameTextBox.Text = "";

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream afileStream = new FileStream(fileLocation,FileMode.Open);
            StreamReader aReader = new StreamReader(afileStream);
            listBox1.Items.Clear();
            while(!aReader.EndOfStream)
            {
                string aLine = aReader.ReadLine();
                listBox1.Items.Add(aLine);
            }
            aReader.Close();
        }
    }
}
