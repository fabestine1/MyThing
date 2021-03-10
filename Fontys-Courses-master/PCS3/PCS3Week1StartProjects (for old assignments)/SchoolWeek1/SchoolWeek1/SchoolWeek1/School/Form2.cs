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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace School
{
    public partial class Form2 : Form
    {
        private School school;
        private Person person;
        private ISpeaker guestSpeaker;
        private List<Person> selectedPersons;
        public Form2()
        {
            InitializeComponent();
            school = new School("John's School");
            Point p = new Point(256, 19);
            groupBoxStudent.Location = p;
            groupBoxTeacher.Location = p;
            Populate();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            if (rbtnStudent.Checked)
            {
                if (tbxECs.Text != "" && tbxYearsAtSchool.Text != "")
                {
                    person = new Student(tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxAge.Text), tbxCountry.Text, "Rachelsmolen 1", Convert.ToInt32(tbxECs.Text), Convert.ToInt32(tbxYearsAtSchool.Text));
                }
                else
                {
                    person = new Student(tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxAge.Text), tbxCountry.Text, "Rachelsmolen 1");
                }
            }
            else
            {
                if (tbxYearsAtSchool.Text != "")
                {
                    person = new Teacher(tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxAge.Text), Function.JUNIOR_DOCENT, Convert.ToInt32(tbxSalary.Text), "Rachelsmolen 1", Convert.ToInt32(tbxYearsAtSchool.Text));
                }
                else
                {
                    person = new Teacher(tbxName.Text, Convert.ToInt32(tbxPCN.Text), Convert.ToInt32(tbxAge.Text), Function.JUNIOR_DOCENT, Convert.ToInt32(tbxSalary.Text), "Rachelsmolen 1");
                }
            }
            if (school.AddPerson(person) == false)
            {
                MessageBox.Show("Person already exists!");
            }
            else
            {
                lbxPersons.Items.Add(person);
                MessageBox.Show("Person successfully added!");
            }
        }

        private void ShowInfoPerson(Person p)
        {
            if (p != null)
            {
                richTextBoxLog.Text = p.ToString();
                tbxLogName.Text = p.Name;
                tbxLogPCN.Text = p.PCN.ToString();
            }
        }

        private void btnShowInfoPerson_Click(object sender, EventArgs e)
        {
            ShowInfoPerson(person);
        }

        private void btnCelebBirthday_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            foreach (Person person in selectedPersons)
            {
                person.CelebrateBirthday();
                richTextBoxLog.Text += person;
            }
        }

        private void btnNewSchoolYear_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            foreach (Person person in selectedPersons)
            {
                person.StartAnotherSchoolYear();
                richTextBoxLog.Text += person;
            }
        }

        private void btnAddECs_Click(object sender, EventArgs e)
        {
            Person foundPerson = school.GetPerson(Convert.ToInt32(tbxActionsPCN.Text));
            if (foundPerson is Student)
            {
                ((Student)foundPerson).AddECs(3);
                ShowInfoPerson(foundPerson);
            }
            else
            {
                MessageBox.Show("Person is not a student!");
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            Person foundPerson = school.GetPerson(Convert.ToInt32(tbxActionsPCN.Text));
            if (foundPerson is Teacher)
            {
                ((Teacher)foundPerson).Promote();
                ShowInfoPerson(foundPerson);
            }
            else
            {
                MessageBox.Show("Person is not a teacher!");
            }
        }

        private void rbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxStudent.Visible = true;
            groupBoxTeacher.Visible = false;
            //btnAddECs.Visible = true;
            //btnPromote.Visible = false;
        }

        private void rbtnTeacher_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxStudent.Visible = false;
            groupBoxTeacher.Visible = true;
            //btnAddECs.Visible = false;
            //btnPromote.Visible = true;
        }
        private void addToList(Person p)
        {
            school.AddPerson(p);
            lbxPersons.Items.Add(p);
        }
        private void Populate()
        {
            Person p;
            p = new Student("Acton", 111113, 23, "USA", "Rachelsmolen 1");
            addToList(p);
            p = new Student("Adamaris", 111114, 24, "United Kingdom", "Rachelsmolen 1");
            addToList(p);
            p = new Teacher("Addison", 111115, 25, Function.DIRECTOR, 3000, "Rachelsmolen 1");
            addToList(p);
            p = new Teacher("Adney", 111116, 26, Function.DOCENT_1, 2242, "Rachelsmolen 1");
            addToList(p);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
            if (tbxLogName.Text != "")
            {
                List<Person> foundPersonList = school.GetPersons(tbxLogName.Text);
                if (foundPersonList.Count != 0)
                {
                    richTextBoxLog.Text = "Found:\n\n";
                    foreach (Person person in foundPersonList)
                    {
                        richTextBoxLog.Text += person + "\n---------------------\n";
                    }
                }
            }
        }

        private void btnShowAllPersons_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
            List<Person> people = school.GetPersons();
            foreach (Person person in people)
            {
                richTextBoxLog.Text += person + "\n---------------------\n";
            }
        }

        private void btnSearchPCN_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
            if (tbxLogPCN.Text != "")
            {
                Person foundPerson = school.GetPerson(Convert.ToInt32(tbxLogPCN.Text));
                if (foundPerson != null)
                {
                    richTextBoxLog.Text = "Found:\n\n" + foundPerson;
                }
            }
        }

        private void btnShowYoungPersons_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text = "";
            List<Person> youngPeople = school.GetYoungPersons(Convert.ToInt32(tbxSearchAge.Text));
            if (youngPeople.Count != 0)
            {
                richTextBoxLog.Text = "Found:\n\n";
                foreach (Person person in youngPeople)
                {
                    richTextBoxLog.Text += person + "\n---------------------\n";
                }
            }
        }

        private void btnGetExtraInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.GetExtraInfo());
        }

        private void lbxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPersons.SelectedIndices != null)
            {
                selectedPersons = new List<Person>();
                string selectedInfo = "";
                foreach (Person person in lbxPersons.SelectedItems)
                {
                    selectedPersons.Add(person);
                    selectedInfo += person;
                }
                richTextBoxLog.Text = selectedInfo;
                person = (Person)(lbxPersons.SelectedItem);
                tbxLogName.Text = person.Name;
                tbxLogPCN.Text = person.PCN.ToString();
            }
        }

        private void btnSetGuestSpeaker_Click(object sender, EventArgs e)
        {
            guestSpeaker = (Person)lbxPersons.SelectedItem;
        }

        private void btnPresentGuestLecture_Click(object sender, EventArgs e)
        {
            MessageBox.Show(guestSpeaker.GetStartOfSpeech());
        }

        private void btnInviteRobotSpeaker_Click(object sender, EventArgs e)
        {
            guestSpeaker = new Robot();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save data";
                sfd.FileName = "DataFile";
                sfd.DefaultExt = ".dat";
                sfd.Filter = "Data files (.dat)|*.dat";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!sfd.FileName.Contains(".dat"))
                    {
                        string[] str = sfd.FileName.Split('.');
                        sfd.FileName = str[0] + ".dat";
                    }
                    try
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        try
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(fs, school);
                            try
                            {
                                if (fs != null)
                                {
                                    fs.Close();
                                }
                            }
                            catch (IOException)
                            {
                                MessageBox.Show("Error closing file");
                            }
                        }
                        catch (SerializationException)
                        {
                            MessageBox.Show("Error writing to file");
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file");
                    }
                }
                sfd.Dispose();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog sfd = new OpenFileDialog())
            {
                sfd.Title = "Load data";
                sfd.FileName = "DataFile";
                sfd.DefaultExt = ".dat";
                sfd.Filter = "Data files (.dat)|*.dat";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Open, FileAccess.Read);
                        try
                        {
                            BinaryFormatter bf = new BinaryFormatter();
                            school = (School)bf.Deserialize(fs);
                            lbxPersons.Items.Clear();
                            foreach(Person person in school.GetPersons())
                            {
                                lbxPersons.Items.Add(person);
                            }
                        }
                        catch (SerializationException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            if (fs != null)
                            {
                                fs.Close();
                            }
                        }
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error opening file");
                    }
                }
                sfd.Dispose();
            }
        }

        private void btnGenerateOverview_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save overview";
                sfd.FileName = "overview";
                sfd.DefaultExt = ".txt";
                sfd.Filter = "Text files (.)txt|*.txt";
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!sfd.FileName.Contains(".txt"))
                    {
                        string[] str = sfd.FileName.Split('.');
                        sfd.FileName = str[0] + ".txt";
                    }
                    try
                    {
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        try
                        {
                            foreach (Person person in school.GetPersons())
                            {
                                if (person.YearsAtFontys == 1 && person is Student)
                                {
                                    sw.WriteLine("Name: " + person.Name + Environment.NewLine + "PCN: " + person.PCN + Environment.NewLine + "Age: " + person.Age + Environment.NewLine + "Address: " + person.Address + Environment.NewLine + "Country: " + ((Student)person).Country + Environment.NewLine + "EC: " + ((Student)person).EC + Environment.NewLine);
                                }
                            }
                        }
                        catch(IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            try
                            {
                                if (sw != null)
                                {
                                    sw.Close();
                                }
                            }
                            catch (IOException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                sfd.Dispose();
            }
        }
    }
}
