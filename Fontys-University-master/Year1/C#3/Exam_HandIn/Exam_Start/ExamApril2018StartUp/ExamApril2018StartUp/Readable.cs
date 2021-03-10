namespace ExamApril2018StartUp
{
    public abstract class Readable
    {
        private int id;
        private string title;
        
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }

        public Readable(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public virtual string ToString()
        {
            return " id: " +this.id  + ", title: " + this.title ;
        }
    }
}