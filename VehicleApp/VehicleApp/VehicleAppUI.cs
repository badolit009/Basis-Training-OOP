using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class VehicleAppUI : Form
    {
        public VehicleAppUI()
        {
            InitializeComponent();
        }

        private Vehicle aVehicle;
        private void createButton_Click(object sender, EventArgs e)
        {
            aVehicle = new Vehicle(vehicleNameTextBox.Text,regNoTextBox.Text);
            MessageBox.Show(@"Your Registration Has Been Created");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVehicle.GetSpeed(Convert.ToDouble(speedTextBox.Text));
            MessageBox.Show(@"Please Click Show Button");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            maximumTextBox.Text = aVehicle.Maximum.ToString();
            minimumTextBox.Text = aVehicle.Minimum.ToString();
            averageTextBox.Text = aVehicle.GetAverage().ToString();
        }
    }
}
