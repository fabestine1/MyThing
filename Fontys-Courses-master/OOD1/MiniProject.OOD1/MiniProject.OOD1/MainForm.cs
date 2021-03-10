using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalShelter;
using Phidget22;
using Phidget22.Events;

namespace MiniProject.OOD1
{
    public partial class MainForm : Form
    {
        Shelter myShelter;

        Animal myAnimal;
        //RFID to add an animal
        RFID RFIDaddingAnimal;

        //RFID to display an animal on Adopt/Claim panel
        RFID RFIDanimalSearching;


        decimal feeCalculated=0;

        public MainForm()
        {
            InitializeComponent();
            myShelter = new Shelter("ANTF", "Eindhoven", 012345678, "ANTF@gmail.com");

            this.Text = myShelter.Name;

            //RFID initialize
            RFIDaddingAnimal = new RFID();
            RFIDaddingAnimal.Tag += RFIDinput_Tag;

            //RFID initialize
            RFIDanimalSearching = new RFID();
            RFIDanimalSearching.Tag += RFIDanimalSearching_Tag;


        }

        private void RFIDanimalSearching_Tag(object sender, RFIDTagEventArgs e)
        {
            if(e.Tag!="")
            {
                myAnimal = myShelter.GetAnimal(e.Tag);
                if (myShelter.GetAnimal(e.Tag) != null)
                {
                    lbNoticeAnimalSearching.Visible = false;
                    gbAnimalInfo.Enabled = true;
                    gbOwnerInfo.Enabled = true;
                    btnAdopt.Enabled = true;
                    btnClaim.Enabled = true;
                    DateTimePicker_ACpn.Visible = true;

                    Animal a = myShelter.GetAnimal(e.Tag);
                    tbDescription_ACpn.Text = a.Description;
                    tbLocationOfFinding_ACpn.Text = a.FoundLocation;
                    DateTimePicker_ACpn.Value = a.BroughtInDate; 
                    if (a is Cat)
                    {
                        lbExtraInfoTitle.Visible = true;
                        tbExtraInfo_ACpn.Visible = true;
                        rbCat_ACpn.Checked = true;
                        btnUpdateExtraInfo_ACpn.Enabled = true;

                        tbExtraInfo_ACpn.Text= ((Cat)a).ExtraInfo;
                    }
                    else if(a is Dog)
                    {
                        lbLastWalkingDate_ACpn.Visible = true;
                        lbLastWDateTitle.Visible = true;
                        rbDog_ACpn.Checked = true;
                        btnWalk.Enabled = true;

                        lbLastWalkingDate_ACpn.Text = ((Dog)a).LastWalkingDate.ToString();
                    }
                    
                }
                else
                {
                    MessageBox.Show("This animal is not existed!");
                }
                RFIDanimalSearching.Close();
            }
        }

        private void RFIDinput_Tag(object sender, RFIDTagEventArgs e)
        {
            if (e.Tag != "")
            {               
                if (myShelter.GetAnimal(e.Tag) != null)
                {
                    lbNotification.Text = "This RFID tag was already used!";
                }
                else
                {
                    string description = tbxDescription_Add.Text;
                    string foundLocation = tbxFoundLocation_Add.Text;
                    DateTime broughtInDate = DateTimePicker_AddingForm.Value;
                    bool added = false;
                    if(rbtnCat.Checked)
                    {
                        string extraInfo = tbxExtraInfo_Add.Text;
                        if(myShelter.AddAnimal(new Cat(e.Tag,description,foundLocation,extraInfo,broughtInDate)))
                        {
                            added = true;
                        }
                    }
                    if (rbtnDog.Checked)
                    {
                        if (myShelter.AddAnimal(new Dog(e.Tag, description, foundLocation,broughtInDate)))
                        {
                            added = true;
                        }
                    }
                    if(added)
                    {
                        lbNotification.Text = "Added successfully!";
                    }
                    else
                    {
                        lbNotification.Text = "Added unsuccessfully!";
                    }
                    RFIDaddingAnimal.Close();
                }
                
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnAddAnimal.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnAddAnimal.Enabled = true;
            this.btnOwnerRegister.Enabled = true;
            this.btn_Adopt_Claim.Enabled = true;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }

        private void btnOwnerRegister_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnOwnerRegister.Visible = true;
        }

        private void btn_Adopt_Claim_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnAdoptClaim.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription_Add.Text;
            string foundLocation = tbxFoundLocation_Add.Text;
            if ((rbtnCat.Checked || rbtnDog.Checked )&& description != "" &&foundLocation!="")
            {
                lbNotification.Text = "Please put a RFID card on scanner";
                RFIDaddingAnimal.Open();
            }

            else
            {
                lbNotification.Text = "Please input enough information!";
            }
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lastname = tbLastName_pnOwnerRegister.Text;
            string email = tbEmail_pnOwnerRegister.Text;
            if (lastname == "" || email == "")
            {
                lbNotification.Text = "Please input enough information!";
            }
            else
            {
                if (myShelter.AddOwner(new Owner(lastname, email)))
                {
                    lbNotification.Text = "Owner Added!";
                }
                else
                {
                    lbNotification.Text = "This owner is already existed";
                }
            }
        }
        private void HidePanel()
        {
            pnAddAnimal.Visible = false;
            pnOwnerRegister.Visible = false;
            pnAdoptClaim.Visible = false;
        }

        private void btnListOfAnimals_Click(object sender, EventArgs e)
        {
            HidePanel();
            listPanel.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pnAdoptClaim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            Owner AnOwner = myShelter.GetOwner(tbEmail_ACpn.Text);
            if (AnOwner != null)
            {
                if (myAnimal.Claim(AnOwner, ref feeCalculated))
                {
                    MessageBox.Show("The claim is successful. The claim fee is " + feeCalculated);
                }
                else
                {
                    MessageBox.Show("The claim is unsuccessful");
                }
            }
            else
            {
                MessageBox.Show("This owner is not existed!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            Owner AnOwner = myShelter.GetOwner(tbEmail_ACpn.Text);
            if (AnOwner != null)
            {
                if (myAnimal.Adopt(AnOwner, ref feeCalculated))
                {
                    MessageBox.Show("The adoption is successful. The adoption fee is " + feeCalculated);
                }
                else
                {
                    MessageBox.Show("The adoption is unsuccessful");
                }
            }
            else
            {
                MessageBox.Show("This owner is not existed");
            }
        }

        private void bnWalk_Click(object sender, EventArgs e)
        {
            if (myAnimal is Dog)
               ((Dog)myAnimal).UpdateLastWalkingDate();
               lbLastWalkingDate_ACpn.Text = ((Dog)myAnimal).LastWalkingDate.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            myAnimal.UpdateInfo(DateTimePicker_ACpn.Value, tbLocationOfFinding_ACpn.Text, tbDescription_ACpn.Text);
        }

        private void btnAnimalSearch_Click(object sender, EventArgs e)
        {
            lbNoticeAnimalSearching.Visible = true;
            RFIDanimalSearching.Open();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateExtraInfo_ACpn_Click(object sender, EventArgs e)
        {
            if (myAnimal is Cat)
                ((Cat)myAnimal).updateExtraInfo(tbExtraInfo_ACpn.Text);
        }

        private void adoptableBtn_Click(object sender, EventArgs e)
        {
            AnimalslistBox.Items.Clear();
            List<Animal> list = new List<Animal>();
            list = myShelter.GetAdoptableAnimals();
            for (int i = 0; i < list.Count; i++)
                AnimalslistBox.Items.Add(list[i].ToString());
        }

        private void notAdoptableBtn_Click(object sender, EventArgs e)
        {
            AnimalslistBox.Items.Clear();
            List<Animal> list = new List<Animal>();
            list = myShelter.GetNotYetAdoptableAnimals();
            for (int i = 0; i < list.Count; i++)
                AnimalslistBox.Items.Add(list[i].ToString());
        }

        private void getByOwnerBtn_Click(object sender, EventArgs e)
        {
            AnimalslistBox.Items.Clear();
            string lastname = OwnerLastNameTxtBox.Text;
            List<Animal> ListOfAnimalByOwner = myShelter.GetAnimalsByOwner(lastname);
            if(ListOfAnimalByOwner==null)
            {
                AnimalslistBox.Items.Add("There is no animal of this owner!");
            }
            else
            {
                foreach(Animal a in ListOfAnimalByOwner)
                {
                    AnimalslistBox.Items.Add(a);
                }
            }

        }

        private void listPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
