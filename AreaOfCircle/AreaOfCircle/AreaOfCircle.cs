﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AreaOfCircle
{
    public partial class AreaOfCircle : Form
    {
        public AreaOfCircle()
        {
            InitializeComponent();
        }
        const double pi =3.1416;
        double redius = 0;
        double area;
        private void button1_Click(object sender, EventArgs e)
        {
            redius = Convert.ToDouble(rediasTextBox.Text);
            area = pi * redius * redius;
            areaTextBox.Text = area.ToString();
        }
    }
}
