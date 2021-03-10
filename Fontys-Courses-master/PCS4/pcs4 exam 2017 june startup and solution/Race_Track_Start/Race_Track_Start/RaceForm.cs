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
        LinkedList linkedList = new LinkedList();

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
        }

        private void InitializeParticipants()
        {
            Participant p;
            p = new Participant("Roxana", 20, "Reading", Color.Red);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
            p = new Participant("Stan", 25, "Horse riding", Color.Blue);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
            p = new Participant("Chung", 30, "Baseball", Color.Yellow);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
            p = new Participant("Andre", 20, "Play Piano", Color.Green);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
            p = new Participant("Emin", 22, "Dancing", Color.Purple);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
            p = new Participant("Bert", 18, "Soccer", Color.White);
            p.Finished += UpdateResults;
            myRace.AddParticipant(p);
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrAnimate.Start();
            myRace.ChangeSpeedOfAllParticipants();
        }
        private void UpdateResults(Participant p)
        {
            lbInfo.Items.Add(p);
            if(lbInfo.Items.Count == 1) { linkedList.AddWinner(p); }
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
            lbInfo.Items.Clear();
            foreach(string s in linkedList.GetAllWinners())
            {
                lbInfo.Items.Add(s);
            }
        }

        private void btnNameSort_Click(object sender, EventArgs e)
        {
            myRace.SortByName();
            lbInfo.Items.Clear();
            foreach(Participant p in myRace.GetParticipants())
            {
                lbInfo.Items.Add(p);
            }
        }

        private void btnAgeHobbySort_Click(object sender, EventArgs e)
        {
            myRace.SortByAgeThenHobby();
            lbInfo.Items.Clear();
            foreach (Participant p in myRace.GetParticipants())
            {
                lbInfo.Items.Add(p);
            }
        }

        private void btnYoungest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myRace.GetYoungestParticipant(myRace.GetParticipants().Count).ToString());
        }
    }
}