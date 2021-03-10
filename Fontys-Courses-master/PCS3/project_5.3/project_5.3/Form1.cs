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

namespace project_5._3
{
    public partial class Form1 : Form
    {
        PersonManager pm;
        public Form1()
        {
            InitializeComponent();
            pm = new PersonManager();
            AddSomeTestingStuff();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text != "" && tbPCN.Text != "" && tbAge.Text != "" && tbYearsAtSchool.Text != "")
                {
                    Person p = new Person(tbName.Text, Convert.ToInt32(tbPCN.Text), Convert.ToInt32(tbAge.Text), Convert.ToInt32(tbYearsAtSchool.Text));
                    if (pm.AddPerson(p))
                    {
                        MessageBox.Show("Successfully added person.");
                        lbxPeople.Items.Add(p);
                    }
                    else MessageBox.Show("Person already exists.");
                }
                else
                {
                    MessageBox.Show("You have to fill all fields.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input fields are in incorrect format.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pm.RemovePerson((Person)lbxPeople.SelectedItem);
            lbxPeople.Items.Remove(lbxPeople.SelectedItem);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                if (tbName.Text != "")
                {
                    pm.GetPerson(((Person)lbxPeople.SelectedItem).PCN).Name = tbName.Text;
                    UpdatePeople();
                }
                else
                {
                    MessageBox.Show("There is an empty field.");
                }
            }
            else MessageBox.Show("You have to select a person.");
        }

        private void btnSelebrateBirthday_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person p = pm.GetPerson(((Person)lbxPeople.SelectedItem).PCN);
                p.CelebrateBirthDay();
                UpdatePersonInfo(p);
            }
            else MessageBox.Show("You have to select a person.");
        }

        private void btnStartAnotherSchoolYear_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                Person p = pm.GetPerson(((Person)lbxPeople.SelectedItem).PCN);
                p.StartAnotherSchoolYear();
                UpdatePersonInfo(p);
            }
            else MessageBox.Show("You have to select a person.");
        }

        private void UpdatePeople()
        {
            lbxPeople.Items.Clear();
            foreach(Person p in pm.GetAllPeople())
            {
                lbxPeople.Items.Add(p);
            }
        }
        private void UpdatePersonInfo(Person p)
        {
            lbxPeople.SelectedValue = p.ToString();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            if (lbxPeople.SelectedIndex != -1)
            {
                MessageBox.Show(((Person)lbxPeople.SelectedItem).InfoString());
            }
            else MessageBox.Show("You have to select a person.");
        }

        private void AddSomeTestingStuff()
        {
            pm.AddPerson(new Person("Peter Smith", 123456, 25, 0));
            pm.AddPerson(new Person("Joe Jameson", 654321, 46, 15));
            pm.AddPerson(new Person("Amanda Levy", 987654, 20, 5));
            pm.AddPerson(new Person("Ann Fergusson", 456789, 54, 20));
            UpdatePeople();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs;
                    StreamWriter sw = null;

                    try
                    {
                        fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        sw = new StreamWriter(fs);

                        foreach(Person p in pm.GetAllPeople())
                        {
                            sw.WriteLine(p.Name + "|" + p.PCN + "|" + p.Age + "|" + p.YearsAtFontys);
                        }
                    }
                    catch(IOException ex)
                    {
                        MessageBox.Show("Error writing to file: " + ex.Message);
                    }
                    finally
                    {
                        if (sw != null) sw.Close();
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs;
                        StreamReader sr = null;

                        try
                        {
                            fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                            sr = new StreamReader(fs);
                        string[] lineAttr = new string[5];
                        while (!sr.EndOfStream)
                        {
                            lineAttr = sr.ReadLine().Split('|');
                            pm.AddPerson(new Person(lineAttr[0], Convert.ToInt32(lineAttr[1]), Convert.ToInt32(lineAttr[2]), Convert.ToInt32(lineAttr[3])));
                            UpdatePeople();
                        }
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show("Error loading file: " + ex.Message);
                        }
                        finally
                        {
                            if (sr != null) sr.Close();
                        }
                    }
                }
        }
    }
}
