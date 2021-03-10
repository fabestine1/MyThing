using System.Linq;

namespace AppAboutZebras
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private Studbook myStudbook;

        public Form1()
        {
            InitializeComponent();
            myStudbook = new Studbook("Miracle-");
            Text = $"Studbook-app, made by {this.myStudbook.Name}";

            // This will show EVERYTIME! 
            lbInfo.Items.Add("ZebrasBornStripeByStripe");
            lbInfo.Items.Add(".-.-.-.-.-.-.-.-.-.-.-.");
            this.addSomeTestingStuff();
        }

        private void btnShowAllZebras_Click(object sender, EventArgs e)
        {
            this.lbInfo.Items.Clear();
            this.lbInfo.Items.Add(this.myStudbook.Name);
            this.lbInfo.Items.Add(".-.-.-.-.-.-.-.-.-.-.-.");
            foreach (Zebra z in this.myStudbook.GetAllZebras())
            {
                this.lbInfo.Items.Add(z.getInfo());
            }
        }

        private void btnShowInfoOf1Zebra_Click(object sender, EventArgs e)
        {
            //todo
            bool isThere = false;
            lbInfo.Items.Clear();
            foreach (var zebra in this.myStudbook.GetAllZebras())
            {
                if (zebra.Id == Convert.ToInt32(tbOthers.Text))
                {
                    lbInfo.Items.Add(zebra.getInfo());
                    isThere = true;
                }
            }

            if (!isThere)
            {
                MessageBox.Show("There is no zebra with this Id!");
            }
        }

        private void btnAddZebra_Click(object sender, EventArgs e)
        {
            //todo
            foreach (var zebra in this.myStudbook.GetAllZebras())
            {
                if (zebra.Id == Convert.ToInt32(tbId.Text))
                {
                    MessageBox.Show("There is already a zebra like that in the list!");
                    return;
                }
            }

            Gender gender = Gender.MARE;
            if (rbStallion.Text == Gender.STALLION.ToString())
            {
                gender = Gender.STALLION;
            }
            else if (rbUnknownGender.Text == Gender.UNKNOWN.ToString())
            {
                gender = Gender.UNKNOWN;
            }

            int id = Convert.ToInt32(tbId.Text);
            int dz = Convert.ToInt32(tbDz.Text);
            int mother = Convert.ToInt32(tbMotherId.Text);
            int father = Convert.ToInt32(tbFatherId.Text);

            Zebra z = new Zebra(id, tbName.Text, dz,mother,father, gender);
            this.myStudbook.AddZebra(z);
            MessageBox.Show("You have added a new zebra!");
        }

        private void btnShowZebrasWithFather_Click(object sender, EventArgs e)
        {
            //todo
            var zebras = this.myStudbook.GetZebrasWithFather(Convert.ToInt32(tbOthers.Text));
            lbInfo.Items.Clear();
            foreach (var zebra in zebras)
            {
                lbInfo.Items.Add(zebra.getInfo());
            }
        }

        private void btnShowZebrasInMotherline_Click(object sender, EventArgs e)
        {
            //todo
            var zebras = this.myStudbook.GetAncestorsInMotherline(Convert.ToInt32(tbOthers.Text));
            lbInfo.Items.Clear();
            foreach (var zebra in zebras.ToArray().Reverse())
            {
                lbInfo.Items.Add(zebra.getInfo());
            }
        }

        public void addSomeTestingStuff()
        {
            Zebra z;
            z = new Zebra(11, "Emma", -1); this.myStudbook.AddZebra(z);
            z = new Zebra(22, "Wilhelmina", 11); this.myStudbook.AddZebra(z);
            z = new Zebra(33, "Juliana", 32, 22, -1, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(35, "Bernhard", 15,-1,-1,Gender.STALLION); this.myStudbook.AddZebra(z);
            z = new Zebra(44, "Beatrix", 35, 33, 35, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(55, "Willem Alexander", 30, 44, -1, Gender.STALLION); this.myStudbook.AddZebra(z);
            z = new Zebra(60, "Maxima"); this.myStudbook.AddZebra(z);
            z = new Zebra(75, "Clara", 22, -1, 35, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(66, "Amalia", 44, 60, 55, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(32, "Sam"); this.myStudbook.AddZebra(z);
            z = new Zebra(36, "Samantha", 45, -1, 32, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(41, "Clara", 32, 36, 35, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(72, "Carlo", 52); this.myStudbook.AddZebra(z);           
            z = new Zebra(61, "Dora", 47, 41, 72, Gender.MARE); this.myStudbook.AddZebra(z);
            z = new Zebra(62, "Emma", 26, 61, 35, Gender.MARE); this.myStudbook.AddZebra(z);
        }
    }
}
