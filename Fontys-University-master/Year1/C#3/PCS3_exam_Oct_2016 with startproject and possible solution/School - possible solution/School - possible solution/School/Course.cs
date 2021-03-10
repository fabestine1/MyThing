using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    // assignment 1a: (Create this class, and modify classes ClassroomCourse and ECourse)
    public abstract class Course: ICourse // assignment 2a
    {
        // fields
        private int courseId; // the id of this course
        private String courseName; // the name of this course
        private List<Participant> participants; // the list of participants for this course

        // property
        public int CourseId
        {
            get { return this.courseId; }
        }

        // constructor
        public Course(int courseId, String courseName)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.participants = new List<Participant>(); 
        }

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

        // Assignment 1b and 3: (see also classes ClassroomCourse and ECourse)
        public override String ToString()
        {
            return "Id: " + this.courseId.ToString() + " Course name: " + this.courseName + " Nr of participants " + this.GetNrOfParticipants().ToString();
        }

        // Assignment 2b: (see also classes ClassroomCourse and ECourse)
        public virtual void AddParticipant(int id, string name)
        {
            if (this.GetParticipant(id) == null)
            {
                Participant p = new Participant(id, name);
                this.participants.Add(p);
            }
            else
            {
                throw new CourseException("Participant with id: " + id.ToString() + " already registered");
            }

        }

        // Assignment 2c: (see also classes ClassroomCourse and ECourse)
        public abstract int GetPricePerParticipant();

    }
}
