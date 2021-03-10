using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_Track_Solution
{
    public partial class RaceForm : Form
    {
        Race myRace;
        LinkedListOfWinners myLinkedList;

        #region This code is implemented for you


        private void TmrAnimate_Tick(object sender, EventArgs e)
        {
            myRace.ChangeSpeedOfAllParticipants();
            myRace.Update(pbRaceTrack.Width - 35);
            pbRaceTrack.Refresh(); // This will call the method pbRaceTrack_Paint automatically
        }

        private void pbRaceTrack_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.IndianRed);
            int finishOffset = 35;
            int finishX = pbRaceTrack.Width - finishOffset;
            int participantSizeY = 46;
            int participantSizeX = 29;
            int participantDistance = 3;
            for (int i = 1; i < 6; i++)
            {
                e.Graphics.DrawLine(Pens.White, new Point(0, i * (participantSizeY + participantDistance)), new Point(pbRaceTrack.Width - finishOffset, i * (participantSizeY + participantDistance)));
            }
            e.Graphics.FillRectangle(Brushes.White, new Rectangle(finishX, 0, 4, pbRaceTrack.Height));

            List<Participant> myParticipants = myRace.GetParticipants();
            if (myParticipants.Count > 0)
            {
                for (int i = 0; i < myParticipants.Count; i++)
                {
                    Participant p = myParticipants[i];
                    e.Graphics.DrawString(p.Name, new Font("Consolas", 20), new SolidBrush(Color.White), new Point(pbRaceTrack.Width / 2, participantDistance + i * (participantSizeY + participantDistance)));
                    e.Graphics.FillRectangle(new SolidBrush(p.Color), new Rectangle((int)p.X + 10, participantDistance + i * (participantSizeY + participantDistance) + 13, 8, 20));
                    e.Graphics.DrawImage(new Bitmap("Runner.png"), new Rectangle((int)p.X, participantDistance + i * (participantSizeY + participantDistance), participantSizeX, participantSizeY));
                }
            }
        }

        #endregion

        public RaceForm()
        {
            myRace = new Race();

            InitializeComponent();
            InitializeParticipants();
            myLinkedList = new LinkedListOfWinners();
        }
 
        private void InitializeParticipants()
        {
            Participant p;
            p = new Participant("Roxana", 20, "Reading", Color.Red);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);

            p = new Participant("Stan", 25, "Horse riding", Color.Blue);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);
            p = new Participant("Chung", 30, "Baseball", Color.Yellow);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);
            p = new Participant("Andre", 20, "Play Piano", Color.Green);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);
            p = new Participant("Emin", 22, "Dancing", Color.Purple);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);
            p = new Participant("Bert", 18, "Soccer", Color.White);
            myRace.AddParticipant(p);
            p.raceFinished += new Participant.raceFinishedHandler(this.showInListBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrAnimate.Start();
            myRace.ChangeSpeedOfAllParticipants();
        }
        public void showInListBox(Participant p)
        {
            this.lbInfo.Items.Add(p.ToString());
            //now check if it is the winner
            if (this.lbInfo.Items.Count == 1) { this.myLinkedList.registerWinner(p); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            tmrAnimate.Stop();
            myRace.ResetParticipants();
            pbRaceTrack.Refresh(); // paints the participants at their starting position.
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            List<String> temp = this.myLinkedList.getInfoOfAllItems();
            this.lbInfo.Items.Clear();
            foreach (String s in temp) { this.lbInfo.Items.Add(s); }
        }

        private void btnNameSort_Click(object sender, EventArgs e)
        {
            this.myRace.sortOnName();
            this.showAllParticipantsInListbox();
        }

        private void btnAgeHobbySort_Click(object sender, EventArgs e)
        {
            this.myRace.sortByAgeAndHobby();
            this.showAllParticipantsInListbox();
        }

        private void showAllParticipantsInListbox()
        {
            this.lbInfo.Items.Clear();
            foreach (Participant p in myRace.GetParticipants())
            { lbInfo.Items.Add(p.ToString()); }
        }

        private void btnYoungest_Click(object sender, EventArgs e)
        {
            Participant youngest = myRace.getYoungest();
            if (youngest == null)
                MessageBox.Show("no participants, so also no youngest");
            else
                MessageBox.Show(myRace.getYoungest().ToString());
        }
    }
}