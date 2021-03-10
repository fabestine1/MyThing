using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//for last assignment

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
            this.myStore = new Store("Bert's candy store");
            this.Text = this.myStore.Name;
            this.addSomeData();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbNameSalesperson.Text == "")
                {
                    MessageBox.Show("Please, type a name for the salesperson");
                }
                else
                {
                    Candy c;
                    if (rbMixedCandy.Checked)
                    {
                        c = new MixedCandy(this.tbNameSalesperson.Text,
                            this.pricePerKilogramMixedCandy,
                            Convert.ToInt32(this.tbWeightOfLollipops.Text),
                            Convert.ToInt32(this.tbWeightOfChewingGums.Text),
                            Convert.ToInt32(this.tbWeightOfGummyDrops.Text));
                    }
                    else
                    {
                        c = new PackedCandy(this.tbNameSalesperson.Text,
                            this.namesPackedCandy[this.lbPackedCandy.SelectedIndex],
                            this.pricesPackedCandy[this.lbPackedCandy.SelectedIndex],
                            Convert.ToInt32(this.tbNumberOfBags.Text));
                    }
                    this.myStore.AddCandy(c);
                }
            }
            catch (FormatException) { MessageBox.Show("Please, type a number"); }
            catch (IndexOutOfRangeException) { MessageBox.Show("Select a packed candy first"); }
        }

        private void btnShowAllSoldCandy_Click(object sender, EventArgs e)
        {//todo
            this.lbOverview.Items.Clear();
            foreach (Candy c in this.myStore.GetAllSoldCandy())
            {
                this.lbOverview.Items.Add(c.GetInfo());
            }
        }

        private void btnShowSoldMixedCandy_Click(object sender, EventArgs e)
        {//todo
            this.lbOverview.Items.Clear();
            foreach (Candy c in this.myStore.GetSoldMixedCandy())
            {
                this.lbOverview.Items.Add(c.GetInfo());
            }
        }

        private void btnShowWeightsMixedCandy_Click(object sender, EventArgs e)
        {//todo
            int[] results = this.myStore.GetWeightsMixedCandy();
            String holder = "Total weight loppipops is " + results[0] +
                ", total weight chewing gums is " + results[1] +
                ", total weight gummy drops is " + results[2];
            MessageBox.Show(holder);
        }

        private void btnSaveInformationToFile_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(this.saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    double profitOfPackedCandy = 0.0;
                    double profitOfMixedCandy = 0.0;
                    foreach (Candy c in this.myStore.GetAllSoldCandy())
                    {
                        sw.WriteLine(c.GetInfo());
                        if (c is PackedCandy)
                        {
                            profitOfPackedCandy += c.GetPrice();
                        }
                        else
                        {
                            profitOfMixedCandy += c.GetPrice();
                        }

                    }
                    sw.WriteLine("******************* totals *******************");
                    sw.WriteLine("profit from packed candy is: " + profitOfPackedCandy);
                    sw.WriteLine("profit from mixed candy is: " + profitOfMixedCandy);

                }
                catch (IOException)
                {
                    MessageBox.Show("something went wrong, IOException was thrown");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Nothing saved, since you pressed the CANCEL-button.");
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
