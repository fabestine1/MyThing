using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public abstract class Course : ICourse
    {
        private int courseId; // the id of this course
        private String courseName; // the name of this course
        private List<Participant> participants; // the list of participants for this course
        protected int price;

        public int CourseId
        {
            get { return this.courseId; }
        }

        public Course(int courseId, string courseName, int price)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.participants = new List<Participant>();
            this.price = price;
        }

        // methods

        /// <summary>
        /// GetNrOfParticipants()
        /// Returns the number of participants for this course
        /// </summary>
        /// <returns></returns>
        public int GetNrOfParticipants()
        {
            return this.participants.Count;
        }

        /// <summary>
        /// GetParticipant(int participantId)
        /// Returns the participant with id participantId, if this participant attends the course
        /// and null otherwise
        /// </summary>
        /// <param name="participantId"></param>
        /// <returns></returns>
        public Participant GetParticipant(int participantId)
        {
            foreach (Participant p in this.participants)
            {
                if (p.GetId() == participantId)
                    return p;
            }
            return null;
        }

        /// <summary>
        /// ToString()
        /// Returns a string with all relevant information about the current classroom course in a string
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            // To do, assignment 1b and 3
            return "Id: " + courseId + " Course name: " + courseName + " Nr of participants " + GetNrOfParticipants();
        }


        public virtual void AddParticipant(int id, string name)
        {
            if (GetParticipant(id) == null)
            {
                participants.Add(new Participant(id, name));
            }
            else throw new CourseException("Participant with id " + id + " already registered");
        }
        public abstract int GetPricePerParticipant();
    }
}
