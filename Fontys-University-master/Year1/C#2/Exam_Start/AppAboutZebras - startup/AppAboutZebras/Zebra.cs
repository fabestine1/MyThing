namespace AppAboutZebras
{
    public class Zebra
    {
        private int dz;
        private int motherId;
        private int fatherId;
        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
            }
        }

        public string Name { get; set; }

        public int Dz
        {
            get { return dz; }
            set
            {
                if (value > 50)
                {
                    dz = 50;
                }
                else if (value < 10)
                {
                    dz = 10;
                }
                else
                {
                    dz = value;
                }
            }
        }

        public int MotherId
        {
            get { return motherId; }
            set
            {
                if (value > 0)
                {
                    motherId = value;
                }
            }
        }

        public int FatherId
        {
            get { return fatherId; }
            set
            {
                if (value > 0)
                {
                    fatherId = value;
                }
            }
        }

        public Gender Gender { get; set; }

        public Zebra(int id, string name)
        {
            Id = id;
            Name = name;
            this.motherId = -1;
            this.fatherId = -1;
            this.dz = 25;
            this.Gender = Gender.UNKNOWN;
        }

        public Zebra(int id, string name,int motherId)
        {
            this.Id = id;
            this.Name = name;
            this.MotherId = motherId;
            this.fatherId = -1;
            this.dz = 25;
            this.Gender = Gender.UNKNOWN;
        }

        public Zebra(int id, string name, int dz, int motherId, int fatherId,  Gender gender)
        {
            this.Dz = dz;
            this.MotherId = motherId;
            this.FatherId = fatherId;
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }

        public string getInfo()
        {
            return $"{this.Name} ({this.Id}), dz: {this.Dz}, id of mother: {this.MotherId}, " +
                   $"id of father: {this.FatherId}, gender {this.Gender}";
        }
    }
}
