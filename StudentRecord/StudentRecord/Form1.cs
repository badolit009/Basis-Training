using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CSVLib;

namespace StudentRecord
{
    public partial class Form1 : Form
    {
        public string fileLocation = @"StudentRecord";
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            FileStream aStreamForRead = new FileStream(fileLocation,FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aStreamForRead) ;
            List<string> aRecord = new List<string>();

            while (aReader.ReadRow(aRecord))
            {
                String regiNo = aRecord[0];
                if (registrationNoTextBox.Text == regiNo[0].ToString())
                {
                    MessageBox.Show("Registration Number Doesn't Exist");
                    aStreamForRead.Close();
                        return;
                }
                
                
            }


            FileStream aFileStream = new FileStream(fileLocation ,FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter((aFileStream));
            List<string> studentRecord = new List<string>();
            studentRecord.Add(registrationNoTextBox.Text);
            studentRecord.Add(nameTextBox.Text);
            aWriter.WriteRow(studentRecord);
            aFileStream.Close();

            
        }
    }
}
