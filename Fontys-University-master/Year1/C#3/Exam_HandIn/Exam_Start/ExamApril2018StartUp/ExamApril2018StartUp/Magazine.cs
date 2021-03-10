namespace ExamApril2018StartUp
{
    public class Magazine : Readable
    {
        private int issuenumber;

        public Magazine(int id, string title, int issuenumber) 
            : base(id, title)
        {
            this.issuenumber = issuenumber;
        }

        public override string ToString()
        {
            return "Magazine:" + base.ToString() + " issue number: " + this.issuenumber;
        }
    }
}
