using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutZebras
{
    class Zebra
    {
        private int dz;
        private int motherId = -1;
        private int fatherId = -1;
        private Gender zebraGender = Gender.UNKNOWN;
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int Dz
        {
            get { return dz; }
            set
            {
                if(value < 10)
                {
                    dz = 10;
                }
                else if(value > 50)
                {
                    dz = 50;
                }
                else
                {
                    dz = value;
                }
            }
        }
        public int MotherId
        {
            get
            {
                return motherId;
            }
            set
            {
                if (value >= 0)
                {
                    motherId = value;
                }
            }
        }
        public int FatherId
        {
            get
            {
                    return fatherId;
             }
            set
            {
                if(value >= 0)
                {
                    fatherId = value;
                }
            }
        }
        public Gender ZebraGender
        {
            get { return zebraGender; }
            set { zebraGender = value; }
        }
        public Zebra(int id, String name)
        {
            Id = id;
            Name = name;
            Dz = 25;
        }
        public Zebra(int id, String name, int motherId)
        {
            Id = id;
            Name = name;
            Dz = 25;
            MotherId = motherId;
        }
        public Zebra(int id, String name, int dz, int motherId, int fatherId, Gender g)
        {
            Id = id;
            Name = name;
            Dz = dz;
            MotherId = motherId;
            FatherId = fatherId;
            ZebraGender = g;
        }
        public string getInfo()
        {
            return Name + " (" + Id + "), dz: " + Dz + ", id of mother: " + MotherId + ", id of father: " + FatherId + ", gender " + ZebraGender;
        }
    }
}
