using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApril2018StartUp
{
    class NewsPaper : Readable
    {
        //properties
        public string Date { get; }

        //constructors
        public NewsPaper(int id, string title, string date) : base(id, title)
        {
            Date = date;
        }

        //methods
        public override string ToString()
        {
            return "Newspaper" + base.ToString() + " publish date: " + Date;
        }
    }
}
