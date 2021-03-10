using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopRevisited
{
    public partial class Form1 : Form
    {
        private List<Customer> customers;
        private OrdersHandler ordersHandler;
        private Order currentOrder;

        public Form1()
        {
            InitializeComponent();
            customers = new List<Customer>();
            ordersHandler = new OrdersHandler();
            tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void pbxClose_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pbxMinimize_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbxMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pbxClose_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            tabControlPdAndCustomers.SelectedTab = tabPageNewCustomer;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "")
            {
                MessageBox.Show("Please fill in your names!");
            }
            else if (tbEmail.Text == "")
            {
                var newCustomer = new Customer(tbFirstName.Text, tbLastName.Text);
                customers.Add(newCustomer);
                MessageBox.Show("Succsesfully added");
                tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                tbFirstName.Text = "";
                tbLastName.Text = "";
                UpdateCbxCustomers();
                WriteData();
            }
            else
            {
                try
                {
                    var newCustomer = new Customer(tbFirstName.Text, tbLastName.Text, tbEmail.Text);
                    customers.Add(newCustomer);
                    MessageBox.Show("Succsesfully added");
                    tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                    tbFirstName.Text = "";
                    tbLastName.Text = "";
                    tbEmail.Text = "";
                    UpdateCbxCustomers();
                    WriteData();
                }
                catch (WrongEmailException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btEditExistingCustomer_Click(object sender, EventArgs e)
        {
            if (cbxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select customer!");
            }
            else
            {
                var currentCustomer = GetCurrentCustomerId();
                tbEditFirstName.Text = currentCustomer.GetCustomerName().Split().ToArray()[0];
                tbEditLastName.Text = currentCustomer.GetCustomerName().Split().ToArray()[1];
                tbEditEmail.Text = currentCustomer.Email;


                tabControlPdAndCustomers.SelectedTab = tabPageEditCustomer;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var currentCustomer = GetCurrentCustomerId();

            if (tbEditFirstName.Text == "" || tbEditLastName.Text == "")
            {
                MessageBox.Show("Please fill in your names!");
            }
            else if (tbEditEmail.Text == "")
            {
                currentCustomer.EditCustomerData(tbEditFirstName.Text, tbEditLastName.Text);
                MessageBox.Show("Succsesfully updated!");
                tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                tbEditFirstName.Text = "";
                tbEditLastName.Text = "";
                var selectedIndex = cbxCustomers.SelectedIndex;
                UpdateCbxCustomers();
                cbxCustomers.SelectedIndex = selectedIndex;
                tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                WriteData();

            }
            else
            {
                try
                {
                    currentCustomer.EditCustomerData(tbFirstName.Text, tbLastName.Text, tbEmail.Text);
                    MessageBox.Show("Succsesfully updated!");
                    tabControlPdAndCustomers.SelectedTab = tabPagePizzaAndDrinks;
                    tbEditFirstName.Text = "";
                    tbEditLastName.Text = "";
                    tbEditEmail.Text = "";
                    UpdateCbxCustomers();
                    WriteData();
                }
                catch (WrongEmailException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateCbxCustomers()
        {
            cbxCustomers.Items.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                cbxCustomers.Items.Add($"{customers[i].GetCustomerId()} {customers[i].GetCustomerName()}");
            }
        }

        private void cbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btNewOrder_Click(object sender, EventArgs e)
        {
            if (cbxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select customer first!");
            }
            else
            {
                cbxCustomers.Enabled = false;
                lbxReceipt.Items.Clear();
                var currentCustomer = GetCurrentCustomerId();
                currentOrder = new Order(currentCustomer);
                tabControlPdAndCustomers.SelectedTab = tabPagePizzaAndDrinks;
            }
        }

        private Customer GetCurrentCustomerId()
        {
            if (cbxCustomers.SelectedItem.ToString() != "")
            {
                var customerId = int.Parse(cbxCustomers.SelectedItem.ToString().Split(' ').ToArray()[0]);
                Customer currentCustomer = null;
                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].GetCustomerId() == customerId)
                    {
                        currentCustomer = customers[i];
                    }
                }
                return currentCustomer;
            }
            else
            {
                MessageBox.Show("Try again!");
            }
            return null;
        }

        private void btAddPizza_Click(object sender, EventArgs e)
        {
            PizzaType pizzaType = PizzaType.Margherita;
            bool selected = true;
            string topping = "";
            switch (lbxPizzas.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please select Pizza!");
                    selected = false;
                    break;
                case 0:
                    pizzaType = PizzaType.Margherita;
                    break;
                case 1:
                    pizzaType = PizzaType.QuattroFormaggi;
                    break;
                case 2:
                    pizzaType = PizzaType.QuattroStagioni;
                    break;
                case 3:
                    pizzaType = PizzaType.Pepperoni;
                    break;
                case 4:
                    pizzaType = PizzaType.BbqChicken;
                    break;
                default:
                    break;
            }
            if (rbNone.Checked)
            {
                topping = "";
            }
            else if (rbThick.Checked)
            {
                topping = "thick";
            }
            else if (rbFilled.Checked)
            {
                topping = "filled";
            }
            if (selected)
            {
                if (lbxReceipt.Items.Count == 0)
                {
                    PrintReceipt(ordersHandler.StartPrint());
                }


                var pizza = new Pizza(pizzaType, topping);
                var pizzaQuantity = int.Parse(tbPizzaQuantity.Text);
                for (int i = 0; i < pizzaQuantity; i++)
                {
                    currentOrder.AddPizza(pizza);
                }
                var pizzasTotalCost = pizza.price * pizzaQuantity;
                PrintReceipt(ordersHandler.PizzaPrint(pizza.name, pizzaQuantity, pizzasTotalCost));
                lblCurrentPrice.Text = $"Current price : {currentOrder.GetOrderTotalCost():f2}";
                tbPizzaQuantity.Text = "1";
            }


        }

        private void PrintReceipt(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lbxReceipt.Items.Add(list[i]);
            }
        }

        private void btAddDrink_Click(object sender, EventArgs e)
        {
            DrinkType drinkType = DrinkType.Cola;
            bool selected = true;
            switch (lbxDrinks.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please select Drink!");
                    selected = false;
                    break;
                case 0:
                    drinkType = DrinkType.FlatWater;
                    break;
                case 1:
                    drinkType = DrinkType.SparklingWater;
                    break;
                case 2:
                    drinkType = DrinkType.Cola;
                    break;
                case 3:
                    drinkType = DrinkType.IceTea;
                    break;
                case 4:
                    drinkType = DrinkType.EnergyDrink;
                    break;
                default:
                    break;
            }
            if (lbxReceipt.Items.Count == 0)
            {
                PrintReceipt(ordersHandler.StartPrint());
            }
            if (selected)
            {
                var currentDrink = new Drink(drinkType);
                var drinkQuantity = int.Parse(tbDrinkQuantity.Text);
                for (int i = 0; i < drinkQuantity; i++)
                {
                    currentOrder.AddDrink(currentDrink);
                }
                var pizzasTotalCost = currentDrink.price * drinkQuantity;
                PrintReceipt(ordersHandler.PizzaPrint(currentDrink.name, drinkQuantity, pizzasTotalCost));
                lblCurrentPrice.Text = $"Current price : {currentOrder.GetOrderTotalCost():f2}";
                tbDrinkQuantity.Text = "1";
            }


        }

        private void btnPlusPizza_Click(object sender, EventArgs e)
        {
            var plusOne = int.Parse(tbPizzaQuantity.Text) + 1;
            tbPizzaQuantity.Text = plusOne.ToString();

        }

        private void btnMinusPizza_Click(object sender, EventArgs e)
        {
            var minusOne = int.Parse(tbPizzaQuantity.Text) - 1;
            if (minusOne == 0)
            {
                MessageBox.Show("The quantity cannot be zero");
            }
            else
            {
                tbPizzaQuantity.Text = minusOne.ToString();
            }

        }

        private void btDrinkPlus_Click(object sender, EventArgs e)
        {
            var plusOne = int.Parse(tbDrinkQuantity.Text) + 1;
            tbDrinkQuantity.Text = plusOne.ToString();
        }

        private void btDrinkMinus_Click(object sender, EventArgs e)
        {
            var minusOne = int.Parse(tbDrinkQuantity.Text) - 1;
            if (minusOne == 0)
            {
                MessageBox.Show("The quantity cannot be zero");
            }
            else
            {
                tbDrinkQuantity.Text = minusOne.ToString();
            }
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder.GetOrderTotalCost() == 0.00)
            {
                MessageBox.Show("You must add atleast one item!");
            }
            else
            {
                var currentCustomer = GetCurrentCustomerId();
                ordersHandler.AddOrder(currentOrder);
                ordersHandler.AddRevenue(currentOrder.GetOrderTotalCost());
                PrintReceipt(ordersHandler.finishOrder(currentCustomer, currentOrder));
                currentOrder = null;
                ClearOrderMenu();
                tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                cbxCustomers.SelectedIndex = -1;
                cbxCustomers.Enabled = true;

                MessageBox.Show("Order finished!");


            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            if (currentOrder.GetOrderTotalCost() == 0.00)
            {
                MessageBox.Show("Your order is empty!");
            }
            else
            {
                ClearOrderMenu();
                lbxReceipt.Items.Clear();

                var currentCustomer = GetCurrentCustomerId();
                currentOrder = new Order(currentCustomer);
                MessageBox.Show("Order reseted succesfully!");
                tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
                cbxCustomers.Enabled = true;
            }
        }

        private void ClearOrderMenu()
        {
            lblCurrentPrice.Text = "Current price : 00.00";
            lbxDrinks.SelectedIndex = -1;
            lbxPizzas.SelectedIndex = -1;
            tbDrinkQuantity.Text = "1";
            tbPizzaQuantity.Text = "1";
        }

        private void btEditOrderMenu_Click(object sender, EventArgs e)
        {
            tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
        }

        private void btRegisterOrderMenu_Click(object sender, EventArgs e)
        {
            tabControlPdAndCustomers.SelectedTab = tabPageEmpty;
        }

        private void btStatics_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm f2 = new StatisticsForm(customers, ordersHandler);
            f2.ShowDialog();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream("customers.txt", FileMode.OpenOrCreate, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                for (int i = 0; i < customers.Count; i++)
                {

                    streamWriter.WriteLine($"{customers[i].GetCustomerId()} {customers[i].GetCustomerName()} {customers[i].Email}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem with writing!");
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
        public void WriteData()
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream("customers.txt", FileMode.OpenOrCreate, FileAccess.Write);
                streamWriter = new StreamWriter(fileStream);

                for (int i = 0; i < customers.Count; i++)
                {
                    streamWriter.WriteLine($"{customers[i].GetCustomerId()} {customers[i].GetCustomerName()} {customers[i].Email}");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problem with writing!");
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }
        public void ReadData()
        {
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);
                streamReader = new StreamReader(fileStream);

                cbxCustomers.Items.Clear();

                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    if (line == "")
                    {
                        continue;
                    }
                    var lineToArray = line.Split().ToArray();
                    cbxCustomers.Items.Add(line);
                    try
                    {
                        customers.Add(new Customer(int.Parse(lineToArray[0]), lineToArray[1], lineToArray[2], lineToArray[3]));
                    }
                    catch (Exception)
                    {
                        customers.Add(new Customer(int.Parse(lineToArray[0]), lineToArray[1], lineToArray[2]));
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Problem with reading!");
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}
