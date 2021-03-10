using System.IO;

namespace AppForAShop
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Shop myShop;
        public Form1()
        {
            InitializeComponent();
            myShop = new Shop("Cinderella");
            this.Text = myShop.Name + ", powered by Bert.";
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
            double bprice = Convert.ToDouble(tbBasicPrice.Text);
            int inStock = Convert.ToInt32(tbInStock.Text);
            Article a;
            if (this.rrbWine.Checked)
            {
                a = new Wine(id, tbName.Text, bprice, inStock, Convert.ToInt32(tbYear.Text));
            }
            else if (this.rbDepositArticle.Checked)
            {
                a = new DepositArticle(id, tbName.Text, bprice, inStock, Convert.ToDouble(tbDeposit.Text));
            }
            else
            {//then it will be a wc-art
                a = new WCArt(id, tbName.Text, bprice, inStock, cbDiscount.Checked);
            }

            if (this.myShop.AddArticle(a))
            {
                MessageBox.Show("succesfully added");
            }
            else
            {
                MessageBox.Show("not succesfully added");
            }
        }

        private void btnSellSome_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            try
            {
                int idnr = Convert.ToInt32(this.tbID.Text);
                int amount = Convert.ToInt32(this.tbAmount.Text);
                double totalPrice = this.myShop.SellArticle(idnr, amount);
                if (totalPrice != -1)
                {
                    MessageBox.Show("total price is " + totalPrice);
                }
                else
                {
                    MessageBox.Show("idnumber is not correct");
                }
            }
            catch (FormatException) { MessageBox.Show("please fill in correct numbers"); }
            catch (SellingException se) { MessageBox.Show(se.Message); }
        }

        private void btnShowOldWine_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            this.listBox1.Items.Clear();
            foreach (Article a in this.myShop.GetListOfOldWine(Convert.ToInt32(this.tbYear.Text)))
            {
                this.listBox1.Items.Add(a);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            //todo, see assignment 3
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                this.myShop.clearArticleList();
                try
                {
                    fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string s = sr.ReadLine();
                    while (s != null)
                    {
                        Article newArticle;
                        int id = Convert.ToInt32(sr.ReadLine());
                        string name = sr.ReadLine();
                        double basicPrice = Convert.ToDouble(sr.ReadLine());
                        int nrInStock = Convert.ToInt32(sr.ReadLine());
                        if (s == "wine")
                        {
                            int year = Convert.ToInt32(sr.ReadLine());
                            newArticle = new Wine(id, name, basicPrice, nrInStock, year);
                        }
                        else if (s == "wcart")
                        {
                            String onDiscount = sr.ReadLine();
                            if (onDiscount == "discount yes")
                                newArticle = new WCArt(id, name, basicPrice, nrInStock, true);
                            else
                                newArticle = new WCArt(id, name, basicPrice, nrInStock, false);
                        }
                        else //now s == "dep"
                        {
                            double depositAmount = Convert.ToDouble(sr.ReadLine());
                            newArticle = new DepositArticle(id, name, basicPrice, nrInStock, depositAmount);
                        }
                        this.myShop.AddArticle(newArticle);
                        s = sr.ReadLine();//for skipping the delimiter-line with =-signs
                        s = sr.ReadLine();
                    }
                }
                catch (IOException) { MessageBox.Show("something wrong about file"); }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

        private void addSomeTestingStuff()
        {
            this.myShop.AddArticle(new Wine(11, "Chateaux Brie", 10, 20, 2014));
            this.myShop.AddArticle(new WCArt(22, "orange hat", 12.50, 100, true));
            this.myShop.AddArticle(new Wine(93, "Gran Passione", 17.50, 12, 2006));
            this.myShop.AddArticle(new WCArt(44, "soundblaster", 49.95, 34, false));
            this.myShop.AddArticle(new Wine(17, "Hautes La Lande", 4.94, 31, 2016));
            this.myShop.AddArticle(new Wine(34, "Vino Studente", 2.50, 95, 2012));
            this.myShop.AddArticle(new DepositArticle(77, "Bavaria beer", 2.50, 300, 0.25));
        }
    }
}
