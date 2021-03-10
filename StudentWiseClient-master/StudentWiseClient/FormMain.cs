using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentWiseApi;

namespace StudentWiseClient
{    
    public partial class FormMain : Form
    {
        #region Initialization
        public static FormMain Instance { get; private set; }

        public FormMain()
        {
            InitializeComponent();
            AllEvents = new List<Event>();
            AllExpenses = new List<Expense>();
            AllComplaints = new List<Complaint>();
            AllAgreements = new List<Agreement>();
            AllGroups = new List<Group>();
            Instance = this;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ReloadEvents();
            ReloadComplaints();
            ReloadExpenses();
            UserNameLbl.Text = Server.CurrentSession.Info.ToString();
        }
        #endregion

        #region Events
        public List<Event> AllEvents { get; }

        public void AddEventToUI(Event ev)
        {
            AllEvents.Add(ev);

            // Today's events
            if (EventFilter.Today().Matches(ev))
            {
                // Remove "NoEventsToday" panel
                foreach (Control control in todaysEventsFllpnl.Controls)
                    if (control is NoEventsToday)
                        todaysEventsFllpnl.Controls.Remove(control);

                todaysEventsFllpnl.Controls.Add(new EventComponent(ev));
                flowLayoutPanelToday.Controls.Add(new EventComponent(ev));
            }

            // Upcoming events
            if (EventFilter.Upcoming().Matches(ev))
                flowLayoutPanelUpcoming.Controls.Add(new EventComponent(ev));

            // Created events
            if (EventFilter.Involved(EventInvolvement.Creator).Matches(ev))
            {
                // Remove "NoEventsCreated" panel
                foreach (Control control in CreatedEventsFllpnl.Controls)
                    if (control is NoEventsCreated)
                        CreatedEventsFllpnl.Controls.Remove(control);

                CreatedEventsFllpnl.Controls.Add(new EventComponentAddParticipant(ev));               
            }
        }

        public void ReloadEvents()
        {
            AllEvents.Clear();
            todaysEventsFllpnl.Controls.Clear();
            CreatedEventsFllpnl.Controls.Clear();

            RemoveChilderExceptLabels(flowLayoutPanelToday);
            RemoveChilderExceptLabels(flowLayoutPanelUpcoming);

            foreach (var ev in Event.Enumerate())
                AddEventToUI(ev);

            if (CreatedEventsFllpnl.Controls.Count == 0)
                CreatedEventsFllpnl.Controls.Add(new NoEventsCreated());

            if (todaysEventsFllpnl.Controls.Count == 0)
                todaysEventsFllpnl.Controls.Add(new NoEventsToday());
        }

        public void ShowNewEventForm()
        {
            NewEvent dlgNewEvent = new NewEvent();
            dlgNewEvent.ShowDialog(this);
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            ShowNewEventForm();
        }

        private void RemoveChilderExceptLabels(Control control)
        {
            foreach (Control child in control.Controls)
                if (!(child is Label))
                    control.Controls.Remove(child);
        }

        #endregion

        #region Expenses
        public List<Expense> AllExpenses { get; }

        private void UpdateExpenseBalances()
        {
            HashSet<User> allParticipants = new HashSet<User>();

            foreach (Expense expense in AllExpenses)
                foreach (User user in expense.Participants)
                    allParticipants.Add(user);

            MembersLv.Items.Clear();

            foreach (User user in allParticipants)
            {
                decimal balance = user.ComputeBalance(AllExpenses);
                string balanceStr = balance.ToString("0.00");

                // Update our balance on the dashboard
                if (user == Server.CurrentSession.Info)
                {
                    balanceAmountLbl.Text = balanceStr;
                    balanceAmountLbl.ForeColor = (balance >= 0) ? Color.Green : Color.Red;
                }

                MembersLv.Items.Add(new ListViewItem(new string[] { user.ToString(), balanceStr }));
            }

            // Update total amount
            ExpenseTotalPriceLbl.Text = AllExpenses.
                ConvertAll(e => e.Price * e.Quantity).Append(0).
                Aggregate((a, b) => a + b).ToString();
        }

        private void AddExpenseToUIWorker(Expense expense)
        {
            AllExpenses.Add(expense);

            ExpensesLv.Items.Add(new ListViewItem(new string[]
            {
                expense.Name,
                expense.Quantity.ToString(),
                expense.Price.ToString(),
                expense.Notes
            }));
        }

        public void AddExpenseToUI(Expense expense)
        {
            AddExpenseToUIWorker(expense);
            UpdateExpenseBalances();
        }

        public void ReloadExpenses()
        {
            AllExpenses.Clear();
            ExpensesLv.Items.Clear();

            foreach (Expense expense in Expense.Enumerate())
                AddExpenseToUIWorker(expense);

            UpdateExpenseBalances();            
        }

        private void AddExpenseBtn_Click(object sender, EventArgs e)
        {
            string expenseTitle = ExpenseTitleTbx.Text;
            string expenseNotes = ExpenseNotesRtbx.Text;
            decimal expensePrice = ExpensePriceNum.Value;
            int expenseQuantity = Convert.ToInt32(ExpenseQuantityNum.Value);

            if (string.IsNullOrEmpty(ExpenseTitleTbx.Text))
                throw new ApplicationException("Please, specify a title.");

            if (expensePrice <= 0)
                throw new ApplicationException("Please, specify a positive price.");

            Expense expense = Expense.Create(expenseTitle, expensePrice, expenseQuantity,
                string.IsNullOrWhiteSpace(expenseNotes) ? null : expenseNotes);

            // Share expeses with all users by default
            foreach (User user in User.Enumerate())
                if (user != Server.CurrentSession.Info)
                    expense.AddParticipant(user.Id);

            AddExpenseToUI(expense);
        }
        #endregion

        #region Complaints
        public List<Complaint> AllComplaints { get; }

        public void AddComplaintToUI(Complaint complaint)
        {
            // Remove "NoAgreements" panels
            if (AllComplaints.Count == 0)
            {
                foreach (Control control in complaintsFllpnl.Controls)
                    if (control is NoComplaints)
                        complaintsFllpnl.Controls.Remove(control);

                foreach (Control control in complaintsFllPanel.Controls)
                    if (control is NoComplaints)
                        complaintsFllPanel.Controls.Remove(control);
            }

            AllComplaints.Add(complaint);
            complaintsFllpnl.Controls.Add(new ComplaintsComponent(complaint));
            complaintsFllPanel.Controls.Add(new MiniComplaintComponent(complaint));
        }

        public void ReloadComplaints()
        {
            AllComplaints.Clear();
            complaintsFllpnl.Controls.Clear();
            complaintsFllPanel.Controls.Clear();

            foreach (Complaint complaint in Complaint.Enumerate())
                AddComplaintToUI(complaint);

            if (AllComplaints.Count == 0)
            {
                complaintsFllPanel.Controls.Add(new NoComplaints());
                complaintsFllpnl.Controls.Add(new NoComplaints());
            }
        }

        private void FileComplaintBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTbx.Text))
                throw new ApplicationException("Please, specify a title.");

            Complaint newComplaint = Complaint.Create(titleTbx.Text,
                string.IsNullOrWhiteSpace(descriptionTbx.Text) ? null : descriptionTbx.Text);

            titleTbx.Clear();
            descriptionTbx.Clear();
            AddComplaintToUI(newComplaint);
        }
        #endregion

        #region Agreements
        public List<Agreement> AllAgreements { get; }

        public void AddAgreementToUI(Agreement agreement)
        {
            // Remove "NoAgreements" panel
            if (AllAgreements.Count == 0)
                foreach (Control control in agreementsFlpnl.Controls)
                    if (control is NoAgreements)
                        agreementsFlpnl.Controls.Remove(control);

            AllAgreements.Add(agreement);
            agreementsFlpnl.Controls.Add(new AgreementComponent(agreement));
        }

        public void ReloadAgreements()
        {
            AllAgreements.Clear();
            agreementsFlpnl.Controls.Clear();

            foreach (Agreement agreement in Agreement.Enumerate())
                AddAgreementToUI(agreement);

            if (AllAgreements.Count == 0)
                agreementsFlpnl.Controls.Add(new NoAgreements());                
        }

        private void tbAgreements_Enter(object sender, EventArgs e)
        {
            ReloadAgreements();
        }

        private void NewAgreementBttn_Click(object sender, EventArgs e)
        {
            string description = agreementDescriprionTbx.Text;
            string title = agreementTitleTbx.Text;

            if (string.IsNullOrEmpty(title))
                throw new ApplicationException("Please, specify a title.");

            Agreement agreement = Agreement.Create(title,
                string.IsNullOrWhiteSpace(description) ? null : description);

            AddAgreementToUI(agreement);
        }
        #endregion

        #region Groups
        public List<Group> AllGroups { get; }

        public void AddGroupToUI(Group group)
        {
            Control groupComponent;

            // Remove "NoGroups" panel
            if (AllGroups.Count == 0)
                foreach (Control control in flPnlGroups.Controls)
                    if (control is NoGroups)
                        flPnlGroups.Controls.Remove(control);
            
            if (Server.CurrentSession.Info.Admin)
                groupComponent = new GroupDetailedComponent(group, User.Enumerate());
            else
                groupComponent = new GroupComponent(group);

            AllGroups.Add(group);
            flPnlGroups.Controls.Add(groupComponent);
        }

        public void ReloadGroups()
        {
            AllGroups.Clear();
            flPnlGroups.Controls.Clear();

            List<Group> groups = Server.CurrentSession.Info.Admin ?
                Group.Enumerate() :
                new List<Group>(1) { Server.CurrentSession.Info.PrimaryGroup };

            foreach (Group group in groups)
                AddGroupToUI(group);

            if (AllGroups.Count == 0)
                flPnlGroups.Controls.Add(new NoGroups());
        }

        private void TpGroups_Enter(object sender, EventArgs e)
        {
            if (Server.CurrentSession.Info.Admin)
            {
                lblGroups.Text = "Groups:";
                gbNewGroup.Visible = true;
            }
            else
            {
                lblGroups.Text = "Your Group:";
                gbNewGroup.Visible = false;
            }

            ReloadGroups();
        }

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            string name = tbxGroupName.Text;
            string description = tbxGroupDescription.Text;
            string rules = tbxGroupRules.Text;

            if (string.IsNullOrEmpty(name))
                throw new ApplicationException("Please, enter a group name.");

            Group group = Group.Create(name, description, string.IsNullOrWhiteSpace(rules) ? null : rules);
            AddGroupToUI(group);
        }
        #endregion

        #region Misc
        private void SwitchToTab_Click(object sender, EventArgs e)
        {
            int targetTabIndex = tsMain.Items.IndexOf(sender as ToolStripItem);
            tcMain.SelectTab(targetTabIndex);
        }

        private void MyEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tpEvents);
        }

        private void CreatedEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcMain.SelectTab(tpCreatedEvents);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeNowLbl.Text = $"Today is {DateTime.Now.Date.ToString("dd/MM/yyyy")}";
        }

        private void AddEventBtn_Resize(object sender, EventArgs e)
        {
            lblEvents.Width = AddEventBtn.Width;
            UpcomingEventsLbl.Width = AddEventBtn.Width;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ExitIfLastForm();
        }
        #endregion
    }
}
