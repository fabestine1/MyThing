using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_ExtraPractical
{
    public partial class Form1 : Form
    {
        private Truck truck1;
        private Truck truck2;
        private Truck truck3;

        private Truck selectedTruck;
        private Label selectedTruckLetterAmountLabel;
        private Label selectedTruckSmallBoxAmountLabel;
        private Label selectedTruckMediumBoxAmountLabel;
        private Label selectedTruckLargeBoxAmountLabel;
        public Form1()
        {
            InitializeComponent();
            // Create and initialize the Truck objects here
            truck1 = new Truck();
            truck1.InitTruck("Truck 12-JKO-7");
            truck2 = new Truck();
            truck2.InitTruck("Truck 32-ABC-12");
            truck3 = new Truck();
            truck3.InitTruck("Truck 56-UWI-64");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (truckARadioButton.Checked == true)
            {
                selectedTruck = truck1;
                selectedTruckLetterAmountLabel = truckALetterAmountLabel;
                selectedTruckSmallBoxAmountLabel = truckASmallBoxAmountLabel;
                selectedTruckMediumBoxAmountLabel = truckAMediumBoxAmountLabel;
                selectedTruckLargeBoxAmountLabel = truckALargeBoxAmountLabel;
            }
            else if (truckBRadioButton.Checked == true)
            {
                selectedTruck = truck2;
                selectedTruckLetterAmountLabel = truckBLetterAmountLabel;
                selectedTruckSmallBoxAmountLabel = truckBSmallBoxAmountLabel;
                selectedTruckMediumBoxAmountLabel = truckBMediumBoxAmountLabel;
                selectedTruckLargeBoxAmountLabel = truckBLargeBoxAmountLabel;
            }
            else
            {
                selectedTruck = truck3;
                selectedTruckLetterAmountLabel = truckCLetterAmountLabel;
                selectedTruckSmallBoxAmountLabel = truckCSmallBoxAmountLabel;
                selectedTruckMediumBoxAmountLabel = truckCMediumBoxAmountLabel;
                selectedTruckLargeBoxAmountLabel = truckCLargeBoxAmountLabel;
            }
            if (selectedTruck.AddPackages(Convert.ToInt32(distanceNumericUpDown.Value), Convert.ToDouble(weightNumericUpDown.Value)))
            {
                selectedTruckLetterAmountLabel.Text = selectedTruck.Letter.TotalNumberPackages.ToString();
                selectedTruckSmallBoxAmountLabel.Text = selectedTruck.SmallBox.TotalNumberPackages.ToString();
                selectedTruckMediumBoxAmountLabel.Text = selectedTruck.MediumBox.TotalNumberPackages.ToString();
                selectedTruckLargeBoxAmountLabel.Text = selectedTruck.LargeBox.TotalNumberPackages.ToString();
            }
            else
            {
                MessageBox.Show("Package is not added!");
            }
        }

        private void truckAInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(truck1.GetInfo());
        }

        private void truckBInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(truck2.GetInfo());
        }

        private void truckCInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(truck3.GetInfo());
        }
    }
}
