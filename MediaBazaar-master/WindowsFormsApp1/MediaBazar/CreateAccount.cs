using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazar
{
    public partial class CreateAccount : Form
    {
        AddOtherContacts aoc;
        PeopleController pc;
        string username;
        decimal hourlyWage;
        int workerRole;
        List<int> workdays = new List<int>();
        List<int> workshifts = new List<int>();

        bool state = false;
        int loggedInUser;
        int contactCounter;
        bool addContact = false;

        public CreateAccount(int user_id, int workerRole)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pc = new PeopleController();
            PopulateDepartments(Department.GetAllDepartments());
            this.loggedInUser = user_id;
            //dtbContractStartDate.MinDate = System.DateTime.Now;
            //dtbContractStartDate.Value = System.DateTime.Now;
            //dtpBirthdate.Value = System.DateTime.Now;
            //dtpBirthdate.MaxDate = System.DateTime.Now;
            contactCounter = 0;
            if (!addContact)
            {
                btnAddOtherContact.Enabled = false;
                btnOpenContact.Enabled = false;
                btnDeleteContact.Enabled = false;
            }
            this.workerRole = workerRole;
            if (workerRole == (int)ProfileRoles.ADMINISTRATOR)
            {
                btnEdit.Visible = true;
                btnSendRequest.Visible = false;
                rbEmployee.Visible = false;
            }
            else if (workerRole == (int)ProfileRoles.MANAGER)
            {
                btnEdit.Visible = false;
                btnChangeShifts.Visible = false;
                btnCreateAccount.Visible = false;
                rbAdmin.Visible = false;
                rbManager.Visible = false;
                rbEmployee.Checked = true;
                rbEmployee.Enabled = false;
                this.Text = "Hiring Request";
            }
        }


        private void btnSendRequest_Click(object sender, EventArgs e)
        {

            decimal minHourlyWage = 7;
            if (tbUsername.Text == "Username" || tbFirstName.Text == "First name" || tbLastName.Text == "Last name" || tbCountry.Text == "Country" || tbRegion.Text == "region" || tbPostcode.Text == "postcode" || tbStreet.Text == "street" || tbPhoneNumber.Text == "Phone number" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else if (tbUsername.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbCountry.Text == "Country" || tbRegion.Text == "" || tbPostcode.Text == "" || tbStreet.Text == "" || tbPhoneNumber.Text == "" || tbPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!cbMonday.Checked && !cbTuesday.Checked && !cbWednesday.Checked && !cbThursday.Checked && !cbFriday.Checked && !cbSaturday.Checked && !cbSunday.Checked)
            {
                MessageBox.Show("Please select available working days!");
            }
            else if (!cbMorningShift.Checked && !cbAfternoonShift.Checked && !cbEveningShift.Checked)
            {
                MessageBox.Show("Please select a prefered workshift!");
            }
            else if (nHourlyWage.Value < minHourlyWage)
            {
                MessageBox.Show("Employee hourly wage must be above the minimum!");
            }
            else if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else
            {
                if (UniqueUsername())
                {
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        int accountType = 0;
                        if (rbAdmin.Checked)
                        {

                            accountType = (int)ProfileRoles.ADMINISTRATOR;

                        }
                        else if (rbManager.Checked)
                        {
                            accountType = (int)ProfileRoles.MANAGER;
                        }
                        else if (rbEmployee.Checked)
                        {
                            accountType = (int)ProfileRoles.EMPLOYEE;
                        }

                        int contract_id = 0;
                        this.username = tbUsername.Text;
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        DateTime dateOfBirth = dtpBirthdate.Value;
                        string street = tbStreet.Text;
                        string postcode = tbPostcode.Text;
                        string region = tbRegion.Text;
                        string country = tbCountry.Text;
                        string email = tbEmail.Text;
                        hourlyWage = nHourlyWage.Value;
                        string password = tbPassword.Text;
                        long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                        DateTime contractStartDate = dtbContractStartDate.Value;
                        int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                        pc.CreateWorker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage, contractStartDate, departmentId);//adds worker to person table

                        string contractQuery = "INSERT into contract (person_id, contract_start) VALUES (@person_id, @contract_start);";
                        MySqlCommand contractCmd = new MySqlCommand(contractQuery, conn);
                        contractCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        contractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                        conn.Open();
                        contractCmd.ExecuteNonQuery();



                        string employeDetailsQuery = "INSERT into employee_details(person_id, hourly_wage, contract_id, department_id, is_approved) VALUES (@person_id, @hourly_wage, @contract_id, @department_id, @is_approved);";
                        MySqlCommand employeDetailsCmd = new MySqlCommand(employeDetailsQuery, conn);
                        employeDetailsCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        employeDetailsCmd.Parameters.AddWithValue("@hourly_wage", hourlyWage);
                        employeDetailsCmd.Parameters.AddWithValue("@contract_id", pc.GetContractId(pc.GetIdByUsername(username)));
                        employeDetailsCmd.Parameters.AddWithValue("@department_id", departmentId);//department ID department class
                        employeDetailsCmd.Parameters.AddWithValue("@is_approved", 1);
                        employeDetailsCmd.ExecuteNonQuery();

                        if (cbMonday.Checked)
                        {
                            workdays.Add(0);
                        }
                        if (cbTuesday.Checked)
                        {
                            workdays.Add(1);
                        }
                        if (cbWednesday.Checked)
                        {
                            workdays.Add(2);
                        }
                        if (cbThursday.Checked)
                        {
                            workdays.Add(3);
                        }
                        if (cbFriday.Checked)
                        {
                            workdays.Add(4);
                        }
                        if (cbSaturday.Checked)
                        {
                            workdays.Add(5);
                        }
                        if (cbSunday.Checked)
                        {
                            workdays.Add(6);
                        }

                        if (cbMorningShift.Checked)
                        {
                            workshifts.Add(1);
                        }
                        if (cbAfternoonShift.Checked)
                        {
                            workshifts.Add(2);
                        }
                        if (cbEveningShift.Checked)
                        {
                            workshifts.Add(3);
                        }

                        foreach (int shift in workshifts)
                        {
                            foreach (int day in workdays)
                            {
                                string shiftsQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                                MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                                shiftsQueryCmd.Parameters.AddWithValue("@shift", shift);
                                shiftsQueryCmd.Parameters.AddWithValue("@userId", pc.GetIdByUsername(username));
                                shiftsQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                                shiftsQueryCmd.ExecuteNonQuery();
                            }
                        }
                        HiringRequests hr = new HiringRequests(pc.GetIdByUsername(username), loggedInUser, this.username, firstName, lastName, this.hourlyWage, departmentId, contractStartDate, phoneN, email);
                        HiringRequests hr1 = new HiringRequests(pc.GetIdByUsername(username), loggedInUser);
                        if (!hr1.FrExists)
                        {
                            MessageBox.Show("Hiring request already exists!");
                        }
                        else
                        {
                            MessageBox.Show("Request sent successfully!");
                        }
                        addContact = true;
                        if (addContact)
                        {
                            btnAddOtherContact.Enabled = true;
                            btnOpenContact.Enabled = true;
                            btnDeleteContact.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                else { MessageBox.Show("User with that username already exists."); }
            }
        }

        private void btnAddOtherContact_Click(object sender, EventArgs e)
        {
            bool contactExists = false;
            int ContactId = 0;
            MySqlConnection conn = Utils.GetConnection();

            if (this.contactCounter == 2)
            {
                btnAddOtherContact.Enabled = false;
                MessageBox.Show("Sorry you have reached the limit of contacts per person!");
            }
            else
            {
                try
                {
                    string selectContactIdQuery = "SELECT id FROM person where first_name=@firstName AND last_name=@lastName AND date_of_birth=@dateOfBirth AND email=@email AND phone_number=@phoneN";
                    MySqlCommand selectContactIdCmd = new MySqlCommand(selectContactIdQuery, conn);
                    selectContactIdCmd.Parameters.AddWithValue("@firstName", aoc.FirstName);
                    selectContactIdCmd.Parameters.AddWithValue("@lastName", aoc.LastName);
                    selectContactIdCmd.Parameters.AddWithValue("@dateOfBirth", aoc.DateOfBirth);
                    selectContactIdCmd.Parameters.AddWithValue("@email", aoc.Email);
                    selectContactIdCmd.Parameters.AddWithValue("@phoneN", aoc.PhoneNumber);
                    conn.Open();
                    Object contactIdResult = selectContactIdCmd.ExecuteScalar();

                    if (contactIdResult != null)
                    {
                        ContactId = Convert.ToInt32(contactIdResult);
                    }
                    foreach (int Check in pc.CheckExistingContacts(username))
                    {
                        if (Check == ContactId)
                        {
                            contactExists = true;
                        }
                    }
                    if (contactExists == false)
                    {
                        string contactIdQuery = "INSERT INTO contact_person (employee_id, contact_person_id) VALUES (@userId, @contactId);";
                        MySqlCommand contactIdCmd = new MySqlCommand(contactIdQuery, conn);
                        contactIdCmd.Parameters.AddWithValue("@userId", pc.GetIdByUsername(username));
                        contactIdCmd.Parameters.AddWithValue("@contactId", ContactId);
                        contactIdCmd.ExecuteNonQuery();
                        MessageBox.Show("The contact has been added.");
                    }
                    else
                    {
                        MessageBox.Show("This contact is already added.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                PopulateListBoxOtherContacts();
            }

        }

        private void PopulateDepartments(List<Department> departments)
        {
            foreach (Department d in departments)
                cmbDepartment.Items.Add(new DepartmentComboBoxItem(d));
        }

        private void btnOpenContact_Click(object sender, EventArgs e)
        {
            aoc = new AddOtherContacts(this);
            aoc.Show();
        }

        public void PopulateListBoxOtherContacts()
        {
            lbContacts.Items.Clear();
            foreach (string s in pc.PopulateListBox(pc.GetIdByUsername(username)))
            {
                lbContacts.Items.Add(s);
            }


        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = tbUsername.Text;
            PopulateListBoxOtherContacts();
            try
            {
                if (pc.GetIdByUsername(username) != 0)
                {
                    tbFirstName.Text = pc.PopulateFields(pc.GetIdByUsername(username)).FirstName;
                    tbLastName.Text = pc.PopulateFields(pc.GetIdByUsername(username)).LastName;
                    dtpBirthdate.Value = pc.PopulateFields(pc.GetIdByUsername(username)).DateOFBirth;
                    tbStreet.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Street;
                    tbPostcode.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Postcode;
                    tbRegion.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Region;
                    tbCountry.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Country;
                    tbPhoneNumber.Text = pc.PopulateFields(pc.GetIdByUsername(username)).PhoneNumber.ToString();
                    tbEmail.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Email;
                    tbPassword.Text = pc.PopulateFields(pc.GetIdByUsername(username)).Password;
                    nHourlyWage.Value = pc.PopulateFields(pc.GetIdByUsername(username)).HourlyWage;
                    cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact(pc.GetDepartmentName(pc.GetIdByUsername(username)));
                    dtbContractStartDate.Value = pc.PopulateFields(pc.GetIdByUsername(username)).ContractStartDate;
                    if (pc.PopulateFields(pc.GetIdByUsername(username)).AccountType == 0)
                    {
                        rbAdmin.Checked = true;
                    }
                    else if (pc.PopulateFields(pc.GetIdByUsername(username)).AccountType == 1)
                    {
                        rbManager.Checked = true;
                    }
                    else if (pc.PopulateFields(pc.GetIdByUsername(username)).AccountType == 2)
                    {
                        rbEmployee.Checked = true;
                    }
                    foreach (string s in pc.PopulateShifts(pc.GetIdByUsername(username)))
                    {
                        if (s == "morning") { cbMorningShift.Checked = true; }
                        else if (s == "afternoon") { cbAfternoonShift.Checked = true; }
                        else if (s == "evening") { cbEveningShift.Checked = true; }
                    }

                    addContact = true;
                    if (addContact)
                    {
                        btnAddOtherContact.Enabled = true;
                        btnOpenContact.Enabled = true;
                        btnDeleteContact.Enabled = true;
                    }
                }
                else
                {
                    tbFirstName.Text = "First Name";
                    tbLastName.Text = "Last Name";
                    tbStreet.Text = "street";
                    tbPostcode.Text = "postcode";
                    tbRegion.Text = "region";
                    tbCountry.Text = "Country";
                    tbPhoneNumber.Text = "Phone number";
                    tbEmail.Text = "Email address";
                    tbPassword.Text = "Password";
                    nHourlyWage.Value = 0;
                    cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact("Department");
                    dtbContractStartDate.Value = System.DateTime.Now;
                    rbAdmin.Checked = false;
                    rbManager.Checked = false;
                    rbEmployee.Checked = false;
                    cbMorningShift.Checked = false;
                    cbAfternoonShift.Checked = false;
                    cbEveningShift.Checked = false;
                    cbMonday.Checked = false;
                    cbTuesday.Checked = false;
                    cbWednesday.Checked = false;
                    cbThursday.Checked = false;
                    cbFriday.Checked = false;
                    cbSaturday.Checked = false;
                    cbSunday.Checked = false;
                    addContact = false;
                    if (!addContact)
                    {
                        btnAddOtherContact.Enabled = false;
                        btnOpenContact.Enabled = false;
                        btnDeleteContact.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool UniqueUsername()
        {
            string username = tbUsername.Text;
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string usernameQuery = "SELECT username FROM user where username=@username;";
                MySqlCommand usernameCmd = new MySqlCommand(usernameQuery, conn);
                usernameCmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                Object userIdResult = usernameCmd.ExecuteScalar();

                if (userIdResult == null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public void ShowContact(string contact)
        {
            lbContacts.Items.Clear();
            lbContacts.Items.Add(contact);
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            decimal minHourlyWage = 7;
           
            if (tbUsername.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbCountry.Text == "" || tbRegion.Text == "" || tbPostcode.Text == "" || tbStreet.Text == "" || tbPhoneNumber.Text == "" || tbPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!rbAdmin.Checked && !rbManager.Checked)
            {
                MessageBox.Show("Please select an account type!");
            }
            else if (!cbMonday.Checked && !cbTuesday.Checked && !cbWednesday.Checked && !cbThursday.Checked && !cbFriday.Checked && !cbSaturday.Checked && !cbSunday.Checked)
            {
                MessageBox.Show("Please select available working days!");
            }
            else if (!cbMorningShift.Checked && !cbAfternoonShift.Checked && !cbEveningShift.Checked)
            {
                MessageBox.Show("Please select a prefered workshift!");
            }
            else if (nHourlyWage.Value < minHourlyWage)
            {
                MessageBox.Show("Employee hourly wage must be above the minimum!");
            }
            else if (cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else
            {
                if (!UniqueUsername())
                {
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        int accountType = 0;
                        if (rbAdmin.Checked)
                        {

                            accountType = (int)ProfileRoles.ADMINISTRATOR;

                        }
                        else if (rbManager.Checked)
                        {
                            accountType = (int)ProfileRoles.MANAGER;
                        }
                        else if (rbEmployee.Checked)
                        {
                            accountType = (int)ProfileRoles.EMPLOYEE;
                        }
                        this.username = tbUsername.Text;
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        DateTime dateOfBirth = dtpBirthdate.Value;
                        string street = tbStreet.Text;
                        string postcode = tbPostcode.Text;
                        string region = tbRegion.Text;
                        string country = tbCountry.Text;
                        string email = tbEmail.Text;
                        hourlyWage = nHourlyWage.Value;
                        string password = tbPassword.Text;
                        long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                        DateTime contractStartDate = dtbContractStartDate.Value;
                        int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                        pc.UpdateWorker(pc.GetIdByUsername(username), password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage, contractStartDate);

                        string contractQuery = "UPDATE contract SET contract_start=@contract_start where person_id=@person_id;";
                        MySqlCommand contractCmd = new MySqlCommand(contractQuery, conn);
                        contractCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        contractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                        conn.Open();
                        contractCmd.ExecuteNonQuery();

                        string employeDetailsQuery = "UPDATE employee_details SET  hourly_wage=@hourly_wage, department_id=@department_id WHERE  person_id=@person_id";
                        MySqlCommand employeDetailsCmd = new MySqlCommand(employeDetailsQuery, conn);
                        employeDetailsCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        employeDetailsCmd.Parameters.AddWithValue("@hourly_wage", hourlyWage);
                        employeDetailsCmd.Parameters.AddWithValue("@department_id", departmentId);
                        employeDetailsCmd.ExecuteNonQuery();

                        if (state == true)
                        {
                            pc.DeleteShifts();
                            if (cbMonday.Checked)
                            {
                                workdays.Add(0);
                            }
                            if (cbTuesday.Checked)
                            {
                                workdays.Add(1);
                            }
                            if (cbWednesday.Checked)
                            {
                                workdays.Add(2);
                            }
                            if (cbThursday.Checked)
                            {
                                workdays.Add(3);
                            }
                            if (cbFriday.Checked)
                            {
                                workdays.Add(4);
                            }
                            if (cbSaturday.Checked)
                            {
                                workdays.Add(5);
                            }
                            if (cbSunday.Checked)
                            {
                                workdays.Add(6);
                            }

                            if (cbMorningShift.Checked)
                            {
                                workshifts.Add(1);
                            }
                            if (cbAfternoonShift.Checked)
                            {
                                workshifts.Add(2);
                            }
                            if (cbEveningShift.Checked)
                            {
                                workshifts.Add(3);
                            }

                            foreach (int shift in workshifts)
                            {
                                foreach (int day in workdays)
                                {
                                    string workdaysQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                                    MySqlCommand workdaysQueryCmd = new MySqlCommand(workdaysQuery, conn);
                                    workdaysQueryCmd.Parameters.AddWithValue("@shift", shift);
                                    workdaysQueryCmd.Parameters.AddWithValue("@userId", pc.GetIdByUsername(username));
                                    workdaysQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                                    workdaysQueryCmd.ExecuteNonQuery();
                                }
                            }
                        }
                        MessageBox.Show("The account has been edited.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Data!Check person details.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else { MessageBox.Show("User with that username doesn't exists."); }
                state = false;
            }
        }
        public string GetUSername()
        {
            string username = tbUsername.Text;
            return username;
        }
        private void btnChangeShifts_Click(object sender, EventArgs e)
        {
            state = true;
            cbMonday.Checked = false;
            cbTuesday.Checked = false;
            cbWednesday.Checked = false;
            cbThursday.Checked = false;
            cbFriday.Checked = false;
            cbSaturday.Checked = false;
            cbSunday.Checked = false;
            cbMorningShift.Checked = false;
            cbAfternoonShift.Checked = false;
            cbEveningShift.Checked = false;
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                string a = lbContacts.SelectedItem.ToString();
                int output = Convert.ToInt32(a.Split('[', ']')[1]);
                pc.DeleteSelectedContact(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PopulateListBoxOtherContacts();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            decimal minHourlyWage = 7;
            if (tbUsername.Text == "Username" || tbFirstName.Text == "First name" || tbLastName.Text == "Last name" || tbCountry.Text == "Country" || tbRegion.Text == "region" || tbPostcode.Text == "postcode" || tbStreet.Text == "street" || tbPhoneNumber.Text == "Phone number" || tbPassword.Text == "Password")
            {
                MessageBox.Show("Please change the initial information in the fields!");
            }
            else if (tbUsername.Text == "" || tbFirstName.Text == "" || tbLastName.Text == "" || tbCountry.Text == "Country" || tbRegion.Text == "" || tbPostcode.Text == "" || tbStreet.Text == "" || tbPhoneNumber.Text == "" || tbPassword.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in all the fields in the table!");
            }
            else if (!rbAdmin.Checked && !rbManager.Checked)
            {
                MessageBox.Show("Please select an account type!");
            }
            else if (!cbMonday.Checked && !cbTuesday.Checked && !cbWednesday.Checked && !cbThursday.Checked && !cbFriday.Checked && !cbSaturday.Checked && !cbSunday.Checked)
            {
                MessageBox.Show("Please select available working days!");
            }
            else if (!cbMorningShift.Checked && !cbAfternoonShift.Checked && !cbEveningShift.Checked)
            {
                MessageBox.Show("Please select a prefered workshift!");
            }
            else if (nHourlyWage.Value < minHourlyWage)
            {
                MessageBox.Show("Employee hourly wage must be above the minimum!");
            }
            else if (cmbDepartment.Text == "Department" || cmbDepartment.Text == "")
            {
                MessageBox.Show("Please select a department from the menu!");
            }
            else if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address!");
            }
            else
            {
                if (UniqueUsername())
                {
                    MySqlConnection conn = Utils.GetConnection();
                    try
                    {
                        int accountType = 0;
                        if (rbAdmin.Checked)
                        {

                            accountType = (int)ProfileRoles.ADMINISTRATOR;

                        }
                        else if (rbManager.Checked)
                        {
                            accountType = (int)ProfileRoles.MANAGER;
                        }
                        else if (rbEmployee.Checked)
                        {
                            accountType = (int)ProfileRoles.EMPLOYEE;
                        }
                        //int contract_id = 0;
                        this.username = tbUsername.Text;
                        string firstName = tbFirstName.Text;
                        string lastName = tbLastName.Text;
                        DateTime dateOfBirth = dtpBirthdate.Value;
                        string street = tbStreet.Text;
                        string postcode = tbPostcode.Text;
                        string region = tbRegion.Text;
                        string country = tbCountry.Text;
                        string email = tbEmail.Text;
                        hourlyWage = nHourlyWage.Value;
                        string password = tbPassword.Text;
                        long phoneN = Convert.ToInt64(tbPhoneNumber.Text);
                        DateTime contractStartDate = dtbContractStartDate.Value;
                        int departmentId = ((DepartmentComboBoxItem)cmbDepartment.SelectedItem).Id;
                        pc.CreateWorker(accountType, username, password, firstName, lastName, dateOfBirth, street, postcode, region, country, phoneN, email, hourlyWage, contractStartDate, departmentId);//adds worker to person table

                        string contractQuery = "INSERT into contract (person_id, contract_start) VALUES (@person_id, @contract_start);";
                        MySqlCommand contractCmd = new MySqlCommand(contractQuery, conn);
                        contractCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        contractCmd.Parameters.AddWithValue("@contract_start", contractStartDate);
                        conn.Open();
                        contractCmd.ExecuteNonQuery();


                        string employeDetailsQuery = "INSERT into employee_details(person_id, hourly_wage, contract_id, department_id, is_approved) VALUES (@person_id, @hourly_wage, @contract_id, @department_id, @is_approved);";
                        MySqlCommand employeDetailsCmd = new MySqlCommand(employeDetailsQuery, conn);
                        employeDetailsCmd.Parameters.AddWithValue("@person_id", pc.GetIdByUsername(username));
                        employeDetailsCmd.Parameters.AddWithValue("@hourly_wage", hourlyWage);
                        employeDetailsCmd.Parameters.AddWithValue("@contract_id", pc.GetContractId(pc.GetIdByUsername(username)));
                        employeDetailsCmd.Parameters.AddWithValue("@department_id", departmentId);//department ID department class
                        employeDetailsCmd.Parameters.AddWithValue("@is_approved", 2);
                        employeDetailsCmd.ExecuteNonQuery();

                        if (cbMonday.Checked)
                        {
                            workdays.Add(0);
                        }
                        if (cbTuesday.Checked)
                        {
                            workdays.Add(1);
                        }
                        if (cbWednesday.Checked)
                        {
                            workdays.Add(2);
                        }
                        if (cbThursday.Checked)
                        {
                            workdays.Add(3);
                        }
                        if (cbFriday.Checked)
                        {
                            workdays.Add(4);
                        }
                        if (cbSaturday.Checked)
                        {
                            workdays.Add(5);
                        }
                        if (cbSunday.Checked)
                        {
                            workdays.Add(6);
                        }

                        if (cbMorningShift.Checked)
                        {
                            workshifts.Add(1);
                        }
                        if (cbAfternoonShift.Checked)
                        {
                            workshifts.Add(2);
                        }
                        if (cbEveningShift.Checked)
                        {
                            workshifts.Add(3);
                        }

                        foreach (int shift in workshifts)
                        {
                            foreach (int day in workdays)
                            {
                                string shiftsQuery = "INSERT into employee_working_days (employee_id,week_day_id, shift) VALUE(@userId,@week_day_id, @shift)";
                                MySqlCommand shiftsQueryCmd = new MySqlCommand(shiftsQuery, conn);
                                shiftsQueryCmd.Parameters.AddWithValue("@shift", shift);
                                shiftsQueryCmd.Parameters.AddWithValue("@userId", pc.GetIdByUsername(username));
                                shiftsQueryCmd.Parameters.AddWithValue("@week_day_id", day);
                                shiftsQueryCmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("The account has been created.");
                        addContact = true;
                        if (addContact)
                        {
                            btnAddOtherContact.Enabled = true;
                            btnOpenContact.Enabled = true;
                            btnDeleteContact.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Data!Check person details.");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else { MessageBox.Show("User with that username already exists."); }

            }


        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var emailAddr = new System.Net.Mail.MailAddress(email);
                return emailAddr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}


