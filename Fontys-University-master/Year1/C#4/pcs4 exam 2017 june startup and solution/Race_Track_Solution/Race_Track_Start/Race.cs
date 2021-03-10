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
        private int addedToLinkedList = 0;

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

        /// <summary>
        /// returns a youngest participant in the list of participants if the list is not empty
        /// otherwise it returns null
        /// </summary>
        /// <returns></returns>
        public Participant getYoungest()
        {
            if (this.participants.Count == 0 )
            { return null; }
            else
            { //there is at least 1 participant in the list
                return getYoungest(this.participants.Count);
            }
        }

        /// <summary>
        /// for n>=1 it returns a youngest participant under the first n participants in the list
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Participant getYoungest(int n)
        {
            if (n == 1)
            { return this.participants[0]; }
            else
            { 
                Participant youngestOfAllExceptLastParticipant = this.getYoungest(n - 1);
                if (this.participants[n - 1].Age < youngestOfAllExceptLastParticipant.Age)
                { return this.participants[n - 1]; }
                else
                { return youngestOfAllExceptLastParticipant; }
            }
        }

        public delegate void raceFinishedHandler(Participant p);
        public event raceFinishedHandler addToLinkedList;
    }
}
