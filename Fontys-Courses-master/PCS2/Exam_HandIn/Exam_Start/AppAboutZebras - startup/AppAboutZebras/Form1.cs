using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutZebras
{
    public partial class Form1 : Form
    {
        Studbook myStudbook;
        Gender zebraGender = Gender.UNKNOWN;

        public Form1()
        {
            InitializeComponent();

            myStudbook = new Studbook("Green studbook");
            this.Text = "Studbook-app, made by Nikolay Nikolaev";
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
            lbInfo.Items.Clear();
            Zebra zebra = myStudbook.GetZebra(Convert.ToInt32(tbOthers.Text));
            //todo
            if (zebra != null)
            {
                lbInfo.Items.Add(zebra.getInfo());
            }
            else
            {
                MessageBox.Show("There is no zebra with that ID!");
            }
        }

        private void btnAddZebra_Click(object sender, EventArgs e)
        {
            //todo
            if (myStudbook.GetZebra(Convert.ToInt32(tbId.Text)) == null)
            {
                if (tbFatherId.Text != "" && tbDz.Text != "")
                {
                    myStudbook.AddZebra(new Zebra(Convert.ToInt32(tbId.Text), tbName.Text, Convert.ToInt32(tbMotherId.Text), Convert.ToInt32(tbFatherId.Text), Convert.ToInt32(tbDz.Text), zebraGender));
                }
                else if(tbMotherId.Text != "")
                {
                    myStudbook.AddZebra(new Zebra(Convert.ToInt32(tbId.Text), tbName.Text, Convert.ToInt32(tbMotherId.Text)));
                }
                else
                {
                    myStudbook.AddZebra(new Zebra(Convert.ToInt32(tbId.Text), tbName.Text));
                }
                MessageBox.Show("A new zebra is successfully added!");
            }
            else
            {
                MessageBox.Show("The zebra already exists!");
            }
        }

        private void btnShowZebrasWithFather_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            //todo
            List<Zebra> zebras = myStudbook.GetZebrasWithFather(Convert.ToInt32(tbOthers.Text));
            foreach (Zebra zebra in zebras)
            {
                lbInfo.Items.Add(zebra.getInfo());
            }
        }

        private void btnShowZebrasInMotherline_Click(object sender, EventArgs e)
        {
            //todo
            lbInfo.Items.Clear();
            List<Zebra> zebras = myStudbook.GetAncestorsInMotherline(Convert.ToInt32(tbOthers.Text));
            foreach (Zebra zebra in zebras)
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

        private void rbStallion_CheckedChanged(object sender, EventArgs e)
        {
            zebraGender = Gender.STALLION;
        }

        private void rbMare_CheckedChanged(object sender, EventArgs e)
        {
            zebraGender = Gender.MARE;
        }
    }
}
