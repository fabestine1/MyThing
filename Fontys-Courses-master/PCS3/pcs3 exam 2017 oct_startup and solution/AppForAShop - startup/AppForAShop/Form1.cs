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

namespace AppForAShop
{
    public partial class Form1 : Form
    {
        private Shop myShop;
        public Form1()
        {
            InitializeComponent();
            myShop = new Shop("Trendy");
            this.Text = myShop.Name + ", powered by Nikolay.";
            this.addSomeTestingStuff();
        }

        private void btnShowAllArticles_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach (Article a in this.myShop.GetAllArticles())
            {
                this.listBox1.Items.Add(a);
            }
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            int id = Convert.ToInt32(tbID.Text);
            double bPrice = Convert.ToDouble(tbBasicPrice.Text);
            int inStock = Convert.ToInt32(tbInStock.Text);
            Article article;
            if (rrbWine.Checked)
            {
                article = new WineArt(id, tbName.Text, bPrice, inStock, Convert.ToInt32(tbYear.Text));
            }
            else if (rbWCArticle.Checked)
            {
                article = new WCArt(id, tbName.Text, bPrice, inStock, cbDiscount.Checked);
            }
            else
            {
                article = new DepositArt(id, tbName.Text, bPrice, inStock, Convert.ToDouble(tbDeposit.Text));
            }
            if (myShop.AddArticle(article))
            {
                MessageBox.Show("Successfully added article.");
            }
            else
            {
                MessageBox.Show("Already exists an article with that ID number.");
            }
        }

        private void btnSellSome_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            try
            {
                double sum = myShop.SellArticle(Convert.ToInt32(tbID.Text), Convert.ToInt32(tbAmount.Text));
                if(sum != -1)
                {
                    MessageBox.Show("The purchase of total amount of " + sum + " is successful.");
                }
                else
                {
                    MessageBox.Show("Product with such ID does not exist.");
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("The ID or/and the amount is/are in incorrect format: " + ex.Message);
            }
            catch (InsufficientStockException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowOldWine_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            listBox1.Items.Clear();
            foreach(Article article in myShop.GetListOfOldWine(Convert.ToInt32(tbYear.Text)))
            {
                listBox1.Items.Add(article);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs;
                    StreamReader sr = null;
                    try
                    {
                        fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        bool temp;
                        string line = sr.ReadLine();
                        int id;
                        string name;
                        double basicPrice;
                        int nrInStock;
                        Article article;
                        while (!sr.EndOfStream)
                        {
                            id = Convert.ToInt32(sr.ReadLine());
                            name = sr.ReadLine();
                            basicPrice = Convert.ToDouble(sr.ReadLine());
                            nrInStock = Convert.ToInt32(sr.ReadLine());
                            if (line.Contains("wine"))
                            {
                                int year = Convert.ToInt32(sr.ReadLine());
                                article = new WineArt(id, name, basicPrice, nrInStock, year);
                            }
                            else if (line.Contains("wcart"))
                            {
                                if(sr.ReadLine() == "discount yes") temp = true; else temp = false;
                                article = new WCArt(id, name, basicPrice, nrInStock, temp);
                            }
                            else
                            {
                                double deposit = Convert.ToDouble(sr.ReadLine());
                                article = new DepositArt(id, name, basicPrice, nrInStock, deposit);
                            }
                            myShop.AddArticle(article);
                            sr.ReadLine();
                            line = sr.ReadLine();
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (sr != null) sr.Close();
                    }
                }
            }
        }

        private void addSomeTestingStuff()
        {
            this.myShop.AddArticle(new WineArt(11, "Chateaux Brie", 10, 20, 2014));
            this.myShop.AddArticle(new WCArt(22, "orange hat", 12.50, 100, true));
            this.myShop.AddArticle(new WineArt(93, "Gran Passione", 17.50, 12, 2006));
            this.myShop.AddArticle(new WCArt(44, "soundblaster", 49.95, 34, false));
            this.myShop.AddArticle(new WineArt(17, "Hautes La Lande", 4.94, 31, 2016));
            this.myShop.AddArticle(new WineArt(34, "Vino Studente", 2.50, 95, 2012));
            this.myShop.AddArticle(new DepositArt(77, "Bavaria beer", 2.50, 300, 0.25));
        }
    }
}
