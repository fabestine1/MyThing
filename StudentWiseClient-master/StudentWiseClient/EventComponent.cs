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
    public partial class EventComponent : UserControl
    {
        public EventComponent(Event ev)
        {
            InitializeComponent();
            Self = ev;
            SetAllNeededProperties();
        }

        public Event Self { get; private set; }

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
        }
        public void SetAllNeededProperties()
        {
            EventTitleLbl.Text = Self.Title.UppercaseFirst();
            EventDescriptionLbl.Text = Self.Description.UppercaseFirst() ?? "No description provided.";
            EventTypeLbl.Text = Self.Kind.ToString().ToUpper();
            SetDeadline(Self.StartsAt, Self.FinishesAt);
            
            DeleteEventPbx.Visible = Self.Creator == Server.CurrentSession.Info;
            
            switch (Self.Kind)
            {
                case EventType.Party:
                    BackColor = Color.Gold;
                    break;

                case EventType.Duty:
                    BackColor = Color.OrangeRed;
                    break;
            }
            SetEvent();
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

        private void DeleteEvent()
        {
            Self.Delete();
            FormMain.Instance.ReloadEvents();
        }
        
    }
}
