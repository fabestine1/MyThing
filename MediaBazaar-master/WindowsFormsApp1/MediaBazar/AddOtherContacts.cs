using System;
using System.Windows.Forms;

namespace MediaBazar
{

    public partial class AddOtherContacts : Form
    {
        CreateAccount ca;
        Person p;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        string email;
        long phoneN;
        private string sendContact;

        public AddOtherContacts(CreateAccount form)
        {
            InitializeComponent();
            ca = form;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public string FirstName { get { return firstName; } private set { firstName = tbFirstName.Text; } }
        public string LastName { get { return lastName; } private set { lastName = tbLastName.Text; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } private set { dateOfBirth = dtpBirthdate.Value; } }
        public long PhoneNumber { get { return phoneN; } private set { phoneN = Convert.ToInt64(tbPhoneNumber.Text); } }
        public string Email { get { return email; } private set { email = tbEmail.Text; } }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "First name" || tbLastName.Text == "Last name" || tbPhoneNumber.Text == "Phone number")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else if (tbFirstName.Text == "" || tbLastName.Text == "" || tbPhoneNumber.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!ca.IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else
            {
                try
                {
                    FirstName = tbFirstName.Text;
                    LastName = tbLastName.Text;
                    DateOfBirth = dtpBirthdate.Value;
                    Email = tbEmail.Text;
                    PhoneNumber = Convert.ToInt64(tbPhoneNumber.Text);
                    p = new Person(FirstName, LastName, DateOfBirth, PhoneNumber, Email);
                    sendContact = FirstName + " " + LastName + " date of birth: " + DateOfBirth + " tel: " + PhoneNumber + " email: " + Email.ToString();
                    ca.ShowContact(sendContact);
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Data!Check person details.");
                }
            }
        }

    }
}
