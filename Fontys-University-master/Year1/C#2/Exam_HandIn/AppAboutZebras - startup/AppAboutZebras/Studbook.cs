namespace AppAboutZebras
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Studbook
    {
        private String name;
        private List<Zebra> zebras;

        /// <summary>
        /// creates a Studbook-object with name equal to the parameter name.
        /// It has an empty collection of zebras.
        /// </summary>
        /// <param name="name"></param>
        public Studbook(String name)
        {//todo
            this.name = name;
            this.zebras = new List<Zebra>();
        }

        public String Name { get { return this.name; } }

        /// <summary>
        /// returns a list of all zebras
        /// </summary>
        /// <returns></returns>
        public List<Zebra> GetAllZebras() { return this.zebras; }

        /// <summary>
        /// if there is a zebra with identity id, that zebra is returned;
        /// otherwise the returnvalue is null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Zebra GetZebra(int id)
        {
            foreach (Zebra z in this.zebras)
            {
                if (z.Id == id) { return z; }
            }
            return null;
        }

        /// <summary>
        /// if this studbook already has a zebra with the same id as the id of zebra z
        /// then nothing is added and the returnvalue is false;
        /// otherwise z is added to the list of zebras and the returnvalue is true
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public bool AddZebra(Zebra z)
        {//todo
            foreach (var zebra in this.zebras)
            {
                if (z.Id == zebra.Id)
                {
                    return false;
                }
            }

            //Father
            if (z.FatherId == -1)
            {
                z.FatherId = -1;
            }
            else if (z.FatherId > 0 && z.Gender == Gender.STALLION)
            {
                z.FatherId = z.FatherId;
            }
            else
            {
                z.FatherId = -1;
            }

            //Mother
            if (z.MotherId == -1)
            {
                z.MotherId = -1;
            }
            else if (z.MotherId > 0 && z.Gender == Gender.MARE)
            {
                z.MotherId = z.MotherId;
            }
            else
            {
                z.MotherId = -1;
            }

            this.zebras.Add(z);
            return true;
        }

        /// <summary>
        /// returns a list of all zebras, of which the father-id is equal to idFather
        /// </summary>
        /// <param name="idFather"></param>
        /// <returns></returns>
        public List<Zebra> GetZebrasWithFather(int idFather)
        {//todo
            var temp = new List<Zebra>();
            foreach (var zebra in this.zebras)
            {
                if (zebra.FatherId == idFather)
                {
                    temp.Add(zebra);
                }
            }
            return temp;
        }

        /// <summary>
        /// for the zebra with identity equal to id, this method returns a list of its ancestors in the mother-line.
        /// So it returns a list of zebras:
        /// the zebra with identity id, the mother of this zebra, the mother of the mother of this zebra, etc..
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Zebra> GetAncestorsInMotherline(int id)
        {//todo
            List<Zebra> temp = new List<Zebra>();

            foreach (var zebra in this.zebras)
            {
                if (zebra.Id == id)
                {
                    var newZebra = zebra;

                    while (newZebra != null && newZebra.MotherId != -1)
                    {
                        temp.Add(newZebra);
                        newZebra = GetZebra(newZebra.MotherId);

                        //I do this Because of the Last Zebra witch is equal to -1 !
                        if (newZebra != null && newZebra.MotherId == -1)
                        {
                            temp.Add(newZebra);
                        }
                    }
                }
            }

            return temp;
        }

    }
}
