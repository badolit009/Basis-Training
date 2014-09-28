using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlanetName
{
    public partial class PlanetNameApp : Form
    {
        public PlanetNameApp()
        {
            InitializeComponent();
        }

        private void planetButton_Click(object sender, EventArgs e)
        {
            string planetName = PlanetComboBoxTextBox.Text;
            if(planetName=="Badol")
            {
                MessageBox.Show("He is pretty Boy");
                PlanetComboBoxTextBox.Text = "";

            }
            else if(planetName=="Foyez")
            {
                MessageBox.Show("He is good");
                PlanetComboBoxTextBox.Text = "";
            }
            else if(planetName=="Moshiur")
            {
                MessageBox.Show("He is Foxy Boy");
                PlanetComboBoxTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("I don't know who is this man");
                PlanetComboBoxTextBox.Text = "";
            }
        }
    }
}
