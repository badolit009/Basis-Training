using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerQueueManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        Queue<string> aQueue = new Queue<string>();
        

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            string serial = Convert.ToString(++count);
            string name = eNameTextBox.Text;
            string complain = eComplainTextBox.Text;
           
            aQueue.Enqueue(serial);
            aQueue.Enqueue(name);
            aQueue.Enqueue(complain);

            eNameTextBox.Text = "";
            eComplainTextBox.Text = "";

            ListViewItem liv = new ListViewItem(serial);
            liv.SubItems.Add(name);
            liv.SubItems.Add(complain);
            listView1.Items.Add(liv);


        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                dSerialNoTextBox.Text = aQueue.Dequeue();
                dNameTextBox.Text = aQueue.Dequeue();
                dComplainTextBox.Text = aQueue.Dequeue();
               
                listView1.Items.RemoveAt(0);


            }
            else
            {
                MessageBox.Show("You Have No Data In Queue");
            }
            
        }
    }
}
