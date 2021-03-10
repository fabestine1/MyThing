namespace Movies
{
    using System;

    [Serializable]
    public class Movie
    {
        public enum Genre { Action, Horror, Romance, LAST };

        public string Title { get; set; }
        public string Director { get; set; }
        public string Location { get; set; }
        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1900 && value < 2100) year = value;
            }
        }

        public Genre MovieGerne { get; set; }

        public Movie(string title)
        {
            this.Title = title;
        }

        public Movie()
        {
        }

        public string GetInfo()
        {
            return Title + "by" + Director + '(' + Year + ')';
        }
    }
}
