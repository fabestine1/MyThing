namespace ExamApril2018StartUp
{
    public class NewsPaper : Readable
    {
        private string date;

        public NewsPaper(int id, string title, string date) 
            : base(id, title)
        {
            this.date = date;
        }

        public override string ToString()
        {
            return "NewsPaper:" + base.ToString() + " publish date: " + this.date;
        }
    }
}
