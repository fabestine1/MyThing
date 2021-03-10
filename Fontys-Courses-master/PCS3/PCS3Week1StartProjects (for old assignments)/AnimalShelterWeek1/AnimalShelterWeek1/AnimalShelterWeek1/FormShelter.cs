using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalShelterWeek1
{
    public partial class AnimalShelterForm : Form
    {
        private Animal animal;
        private Dog dog;
        private Cat cat;
        public AnimalShelterForm()
        {
            InitializeComponent();
        }

        private void btnCreateAnimal_Click(object sender, EventArgs e)
        {
            animal = new Animal("d245", Convert.ToDateTime("12-05-13 00:00:00"), "Max");
            labelAnimalInfo.Text = animal.AsString();
        }

        private void btnCreateDog_Click(object sender, EventArgs e)
        {
            dog = new Dog("d245", Convert.ToDateTime("12-05-13 00:00:00"), "Max", DateTime.Now);
            labelDogInfo.Text = dog.AsString();
        }

        private void btnCreateCat_Click(object sender, EventArgs e)
        {
            cat = new Cat("c356", Convert.ToDateTime("12-05-13 00:00:00"), "Oscar", "makes noise");
            labelCatInfo.Text = cat.AsString();
        }

        private void btnShowInfoAnimal_Click(object sender, EventArgs e)
        {
            if(animal != null)
            {
                labelAnimalInfo.Text = animal.AsString();
            }
        }

        private void btnShowInfoDog_Click(object sender, EventArgs e)
        {
            if (dog != null)
            {
                labelDogInfo.Text = dog.AsString();
            }
        }

        private void btnShowInfoCat_Click(object sender, EventArgs e)
        {
            if (cat != null)
            {
                labelCatInfo.Text = cat.AsString();
            }
        }

        private void btnDogWalk_Click(object sender, EventArgs e)
        {
            if (dog != null)
            {
                dog.TakeForAWalk();
            }
        }

        private void btnCatBadHabbit_Click(object sender, EventArgs e)
        {
            if (cat != null)
            {
                cat.AddBadHabit(tbCatBadHabbit.Text);
            }
        }
    }
}
