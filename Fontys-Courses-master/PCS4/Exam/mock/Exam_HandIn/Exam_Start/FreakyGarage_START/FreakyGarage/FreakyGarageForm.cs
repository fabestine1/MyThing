using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreakyGarage
{
    public partial class FreakyGarageForm : Form
    {
        private Garage myGarage; // the garage that has a list of cars for sale

        private FortuneFritzForm frmF;
        private BudgetBobForm frmB;
        private LinkedListForTestDrives linkedListForTestDrives;

        public FreakyGarageForm()
        {
            InitializeComponent();
            this.frmF = new FortuneFritzForm(); // the window for Fortune Fritz
            this.frmB = new BudgetBobForm(); // the window for Budget Bob
            this.myGarage = new Garage("Freaky Garage");
            myGarage.FerrariUpdate += frmF.showFerrari;
            myGarage.Below5000Update += frmB.showCheapCar;
            addSomeTestingStuff();
            showAllCars();
            linkedListForTestDrives = new LinkedListForTestDrives();
        }

        private void showAllCars()
        {
            this.lbCarsForSale.Items.Clear();
            foreach (Car c in this.myGarage.getAllCars())
            {
                this.lbCarsForSale.Items.Add(c);
            }
        }

        private void btnSortYear_Click(object sender, EventArgs e)
        {
            this.myGarage.sortByYear();
            showAllCars();
        }

        private void btnSortBrandTypePrice_Click(object sender, EventArgs e)
        {
            this.myGarage.sortByBrandTypeAndPrice();
            showAllCars();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string brand = tbBrand.Text;
            string car_type = tbType.Text;
            int year = Convert.ToInt32(tbManufacturingYear.Text);
            int price = Convert.ToInt32(tbPrice.Text);
            Car c = new Car(brand, car_type, year, price);
            this.myGarage.addCar(c);
            showAllCars();
        }

        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            Car selectedCar = (Car)lbCarsForSale.SelectedItem;
            if (selectedCar != null)
            {
                int newPrice = Convert.ToInt32(tbNewPrice.Text);
                selectedCar.setCurrentPrice(newPrice);

                // Notify interested listeners of price change
                this.myGarage.NotifyListeners(selectedCar, "Price change");

                showAllCars();
            }
            else
            {
                MessageBox.Show("No car selected, please select a car from the list");
            }
        }

        private void btnAddTestDrive_Click(object sender, EventArgs e)
        {
            // To do: assignment 3
            Car selectedCar = (Car)lbCarsForSale.SelectedItem;
            if (selectedCar != null)
            {
                linkedListForTestDrives.addCarToList(selectedCar);
            }
            else
            {
                MessageBox.Show("No car selected, please select a car from the list");
            }
        }

        private void btnNrOfTestDrives_Click(object sender, EventArgs e)
        {
            // To do: assignment 3
            MessageBox.Show(linkedListForTestDrives.nrOfTestDrivesWithCarsOfBrand(tbBrandTestDrive.Text).ToString());
        }

        private void btnMaxPrice_Click(object sender, EventArgs e)
        {
            // To do: assignment 4
            MessageBox.Show(myGarage.getMaxPriceFerrari(myGarage.getAllCars().Count).ToString());
        }


        private void addSomeTestingStuff()
        {
            this.myGarage.addCar(new Car("Suzuki", "Baleno", 2004, 4995));
            this.myGarage.addCar(new Car("Suzuki", "Alto", 2000, 500));
            this.myGarage.addCar(new Car("Peugeot", "508", 2012, 15000));
            this.myGarage.addCar(new Car("Peugeot", "406", 2004, 800));
            this.myGarage.addCar(new Car("Ferrari", "Testarossa", 2008, 150000));
            this.myGarage.addCar(new Car("Lamborghini", "Countach", 2009, 390000));
            this.myGarage.addCar(new Car("Ferrari", "F12", 2010, 250000));
            this.myGarage.addCar(new Car("Renault", "Scenic", 2008, 5100));
            this.myGarage.addCar(new Car("Renault", "Laguna", 2000, 500));
            this.myGarage.addCar(new Car("Renault", "Laguna", 2003, 950));
            this.myGarage.addCar(new Car("Renault", "Laguna", 2004, 900));
        }

    }
}
