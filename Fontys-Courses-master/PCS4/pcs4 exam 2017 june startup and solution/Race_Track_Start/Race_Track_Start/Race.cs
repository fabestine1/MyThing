using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race_Track_Solution
{
    class Race
    {
        #region This code is implemented for you
        
        private List<Participant> participants;

        public Race()
        {
            participants = new List<Participant>();
        }

        public void AddParticipant(Participant p)
        {
            participants.Add(p);
        }

        public void ChangeSpeedOfAllParticipants()
        {
            Random r = new Random();
            foreach (Participant p in participants)
            {
                p.ChangeSpeed(r.Next(3, 35));
            }
        }

        public List<Participant> GetParticipants()
        {
            return participants;
        }

        public void ResetParticipants()
        {
            foreach (Participant p in participants)
            {
                p.Reset();
            }
        }

        #endregion

        /// <summary>
        /// This method updates all participants.
        /// </summary>
        /// <param name="finishLocation">The distance from the start on which the finish-line is located.</param>
        public void Update(int finishLocation)
        {
            foreach (Participant p in participants)
            {
                p.Update(finishLocation);
            }
        }
        public void SortByName()
        {
            participants.Sort();
        }
        public void SortByAgeThenHobby()
        {
            participants.Sort(new SortParticipantsByAgeThenHobby());
        }
        public Participant GetYoungestParticipant(int n)
        {
            if (n == 0) return participants[0];
            Participant rest = GetYoungestParticipant(n - 1);
            if (participants[n - 1].Age < rest.Age) return participants[n - 1];
            return rest;
        }
    }
}
