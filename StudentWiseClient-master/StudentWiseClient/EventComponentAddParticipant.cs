using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentWiseApi;


namespace StudentWiseClient
{
    public partial class EventComponentAddParticipant : UserControl
    {
        public EventComponentAddParticipant(Event ev)
        {
            InitializeComponent();
            Self = ev;
            SetAllNeededProperties();
            SetEvent();
        }

        public Event Self { get; private set; }        

        public void SetAllNeededProperties()
        {
            EventTitleLbl.Text = Self.Title.UppercaseFirst();
            EventDescriptionLbl.Text = Self.Description.UppercaseFirst() ?? "No description provided.";
            EventTypeLbl.Text = Self.Kind.ToString().ToUpper();
            SetDeadline(Self.StartsAt, Self.FinishesAt);

            DeleteEventPbx.Visible = Self.Creator == Server.CurrentSession.Info;
        }
        public void SetEvent()
        {
            if (Self.Participants.Contains(Server.CurrentSession.Info))
            {
                switch (Self.Status)
                {
                    case EventStatus.Pending:
                        EventCompletePbx.Image = Properties.Resources.undo_favicon;
                        break;

                    case EventStatus.Finished:
                        EventCompletePbx.Image = Properties.Resources.kisspng_check_mark_symbol_icon_black_checkmark_5a76d35a732948_8416047115177367944717;
                        break;

                    default:
                        EventCompletePbx.Visible = false;
                        break;
                }
            }

            ReloadParticipants();
        }

        public void SetDeadline(DateTime? start, DateTime? end)
        {
            string result = "";

            if (start.HasValue)
                result += $"From {start} ";

            if (end.HasValue)
                result += $"Until {end}";

            EventDeadlineLbl.Text = result;
        }

        private void DeleteEvent()
        {
            Self.Delete();
            FormMain.Instance.ReloadEvents();
        }

        private void ReloadParticipants()
        {
            ParticipantsCmb.Items.Clear();

            foreach (User user in User.Enumerate().Except(Self.Participants))
                ParticipantsCmb.Items.Add(user);
        }

        private void AddParticipantBtn_Click(object sender, EventArgs e)
        {
            if (ParticipantsCmb.SelectedItem is User)
            {
                User user = ParticipantsCmb.SelectedItem as User;

                Self.AddParticipant(user.Id);
                ParticipantsCmb.Items.Remove(ParticipantsCmb.SelectedItem);

                MessageBox.Show(
                    $"Successfully added {user} to the {Self.Title.UppercaseFirst()} event of type {Self.Kind}.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void DeleteEventPbx_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteEvent();
            }
        }

        private void EventCompletePbx_Click(object sender, EventArgs e)
        {
            if (Self.Participants.Contains(Server.CurrentSession.Info))
            {
                switch (Self.Status)
                {
                    case EventStatus.Pending:
                        Self.MarkAsFinished();
                        EventCompletePbx.Image = Properties.Resources.undo_favicon;
                        break;

                    case EventStatus.Finished:
                        Self.MarkAsPending();
                        EventCompletePbx.Image = Properties.Resources.kisspng_check_mark_symbol_icon_black_checkmark_5a76d35a732948_8416047115177367944717;
                        break;
                }
            }
        }
    }
}
