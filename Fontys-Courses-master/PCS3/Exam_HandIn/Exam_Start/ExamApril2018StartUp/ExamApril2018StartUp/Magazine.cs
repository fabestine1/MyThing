using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    class Magazine : Readable
    {
        //properties
        public int IssueNumber { get; }

        //constructors
        public Magazine(int id, string title, int issueNumber) : base(id, title)
        {
            IssueNumber = issueNumber;
        }

        //methods
        public override string ToString()
        {
            return "Magazine" + base.ToString() + " issue number: " + IssueNumber;
        }
    }
}
