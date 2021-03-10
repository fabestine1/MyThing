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

        public void sortOnName()
        {
            this.participants.Sort();
        }
        public void sortByAgeAndHobby()
        {
            CompareByAgeAndHobby help = new CompareByAgeAndHobby();
            this.participants.Sort(help);
        }

        public Participant FindYoungest()
        {
            if (this.participants.Count == 0)
            {
                return null;
            }
            else
            {
                return FindYoungest(this.participants.Count);
            }
        }

        private Participant FindYoungest(int n)
        {
            if (n==1)
            {
                return this.participants[0];
            }
            else
            {
                Participant youngest;
                youngest = FindYoungest(n - 1);
                if (this.participants[n-1].Age<youngest.Age)
                {
                    return this.participants[n - 1];
                }
                else
                {
                    return youngest;
                }
            }
        }
    }
}
