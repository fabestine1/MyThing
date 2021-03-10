using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppForCandyStore
{
    public partial class FormForCandyStore : Form
    {
        private Store myStore;
        private String[] namesPackedCandy; //the names of the packed candy
        private double[] pricesPackedCandy;//the corresponding prices of the packed candy
        private double pricePerKilogramMixedCandy;

        public FormForCandyStore()
        {
            InitializeComponent();
            this.myStore = new Store("Nikolay's candy store");
            this.Text = this.myStore.Name;
            this.addSomeData();

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //todo, assignment 3
            try
            {
                if (tbNameSalesperson.Text == "")
                {
                    MessageBox.Show("Enter a salesman name.");
                }
                else
                {
                    Candy candy = null;
                    if (rbPackedCandy.Checked)
                    {
                        if (Convert.ToInt32(tbNumberOfBags.Text) < 1)
                        {
                            MessageBox.Show("You should enter a number at least equal to 1");
                        }
                        else
                        {
                            candy = new PackedCandy(tbNameSalesperson.Text, namesPackedCandy[lbPackedCandy.SelectedIndex], pricesPackedCandy[lbPackedCandy.SelectedIndex], Convert.ToInt32(tbNumberOfBags.Text));
                        }
                    }
                    else
                    {
                        candy = new MixedCandy(tbNameSalesperson.Text, pricePerKilogramMixedCandy, Convert.ToInt32(tbWeightOfLollipops.Text), Convert.ToInt32(tbWeightOfChewingGums.Text), Convert.ToInt32(tbWeightOfGummyDrops.Text));
                    }
                    myStore.AddCandy(candy);
                }
            }
            catch (FormatException)
            {
                if (rbPackedCandy.Checked)
                {
                    if (tbNumberOfBags.Text == "")
                    {
                        tbNumberOfBags.Text = "1";
                        MessageBox.Show("You have to buy at least one bag.");
                    }
                }
                else if (tbWeightOfLollipops.Text == "" || tbWeightOfChewingGums.Text == "" || tbWeightOfGummyDrops.Text == "")
                {
                    MessageBox.Show("Enter a valid weight of all the three candies.");
                }
                else
                {
                    MessageBox.Show("Invalid input format!");
                }
            }
            catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("You didn't select a candy!");
                }
        }

        private void btnShowAllSoldCandy_Click(object sender, EventArgs e)
        {
            //todo, assignment 3
            lbOverview.Items.Clear();
            foreach (Candy candy in myStore.GetAllSoldCandy())
                {
                    lbOverview.Items.Add(candy.GetInfo());
                }
        }

        private void btnShowSoldMixedCandy_Click(object sender, EventArgs e)
        {
            //todo, assignment 3
            lbOverview.Items.Clear();
            foreach (Candy candy in myStore.GetSoldMixedCandy())
            {
                lbOverview.Items.Add(candy.GetInfo());
            }

        }

        private void btnShowWeightsMixedCandy_Click(object sender, EventArgs e)
        {
            //todo, assignment 3
            lbOverview.Items.Clear();
            int[] weights = myStore.GetWeightsMixedCandy();
            lbOverview.Items.Add("Total weight of lollipops of all sold mixed candies: " + weights[0]);
            lbOverview.Items.Add("Total weight of chewing gums of all sold mixed candies: " + weights[1]);
            lbOverview.Items.Add("Total weight of gummy drops of all sold mixed candies: " + weights[2]);

        }

        private void btnSaveInformationToFile_Click(object sender, EventArgs e)
        {
            //todo, assignment 3
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = null;
                    StreamWriter sw = null;
                    try
                    {
                        fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);
                        double[] profit = new double[2];

                        foreach (Candy candy in myStore.GetAllSoldCandy())
                        {
                            sw.WriteLine(candy.GetInfo());
                            if (candy is PackedCandy)
                            {
                                profit[0] += candy.GetPrice();
                            }
                            else
                            {
                                profit[1] += candy.GetPrice();
                            }
                        }
                        sw.WriteLine("****************totals****************");
                        sw.WriteLine("profit from packed candy is: " + profit[0] + Environment.NewLine + "profit from mixed candy is: " + profit[1]);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error writing to file: " + ex.Message);
                    }
                    finally
                    {
                        if(sw != null) sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Nothing is saved.");
                }
            }

        }

        //the methods below are already implemented
        private void addSomeData()
        {
            this.namesPackedCandy = new String[] { "Twix", "M&M", "Gummy bears", "Soft jelly beans", "Chocolate bars" };
            this.pricesPackedCandy = new double[] { 2.95, 1.90, 4.00, 3.50, 3.00 };
            this.showNamesAndPricesOfPackedCandy();

            this.pricePerKilogramMixedCandy = 12.00;
            this.gbMixedCandy.Text = "mixed candy, price per kilogram is " + this.pricePerKilogramMixedCandy.ToString("F2");

        }
        private void showNamesAndPricesOfPackedCandy()
        {
            this.lbPackedCandy.Items.Clear();
            String holder;
            for (int i = 0; i < this.namesPackedCandy.Length; i++)
            {
                holder = this.namesPackedCandy[i] + "- " + this.pricesPackedCandy[i].ToString("F2");
                this.lbPackedCandy.Items.Add(holder);
            }
        }
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (this.rbPackedCandy.Checked)
            { //change the price of the selected packed candy
                int index = this.lbPackedCandy.SelectedIndex;
                this.pricesPackedCandy[index] = Convert.ToDouble(tbPrice.Text);
                this.showNamesAndPricesOfPackedCandy();
            }
            else
            {//change the price for the mixed candy
                this.pricePerKilogramMixedCandy = Convert.ToDouble(tbPrice.Text);
                this.gbMixedCandy.Text = "mixed candy, price per kilogram is " + this.pricePerKilogramMixedCandy.ToString("F2");
            }
        }

    }
}
