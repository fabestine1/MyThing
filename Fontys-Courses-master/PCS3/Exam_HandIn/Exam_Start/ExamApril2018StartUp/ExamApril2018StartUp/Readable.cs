using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    class Readable
    {
        //properties
        public int Id { get; }
        public string Title { get; }

        //constructors
        public Readable(int id, string title)
        {
            Id = id;
            Title = title;
        }

        //methods
        public override string ToString()
        {
            return ": id: " + Id + ", title: " + Title;
        }
    }
}
